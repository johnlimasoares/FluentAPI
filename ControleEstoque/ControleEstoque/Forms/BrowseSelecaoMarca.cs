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
    public partial class BrowseSelecaoMarca : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoMarca() : base()
        {
            InitializeComponent();
            SetTitle("marcas");

        }

        private List<Marca> GetListaMarca(Func<Marca, bool> where = null)
        {
            return new MarcaRepository().Get(where).AsNoTracking().ToList();
        }

        private void PreencherListView(List<Marca> listaMarcas)
        {
            listView.Items.Clear();
            foreach(var marca in listaMarcas) {
                var listViewItem = new ListViewItem(marca.MarcaId.ToString());
                listViewItem.SubItems.Add(marca.Descricao);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaMarca((Func<Marca, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Marca>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
