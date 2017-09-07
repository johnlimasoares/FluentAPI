using Business;
using ControleEstoque.Utils;
using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoque.Forms
{
    public partial class FrmFornecedor : Form
    {
        public bool IsUpdate { get; set; } = false;
        public Fornecedor fornecedor { get; set; }
        public List<EnderecoDTO> listEndereco = new List<EnderecoDTO>();
        public List<TelefoneDTO> listFone = new List<TelefoneDTO>();
        public DataContext ctx = new DataContext();

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        public FrmFornecedor(int idFornecedor)
        {
            try {
                InitializeComponent();
                PreencherControles(idFornecedor);
                GetInstanceWorker().RunWorkerAsync(idFornecedor);
                this.IsUpdate = true;
            } catch(Exception ex) {
                ex.Message.ShowError();
            }

        }

        private void PreencherControles(int id)
        {
            fornecedor = FornecedorBusiness.GetFornecedor(ctx, id);
            txtApelidoFantasia.Text = fornecedor.Pessoa.ApelidoFantasia;
            txtNomeRazao.Text = fornecedor.Pessoa.NomeRazao;
            txtCpfCnpj.Text = fornecedor.Pessoa.CpfCnpj;
            txtRgIe.Text = fornecedor.Pessoa.RgIe;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
            var pessoa = new Pessoa();
            pessoa.NomeRazao = txtNomeRazao.Text;
            pessoa.ApelidoFantasia = txtApelidoFantasia.Text;
            pessoa.CpfCnpj = txtCpfCnpj.Text;
            pessoa.RgIe = txtRgIe.Text;
            pessoa.TipoPessoa = txtCpfCnpj.Text.Length > 11 ? "J" : "F";
            FornecedorBusiness.Salvar(ctx, pessoa, listEndereco, listFone);
        }

        private void Atualizar()
        {
            fornecedor.Pessoa.NomeRazao = txtNomeRazao.Text;
            fornecedor.Pessoa.ApelidoFantasia = txtApelidoFantasia.Text;
            fornecedor.Pessoa.CpfCnpj = txtCpfCnpj.Text;
            fornecedor.Pessoa.TipoPessoa = txtCpfCnpj.Text.Length > 11 ? "J" : "F";
            fornecedor.Pessoa.RgIe = txtRgIe.Text;
            FornecedorBusiness.Atualizar(ctx, fornecedor, listEndereco, listFone);
        }

        private bool IsCamposValidos()
        {
            if(txtNomeRazao.Text.IsNullOrEmpty()) {
                lblNomeRazao.Text.InformeCampoObrigatorio();
                SelectTabPrincipal();
                txtNomeRazao.Focus();
                return false;
            }

            if(txtApelidoFantasia.Text.IsNullOrEmpty()) {
                lblApelidoFantasia.Text.InformeCampoObrigatorio();
                SelectTabPrincipal();
                txtApelidoFantasia.Focus();
                return false;
            }
            if(txtCpfCnpj.Text.IsNullOrEmpty()) {
                lblCpfCnpj.Text.InformeCampoObrigatorio();
                SelectTabPrincipal();
                txtCpfCnpj.Focus();
                return false;
            }
            if(txtRgIe.Text.IsNullOrEmpty()) {
                lblRgIe.Text.InformeCampoObrigatorio();
                SelectTabPrincipal();
                txtRgIe.Focus();
                return false;
            }

            return true;
        }

        private void SelectTabPrincipal()
        {
            tabControl.SelectedTab = tabPagePrincipal;
        }

        private bool HaItemSelecionado(ListView listView)
        {
            if(listView.SelectedItems.Count == 0) {
                MessageUtils.ShowInfo("Selecione um item para edição");
                return false;
            }
            return true;
        }

        private int GetCodigoItemSelecionado(ListView listView)
        {
            return listView.SelectedItems[0].SubItems[0].Text.ToInteger();
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
                int fornecedorId = (int)e.Argument;
                listEndereco = FornecedorBusiness.GetAllEnderecos(ctx, fornecedorId);
                listFone  = FornecedorBusiness.GetAllFones(ctx, fornecedorId);
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try {                
                PreencherListViewEndereco();
                PreencherListViewFones();
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void PreencherListViewEndereco()
        {
            listViewEndereco.Items.Clear();
            foreach(var endereco in listEndereco.Where(x => !x.IsDeleted)) {
                var listViewItem = new ListViewItem(endereco.EnderecoId.ToString());
                listViewItem.SubItems.Add(endereco.Logradouro);
                listViewItem.SubItems.Add(endereco.Numero);
                listViewItem.SubItems.Add(endereco.CEP);
                listViewItem.SubItems.Add(endereco.Cidade.Nome);
                listViewEndereco.Items.Add(listViewItem);
            }
        }

        private EnderecoDTO GetEnderecoSelecionado()
        {
            var enderecoId = GetCodigoItemSelecionado(listViewEndereco);
            return listEndereco.Where(x => x.EnderecoId == enderecoId).FirstOrDefault();
        }

        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {
            using(var frmEndereco = new FrmEndereco()) {
                if(frmEndereco.ShowDialog() == DialogResult.OK) {
                    var novoEndereco = frmEndereco.enderecoDTO;
                    novoEndereco.EnderecoId = (listEndereco.Count > 0 ? listEndereco.Max(x => x.EnderecoId) : 0) + 1;
                    listEndereco.Add(novoEndereco);
                    PreencherListViewEndereco();
                }
            }

        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {
            try {
                if(HaItemSelecionado(listViewEndereco)) {
                    var enderecoSelecionado = GetEnderecoSelecionado();
                    using(var frmEndereco = new FrmEndereco(enderecoSelecionado)) {
                        if(frmEndereco.ShowDialog() == DialogResult.OK) {
                            var novoEndereco = frmEndereco.enderecoDTO;
                            listEndereco[listEndereco.IndexOf(enderecoSelecionado)] = novoEndereco;
                            PreencherListViewEndereco();
                        }
                    }
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }

        }

        private void btnExcluirEndereo_Click(object sender, EventArgs e)
        {
            try {
                if(HaItemSelecionado(listViewEndereco)) {
                    var endereco = GetEnderecoSelecionado();
                    if(!endereco.IsPersisted) {
                        listEndereco.Remove(endereco);
                    }
                    else {
                        endereco.IsDeleted = true;
                    }
                    PreencherListViewEndereco();
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }


        private void PreencherListViewFones()
        {
            listViewFone.Items.Clear();
            foreach(var fone in listFone.Where(x => !x.IsDeleted)) {
                var listViewItem = new ListViewItem(fone.TelefoneId.ToString());
                listViewItem.SubItems.Add(fone.Numero);
                listViewItem.SubItems.Add(GetDescricaoTipoFone(fone.TipoFone));
                listViewFone.Items.Add(listViewItem);
            }
        }

        private TelefoneDTO GetTelefoneSelecionado()
        {
            var telefoneId = GetCodigoItemSelecionado(listViewFone);
            return listFone.Where(x => x.TelefoneId == telefoneId).FirstOrDefault();
        }

        public string GetDescricaoTipoFone(string index)
        {
            switch(index) {
                case "0":
                return "Celular";
                break;
                case "1":
                return "Whatts App";
                break;
                case "2":
                return "Trabalho";
                break;
                case "3":
                return "Recado";
                break;
                case "4":
                return "Residência";
                break;
            }
            throw new NotImplementedException();
        }

        private void btnNovoFone_Click(object sender, EventArgs e)
        {
            try {
                using(var frmFone = new FrmTelefone()) {
                    if(frmFone.ShowDialog() == DialogResult.OK) {
                        var novoFone = frmFone.telefoneDTO;
                        novoFone.TelefoneId = (listFone.Count > 0 ? listFone.Max(x => x.TelefoneId) : 0) + 1;
                        listFone.Add(novoFone);
                        PreencherListViewFones();
                    }
                }
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void btnEditarFone_Click(object sender, EventArgs e)
        {
            try {
                if(HaItemSelecionado(listViewFone)) {
                    var telefoneSelecionado = GetTelefoneSelecionado();
                    using(var frmFone = new FrmTelefone(telefoneSelecionado)) {
                        if(frmFone.ShowDialog() == DialogResult.OK) {
                            var novoFone = frmFone.telefoneDTO;
                            listFone[listFone.IndexOf(telefoneSelecionado)] = novoFone;
                            PreencherListViewFones();
                        }
                    }
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }

        }

        private void btnExcluirFone_Click(object sender, EventArgs e)
        {
            try {
                if(HaItemSelecionado(listViewFone)) {
                    var fone = GetTelefoneSelecionado();
                    if(!fone.IsPersisted) {
                        listFone.Remove(fone);
                    }
                    else {
                        fone.IsDeleted = true;
                    }
                    PreencherListViewFones();
                }

            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }
    }
}
