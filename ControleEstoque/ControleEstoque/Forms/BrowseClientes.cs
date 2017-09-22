using Business;
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
    public partial class BrowseClientes : Form
    {
       
        public BrowseClientes()
        {
            try {
                InitializeComponent();
                GetInstanceWorker().RunWorkerAsync();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private List<Cliente> GetListaClientes(Func<Cliente, bool> where = null)
        {
            return ClienteBusiness.GetAll(where);
        }

        private void PreencherListView(List<Cliente> listaClientes)
        {
            listView.Items.Clear();
            foreach(var cliente in listaClientes) {
                var listViewItem = new ListViewItem(cliente.ClienteId.ToString());
                listViewItem.SubItems.Add(cliente.Pessoa.NomeRazao);
                listViewItem.SubItems.Add(cliente.Pessoa.ApelidoFantasia);
                listViewItem.SubItems.Add(cliente.Pessoa.CpfCnpj);
                listView.Items.Add(listViewItem);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaClientes((Func<Cliente, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Cliente>)e.Result);
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
                var result = new FrmCliente().ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaClientes());
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
                var result = new FrmCliente(id).ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaClientes());
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                Func<Cliente, bool> where = null;
                if(!string.IsNullOrEmpty(txtBusca.Text)) {
                    if(rdDescricao.Checked) {
                        where = delegate (Cliente m) {
                            return m.Pessoa.NomeRazao.ToUpper().Contains(txtBusca.Text.ToUpper()) 
                            || m.Pessoa.ApelidoFantasia.ToUpper().Contains(txtBusca.Text.ToUpper())
                            || m.Pessoa.CpfCnpj.ToUpper().Contains(txtBusca.Text.ToUpper())
                            ; };
                    }
                    else {
                        where = delegate (Cliente m) { return m.ClienteId.ToString() == txtBusca.Text; };
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
                    ClienteBusiness.Delete(id);
                    GetInstanceWorker().RunWorkerAsync();
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
