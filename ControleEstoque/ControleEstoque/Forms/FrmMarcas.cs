using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmMarcas : Form
    {
        private MarcaRepository repository;
        private Marca Marca { get; set; }

        public bool IsUpdate { get; set; } = false;

        public FrmMarcas()
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        public FrmMarcas(int id)
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

        private MarcaRepository GetInstanceRepository()
        {
            return new MarcaRepository();
        }

        private void PreencherControles(int id)
        {
            Marca = repository.Find(id);
            txtDescricao.Text = Marca.Descricao;

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
            Marca = new Marca();
            Marca.Descricao = txtDescricao.Text;
            repository.Salvar(Marca);
        }

        private void Atualizar()
        {
            Marca.Descricao = txtDescricao.Text;
            repository.Atualizar(Marca);
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
