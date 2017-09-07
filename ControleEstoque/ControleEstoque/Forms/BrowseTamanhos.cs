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
    public partial class BrowseTamanhos : Form
    {
       
        public BrowseTamanhos()
        {
            try {
                InitializeComponent();
                GetInstanceWorker().RunWorkerAsync();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private List<Tamanho> GetListaTamanho(Func<Tamanho, bool> where = null)
        {
            return new TamanhoRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Tamanho> listaTamanhos)
        {
            listView.Items.Clear();
            foreach(var Tamanho in listaTamanhos) {
                var listViewItem = new ListViewItem(Tamanho.TamanhoId.ToString());
                listViewItem.SubItems.Add(Tamanho.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaTamanho((Func<Tamanho, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Tamanho>)e.Result);
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
            var worker = new Worker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            return worker;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                var result = new FrmTamanhos().ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaTamanho());
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
                var result = new FrmTamanhos(id).ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaTamanho());
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                Func<Tamanho, bool> where = null;
                if(!string.IsNullOrEmpty(txtBusca.Text)) {
                    if(rdDescricao.Checked) {
                        where = delegate (Tamanho m) { return m.Descricao.ToUpper().Contains(txtBusca.Text.ToUpper()); };
                    }
                    else {
                        where = delegate (Tamanho m) { return m.TamanhoId.ToString() == txtBusca.Text; };
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

                    var repository = new TamanhoRepository();
                    var Tamanho = repository.Find(id);
                    repository.Excluir(Tamanho);
                    GetInstanceWorker().RunWorkerAsync();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
