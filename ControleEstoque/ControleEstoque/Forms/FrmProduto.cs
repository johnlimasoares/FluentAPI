using Business;
using ControleEstoque.Utils;
using DataAccess;
using Domain.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmProduto : Form
    {

        private DataContext ctx = new DataContext();
        private Produto produto;
        public bool IsUpdate { get; set; } = false;

        public FrmProduto()
        {
            try {
                InitializeComponent();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }
        }

        public FrmProduto(int id)
        {
            try {
                InitializeComponent();
                PreencherControles(id);
                this.IsUpdate = true;
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }
        }

        private void PreencherControles(int id)
        {
            //produto = ctx.Produtos.Find(id);
            produto = ctx.Set<Produto>()
                    .Include("Grupo")
                    .Include("Marca")
                    .Include("Tamanho")
                    .Include("Cor")
                    .Include(e => e.Fornecedor.Pessoa)
                    .Single(x => x.ProdutoId == id);

            txtDescricaoProduto.Text = produto.Descricao;
            txtCodigoProduto.Text = produto.CodigoProduto;

            txtCodigoMarca.Text = produto.Marca.MarcaId.ToString();
            lblDescricaoMarca.Text = produto.Marca.Descricao;

            txtCodigoGrupo.Text = produto.Grupo.GrupoId.ToString();
            lblDescricaoGrupo.Text = produto.Grupo.Descricao;

            txtCodigoTamanho.Text = produto.Tamanho.TamanhoId.ToString();
            lblDescricaoTamanho.Text = produto.Tamanho.Descricao;

            txtCodigoFornecedor.Text = produto.Fornecedor.FornecedorId.ToString();
            lblDescricaoFornecedor.Text = produto.Fornecedor.Pessoa.NomeRazao;

            txtCodigoCor.Text = produto.Cor.CorId.ToString();
            lblDescricaoCor.Text = produto.Cor.Descricao;

            txtPrecoCompra.Text = produto.PrecoCompra.ToString("N");
            txtPrecoVenda.Text = produto.PrecoVenda.ToString("N");

            txtEstoque.Text = produto.EstoqueAtual.ToString();

            txtObservacao.Text = produto.Observacao;
            txtLocalizacao.Text = produto.Localizacao;

            txtDataAtualizacao.Text = produto.DataUltimaAtualizacao.ToString("dd/MM/yyyy");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if(IsCamposValidos()) {

                    if(IsUpdate) {
                        Atualizar();
                    }
                    else {
                        Salvar();
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Salvar()
        {
            var produto = new Produto();
            produto.CodigoProduto = txtCodigoProduto.Text;
            produto.Descricao = txtDescricaoProduto.Text.ToLower();
            produto.Marca = new Marca() { MarcaId = txtCodigoMarca.Text.ToInteger(), Descricao = lblDescricaoMarca.Text };
            produto.Grupo = new Grupo() { GrupoId = txtCodigoGrupo.Text.ToInteger(), Descricao = lblDescricaoGrupo.Text };
            produto.Fornecedor = new Fornecedor() { FornecedorId = txtCodigoFornecedor.Text.ToInteger() };
            produto.Tamanho = new Tamanho() { TamanhoId = txtCodigoTamanho.Text.ToInteger(), Descricao = lblDescricaoTamanho.Text };
            produto.Cor = new Cor() { CorId = txtCodigoCor.Text.ToInteger(), Descricao = lblDescricaoCor.Text };
            produto.PrecoCompra = txtPrecoCompra.Text.ToDecimal();
            produto.PrecoVenda = txtPrecoVenda.Text.ToDecimal();
            produto.EstoqueAtual = txtEstoque.Text.ToInteger();
            produto.Observacao = txtObservacao.Text;
            produto.Localizacao = txtLocalizacao.Text;
            produto.DataUltimaAtualizacao = DateTime.Now;
            ProdutoBusiness.Salvar(produto);
        }

        private void Atualizar()
        {
            produto.CodigoProduto = txtCodigoProduto.Text;
            produto.Descricao = txtDescricaoProduto.Text.ToLower();
            produto.PrecoCompra = txtPrecoCompra.Text.ToDecimal();
            produto.PrecoVenda = txtPrecoVenda.Text.ToDecimal();
            produto.EstoqueAtual = txtEstoque.Text.ToInteger();
            produto.Observacao = txtObservacao.Text;
            produto.Localizacao = txtLocalizacao.Text;
            produto.DataUltimaAtualizacao = DateTime.Now;
            var marcaId = txtCodigoMarca.Text.ToInteger();
            var grupoId = txtCodigoGrupo.Text.ToInteger();
            var fornecedorId = txtCodigoFornecedor.Text.ToInteger();
            var tamanhoId = txtCodigoTamanho.Text.ToInteger();
            var corId = txtCodigoCor.Text.ToInteger();
            ProdutoBusiness.Atualizar(ctx, produto, marcaId, grupoId, fornecedorId, tamanhoId, corId);
        }

        private bool IsCamposValidos()
        {
            if(txtDescricaoProduto.Text.IsNullOrEmpty()) {
                lblDescricaoProduto.Text.InformeCampoObrigatorio();
                SelectTabDados();
                txtDescricaoProduto.Focus();
                return false;
            }

            if(txtCodigoProduto.Text.IsNullOrEmpty()) {
                lblCodigo.Text.InformeCampoObrigatorio();
                SelectTabDados();
                txtCodigoProduto.Focus();
                return false;
            }

            if(txtCodigoMarca.Text.IsNullOrEmpty()) {
                lblMarca.Text.InformeCampoObrigatorio();
                SelectTabDados();
                txtCodigoMarca.Focus();
                return false;
            }

            if(txtCodigoGrupo.Text.IsNullOrEmpty()) {
                lblGrupo.Text.InformeCampoObrigatorio();
                SelectTabDados();
                txtCodigoGrupo.Focus();
                return false;
            }

            if(txtCodigoTamanho.Text.IsNullOrEmpty()) {
                lblTamanho.Text.InformeCampoObrigatorio();
                txtCodigoTamanho.Focus();
                return false;
            }

            if(txtCodigoCor.Text.IsNullOrEmpty()) {
                lblCor.Text.InformeCampoObrigatorio();
                txtCodigoCor.Focus();
                return false;
            }

            if(txtCodigoFornecedor.Text.IsNullOrEmpty()) {
                lblFornecedor.Text.InformeCampoObrigatorio();
                SelectTabDados();
                txtCodigoFornecedor.Focus();
                return false;
            }

            if(txtPrecoCompra.Text.IsNullOrEmpty()) {
                lblPrecoCompra.Text.InformeCampoObrigatorio();
                SelectTabPrecoEstoque();
                txtPrecoCompra.Focus();
                return false;
            }

            if(txtPrecoVenda.Text.IsNullOrEmpty()) {
                lblPrecoVenda.Text.InformeCampoObrigatorio();
                SelectTabPrecoEstoque();
                txtPrecoVenda.Focus();
                return false;
            }

            if(txtEstoque.Text.IsNullOrEmpty()) {
                lblEstoque.Text.InformeCampoObrigatorio();
                SelectTabPrecoEstoque();
                txtEstoque.Focus();
                return false;
            }

            return true;
        }

        private void SelectTabDados()
        {
            tabControl.SelectedTab = tabPageDados;
        }

        private void SelectTabPrecoEstoque()
        {
            tabControl.SelectedTab = tabPagePrecoEstoque;
        }

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

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoFornecedor);
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

                case "txtCodigoFornecedor":
                OpenDialog(new BrowseSelecaoFornecedor(), txtCodigoFornecedor, lblDescricaoFornecedor);
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
                return ctx.Marcas.Find(key);
                break;
                case "txtCodigoGrupo":
                return ctx.Grupos.Find(key);
                break;
                case "txtCodigoTamanho":
                return ctx.Tamanhos.Find(key);
                break;
                case "txtCodigoFornecedor":
                return ctx.Fornecedores.Include("Pessoa").SingleOrDefault(x => x.FornecedorId == key);
                break;
                case "txtCodigoCor":
                return ctx.Cores.Find(key);
                break;
                default:
                throw new NotImplementedException();
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
                case "txtCodigoFornecedor":
                return lblDescricaoFornecedor;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
