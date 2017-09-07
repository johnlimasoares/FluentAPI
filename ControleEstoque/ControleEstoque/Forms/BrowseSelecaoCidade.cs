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
    public partial class BrowseSelecaoCidade : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoCidade() : base()
        {
            InitializeComponent();
            SetTitle("cidades");
        }

        private List<Cidade> GetListaCor(Func<Cidade, bool> where = null)
        {
            return new CidadeRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Cidade> listaCidades)
        {
            listView.Items.Clear();
            foreach(var cidade in listaCidades) {
                var listViewItem = new ListViewItem(cidade.CidadeId.ToString());
                listViewItem.SubItems.Add(cidade.Nome);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaCor((Func<Cidade, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Cidade>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
