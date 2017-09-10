namespace ControleEstoque.Forms
{
    partial class FrmEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEndereco));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpEndereço = new System.Windows.Forms.GroupBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCodigoCidade = new System.Windows.Forms.TextBox();
            this.btnBuscarCidades = new System.Windows.Forms.Button();
            this.lblDescricaoCidade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoEndereo = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.grpEndereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(316, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpEndereço
            // 
            this.grpEndereço.Controls.Add(this.lblCidade);
            this.grpEndereço.Controls.Add(this.txtCodigoCidade);
            this.grpEndereço.Controls.Add(this.btnBuscarCidades);
            this.grpEndereço.Controls.Add(this.lblDescricaoCidade);
            this.grpEndereço.Controls.Add(this.lblTipo);
            this.grpEndereço.Controls.Add(this.cbTipoEndereo);
            this.grpEndereço.Controls.Add(this.lblNumero);
            this.grpEndereço.Controls.Add(this.txtNumero);
            this.grpEndereço.Controls.Add(this.lblCEP);
            this.grpEndereço.Controls.Add(this.txtCEP);
            this.grpEndereço.Controls.Add(this.lblLogradouro);
            this.grpEndereço.Controls.Add(this.txtLogradouro);
            this.grpEndereço.Location = new System.Drawing.Point(5, 5);
            this.grpEndereço.Name = "grpEndereço";
            this.grpEndereço.Size = new System.Drawing.Size(386, 232);
            this.grpEndereço.TabIndex = 3;
            this.grpEndereço.TabStop = false;
            this.grpEndereço.Text = "Dados de endereço";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCidade.Location = new System.Drawing.Point(5, 142);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 26;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoCidade
            // 
            this.txtCodigoCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCidade.Location = new System.Drawing.Point(8, 158);
            this.txtCodigoCidade.MaxLength = 5;
            this.txtCodigoCidade.Name = "txtCodigoCidade";
            this.txtCodigoCidade.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoCidade.TabIndex = 3;
            this.txtCodigoCidade.Text = "0";
            this.txtCodigoCidade.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoCidade.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnBuscarCidades
            // 
            this.btnBuscarCidades.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCidades.Image")));
            this.btnBuscarCidades.Location = new System.Drawing.Point(43, 157);
            this.btnBuscarCidades.Name = "btnBuscarCidades";
            this.btnBuscarCidades.Size = new System.Drawing.Size(24, 22);
            this.btnBuscarCidades.TabIndex = 25;
            this.btnBuscarCidades.UseVisualStyleBackColor = true;
            this.btnBuscarCidades.Click += new System.EventHandler(this.btnBuscarCidades_Click);
            // 
            // lblDescricaoCidade
            // 
            this.lblDescricaoCidade.AutoSize = true;
            this.lblDescricaoCidade.Location = new System.Drawing.Point(73, 160);
            this.lblDescricaoCidade.Name = "lblDescricaoCidade";
            this.lblDescricaoCidade.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoCidade.TabIndex = 27;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 184);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipoEndereo
            // 
            this.cbTipoEndereo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEndereo.FormattingEnabled = true;
            this.cbTipoEndereo.Items.AddRange(new object[] {
            "Residência",
            "Trabalho",
            "Cobrança",
            ""});
            this.cbTipoEndereo.Location = new System.Drawing.Point(6, 200);
            this.cbTipoEndereo.Name = "cbTipoEndereo";
            this.cbTipoEndereo.Size = new System.Drawing.Size(112, 21);
            this.cbTipoEndereo.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 103);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 119);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(112, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 64);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 80);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(112, 20);
            this.txtCEP.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 25);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 1;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 41);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(374, 20);
            this.txtLogradouro.TabIndex = 0;
            // 
            // FrmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 278);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpEndereço);
            this.Name = "FrmEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Endereço";
            this.grpEndereço.ResumeLayout(false);
            this.grpEndereço.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpEndereço;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoEndereo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCodigoCidade;
        private System.Windows.Forms.Button btnBuscarCidades;
        private System.Windows.Forms.Label lblDescricaoCidade;
    }
}