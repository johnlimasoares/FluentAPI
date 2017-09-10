namespace ControleEstoque.Forms
{
    partial class FrmTelefone
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
            this.grpFone = new System.Windows.Forms.GroupBox();
            this.lblDescricaoCidade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoFone = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpFone.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFone
            // 
            this.grpFone.Controls.Add(this.lblDescricaoCidade);
            this.grpFone.Controls.Add(this.lblTipo);
            this.grpFone.Controls.Add(this.cbTipoFone);
            this.grpFone.Controls.Add(this.lblNumero);
            this.grpFone.Controls.Add(this.txtNumero);
            this.grpFone.Location = new System.Drawing.Point(7, 12);
            this.grpFone.Name = "grpFone";
            this.grpFone.Size = new System.Drawing.Size(316, 119);
            this.grpFone.TabIndex = 6;
            this.grpFone.TabStop = false;
            this.grpFone.Text = "Dados de telefones";
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
            this.lblTipo.Location = new System.Drawing.Point(7, 61);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipoFone
            // 
            this.cbTipoFone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFone.FormattingEnabled = true;
            this.cbTipoFone.Items.AddRange(new object[] {
            "Celular",
            "Whatts App",
            "Trabalho",
            "Recado",
            "Residência"});
            this.cbTipoFone.Location = new System.Drawing.Point(6, 77);
            this.cbTipoFone.Name = "cbTipoFone";
            this.cbTipoFone.Size = new System.Drawing.Size(112, 21);
            this.cbTipoFone.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 35);
            this.txtNumero.MaxLength = 12;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(112, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(249, 137);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 164);
            this.Controls.Add(this.grpFone);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telefone";
            this.grpFone.ResumeLayout(false);
            this.grpFone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFone;
        private System.Windows.Forms.Label lblDescricaoCidade;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoFone;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}