using ControleEstoque.Utils;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace ControleEstoque.Forms
{
    public partial class BrowseSelecao : Form
    {
        public string Descricao { get; set; } = string.Empty;
        public int Id { get; set; } = 0;

        public BrowseSelecao()
        {
            InitializeComponent();
            GetInstanceWorker().RunWorkerAsync();
        }

        public void SetTitle(string title) {
            this.Text = $"Seleção de {title}";
        }
        public virtual void btnPesquisa_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public virtual void btnSelecionar_Click(object sender, System.EventArgs e)
        {
            try {
                SetCodigoItemSelecionado();                
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        public bool HaItemSelecionado()
        {
            if(listView.SelectedItems.Count == 0) {
                MessageUtils.ShowInfo("Selecione um item para edição");
                return false;
            }
            return true;
        }

        public BackgroundWorker GetInstanceWorker()
        {
            var worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            return worker;
        }

        public virtual void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public virtual void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public void SetCodigoItemSelecionado()
        {
            if(!HaItemSelecionado())
                return;

            Id = listView.SelectedItems[0].SubItems[0].Text.ToInteger();
            Descricao = listView.SelectedItems[0].SubItems[1].Text;
            this.DialogResult = DialogResult.OK;
        }

        public void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try {
                SetCodigoItemSelecionado();
            } catch(Exception ex) {
                ex.Message.ShowError();
            }
        }

        private void listView_KeyUp(object sender, KeyEventArgs e)
        {
            try {
                if(e.KeyCode == Keys.Enter) {
                    SetCodigoItemSelecionado();
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
