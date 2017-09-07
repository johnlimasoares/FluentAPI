using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmGrupos : Form
    {
        private GrupoRepository repository;
        private Grupo Grupo { get; set; }
        public bool IsUpdate { get; set; } = false;

        public FrmGrupos()
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        public FrmGrupos(int id)
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

        private GrupoRepository GetInstanceRepository()
        {
            return new GrupoRepository();
        }

        private void PreencherControles(int id)
        {
            Grupo = repository.Find(id);
            txtDescricao.Text = Grupo.Descricao;

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
            Grupo = new Grupo();
            Grupo.Descricao = txtDescricao.Text;
            repository.Salvar(Grupo);
        }

        private void Atualizar()
        {
            Grupo.Descricao = txtDescricao.Text;
            repository.Atualizar(Grupo);
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
