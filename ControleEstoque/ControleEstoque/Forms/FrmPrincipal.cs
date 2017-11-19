using ControleEstoque.Forms;
using System;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseProdutos");
            if(form == null) {
                AbreFormulario(new BrowseProdutos());
            }
            else {
                form.Focus();
            }
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseMarcas");
            if(form == null) {
                AbreFormulario(new BrowseMarcas());
            }
            else {
                form.Focus();
            }
        }

        private void AbreFormulario(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private Form GetInstanceForm(string name)
        {
            return Application.OpenForms[name];
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseGrupos");
            if(form == null) {
                AbreFormulario(new BrowseGrupos());
            }
            else {
                form.Focus();
            }

        }

        private void tamanhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseTamanhos");
            if(form == null) {
                AbreFormulario(new BrowseTamanhos());
            }
            else {
                form.Focus();
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = GetInstanceForm("BrowseFornecedores");
            if(form == null) {
                AbreFormulario(new BrowseFornecedores());
            }
            else {
                form.Focus();
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseCores");
            if(form == null) {
                AbreFormulario(new BrowseCores());
            }
            else {
                form.Focus();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseClientes");
            if(form == null) {
                AbreFormulario(new BrowseClientes());
            }
            else {
                form.Focus();
            }

        }

        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = GetInstanceForm("BrowseMunicipio");
            if(form == null) {
                AbreFormulario(new BrowseMunicipio());
            }
            else {
                form.Focus();
            }
        }
    }
}
