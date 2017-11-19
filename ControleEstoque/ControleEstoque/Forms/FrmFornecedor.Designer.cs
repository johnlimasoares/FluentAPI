namespace ControleEstoque.Forms
{
    partial class FrmFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.lblNomeRazao = new System.Windows.Forms.Label();
            this.lblRgIe = new System.Windows.Forms.Label();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.txtRgIe = new System.Windows.Forms.TextBox();
            this.txtApelidoFantasia = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblApelidoFantasia = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.listViewEndereco = new System.Windows.Forms.ListView();
            this.columnCódigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.btnExcluirEndereo = new System.Windows.Forms.Button();
            this.btnNovoEndereco = new System.Windows.Forms.Button();
            this.tabPageTelefone = new System.Windows.Forms.TabPage();
            this.btnNovoFone = new System.Windows.Forms.Button();
            this.btnEditarFone = new System.Windows.Forms.Button();
            this.btnExcluirFone = new System.Windows.Forms.Button();
            this.listViewFone = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageObservacao = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.grpPrincipal.SuspendLayout();
            this.tabPageEndereco.SuspendLayout();
            this.tabPageTelefone.SuspendLayout();
            this.tabPageObservacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePrincipal);
            this.tabControl.Controls.Add(this.tabPageEndereco);
            this.tabControl.Controls.Add(this.tabPageTelefone);
            this.tabControl.Controls.Add(this.tabPageObservacao);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(648, 428);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Controls.Add(this.grpPrincipal);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(640, 402);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Dados Fornecedor";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.lblNomeRazao);
            this.grpPrincipal.Controls.Add(this.lblRgIe);
            this.grpPrincipal.Controls.Add(this.txtNomeRazao);
            this.grpPrincipal.Controls.Add(this.txtRgIe);
            this.grpPrincipal.Controls.Add(this.txtApelidoFantasia);
            this.grpPrincipal.Controls.Add(this.lblCpfCnpj);
            this.grpPrincipal.Controls.Add(this.lblApelidoFantasia);
            this.grpPrincipal.Controls.Add(this.txtCpfCnpj);
            this.grpPrincipal.Location = new System.Drawing.Point(6, 6);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(628, 390);
            this.grpPrincipal.TabIndex = 8;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "Principal";
            // 
            // lblNomeRazao
            // 
            this.lblNomeRazao.AutoSize = true;
            this.lblNomeRazao.Location = new System.Drawing.Point(6, 20);
            this.lblNomeRazao.Name = "lblNomeRazao";
            this.lblNomeRazao.Size = new System.Drawing.Size(38, 13);
            this.lblNomeRazao.TabIndex = 1;
            this.lblNomeRazao.Text = "Razão";
            // 
            // lblRgIe
            // 
            this.lblRgIe.AutoSize = true;
            this.lblRgIe.Location = new System.Drawing.Point(6, 155);
            this.lblRgIe.Name = "lblRgIe";
            this.lblRgIe.Size = new System.Drawing.Size(17, 13);
            this.lblRgIe.TabIndex = 7;
            this.lblRgIe.Text = "IE";
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.Location = new System.Drawing.Point(6, 36);
            this.txtNomeRazao.MaxLength = 50;
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(275, 20);
            this.txtNomeRazao.TabIndex = 0;
            // 
            // txtRgIe
            // 
            this.txtRgIe.Location = new System.Drawing.Point(6, 171);
            this.txtRgIe.MaxLength = 20;
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(275, 20);
            this.txtRgIe.TabIndex = 6;
            // 
            // txtApelidoFantasia
            // 
            this.txtApelidoFantasia.Location = new System.Drawing.Point(6, 81);
            this.txtApelidoFantasia.MaxLength = 50;
            this.txtApelidoFantasia.Name = "txtApelidoFantasia";
            this.txtApelidoFantasia.Size = new System.Drawing.Size(275, 20);
            this.txtApelidoFantasia.TabIndex = 2;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(6, 110);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCpfCnpj.TabIndex = 5;
            this.lblCpfCnpj.Text = "CNPJ";
            // 
            // lblApelidoFantasia
            // 
            this.lblApelidoFantasia.AutoSize = true;
            this.lblApelidoFantasia.Location = new System.Drawing.Point(6, 65);
            this.lblApelidoFantasia.Name = "lblApelidoFantasia";
            this.lblApelidoFantasia.Size = new System.Drawing.Size(47, 13);
            this.lblApelidoFantasia.TabIndex = 3;
            this.lblApelidoFantasia.Text = "Fantasia";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(6, 126);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(275, 20);
            this.txtCpfCnpj.TabIndex = 4;
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.Controls.Add(this.listViewEndereco);
            this.tabPageEndereco.Controls.Add(this.btnEditarEndereco);
            this.tabPageEndereco.Controls.Add(this.btnExcluirEndereo);
            this.tabPageEndereco.Controls.Add(this.btnNovoEndereco);
            this.tabPageEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndereco.Size = new System.Drawing.Size(640, 402);
            this.tabPageEndereco.TabIndex = 1;
            this.tabPageEndereco.Text = "Endereços";
            this.tabPageEndereco.UseVisualStyleBackColor = true;
            // 
            // listViewEndereco
            // 
            this.listViewEndereco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCódigo,
            this.columnLogradouro,
            this.columnNumero,
            this.columnCep,
            this.columnCidade});
            this.listViewEndereco.FullRowSelect = true;
            this.listViewEndereco.Location = new System.Drawing.Point(6, 45);
            this.listViewEndereco.MultiSelect = false;
            this.listViewEndereco.Name = "listViewEndereco";
            this.listViewEndereco.Size = new System.Drawing.Size(628, 322);
            this.listViewEndereco.TabIndex = 12;
            this.listViewEndereco.UseCompatibleStateImageBehavior = false;
            this.listViewEndereco.View = System.Windows.Forms.View.Details;
            // 
            // columnCódigo
            // 
            this.columnCódigo.Text = "Código";
            // 
            // columnLogradouro
            // 
            this.columnLogradouro.Text = "Logradouro";
            this.columnLogradouro.Width = 273;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número";
            this.columnNumero.Width = 86;
            // 
            // columnCep
            // 
            this.columnCep.Text = "Cep";
            this.columnCep.Width = 86;
            // 
            // columnCidade
            // 
            this.columnCidade.Text = "Cidade";
            this.columnCidade.Width = 120;
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Location = new System.Drawing.Point(478, 373);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEndereco.TabIndex = 11;
            this.btnEditarEndereco.Text = "&Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            this.btnEditarEndereco.Click += new System.EventHandler(this.btnEditarEndereco_Click);
            // 
            // btnExcluirEndereo
            // 
            this.btnExcluirEndereo.Location = new System.Drawing.Point(559, 373);
            this.btnExcluirEndereo.Name = "btnExcluirEndereo";
            this.btnExcluirEndereo.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEndereo.TabIndex = 10;
            this.btnExcluirEndereo.Text = "&Excluir";
            this.btnExcluirEndereo.UseVisualStyleBackColor = true;
            this.btnExcluirEndereo.Click += new System.EventHandler(this.btnExcluirEndereo_Click);
            // 
            // btnNovoEndereco
            // 
            this.btnNovoEndereco.Location = new System.Drawing.Point(562, 6);
            this.btnNovoEndereco.Name = "btnNovoEndereco";
            this.btnNovoEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEndereco.TabIndex = 10;
            this.btnNovoEndereco.Text = "&Novo";
            this.btnNovoEndereco.UseVisualStyleBackColor = true;
            this.btnNovoEndereco.Click += new System.EventHandler(this.btnNovoEndereco_Click);
            // 
            // tabPageTelefone
            // 
            this.tabPageTelefone.Controls.Add(this.btnNovoFone);
            this.tabPageTelefone.Controls.Add(this.btnEditarFone);
            this.tabPageTelefone.Controls.Add(this.btnExcluirFone);
            this.tabPageTelefone.Controls.Add(this.listViewFone);
            this.tabPageTelefone.Location = new System.Drawing.Point(4, 22);
            this.tabPageTelefone.Name = "tabPageTelefone";
            this.tabPageTelefone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTelefone.Size = new System.Drawing.Size(640, 402);
            this.tabPageTelefone.TabIndex = 2;
            this.tabPageTelefone.Text = "Telefones";
            this.tabPageTelefone.UseVisualStyleBackColor = true;
            // 
            // btnNovoFone
            // 
            this.btnNovoFone.Location = new System.Drawing.Point(559, 6);
            this.btnNovoFone.Name = "btnNovoFone";
            this.btnNovoFone.Size = new System.Drawing.Size(75, 23);
            this.btnNovoFone.TabIndex = 14;
            this.btnNovoFone.Text = "&Novo";
            this.btnNovoFone.UseVisualStyleBackColor = true;
            this.btnNovoFone.Click += new System.EventHandler(this.btnNovoFone_Click);
            // 
            // btnEditarFone
            // 
            this.btnEditarFone.Location = new System.Drawing.Point(479, 373);
            this.btnEditarFone.Name = "btnEditarFone";
            this.btnEditarFone.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFone.TabIndex = 13;
            this.btnEditarFone.Text = "&Editar";
            this.btnEditarFone.UseVisualStyleBackColor = true;
            this.btnEditarFone.Click += new System.EventHandler(this.btnEditarFone_Click);
            // 
            // btnExcluirFone
            // 
            this.btnExcluirFone.Location = new System.Drawing.Point(559, 373);
            this.btnExcluirFone.Name = "btnExcluirFone";
            this.btnExcluirFone.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFone.TabIndex = 12;
            this.btnExcluirFone.Text = "&Excluir";
            this.btnExcluirFone.UseVisualStyleBackColor = true;
            this.btnExcluirFone.Click += new System.EventHandler(this.btnExcluirFone_Click);
            // 
            // listViewFone
            // 
            this.listViewFone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnFone,
            this.columnTipo});
            this.listViewFone.FullRowSelect = true;
            this.listViewFone.Location = new System.Drawing.Point(6, 45);
            this.listViewFone.Name = "listViewFone";
            this.listViewFone.Size = new System.Drawing.Size(628, 322);
            this.listViewFone.TabIndex = 0;
            this.listViewFone.UseCompatibleStateImageBehavior = false;
            this.listViewFone.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            this.columnCodigo.Width = 120;
            // 
            // columnFone
            // 
            this.columnFone.Text = "Telefone";
            this.columnFone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnFone.Width = 331;
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo";
            this.columnTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTipo.Width = 166;
            // 
            // tabPageObservacao
            // 
            this.tabPageObservacao.Controls.Add(this.txtObs);
            this.tabPageObservacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageObservacao.Name = "tabPageObservacao";
            this.tabPageObservacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObservacao.Size = new System.Drawing.Size(640, 402);
            this.tabPageObservacao.TabIndex = 3;
            this.tabPageObservacao.Text = "Observações";
            this.tabPageObservacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(581, 467);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(500, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 12);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(628, 378);
            this.txtObs.TabIndex = 1;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 541);
            this.MinimumSize = new System.Drawing.Size(685, 541);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.tabControl.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageTelefone.ResumeLayout(false);
            this.tabPageObservacao.ResumeLayout(false);
            this.tabPageObservacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.TabPage tabPageEndereco;
        private System.Windows.Forms.Label lblApelidoFantasia;
        private System.Windows.Forms.TextBox txtApelidoFantasia;
        private System.Windows.Forms.Label lblNomeRazao;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.Label lblRgIe;
        private System.Windows.Forms.TextBox txtRgIe;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.TabPage tabPageTelefone;
        private System.Windows.Forms.TabPage tabPageObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnExcluirEndereo;
        private System.Windows.Forms.Button btnNovoEndereco;
        private System.Windows.Forms.ListView listViewEndereco;
        private System.Windows.Forms.ColumnHeader columnCódigo;
        private System.Windows.Forms.ColumnHeader columnLogradouro;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnCep;
        private System.Windows.Forms.ColumnHeader columnCidade;
        private System.Windows.Forms.Button btnEditarFone;
        private System.Windows.Forms.Button btnExcluirFone;
        private System.Windows.Forms.ListView listViewFone;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnFone;
        private System.Windows.Forms.ColumnHeader columnTipo;
        private System.Windows.Forms.Button btnNovoFone;
        private System.Windows.Forms.TextBox txtObs;
    }
}