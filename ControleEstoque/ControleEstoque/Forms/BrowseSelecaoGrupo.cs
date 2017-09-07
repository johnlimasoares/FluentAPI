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
    public partial class BrowseSelecaoGrupo : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoGrupo() : base()
        {
            InitializeComponent();
            SetTitle("grupos");

        }

        private List<Grupo> GetListGrupos(Func<Grupo, bool> where = null)
        {
            return new GrupoRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Grupo> listaGrupos)
        {
            listView.Items.Clear();
            foreach(var grupo in listaGrupos) {
                var listViewItem = new ListViewItem(grupo.GrupoId.ToString());
                listViewItem.SubItems.Add(grupo.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListGrupos((Func<Grupo, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Grupo>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
