using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmEndereco : Form
    {
        public EnderecoDTO enderecoDTO;

        public bool IsUpdate { get; private set; }

        public FrmEndereco()
        {
            try {
                enderecoDTO = new EnderecoDTO();
                InitializeComponent();
                cbTipoEndereo.SelectedIndex = 0;
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public FrmEndereco(EnderecoDTO enderecoDTO)
        {
            try {
                InitializeComponent();
                this.enderecoDTO = enderecoDTO;
                PreencherControles();
                IsUpdate = true;
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void PreencherControles()
        {
            txtLogradouro.Text = enderecoDTO.Logradouro;
            txtCEP.Text = enderecoDTO.CEP;
            txtNumero.Text = enderecoDTO.Numero;
            cbTipoEndereo.SelectedIndex = enderecoDTO.TipoEndereco.ToInteger();
            txtCodigoCidade.Text = enderecoDTO.Cidade.CidadeId.ToString();
            lblDescricaoCidade.Text = enderecoDTO.Cidade.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if(IsCamposValidos()) {                    
                    enderecoDTO.Logradouro = txtLogradouro.Text;
                    enderecoDTO.CEP = txtCEP.Text;
                    enderecoDTO.Numero = txtNumero.Text;
                    enderecoDTO.TipoEndereco = cbTipoEndereo.SelectedIndex.ToString();
                    enderecoDTO.Cidade = new Cidade() { CidadeId = txtCodigoCidade.Text.ToInteger(), Nome = lblDescricaoCidade.Text };

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }



        private bool IsCamposValidos()
        {
            if(txtLogradouro.Text.IsNullOrEmpty()) {
                lblLogradouro.Text.InformeCampoObrigatorio();
                txtLogradouro.Focus();
                return false;
            }

            if(txtNumero.Text.IsNullOrEmpty()) {
                lblNumero.Text.InformeCampoObrigatorio();
                txtNumero.Focus();
                return false;
            }

            if(txtCodigoCidade.Text.IsNullOrEmpty() || lblDescricaoCidade.Text.IsNullOrEmpty()) {
                lblCidade.Text.InformeCampoObrigatorio();
                txtCodigoCidade.Focus();
                return false;
            }
            return true;
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
                case "txtCodigoCidade":
                OpenDialog(new BrowseSelecaoCidade(), txtCodigoCidade, lblDescricaoCidade);
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
                case "txtCodigoCidade":
                return new CidadeRepository().Find(key);
                break;

                default:
                throw new NotImplementedException();
            }
        }

        private Label GetLabel(TextBox txtBox)
        {
            switch(txtBox.Name) {
                case "txtCodigoCidade":
                return lblDescricaoCidade;
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
            try {
                Close();
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnBuscarCidades_Click(object sender, EventArgs e)
        {
            try {
                OpenDialogSelect(txtCodigoCidade);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
