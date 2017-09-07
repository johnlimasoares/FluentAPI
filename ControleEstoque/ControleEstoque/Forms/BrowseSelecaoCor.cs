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
    public partial class BrowseSelecaoCor : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoCor() : base()
        {
            InitializeComponent();
            SetTitle("cores");
        }

        private List<Cor> GetListaCor(Func<Cor, bool> where = null)
        {
            return new CorRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Cor> listaCores)
        {
            listView.Items.Clear();
            foreach(var cor in listaCores) {
                var listViewItem = new ListViewItem(cor.CorId.ToString());
                listViewItem.SubItems.Add(cor.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaCor((Func<Cor, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Cor>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
