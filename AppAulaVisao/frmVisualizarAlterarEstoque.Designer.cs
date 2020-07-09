namespace InventarioVisao
{
    partial class frmVisualizarAlterarEstoque
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
            this.btnInvalidar = new System.Windows.Forms.Button();
            this.tabCProduto = new System.Windows.Forms.TabControl();
            this.tabPagEstoque = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbData = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txbDetalhes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txbQ = new System.Windows.Forms.TextBox();
            this.tabPagProduto = new System.Windows.Forms.TabPage();
            this.dgvVisualizarMovComp = new System.Windows.Forms.DataGridView();
            this.produto_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_DIMENSOES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_VALORTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_NOTAFISCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_OPERACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_LOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarNovo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvVisualizarEstoq = new System.Windows.Forms.DataGridView();
            this.estoqueCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueLOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueQUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvarNovo = new System.Windows.Forms.Button();
            this.tabCProduto.SuspendLayout();
            this.tabPagEstoque.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPagProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMovComp)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEstoq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvalidar
            // 
            this.btnInvalidar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvalidar.Location = new System.Drawing.Point(714, 412);
            this.btnInvalidar.Name = "btnInvalidar";
            this.btnInvalidar.Size = new System.Drawing.Size(104, 34);
            this.btnInvalidar.TabIndex = 73;
            this.btnInvalidar.Text = "Invalidar";
            this.btnInvalidar.UseVisualStyleBackColor = true;
            this.btnInvalidar.Click += new System.EventHandler(this.btnInvalidar_Click);
            // 
            // tabCProduto
            // 
            this.tabCProduto.Controls.Add(this.tabPagEstoque);
            this.tabCProduto.Controls.Add(this.tabPagProduto);
            this.tabCProduto.Location = new System.Drawing.Point(371, 73);
            this.tabCProduto.Name = "tabCProduto";
            this.tabCProduto.SelectedIndex = 0;
            this.tabCProduto.Size = new System.Drawing.Size(561, 329);
            this.tabCProduto.TabIndex = 70;
            // 
            // tabPagEstoque
            // 
            this.tabPagEstoque.Controls.Add(this.groupBox3);
            this.tabPagEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabPagEstoque.Name = "tabPagEstoque";
            this.tabPagEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstoque.Size = new System.Drawing.Size(553, 303);
            this.tabPagEstoque.TabIndex = 0;
            this.tabPagEstoque.Text = "Dados do Estoque";
            this.tabPagEstoque.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbData);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txbDetalhes);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txbCodigo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txbLocal);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txbQ);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 291);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estoque";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(280, 140);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(247, 24);
            this.txbData.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(277, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 16);
            this.label20.TabIndex = 25;
            this.label20.Text = "Data:";
            // 
            // txbDetalhes
            // 
            this.txbDetalhes.Location = new System.Drawing.Point(17, 186);
            this.txbDetalhes.Multiline = true;
            this.txbDetalhes.Name = "txbDetalhes";
            this.txbDetalhes.Size = new System.Drawing.Size(510, 87);
            this.txbDetalhes.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 167);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "Detalhes:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(17, 48);
            this.txbCodigo.MaxLength = 6;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(510, 24);
            this.txbCodigo.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 16);
            this.label22.TabIndex = 24;
            this.label22.Text = "Quantidade:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(14, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 16);
            this.label23.TabIndex = 6;
            this.label23.Text = "Código:";
            // 
            // txbLocal
            // 
            this.txbLocal.Location = new System.Drawing.Point(17, 94);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(510, 24);
            this.txbLocal.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 7;
            this.label24.Text = "Local/Nome:";
            // 
            // txbQ
            // 
            this.txbQ.Location = new System.Drawing.Point(17, 140);
            this.txbQ.Name = "txbQ";
            this.txbQ.Size = new System.Drawing.Size(247, 24);
            this.txbQ.TabIndex = 3;
            // 
            // tabPagProduto
            // 
            this.tabPagProduto.Controls.Add(this.dgvVisualizarMovComp);
            this.tabPagProduto.Location = new System.Drawing.Point(4, 22);
            this.tabPagProduto.Name = "tabPagProduto";
            this.tabPagProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagProduto.Size = new System.Drawing.Size(553, 303);
            this.tabPagProduto.TabIndex = 1;
            this.tabPagProduto.Text = "Produtos no Estoque";
            this.tabPagProduto.UseVisualStyleBackColor = true;
            // 
            // dgvVisualizarMovComp
            // 
            this.dgvVisualizarMovComp.AllowUserToAddRows = false;
            this.dgvVisualizarMovComp.AllowUserToDeleteRows = false;
            this.dgvVisualizarMovComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizarMovComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarMovComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto_CODIGO,
            this.produto_PRODUTO,
            this.produto_DIMENSOES,
            this.produto_DETALHES,
            this.produto_QUANTIDADE,
            this.produto_VALOR,
            this.produto_VALORTOTAL,
            this.produto_SERIE,
            this.produto_NOTAFISCAL,
            this.produto_SEQ,
            this.produto_FORNECEDOR,
            this.produto_COMPLEMENTO,
            this.produto_STATUS,
            this.mov_CODIGO,
            this.mov_DETALHES,
            this.mov_OPERACAO,
            this.mov_QUANTIDADE,
            this.mov_DATA,
            this.estoque_CODIGO,
            this.estoque_LOCAL,
            this.estoque_DETALHES,
            this.estoque_QUANTIDADE});
            this.dgvVisualizarMovComp.Location = new System.Drawing.Point(19, 15);
            this.dgvVisualizarMovComp.Name = "dgvVisualizarMovComp";
            this.dgvVisualizarMovComp.ReadOnly = true;
            this.dgvVisualizarMovComp.RowHeadersVisible = false;
            this.dgvVisualizarMovComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarMovComp.Size = new System.Drawing.Size(513, 268);
            this.dgvVisualizarMovComp.TabIndex = 41;
            this.dgvVisualizarMovComp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarMovComp_CellContentClick);
            // 
            // produto_CODIGO
            // 
            this.produto_CODIGO.HeaderText = "CODIGO";
            this.produto_CODIGO.Name = "produto_CODIGO";
            this.produto_CODIGO.ReadOnly = true;
            // 
            // produto_PRODUTO
            // 
            this.produto_PRODUTO.HeaderText = "NOME";
            this.produto_PRODUTO.Name = "produto_PRODUTO";
            this.produto_PRODUTO.ReadOnly = true;
            // 
            // produto_DIMENSOES
            // 
            this.produto_DIMENSOES.HeaderText = "DIMENSÕES";
            this.produto_DIMENSOES.Name = "produto_DIMENSOES";
            this.produto_DIMENSOES.ReadOnly = true;
            // 
            // produto_DETALHES
            // 
            this.produto_DETALHES.HeaderText = "DETALHES";
            this.produto_DETALHES.Name = "produto_DETALHES";
            this.produto_DETALHES.ReadOnly = true;
            this.produto_DETALHES.Visible = false;
            // 
            // produto_QUANTIDADE
            // 
            this.produto_QUANTIDADE.HeaderText = "QUANTIDADE TOTAL";
            this.produto_QUANTIDADE.Name = "produto_QUANTIDADE";
            this.produto_QUANTIDADE.ReadOnly = true;
            this.produto_QUANTIDADE.Visible = false;
            // 
            // produto_VALOR
            // 
            this.produto_VALOR.HeaderText = "VALOR";
            this.produto_VALOR.Name = "produto_VALOR";
            this.produto_VALOR.ReadOnly = true;
            // 
            // produto_VALORTOTAL
            // 
            this.produto_VALORTOTAL.HeaderText = "VALORTOTAL";
            this.produto_VALORTOTAL.Name = "produto_VALORTOTAL";
            this.produto_VALORTOTAL.ReadOnly = true;
            this.produto_VALORTOTAL.Visible = false;
            // 
            // produto_SERIE
            // 
            this.produto_SERIE.HeaderText = "SERIE";
            this.produto_SERIE.Name = "produto_SERIE";
            this.produto_SERIE.ReadOnly = true;
            this.produto_SERIE.Visible = false;
            // 
            // produto_NOTAFISCAL
            // 
            this.produto_NOTAFISCAL.HeaderText = "NOTAFISCAL";
            this.produto_NOTAFISCAL.Name = "produto_NOTAFISCAL";
            this.produto_NOTAFISCAL.ReadOnly = true;
            this.produto_NOTAFISCAL.Visible = false;
            // 
            // produto_SEQ
            // 
            this.produto_SEQ.HeaderText = "SEQ";
            this.produto_SEQ.Name = "produto_SEQ";
            this.produto_SEQ.ReadOnly = true;
            this.produto_SEQ.Visible = false;
            // 
            // produto_FORNECEDOR
            // 
            this.produto_FORNECEDOR.HeaderText = "FORNECEDOR";
            this.produto_FORNECEDOR.Name = "produto_FORNECEDOR";
            this.produto_FORNECEDOR.ReadOnly = true;
            // 
            // produto_COMPLEMENTO
            // 
            this.produto_COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.produto_COMPLEMENTO.Name = "produto_COMPLEMENTO";
            this.produto_COMPLEMENTO.ReadOnly = true;
            this.produto_COMPLEMENTO.Visible = false;
            // 
            // produto_STATUS
            // 
            this.produto_STATUS.HeaderText = "STATUS";
            this.produto_STATUS.Name = "produto_STATUS";
            this.produto_STATUS.ReadOnly = true;
            // 
            // mov_CODIGO
            // 
            this.mov_CODIGO.HeaderText = "mov_CODIGO";
            this.mov_CODIGO.Name = "mov_CODIGO";
            this.mov_CODIGO.ReadOnly = true;
            this.mov_CODIGO.Visible = false;
            // 
            // mov_DETALHES
            // 
            this.mov_DETALHES.HeaderText = "mov_DETALHES";
            this.mov_DETALHES.Name = "mov_DETALHES";
            this.mov_DETALHES.ReadOnly = true;
            this.mov_DETALHES.Visible = false;
            // 
            // mov_OPERACAO
            // 
            this.mov_OPERACAO.HeaderText = "OPERAÇÃO";
            this.mov_OPERACAO.Name = "mov_OPERACAO";
            this.mov_OPERACAO.ReadOnly = true;
            // 
            // mov_QUANTIDADE
            // 
            this.mov_QUANTIDADE.HeaderText = "QUANTIDADE MOVIMENTADA";
            this.mov_QUANTIDADE.Name = "mov_QUANTIDADE";
            this.mov_QUANTIDADE.ReadOnly = true;
            // 
            // mov_DATA
            // 
            this.mov_DATA.HeaderText = "DATA";
            this.mov_DATA.Name = "mov_DATA";
            this.mov_DATA.ReadOnly = true;
            // 
            // estoque_CODIGO
            // 
            this.estoque_CODIGO.HeaderText = "estoque_CÓDIGO";
            this.estoque_CODIGO.Name = "estoque_CODIGO";
            this.estoque_CODIGO.ReadOnly = true;
            this.estoque_CODIGO.Visible = false;
            // 
            // estoque_LOCAL
            // 
            this.estoque_LOCAL.HeaderText = "estoque_LOCAL";
            this.estoque_LOCAL.Name = "estoque_LOCAL";
            this.estoque_LOCAL.ReadOnly = true;
            this.estoque_LOCAL.Visible = false;
            // 
            // estoque_DETALHES
            // 
            this.estoque_DETALHES.HeaderText = "estoque_DETALHES";
            this.estoque_DETALHES.Name = "estoque_DETALHES";
            this.estoque_DETALHES.ReadOnly = true;
            this.estoque_DETALHES.Visible = false;
            // 
            // estoque_QUANTIDADE
            // 
            this.estoque_QUANTIDADE.HeaderText = "estoque_QUANTIDADE";
            this.estoque_QUANTIDADE.Name = "estoque_QUANTIDADE";
            this.estoque_QUANTIDADE.ReadOnly = true;
            this.estoque_QUANTIDADE.Visible = false;
            // 
            // btnConsultarNovo
            // 
            this.btnConsultarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNovo.Location = new System.Drawing.Point(604, 412);
            this.btnConsultarNovo.Name = "btnConsultarNovo";
            this.btnConsultarNovo.Size = new System.Drawing.Size(104, 34);
            this.btnConsultarNovo.TabIndex = 67;
            this.btnConsultarNovo.Text = "Consultar";
            this.btnConsultarNovo.UseVisualStyleBackColor = true;
            this.btnConsultarNovo.Click += new System.EventHandler(this.btnConsultarNovo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvVisualizarEstoq);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 380);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estoques";
            // 
            // dgvVisualizarEstoq
            // 
            this.dgvVisualizarEstoq.AllowUserToAddRows = false;
            this.dgvVisualizarEstoq.AllowUserToDeleteRows = false;
            this.dgvVisualizarEstoq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizarEstoq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarEstoq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estoqueCODIGO,
            this.estoqueLOCAL,
            this.estoqueDETALHES,
            this.estoqueQUANTIDADE,
            this.estoqueDATA});
            this.dgvVisualizarEstoq.Location = new System.Drawing.Point(15, 23);
            this.dgvVisualizarEstoq.Name = "dgvVisualizarEstoq";
            this.dgvVisualizarEstoq.ReadOnly = true;
            this.dgvVisualizarEstoq.RowHeadersVisible = false;
            this.dgvVisualizarEstoq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarEstoq.Size = new System.Drawing.Size(314, 347);
            this.dgvVisualizarEstoq.TabIndex = 40;
            this.dgvVisualizarEstoq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarEstoq_CellContentClick);
            // 
            // estoqueCODIGO
            // 
            this.estoqueCODIGO.HeaderText = "Código";
            this.estoqueCODIGO.Name = "estoqueCODIGO";
            this.estoqueCODIGO.ReadOnly = true;
            // 
            // estoqueLOCAL
            // 
            this.estoqueLOCAL.HeaderText = "Local/Nome";
            this.estoqueLOCAL.Name = "estoqueLOCAL";
            this.estoqueLOCAL.ReadOnly = true;
            // 
            // estoqueDETALHES
            // 
            this.estoqueDETALHES.HeaderText = "Detalhes";
            this.estoqueDETALHES.Name = "estoqueDETALHES";
            this.estoqueDETALHES.ReadOnly = true;
            // 
            // estoqueQUANTIDADE
            // 
            this.estoqueQUANTIDADE.HeaderText = "Quantidade";
            this.estoqueQUANTIDADE.Name = "estoqueQUANTIDADE";
            this.estoqueQUANTIDADE.ReadOnly = true;
            // 
            // estoqueDATA
            // 
            this.estoqueDATA.HeaderText = "Data";
            this.estoqueDATA.Name = "estoqueDATA";
            this.estoqueDATA.ReadOnly = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(365, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(205, 34);
            this.label26.TabIndex = 71;
            this.label26.Text = "Editar Estoque";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(824, 412);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 34);
            this.btnVoltar.TabIndex = 69;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(27, 412);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 34);
            this.btnLimpar.TabIndex = 68;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnSalvarNovo
            // 
            this.btnSalvarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovo.Location = new System.Drawing.Point(494, 412);
            this.btnSalvarNovo.Name = "btnSalvarNovo";
            this.btnSalvarNovo.Size = new System.Drawing.Size(104, 34);
            this.btnSalvarNovo.TabIndex = 66;
            this.btnSalvarNovo.Text = "Salvar";
            this.btnSalvarNovo.UseVisualStyleBackColor = true;
            this.btnSalvarNovo.Click += new System.EventHandler(this.btnSalvarNovo_Click);
            // 
            // frmVisualizarAlterarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 459);
            this.Controls.Add(this.btnInvalidar);
            this.Controls.Add(this.tabCProduto);
            this.Controls.Add(this.btnConsultarNovo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvarNovo);
            this.Name = "frmVisualizarAlterarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.tabCProduto.ResumeLayout(false);
            this.tabPagEstoque.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPagProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMovComp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEstoq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvalidar;
        private System.Windows.Forms.TabControl tabCProduto;
        private System.Windows.Forms.TabPage tabPagEstoque;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbDetalhes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txbQ;
        private System.Windows.Forms.Button btnConsultarNovo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvVisualizarEstoq;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvarNovo;
        private System.Windows.Forms.DateTimePicker txbData;
        private System.Windows.Forms.TabPage tabPagProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueLOCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueQUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDATA;
        private System.Windows.Forms.DataGridView dgvVisualizarMovComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_DIMENSOES;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_VALORTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_NOTAFISCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_OPERACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_LOCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_QUANTIDADE;
    }
}