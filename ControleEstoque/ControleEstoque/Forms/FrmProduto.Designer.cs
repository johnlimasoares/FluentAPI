namespace ControleEstoque.Forms
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDados = new System.Windows.Forms.TabPage();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.lblDescricaoCor = new System.Windows.Forms.Label();
            this.btnBuscarCor = new System.Windows.Forms.Button();
            this.txtCodigoCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblDescricaoFornecedor = new System.Windows.Forms.Label();
            this.lblDescricaoTamanho = new System.Windows.Forms.Label();
            this.lblDescricaoGrupo = new System.Windows.Forms.Label();
            this.lblDescricaoMarca = new System.Windows.Forms.Label();
            this.btnBuscarFornecedor = new System.Windows.Forms.Button();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnBuscarTamanho = new System.Windows.Forms.Button();
            this.txtCodigoTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.btnBuscarGrupo = new System.Windows.Forms.Button();
            this.txtCodigoGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnBuscarMarcas = new System.Windows.Forms.Button();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.tabPagePrecoEstoque = new System.Windows.Forms.TabPage();
            this.grpEstoque = new System.Windows.Forms.GroupBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.grpPreco = new System.Windows.Forms.GroupBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.tabPageComplementos = new System.Windows.Forms.TabPage();
            this.grpComplemento = new System.Windows.Forms.GroupBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.lbdData = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDataAtualizacao = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageDados.SuspendLayout();
            this.grpProduto.SuspendLayout();
            this.tabPagePrecoEstoque.SuspendLayout();
            this.grpEstoque.SuspendLayout();
            this.grpPreco.SuspendLayout();
            this.tabPageComplementos.SuspendLayout();
            this.grpComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDados);
            this.tabControl.Controls.Add(this.tabPagePrecoEstoque);
            this.tabControl.Controls.Add(this.tabPageComplementos);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 386);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageDados
            // 
            this.tabPageDados.Controls.Add(this.grpProduto);
            this.tabPageDados.Location = new System.Drawing.Point(4, 22);
            this.tabPageDados.Name = "tabPageDados";
            this.tabPageDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDados.Size = new System.Drawing.Size(695, 360);
            this.tabPageDados.TabIndex = 0;
            this.tabPageDados.Text = "Dados Produto";
            this.tabPageDados.UseVisualStyleBackColor = true;
            // 
            // grpProduto
            // 
            this.grpProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpProduto.Controls.Add(this.lblDescricaoCor);
            this.grpProduto.Controls.Add(this.btnBuscarCor);
            this.grpProduto.Controls.Add(this.txtCodigoCor);
            this.grpProduto.Controls.Add(this.lblCor);
            this.grpProduto.Controls.Add(this.lblDescricaoFornecedor);
            this.grpProduto.Controls.Add(this.lblDescricaoTamanho);
            this.grpProduto.Controls.Add(this.lblDescricaoGrupo);
            this.grpProduto.Controls.Add(this.lblDescricaoMarca);
            this.grpProduto.Controls.Add(this.btnBuscarFornecedor);
            this.grpProduto.Controls.Add(this.txtCodigoFornecedor);
            this.grpProduto.Controls.Add(this.lblFornecedor);
            this.grpProduto.Controls.Add(this.btnBuscarTamanho);
            this.grpProduto.Controls.Add(this.txtCodigoTamanho);
            this.grpProduto.Controls.Add(this.lblTamanho);
            this.grpProduto.Controls.Add(this.btnBuscarGrupo);
            this.grpProduto.Controls.Add(this.txtCodigoGrupo);
            this.grpProduto.Controls.Add(this.lblGrupo);
            this.grpProduto.Controls.Add(this.btnBuscarMarcas);
            this.grpProduto.Controls.Add(this.txtCodigoMarca);
            this.grpProduto.Controls.Add(this.lblMarca);
            this.grpProduto.Controls.Add(this.lblCodigo);
            this.grpProduto.Controls.Add(this.txtCodigoProduto);
            this.grpProduto.Controls.Add(this.lblDescricaoProduto);
            this.grpProduto.Controls.Add(this.txtDescricaoProduto);
            this.grpProduto.Location = new System.Drawing.Point(6, 6);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(683, 348);
            this.grpProduto.TabIndex = 0;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Dados Produto";
            // 
            // lblDescricaoCor
            // 
            this.lblDescricaoCor.AutoSize = true;
            this.lblDescricaoCor.Location = new System.Drawing.Point(74, 287);
            this.lblDescricaoCor.Name = "lblDescricaoCor";
            this.lblDescricaoCor.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoCor.TabIndex = 26;
            // 
            // btnBuscarCor
            // 
            this.btnBuscarCor.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarCor.Location = new System.Drawing.Point(44, 281);
            this.btnBuscarCor.Name = "btnBuscarCor";
            this.btnBuscarCor.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarCor.TabIndex = 24;
            this.btnBuscarCor.UseVisualStyleBackColor = true;
            this.btnBuscarCor.Click += new System.EventHandler(this.btnBuscarCor_Click);
            // 
            // txtCodigoCor
            // 
            this.txtCodigoCor.Location = new System.Drawing.Point(9, 282);
            this.txtCodigoCor.MaxLength = 5;
            this.txtCodigoCor.Name = "txtCodigoCor";
            this.txtCodigoCor.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoCor.TabIndex = 6;
            this.txtCodigoCor.Text = "0";
            this.txtCodigoCor.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoCor.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(6, 266);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 25;
            this.lblCor.Text = "Cor";
            // 
            // lblDescricaoFornecedor
            // 
            this.lblDescricaoFornecedor.AutoSize = true;
            this.lblDescricaoFornecedor.Location = new System.Drawing.Point(74, 246);
            this.lblDescricaoFornecedor.Name = "lblDescricaoFornecedor";
            this.lblDescricaoFornecedor.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoFornecedor.TabIndex = 22;
            // 
            // lblDescricaoTamanho
            // 
            this.lblDescricaoTamanho.AutoSize = true;
            this.lblDescricaoTamanho.Location = new System.Drawing.Point(74, 206);
            this.lblDescricaoTamanho.Name = "lblDescricaoTamanho";
            this.lblDescricaoTamanho.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoTamanho.TabIndex = 21;
            // 
            // lblDescricaoGrupo
            // 
            this.lblDescricaoGrupo.AutoSize = true;
            this.lblDescricaoGrupo.Location = new System.Drawing.Point(74, 165);
            this.lblDescricaoGrupo.Name = "lblDescricaoGrupo";
            this.lblDescricaoGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoGrupo.TabIndex = 20;
            // 
            // lblDescricaoMarca
            // 
            this.lblDescricaoMarca.AutoSize = true;
            this.lblDescricaoMarca.Location = new System.Drawing.Point(74, 126);
            this.lblDescricaoMarca.Name = "lblDescricaoMarca";
            this.lblDescricaoMarca.Size = new System.Drawing.Size(0, 13);
            this.lblDescricaoMarca.TabIndex = 19;
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(44, 241);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarFornecedor.TabIndex = 9;
            this.btnBuscarFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.btnBuscarFornecedor_Click);
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(9, 242);
            this.txtCodigoFornecedor.MaxLength = 5;
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoFornecedor.TabIndex = 5;
            this.txtCodigoFornecedor.Text = "0";
            this.txtCodigoFornecedor.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoFornecedor.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(6, 226);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 16;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // btnBuscarTamanho
            // 
            this.btnBuscarTamanho.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarTamanho.Location = new System.Drawing.Point(44, 201);
            this.btnBuscarTamanho.Name = "btnBuscarTamanho";
            this.btnBuscarTamanho.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarTamanho.TabIndex = 7;
            this.btnBuscarTamanho.UseVisualStyleBackColor = true;
            this.btnBuscarTamanho.Click += new System.EventHandler(this.btnBuscarTamanho_Click);
            // 
            // txtCodigoTamanho
            // 
            this.txtCodigoTamanho.Location = new System.Drawing.Point(9, 202);
            this.txtCodigoTamanho.MaxLength = 5;
            this.txtCodigoTamanho.Name = "txtCodigoTamanho";
            this.txtCodigoTamanho.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoTamanho.TabIndex = 4;
            this.txtCodigoTamanho.Text = "0";
            this.txtCodigoTamanho.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoTamanho.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(6, 186);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 12;
            this.lblTamanho.Text = "Tamanho";
            // 
            // btnBuscarGrupo
            // 
            this.btnBuscarGrupo.Image = global::ControleEstoque.Properties.Resources.search1;
            this.btnBuscarGrupo.Location = new System.Drawing.Point(44, 160);
            this.btnBuscarGrupo.Name = "btnBuscarGrupo";
            this.btnBuscarGrupo.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarGrupo.TabIndex = 5;
            this.btnBuscarGrupo.UseVisualStyleBackColor = true;
            this.btnBuscarGrupo.Click += new System.EventHandler(this.btnBuscarGrupo_Click);
            // 
            // txtCodigoGrupo
            // 
            this.txtCodigoGrupo.Location = new System.Drawing.Point(9, 161);
            this.txtCodigoGrupo.MaxLength = 5;
            this.txtCodigoGrupo.Name = "txtCodigoGrupo";
            this.txtCodigoGrupo.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoGrupo.TabIndex = 3;
            this.txtCodigoGrupo.Text = "0";
            this.txtCodigoGrupo.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoGrupo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(6, 145);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 8;
            this.lblGrupo.Text = "Grupo";
            // 
            // btnBuscarMarcas
            // 
            this.btnBuscarMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMarcas.Image")));
            this.btnBuscarMarcas.Location = new System.Drawing.Point(44, 121);
            this.btnBuscarMarcas.Name = "btnBuscarMarcas";
            this.btnBuscarMarcas.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarMarcas.TabIndex = 3;
            this.btnBuscarMarcas.UseVisualStyleBackColor = true;
            this.btnBuscarMarcas.Click += new System.EventHandler(this.btnBuscarMarcas_Click);
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoMarca.Location = new System.Drawing.Point(9, 122);
            this.txtCodigoMarca.MaxLength = 5;
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(31, 20);
            this.txtCodigoMarca.TabIndex = 2;
            this.txtCodigoMarca.Text = "0";
            this.txtCodigoMarca.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtCodigoMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            this.txtCodigoMarca.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 106);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código Referência";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(6, 83);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(305, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(6, 28);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Descrição";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(6, 44);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(305, 20);
            this.txtDescricaoProduto.TabIndex = 0;
            // 
            // tabPagePrecoEstoque
            // 
            this.tabPagePrecoEstoque.Controls.Add(this.grpEstoque);
            this.tabPagePrecoEstoque.Controls.Add(this.grpPreco);
            this.tabPagePrecoEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrecoEstoque.Name = "tabPagePrecoEstoque";
            this.tabPagePrecoEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrecoEstoque.Size = new System.Drawing.Size(695, 360);
            this.tabPagePrecoEstoque.TabIndex = 1;
            this.tabPagePrecoEstoque.Text = "Preços e Estoque";
            this.tabPagePrecoEstoque.UseVisualStyleBackColor = true;
            // 
            // grpEstoque
            // 
            this.grpEstoque.Controls.Add(this.lblEstoque);
            this.grpEstoque.Controls.Add(this.txtEstoque);
            this.grpEstoque.Location = new System.Drawing.Point(7, 186);
            this.grpEstoque.Name = "grpEstoque";
            this.grpEstoque.Size = new System.Drawing.Size(682, 168);
            this.grpEstoque.TabIndex = 6;
            this.grpEstoque.TabStop = false;
            this.grpEstoque.Text = "Estoque";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(7, 24);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 5;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(7, 40);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(107, 20);
            this.txtEstoque.TabIndex = 0;
            // 
            // grpPreco
            // 
            this.grpPreco.Controls.Add(this.lblPrecoVenda);
            this.grpPreco.Controls.Add(this.txtPrecoVenda);
            this.grpPreco.Controls.Add(this.lblPrecoCompra);
            this.grpPreco.Controls.Add(this.txtPrecoCompra);
            this.grpPreco.Location = new System.Drawing.Point(7, 7);
            this.grpPreco.Name = "grpPreco";
            this.grpPreco.Size = new System.Drawing.Size(682, 173);
            this.grpPreco.TabIndex = 0;
            this.grpPreco.TabStop = false;
            this.grpPreco.Text = "Preços";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(6, 66);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(69, 13);
            this.lblPrecoVenda.TabIndex = 5;
            this.lblPrecoVenda.Text = "Preço Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(6, 82);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(107, 20);
            this.txtPrecoVenda.TabIndex = 1;
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Location = new System.Drawing.Point(6, 23);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(74, 13);
            this.lblPrecoCompra.TabIndex = 3;
            this.lblPrecoCompra.Text = "Preço Compra";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(6, 39);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(107, 20);
            this.txtPrecoCompra.TabIndex = 0;
            // 
            // tabPageComplementos
            // 
            this.tabPageComplementos.Controls.Add(this.grpComplemento);
            this.tabPageComplementos.Location = new System.Drawing.Point(4, 22);
            this.tabPageComplementos.Name = "tabPageComplementos";
            this.tabPageComplementos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComplementos.Size = new System.Drawing.Size(695, 360);
            this.tabPageComplementos.TabIndex = 2;
            this.tabPageComplementos.Text = "Complementos";
            this.tabPageComplementos.UseVisualStyleBackColor = true;
            // 
            // grpComplemento
            // 
            this.grpComplemento.Controls.Add(this.lblObservacao);
            this.grpComplemento.Controls.Add(this.txtObservacao);
            this.grpComplemento.Controls.Add(this.lblLocalizacao);
            this.grpComplemento.Controls.Add(this.txtLocalizacao);
            this.grpComplemento.Location = new System.Drawing.Point(6, 6);
            this.grpComplemento.Name = "grpComplemento";
            this.grpComplemento.Size = new System.Drawing.Size(683, 348);
            this.grpComplemento.TabIndex = 1;
            this.grpComplemento.TabStop = false;
            this.grpComplemento.Text = "Complementos";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 71);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 13);
            this.lblObservacao.TabIndex = 25;
            this.lblObservacao.Text = "Observações";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(9, 87);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(302, 130);
            this.txtObservacao.TabIndex = 1;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(6, 20);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 23;
            this.lblLocalizacao.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(6, 36);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(305, 20);
            this.txtLocalizacao.TabIndex = 0;
            // 
            // lbdData
            // 
            this.lbdData.AutoSize = true;
            this.lbdData.Location = new System.Drawing.Point(618, 402);
            this.lbdData.Name = "lbdData";
            this.lbdData.Size = new System.Drawing.Size(94, 13);
            this.lbdData.TabIndex = 27;
            this.lbdData.Text = "Última Atualização";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(598, 472);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(478, 472);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDataAtualizacao
            // 
            this.txtDataAtualizacao.AutoSize = true;
            this.txtDataAtualizacao.Enabled = false;
            this.txtDataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAtualizacao.Location = new System.Drawing.Point(618, 422);
            this.txtDataAtualizacao.Name = "txtDataAtualizacao";
            this.txtDataAtualizacao.Size = new System.Drawing.Size(94, 17);
            this.txtDataAtualizacao.TabIndex = 2;
            this.txtDataAtualizacao.Text = "DD/MM/YYYY";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 507);
            this.Controls.Add(this.txtDataAtualizacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbdData);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 546);
            this.MinimumSize = new System.Drawing.Size(744, 546);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.tabControl.ResumeLayout(false);
            this.tabPageDados.ResumeLayout(false);
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.tabPagePrecoEstoque.ResumeLayout(false);
            this.grpEstoque.ResumeLayout(false);
            this.grpEstoque.PerformLayout();
            this.grpPreco.ResumeLayout(false);
            this.grpPreco.PerformLayout();
            this.tabPageComplementos.ResumeLayout(false);
            this.grpComplemento.ResumeLayout(false);
            this.grpComplemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDados;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.Button btnBuscarFornecedor;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnBuscarTamanho;
        private System.Windows.Forms.TextBox txtCodigoTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnBuscarGrupo;
        private System.Windows.Forms.TextBox txtCodigoGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnBuscarMarcas;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TabPage tabPagePrecoEstoque;
        private System.Windows.Forms.GroupBox grpEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.GroupBox grpPreco;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.TabPage tabPageComplementos;
        private System.Windows.Forms.GroupBox grpComplemento;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label lbdData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label txtDataAtualizacao;
        private System.Windows.Forms.Label lblDescricaoFornecedor;
        private System.Windows.Forms.Label lblDescricaoTamanho;
        private System.Windows.Forms.Label lblDescricaoGrupo;
        private System.Windows.Forms.Label lblDescricaoMarca;
        private System.Windows.Forms.Label lblDescricaoCor;
        private System.Windows.Forms.Button btnBuscarCor;
        private System.Windows.Forms.TextBox txtCodigoCor;
        private System.Windows.Forms.Label lblCor;
    }
}