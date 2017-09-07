using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmTamanhos : Form
    {
        private TamanhoRepository repository;
        private Tamanho Tamanho { get; set; }
        public bool IsUpdate { get; set; } = false;

        public FrmTamanhos()
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        public FrmTamanhos(int id)
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

        private TamanhoRepository GetInstanceRepository()
        {
            return new TamanhoRepository();
        }

        private void PreencherControles(int id)
        {
            Tamanho = repository.Find(id);
            txtDescricao.Text = Tamanho.Descricao;

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
            Tamanho = new Tamanho();
            Tamanho.Descricao = txtDescricao.Text;
            repository.Salvar(Tamanho);
        }

        private void Atualizar()
        {
            Tamanho.Descricao = txtDescricao.Text;
            repository.Atualizar(Tamanho);
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
