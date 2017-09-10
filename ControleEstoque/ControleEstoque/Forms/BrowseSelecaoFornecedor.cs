using Business;
using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class BrowseSelecaoFornecedor : ControleEstoque.Forms.BrowseSelecao
    {
        public BrowseSelecaoFornecedor() : base()
        {
            InitializeComponent();
            SetTitle("fornecedores");

        }

        private List<Fornecedor> GetListaFornecedores(Func<Fornecedor, bool> where = null)
        {
            return  FornecedorBusiness.GetAll(where).ToList();
        }

        private void PreencherListView(List<Fornecedor> list)
        {
            listView.Items.Clear();
            foreach(var tamanho in list) {
                var listViewItem = new ListViewItem(tamanho.FornecedorId.ToString());
                listViewItem.SubItems.Add(tamanho.Pessoa.NomeRazao);
                listView.Items.Add(listViewItem);
            }
        }

        public override void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = GetListaFornecedores((Func<Fornecedor, bool>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public override void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                PreencherListView((List<Fornecedor>)e.Result);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

    }
}
