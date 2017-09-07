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
    public partial class BrowseGrupos : Form
    {
       
        public BrowseGrupos()
        {
            try {
                InitializeComponent();
                GetInstanceWorker().RunWorkerAsync();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private List<Grupo> GetListaGrupo(Func<Grupo, bool> where = null)
        {
            return new GrupoRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Grupo> listaGrupos)
        {
            listView.Items.Clear();
            foreach(var Grupo in listaGrupos) {
                var listViewItem = new ListViewItem(Grupo.GrupoId.ToString());
                listViewItem.SubItems.Add(Grupo.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaGrupo((Func<Grupo, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Grupo>)e.Result);
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
                var result = new FrmGrupos().ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaGrupo());
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
                var result = new FrmGrupos(id).ShowDialog();
                if(result == DialogResult.OK) {
                    PreencherListView(GetListaGrupo());
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                Func<Grupo, bool> where = null;
                if(!string.IsNullOrEmpty(txtBusca.Text)) {
                    if(rdDescricao.Checked) {
                        where = delegate (Grupo m) { return m.Descricao.ToUpper().Contains(txtBusca.Text.ToUpper()); };
                    }
                    else {
                        where = delegate (Grupo m) { return m.GrupoId.ToString() == txtBusca.Text; };
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

                    var repository = new GrupoRepository();
                    var Grupo = repository.Find(id);
                    repository.Excluir(Grupo);
                    GetInstanceWorker().RunWorkerAsync();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
