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
    public partial class BrowseCores : Form
    {


        public BrowseCores()
        {
            try {
                InitializeComponent();
                GetInstanceWorker().RunWorkerAsync();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private List<Cor> GetListaCor(Func<Cor, bool> where = null)
        {
            return new CorRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Cor> listaCores)
        {
            listView.Items.Clear();
            foreach(var Cor in listaCores) {
                var listViewItem = new ListViewItem(Cor.CorId.ToString());
                listViewItem.SubItems.Add(Cor.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaCor((Func<Cor, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Cor>)e.Result);
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
                var result = new FrmCores().ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaCor());
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
                var result = new FrmCores(id).ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaCor());
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                Func<Cor, bool> where = null;
                
                if(!string.IsNullOrEmpty(txtBusca.Text)) {
                    if(rdDescricao.Checked) {
                        where = delegate (Cor m) { return m.Descricao.ToUpper().Contains(txtBusca.Text.ToUpper()); };
                    }
                    else {
                        where = delegate (Cor m) { return m.CorId.ToString() == txtBusca.Text; };
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

                    var repository = new CorRepository();
                    var cor = repository.Find(id);
                    repository.Excluir(cor);
                    GetInstanceWorker().RunWorkerAsync();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
