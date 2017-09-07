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
    public partial class BrowseSelecaoTamanho : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoTamanho() : base()
        {
            InitializeComponent();
            SetTitle("tamanhos");
        }

        private List<Tamanho> GetListaTamanhos(Func<Tamanho, bool> where = null)
        {
            return new TamanhoRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Tamanho> list)
        {
            listView.Items.Clear();
            foreach(var tamanho in list) {
                var listViewItem = new ListViewItem(tamanho.TamanhoId.ToString());
                listViewItem.SubItems.Add(tamanho.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaTamanhos((Func<Tamanho, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Tamanho>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
