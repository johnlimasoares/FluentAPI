using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class BrowseFornecedores : Form
    {
       
        public BrowseFornecedores()
        {
            try {
                InitializeComponent();
                GetInstanceWorker().RunWorkerAsync();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private List<Fornecedor> GetListaFornecedores(Func<Fornecedor, bool> where = null)
        {
            return new FornecedorRepository().GetAll(where);
        }

        private void PreencherListView(List<Fornecedor> listaFornecedors)
        {
            listView.Items.Clear();
            foreach(var Fornecedor in listaFornecedors) {
                var listViewItem = new ListViewItem(Fornecedor.FornecedorId.ToString());
                listViewItem.SubItems.Add(Fornecedor.Pessoa.NomeRazao);
                listViewItem.SubItems.Add(Fornecedor.Pessoa.ApelidoFantasia);
                listViewItem.SubItems.Add(Fornecedor.Pessoa.CpfCnpj);
                listView.Items.Add(listViewItem);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaFornecedores((Func<Fornecedor, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Fornecedor>)e.Result);
            } catch(Exception ex) {

                ex.Message.ShowError();
            }
        }

        private bool HaItemSelecionado()
        {
            if(listView.SelectedItems.Count == 0) {
                MessageUtils.ShowInfo("Selecione um item para edição");
                return false;
            }
            return true;
        }

        private int GetCodigoItemSelecionado()
        {
            return listView.SelectedItems[0].SubItems[0].Text.ToInteger();
        }

        private BackgroundWorker GetInstanceWorker()
        {
            var worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            return worker;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                var result = new FrmFornecedor().ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaFornecedores());
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try {
                if(!HaItemSelecionado())
                    return;

                var id = GetCodigoItemSelecionado();
                var result = new FrmFornecedor(id).ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaFornecedores());
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                Func<Fornecedor, bool> where = null;
                if(!string.IsNullOrEmpty(txtBusca.Text)) {
                    if(rdDescricao.Checked) {
                        where = delegate (Fornecedor m) {
                            return m.Pessoa.NomeRazao.ToUpper().Contains(txtBusca.Text.ToUpper()) 
                            || m.Pessoa.ApelidoFantasia.ToUpper().Contains(txtBusca.Text.ToUpper()); };
                    }
                    else {
                        where = delegate (Fornecedor m) { return m.FornecedorId.ToString() == txtBusca.Text; };
                    }
                }
                GetInstanceWorker().RunWorkerAsync(where);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try {

                if(!HaItemSelecionado())
                    return;

                if(MessageBox.Show("Deseja Realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    var id = GetCodigoItemSelecionado();

                    var repository = new FornecedorRepository();
                    var Fornecedor = repository.Find(id);
                    repository.Delete(Fornecedor);
                    GetInstanceWorker().RunWorkerAsync();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
