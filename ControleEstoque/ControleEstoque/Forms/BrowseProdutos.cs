using Business;
using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using LinqKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class BrowseProdutos : Form
    {
        public BrowseProdutos()
        {
            try {
                InitializeComponent();
                comboBox.SelectedIndex = 1;
                GetInstanceWorker().RunWorkerAsync(GetWhere());
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private BackgroundWorker GetInstanceWorker()
        {
            var worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            return worker;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                e.Result = ProdutoBusiness.GetProdutos((Expression<Func<Produto, bool>>)e.Argument);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {
                var listProdutos = (List<Produto>)e.Result;
                PreencherListView(listProdutos);
                SetLabelTotalProdutos(listProdutos.Count);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void SetLabelTotalProdutos(int count)
        {
            lblTotalProdutos.Text = $"{count} Produto(s) encontrado(s)";
        }

        private Expression<Func<Produto, bool>> GetWhere()
        {
            var predicate = PredicateBuilder.New<Produto>();

            predicate = chkInativos.Checked ? predicate.And(p => p.IsInativo == true) : predicate.And(p => p.IsInativo == false);

            if(comboBox.SelectedIndex == 0 && !txtBusca.Text.IsNullOrEmpty()) {
                predicate = predicate.And(p => p.Descricao.ToUpper().Contains(txtBusca.Text.ToUpper()));
            }
            if(comboBox.SelectedIndex == 1 && !txtBusca.Text.IsNullOrEmpty()) {
                predicate = predicate.And(p => p.CodigoProduto.ToUpper().Contains(txtBusca.Text.ToUpper()));
            }
            if(comboBox.SelectedIndex == 2 && !txtBusca.Text.IsNullOrEmpty()) {
                predicate = predicate.And(p => p.ProdutoId.ToString().ToUpper().Contains(txtBusca.Text.ToUpper()));
            }

            if(!txtCodigoMarca.Text.IsNullOrEmpty() && txtCodigoMarca.Text.DiferenteDeZero()) {
                predicate = predicate.And(p => p.Marca.MarcaId.ToString() == txtCodigoMarca.Text);
            }
            if(!txtCodigoGrupo.Text.IsNullOrEmpty() && txtCodigoGrupo.Text.DiferenteDeZero()) {
                predicate = predicate.And(p => p.Grupo.GrupoId.ToString() == txtCodigoGrupo.Text);
            }
            if(!txtCodigoTamanho.Text.IsNullOrEmpty() && txtCodigoTamanho.Text.DiferenteDeZero()) {
                predicate = predicate.And(p => p.Tamanho.TamanhoId.ToString() == txtCodigoTamanho.Text);
            }
            if(!txtCodigoCor.Text.IsNullOrEmpty() && txtCodigoCor.Text.DiferenteDeZero()) {
                predicate = predicate.And(p => p.Cor.CorId.ToString() == txtCodigoCor.Text);
            }
            return predicate;

        }

        private void PreencherListView(List<Produto> listaProdutos)
        {
            listView.Items.Clear();
            foreach(var produto in listaProdutos) {
                var listViewItem = new ListViewItem(produto.ProdutoId.ToString());
                listViewItem.SubItems.Add(produto.Descricao);
                listViewItem.SubItems.Add(produto.CodigoProduto.ToString());
                listViewItem.SubItems.Add(produto.Marca.Descricao);
                listViewItem.SubItems.Add(produto.Grupo.Descricao);
                listViewItem.SubItems.Add(produto.Tamanho.Descricao);
                listViewItem.SubItems.Add(produto.Cor.Descricao);
                listViewItem.SubItems.Add(produto.PrecoVenda.ToString("N"));
                listViewItem.SubItems.Add(produto.EstoqueAtual.ToString());
                listView.Items.Add(listViewItem);
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                if(new FrmProduto().ShowDialog() == DialogResult.OK) {
                    GetInstanceWorker().RunWorkerAsync(GetWhere());
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
                var result = new FrmProduto(id).ShowDialog();
                if(result == DialogResult.OK) {
                    GetInstanceWorker().RunWorkerAsync(GetWhere());
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try {
                if(!HaItemSelecionado())
                    return;

                if(MessageUtils.ShowYesOrNO("Deseja inativar este produto?") == DialogResult.Yes) {
                    ProdutoBusiness.InativarProduto(GetCodigoItemSelecionado());
                    GetInstanceWorker().RunWorkerAsync(GetWhere());
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }


        /*Filtros*/

        private void btnBuscarMarcas_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoMarca);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoGrupo);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnBuscarTamanho_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoTamanho);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnBuscarCor_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoCor);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try {
                var txtBox = ((TextBox)sender);
                if(string.IsNullOrEmpty(txtBox.Text) || txtBox.Text.Trim() == "0") {
                    ResetDefaultValue(txtBox, GetLabel(txtBox));
                    return;
                }

                var entity = GetEntity(txtBox.Name, txtBox.Text.ToInteger());

                if(entity == null) {
                    OpenDialogSelect(txtBox);
                    return;
                }

                GetLabel(txtBox).Text = entity.GetDescricao();

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void OpenDialogSelect(TextBox txtBox)
        {
            switch(txtBox.Name) {
                case "txtCodigoMarca":
                OpenDialog(new BrowseSelecaoMarca(), txtCodigoMarca, lblDescricaoMarca);
                break;

                case "txtCodigoGrupo":
                OpenDialog(new BrowseSelecaoGrupo(), txtCodigoGrupo, lblDescricaoGrupo);
                break;

                case "txtCodigoTamanho":
                OpenDialog(new BrowseSelecaoTamanho(), txtCodigoTamanho, lblDescricaoTamanho);
                break;

                case "txtCodigoCor":
                OpenDialog(new BrowseSelecaoCor(), txtCodigoCor, lblDescricaoCor);
                break;
            }
        }

        private void OpenDialog(BrowseSelecao brwSelecao, TextBox txtBox, Label label)
        {
            if(brwSelecao.ShowDialog() == DialogResult.OK) {
                txtBox.Text = brwSelecao.Id.ToString();
                label.Text = brwSelecao.Descricao;
            }
            else {
                if(string.IsNullOrEmpty(label.Text)) {
                    ResetDefaultValue(txtBox, label);
                }
            }
        }

        private void ResetDefaultValue(TextBox textBox, Label label)
        {
            textBox.Text = "0";
            label.Text = string.Empty;
        }

        private IEntity GetEntity(string nameControl, int key)
        {
            switch(nameControl) {
                case "txtCodigoMarca":
                return new MarcaRepository().Find(key);
                break;
                case "txtCodigoGrupo":
                return new GrupoRepository().Find(key);
                break;
                case "txtCodigoTamanho":
                return new TamanhoRepository().Find(key);
                break;
                case "txtCodigoFornecedor":
                return new TamanhoRepository().Find(key);
                break;
                default:
                return null;
            }
        }

        private Label GetLabel(TextBox txtBox)
        {
            switch(txtBox.Name) {
                case "txtCodigoMarca":
                return lblDescricaoMarca;
                break;
                case "txtCodigoGrupo":
                return lblDescricaoGrupo;
                break;
                case "txtCodigoTamanho":
                return lblDescricaoTamanho;
                break;
                case "txtCodigoCor":
                return lblDescricaoCor;
                break;

            }
            throw new NotImplementedException();
        }

        private void txtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                var ch = e.KeyChar;
                if(!Char.IsDigit(ch) && ch != 8) {
                    e.Handled = true;
                }
            } catch(Exception) {
            }
        }

        private void txtFocus_Enter(object sender, EventArgs e)
        {
            try {
                ((TextBox)sender).SelectionStart = 0;
                ((TextBox)sender).SelectionLength = ((TextBox)sender).Text.Length;
            } catch(Exception) {
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                GetInstanceWorker().RunWorkerAsync(GetWhere());
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if(e.KeyCode == Keys.Enter) {
                    btnPesquisar_Click(null, null);
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try {
                var ordemAtual = listView.Columns[e.Column].ListView.Sorting;
                listView.Columns[e.Column].ListView.Sorting = ordemAtual == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
           
        }
    }
}
