using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmCores : Form
    {
        private CorRepository repository;
        private Cor Cor { get; set; }

        public bool IsUpdate { get; set; } = false;

        public FrmCores()
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        public FrmCores(int id)
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
                PreencherControles(id);
                this.IsUpdate = true;
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        private CorRepository GetInstanceRepository()
        {
            return new CorRepository();
        }

        private void PreencherControles(int id)
        {
            Cor = repository.Find(id);
            txtDescricao.Text = Cor.Descricao;

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
            Cor = new Cor();
            Cor.Descricao = txtDescricao.Text;
            repository.Salvar(Cor);
        }

        private void Atualizar()
        {
            Cor.Descricao = txtDescricao.Text;
            repository.Atualizar(Cor);
        }

        private bool IsCamposValidos()
        {
            if(txtDescricao.Text.IsNullOrEmpty()) {
                lblDescricao.Text.InformeCampoObrigatorio();
                txtDescricao.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if(e.KeyCode == Keys.Enter) {
                    btnSalvar_Click(null, null);
                }
                else if(e.KeyCode == Keys.Escape) {
                    Close();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
