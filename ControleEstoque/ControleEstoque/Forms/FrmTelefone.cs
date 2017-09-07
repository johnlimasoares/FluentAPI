using ControleEstoque.Utils;
using Domain.DTO;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmTelefone : Form
    {
        public TelefoneDTO telefoneDTO;
        public bool IsUpdate { get; private set; }

        public FrmTelefone()
        {
            try {
                InitializeComponent();
                telefoneDTO = new TelefoneDTO();
                cbTipoFone.SelectedIndex = 0;
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public FrmTelefone(TelefoneDTO telefoneDTO)
        {
            try {
                InitializeComponent();
                this.telefoneDTO = telefoneDTO;                
                cbTipoFone.SelectedIndex = 0;
                IsUpdate = true;
                PreencherControles();
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void PreencherControles()
        {
            txtNumero.Text = telefoneDTO.Numero;
            cbTipoFone.SelectedIndex = telefoneDTO.TipoFone.ToInteger();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try {
                Close();
            } catch(Exception ex) {
                ex.Message.ShowError();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if(IsCamposValidos()) {
                    telefoneDTO.Numero = txtNumero.Text;
                    telefoneDTO.TipoFone = cbTipoFone.SelectedIndex.ToString();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private bool IsCamposValidos()
        {
            if(txtNumero.Text.IsNullOrEmpty()) {
                lblNumero.Text.InformeCampoObrigatorio();
                txtNumero.Focus();
                return false;
            }
            return true;
        }
    }
}
