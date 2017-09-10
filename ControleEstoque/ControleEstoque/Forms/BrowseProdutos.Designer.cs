namespace ControleEstoque.Forms
{
    partial class BrowseProdutos
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseProdutos));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTamnho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lblDescricaoMarca = new System.Windows.Forms.Label();
            this.btnBuscarMarcas = new System.Windows.Forms.Button();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescricaoGrupo = new System.Windows.Forms.Label();
            this.btnBuscarGrupo = new System.Windows.Forms.Button();
            this.txtCodigoGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDescricaoCor = new System.Windows.Forms.Label();
            this.btnBuscarCor = new System.Windows.Forms.Button();
            this.txtCodigoCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblDescricaoTamanho = new System.Windows.Forms.Label();
            this.btnBuscarTamanho = new System.Windows.Forms.Button();
            this.txtCodigoTamanho = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastrar.Location = new System.Drawing.Point(972, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(82, 26);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "&Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(884, 518);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 26);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(972, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 26);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInativar.Location = new System.Drawing.Point(794, 518);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(82, 26);
            this.btnInativar.TabIndex = 5;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = true;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnDescricao,
            this.columnReferencia,
            this.columnMarca,
            this.columnGrupo,
            this.columnTamnho,
            this.columnCor,
            this.columnPreco,
            this.columnEstoque});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(7, 121);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1047, 392);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            this.columnCodigo.Width = 73;
            // 
            // columnDescricao
            // 
            this.columnDescricao.Text = "Descrição";
            this.columnDescricao.Width = 388;
            // 
            // columnReferencia
            // 
            this.columnReferencia.Text = "Referência";
            this.columnReferencia.Width = 107;
            // 
            // columnMarca
            // 
            this.columnMarca.Text = "Marca";
            this.columnMarca.Width = 113;
            // 
            // columnGrupo
            // 
            this.columnGrupo.Text = "Grupo";
            this.columnGrupo.Width = 110;
            // 
            // columnTamnho
            // 
            this.columnTamnho.Text = "Tamanho";
            this.columnTamnho.Width = 73;
            // 
            // columnCor
            // 
            this.columnCor.Text = "Cor";
            this.columnCor.Width = 122;
            // 
            // columnPreco
            // 
            this.columnPreco.Text = "Preço";
            this.columnPreco.Width = 89;
            // 
            // columnEstoque
            // 
            this.columnEstoque.Text = "Estoque";
            this.columnEstoque.Width = 88;
            // 
            // txtBusca
            // 
            this.txtBusca.AutoCompleteCustomSource.AddRange(new string[] {
            "body",
            "calça",
            "camiseta",
            "camisa",
            "shorts",
            "meia",
            "regata",
            "vestido",
            "sapato",
            "tenis",
            ""});
            this.txtBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBusca.Location = new System.Drawing.Point(308, 33);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(263, 20);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(702, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Descrição",
            "Referência",
            "Código"});
            this.comboBox.Location = new System.Drawing.Point(577, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(119, 21);
            this.comboBox.TabIndex = 9;
            // 
            // lblDescricaoMarca
            // 
            this.lblDescricaoMarca.AutoSize = true;
            this.lblDescricaoMarca.Location = new System.Drawing.Point(72, 34);
            this.lblDescricaoMarca.Name = "lblDescricaoMarca";
            this.lblDescricaoMarca.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoMarca.TabIndex = 23;
            // 
            // btnBuscarMarcas
            // 
            this.btnBuscarMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMarcas.Image")));
            this.btnBuscarMarcas.Location = new System.Drawing.Point(42, 31);
            this.btnBuscarMarcas.Name = "btnBuscarMarcas";
            this.btnBuscarMarcas.Size = new System.Drawing.Size(24, 22);
            this.btnBuscarMarcas.TabIndex = 21;
            this.btnBuscarMarcas.UseVisualStyleBackColor = true;
            this.btnBuscarMarcas.Click += new System.EventHandler(this.btnBuscarMarcas_Click);
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoMarca.Location = new System.Drawing.Point(7, 32);
            this.txtCodigoMarca.MaxLength = 5;
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoMarca.TabIndex = 20;
            this.txtCodigoMarca.Text = "0";
            this.txtCodigoMarca.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoMarca.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Location = new System.Drawing.Point(4, 16);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoGrupo
            // 
            this.lblDescricaoGrupo.AutoSize = true;
            this.lblDescricaoGrupo.Location = new System.Drawing.Point(72, 77);
            this.lblDescricaoGrupo.Name = "lblDescricaoGrupo";
            this.lblDescricaoGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoGrupo.TabIndex = 27;
            // 
            // btnBuscarGrupo
            // 
            this.btnBuscarGrupo.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarGrupo.Location = new System.Drawing.Point(42, 72);
            this.btnBuscarGrupo.Name = "btnBuscarGrupo";
            this.btnBuscarGrupo.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarGrupo.TabIndex = 25;
            this.btnBuscarGrupo.UseVisualStyleBackColor = true;
            this.btnBuscarGrupo.Click += new System.EventHandler(this.btnBuscarGrupo_Click);
            // 
            // txtCodigoGrupo
            // 
            this.txtCodigoGrupo.Location = new System.Drawing.Point(7, 73);
            this.txtCodigoGrupo.MaxLength = 5;
            this.txtCodigoGrupo.Name = "txtCodigoGrupo";
            this.txtCodigoGrupo.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoGrupo.TabIndex = 24;
            this.txtCodigoGrupo.Text = "0";
            this.txtCodigoGrupo.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoGrupo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrupo.Location = new System.Drawing.Point(4, 57);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 26;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoCor
            // 
            this.lblDescricaoCor.AutoSize = true;
            this.lblDescricaoCor.Location = new System.Drawing.Point(239, 77);
            this.lblDescricaoCor.Name = "lblDescricaoCor";
            this.lblDescricaoCor.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoCor.TabIndex = 38;
            // 
            // btnBuscarCor
            // 
            this.btnBuscarCor.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarCor.Location = new System.Drawing.Point(209, 72);
            this.btnBuscarCor.Name = "btnBuscarCor";
            this.btnBuscarCor.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarCor.TabIndex = 36;
            this.btnBuscarCor.UseVisualStyleBackColor = true;
            this.btnBuscarCor.Click += new System.EventHandler(this.btnBuscarCor_Click);
            // 
            // txtCodigoCor
            // 
            this.txtCodigoCor.Location = new System.Drawing.Point(174, 73);
            this.txtCodigoCor.MaxLength = 5;
            this.txtCodigoCor.Name = "txtCodigoCor";
            this.txtCodigoCor.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoCor.TabIndex = 35;
            this.txtCodigoCor.Text = "0";
            this.txtCodigoCor.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoCor.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCor.Location = new System.Drawing.Point(171, 57);
            this.lblCor.Margin = new System.Windows.Forms.Padding(0);
            this.lblCor.Name = "lblCor";
            this.lblCor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 37;
            this.lblCor.Text = "Cor";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoTamanho
            // 
            this.lblDescricaoTamanho.AutoSize = true;
            this.lblDescricaoTamanho.Location = new System.Drawing.Point(238, 34);
            this.lblDescricaoTamanho.Name = "lblDescricaoTamanho";
            this.lblDescricaoTamanho.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoTamanho.TabIndex = 33;
            // 
            // btnBuscarTamanho
            // 
            this.btnBuscarTamanho.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarTamanho.Location = new System.Drawing.Point(208, 31);
            this.btnBuscarTamanho.Name = "btnBuscarTamanho";
            this.btnBuscarTamanho.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarTamanho.TabIndex = 29;
            this.btnBuscarTamanho.UseVisualStyleBackColor = true;
            this.btnBuscarTamanho.Click += new System.EventHandler(this.btnBuscarTamanho_Click);
            // 
            // txtCodigoTamanho
            // 
            this.txtCodigoTamanho.Location = new System.Drawing.Point(173, 32);
            this.txtCodigoTamanho.MaxLength = 5;
            this.txtCodigoTamanho.Name = "txtCodigoTamanho";
            this.txtCodigoTamanho.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoTamanho.TabIndex = 28;
            this.txtCodigoTamanho.Text = "0";
            this.txtCodigoTamanho.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoTamanho.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkInativos);
            this.groupBox1.Controls.Add(this.lblTamanho);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.txtCodigoGrupo);
            this.groupBox1.Controls.Add(this.lblDescricaoCor);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.btnBuscarCor);
            this.groupBox1.Controls.Add(this.txtCodigoMarca);
            this.groupBox1.Controls.Add(this.txtCodigoCor);
            this.groupBox1.Controls.Add(this.btnBuscarMarcas);
            this.groupBox1.Controls.Add(this.lblCor);
            this.groupBox1.Controls.Add(this.lblDescricaoMarca);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.lblDescricaoTamanho);
            this.groupBox1.Controls.Add(this.btnBuscarGrupo);
            this.groupBox1.Controls.Add(this.lblDescricaoGrupo);
            this.groupBox1.Controls.Add(this.txtCodigoTamanho);
            this.groupBox1.Controls.Add(this.btnBuscarTamanho);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 103);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Location = new System.Drawing.Point(308, 72);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(63, 17);
            this.chkInativos.TabIndex = 40;
            this.chkInativos.Text = "Inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTamanho.Location = new System.Drawing.Point(170, 16);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 39;
            this.lblTamanho.Text = "Tamanho";
            this.lblTamanho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrowseProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "BrowseProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnDescricao;
        private System.Windows.Forms.ColumnHeader columnReferencia;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnGrupo;
        private System.Windows.Forms.ColumnHeader columnTamnho;
        private System.Windows.Forms.ColumnHeader columnCor;
        private System.Windows.Forms.ColumnHeader columnPreco;
        private System.Windows.Forms.ColumnHeader columnEstoque;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lblDescricaoMarca;
        private System.Windows.Forms.Button btnBuscarMarcas;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescricaoGrupo;
        private System.Windows.Forms.Button btnBuscarGrupo;
        private System.Windows.Forms.TextBox txtCodigoGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDescricaoCor;
        private System.Windows.Forms.Button btnBuscarCor;
        private System.Windows.Forms.TextBox txtCodigoCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblDescricaoTamanho;
        private System.Windows.Forms.Button btnBuscarTamanho;
        private System.Windows.Forms.TextBox txtCodigoTamanho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.CheckBox chkInativos;
    }
}