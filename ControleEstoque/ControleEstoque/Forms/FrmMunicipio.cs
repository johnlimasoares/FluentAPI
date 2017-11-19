using ControleEstoque.Utils;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmMunicipio : Form
    {
        private CidadeRepository repository;
        private Cidade cidade { get; set; }

        public bool IsUpdate { get; set; } = false;

        public FrmMunicipio()
        {
            try {
                InitializeComponent();
                repository = GetInstanceRepository();
                comboBox.SelectedIndex = 15;
            } catch(Exception ex) {
                ex.Message.ShowError();
                Close();
            }

        }

        public FrmMunicipio(int id)
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

        private CidadeRepository GetInstanceRepository()
        {
            return new CidadeRepository();
        }

        private void PreencherControles(int id)
        {
            cidade = repository.Find(id);
            txtDescricao.Text = cidade.Nome;
            comboBox.SelectedItem = cidade.UF;

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
            cidade = new Cidade();
            cidade.Nome = txtDescricao.Text;
            cidade.UF = comboBox.SelectedItem.ToString();
            repository.Salvar(cidade);
        }

        private void Atualizar()
        {
            cidade.Nome = txtDescricao.Text;
            cidade.UF = comboBox.SelectedItem.ToString();
            repository.Atualizar(cidade);
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
