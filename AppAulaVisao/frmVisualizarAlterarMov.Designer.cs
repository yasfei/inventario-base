namespace InventarioVisao
{
    partial class frmVisualizarAlterarMov
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvVisualizarMov = new System.Windows.Forms.DataGridView();
            this.movCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movESTOQUECOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movPRODUTOCOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movDETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movOPERACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movQUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movQPRODTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movQTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabCProduto = new System.Windows.Forms.TabControl();
            this.tabPagMov = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbQtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQProdTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbDetalhes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txbOp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txbQ = new System.Windows.Forms.TextBox();
            this.tabPagEstoq = new System.Windows.Forms.TabPage();
            this.dgvVisualizarMovComp = new System.Windows.Forms.DataGridView();
            this.estoque_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_LOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnSalvarNovo = new System.Windows.Forms.Button();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.btnConsultarNovo = new System.Windows.Forms.Button();
            this.btnInvalidar = new System.Windows.Forms.Button();
            this.txbCodEstoq = new System.Windows.Forms.ComboBox();
            this.txbCodProd = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMov)).BeginInit();
            this.tabCProduto.SuspendLayout();
            this.tabPagMov.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPagEstoq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMovComp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvVisualizarMov);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 424);
            this.groupBox4.TabIndex = 80;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Movimentações do Produto";
            // 
            // dgvVisualizarMov
            // 
            this.dgvVisualizarMov.AllowUserToAddRows = false;
            this.dgvVisualizarMov.AllowUserToDeleteRows = false;
            this.dgvVisualizarMov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizarMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movCODIGO,
            this.movESTOQUECOD,
            this.movPRODUTOCOD,
            this.movDETALHES,
            this.movOPERACAO,
            this.movQUANTIDADE,
            this.movQPRODTOTAL,
            this.movQTOTAL,
            this.movDATA});
            this.dgvVisualizarMov.Location = new System.Drawing.Point(15, 23);
            this.dgvVisualizarMov.Name = "dgvVisualizarMov";
            this.dgvVisualizarMov.ReadOnly = true;
            this.dgvVisualizarMov.RowHeadersVisible = false;
            this.dgvVisualizarMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarMov.Size = new System.Drawing.Size(314, 388);
            this.dgvVisualizarMov.TabIndex = 40;
            this.dgvVisualizarMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarMov_CellContentClick);
            // 
            // movCODIGO
            // 
            this.movCODIGO.HeaderText = "CÓDIGO";
            this.movCODIGO.Name = "movCODIGO";
            this.movCODIGO.ReadOnly = true;
            // 
            // movESTOQUECOD
            // 
            this.movESTOQUECOD.HeaderText = "ESTOQUE";
            this.movESTOQUECOD.Name = "movESTOQUECOD";
            this.movESTOQUECOD.ReadOnly = true;
            // 
            // movPRODUTOCOD
            // 
            this.movPRODUTOCOD.HeaderText = "PRODUTO";
            this.movPRODUTOCOD.Name = "movPRODUTOCOD";
            this.movPRODUTOCOD.ReadOnly = true;
            // 
            // movDETALHES
            // 
            this.movDETALHES.HeaderText = "DETALHES";
            this.movDETALHES.Name = "movDETALHES";
            this.movDETALHES.ReadOnly = true;
            this.movDETALHES.Visible = false;
            // 
            // movOPERACAO
            // 
            this.movOPERACAO.HeaderText = "OPERAÇÃO";
            this.movOPERACAO.Name = "movOPERACAO";
            this.movOPERACAO.ReadOnly = true;
            // 
            // movQUANTIDADE
            // 
            this.movQUANTIDADE.HeaderText = "Q. MOVIMENTADA";
            this.movQUANTIDADE.Name = "movQUANTIDADE";
            this.movQUANTIDADE.ReadOnly = true;
            // 
            // movQPRODTOTAL
            // 
            this.movQPRODTOTAL.HeaderText = "TOTAL DO PRODUTO";
            this.movQPRODTOTAL.Name = "movQPRODTOTAL";
            this.movQPRODTOTAL.ReadOnly = true;
            this.movQPRODTOTAL.Visible = false;
            // 
            // movQTOTAL
            // 
            this.movQTOTAL.HeaderText = "TOTAL NO ESTOQUE";
            this.movQTOTAL.Name = "movQTOTAL";
            this.movQTOTAL.ReadOnly = true;
            this.movQTOTAL.Visible = false;
            // 
            // movDATA
            // 
            this.movDATA.HeaderText = "DATA";
            this.movDATA.Name = "movDATA";
            this.movDATA.ReadOnly = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(364, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(290, 34);
            this.label26.TabIndex = 79;
            this.label26.Text = "Editar Movimentação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(825, 454);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 34);
            this.btnVoltar.TabIndex = 77;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // tabCProduto
            // 
            this.tabCProduto.Controls.Add(this.tabPagMov);
            this.tabCProduto.Controls.Add(this.tabPagEstoq);
            this.tabCProduto.Location = new System.Drawing.Point(371, 63);
            this.tabCProduto.Name = "tabCProduto";
            this.tabCProduto.SelectedIndex = 0;
            this.tabCProduto.Size = new System.Drawing.Size(561, 382);
            this.tabCProduto.TabIndex = 82;
            // 
            // tabPagMov
            // 
            this.tabPagMov.Controls.Add(this.groupBox3);
            this.tabPagMov.Location = new System.Drawing.Point(4, 22);
            this.tabPagMov.Name = "tabPagMov";
            this.tabPagMov.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagMov.Size = new System.Drawing.Size(553, 356);
            this.tabPagMov.TabIndex = 0;
            this.tabPagMov.Text = "Dados de Movimentação";
            this.tabPagMov.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbCodProd);
            this.groupBox3.Controls.Add(this.txbCodEstoq);
            this.groupBox3.Controls.Add(this.txbData);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbQtotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbQProdTotal);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txbDetalhes);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txbCodigo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txbOp);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txbQ);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 341);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimentação";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(280, 186);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(247, 24);
            this.txbData.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Itens no Estoque:";
            // 
            // txbQtotal
            // 
            this.txbQtotal.Location = new System.Drawing.Point(280, 140);
            this.txbQtotal.Name = "txbQtotal";
            this.txbQtotal.Size = new System.Drawing.Size(247, 24);
            this.txbQtotal.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Código de Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código de Estoque:";
            // 
            // txbQProdTotal
            // 
            this.txbQProdTotal.Location = new System.Drawing.Point(280, 94);
            this.txbQProdTotal.Name = "txbQProdTotal";
            this.txbQProdTotal.Size = new System.Drawing.Size(247, 24);
            this.txbQProdTotal.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(277, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 16);
            this.label20.TabIndex = 25;
            this.label20.Text = "Total do Produto no Estoque:";
            // 
            // txbDetalhes
            // 
            this.txbDetalhes.Location = new System.Drawing.Point(17, 243);
            this.txbDetalhes.Multiline = true;
            this.txbDetalhes.Name = "txbDetalhes";
            this.txbDetalhes.Size = new System.Drawing.Size(510, 87);
            this.txbDetalhes.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 224);
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
            this.txbCodigo.Size = new System.Drawing.Size(247, 24);
            this.txbCodigo.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 16);
            this.label22.TabIndex = 24;
            this.label22.Text = "Quantidade Movimentada:";
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
            // txbOp
            // 
            this.txbOp.Location = new System.Drawing.Point(17, 140);
            this.txbOp.Name = "txbOp";
            this.txbOp.Size = new System.Drawing.Size(247, 24);
            this.txbOp.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 16);
            this.label25.TabIndex = 8;
            this.label25.Text = "Operação:";
            // 
            // txbQ
            // 
            this.txbQ.Location = new System.Drawing.Point(17, 186);
            this.txbQ.Name = "txbQ";
            this.txbQ.Size = new System.Drawing.Size(247, 24);
            this.txbQ.TabIndex = 3;
            // 
            // tabPagEstoq
            // 
            this.tabPagEstoq.Controls.Add(this.dgvVisualizarMovComp);
            this.tabPagEstoq.Location = new System.Drawing.Point(4, 22);
            this.tabPagEstoq.Name = "tabPagEstoq";
            this.tabPagEstoq.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstoq.Size = new System.Drawing.Size(553, 356);
            this.tabPagEstoq.TabIndex = 1;
            this.tabPagEstoq.Text = "Movimentações no Estoque";
            this.tabPagEstoq.UseVisualStyleBackColor = true;
            // 
            // dgvVisualizarMovComp
            // 
            this.dgvVisualizarMovComp.AllowUserToAddRows = false;
            this.dgvVisualizarMovComp.AllowUserToDeleteRows = false;
            this.dgvVisualizarMovComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarMovComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estoque_CODIGO,
            this.estoque_LOCAL,
            this.estoque_DETALHES,
            this.estoque_QUANTIDADE,
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
            this.mov_DATA});
            this.dgvVisualizarMovComp.Location = new System.Drawing.Point(17, 19);
            this.dgvVisualizarMovComp.Name = "dgvVisualizarMovComp";
            this.dgvVisualizarMovComp.ReadOnly = true;
            this.dgvVisualizarMovComp.RowHeadersVisible = false;
            this.dgvVisualizarMovComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarMovComp.Size = new System.Drawing.Size(519, 320);
            this.dgvVisualizarMovComp.TabIndex = 42;
            this.dgvVisualizarMovComp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarMovComp_CellContentClick);
            // 
            // estoque_CODIGO
            // 
            this.estoque_CODIGO.HeaderText = "CÓDIGO";
            this.estoque_CODIGO.Name = "estoque_CODIGO";
            this.estoque_CODIGO.ReadOnly = true;
            // 
            // estoque_LOCAL
            // 
            this.estoque_LOCAL.HeaderText = "LOCAL";
            this.estoque_LOCAL.Name = "estoque_LOCAL";
            this.estoque_LOCAL.ReadOnly = true;
            // 
            // estoque_DETALHES
            // 
            this.estoque_DETALHES.HeaderText = "DETALHES";
            this.estoque_DETALHES.Name = "estoque_DETALHES";
            this.estoque_DETALHES.ReadOnly = true;
            // 
            // estoque_QUANTIDADE
            // 
            this.estoque_QUANTIDADE.HeaderText = "TOTAL NO ESTOQUE";
            this.estoque_QUANTIDADE.Name = "estoque_QUANTIDADE";
            this.estoque_QUANTIDADE.ReadOnly = true;
            // 
            // produto_CODIGO
            // 
            this.produto_CODIGO.HeaderText = "produto_CODIGO";
            this.produto_CODIGO.Name = "produto_CODIGO";
            this.produto_CODIGO.ReadOnly = true;
            this.produto_CODIGO.Visible = false;
            // 
            // produto_PRODUTO
            // 
            this.produto_PRODUTO.HeaderText = "PRODUTO NOME";
            this.produto_PRODUTO.Name = "produto_PRODUTO";
            this.produto_PRODUTO.ReadOnly = true;
            // 
            // produto_DIMENSOES
            // 
            this.produto_DIMENSOES.HeaderText = "produto_DIMENSÕES";
            this.produto_DIMENSOES.Name = "produto_DIMENSOES";
            this.produto_DIMENSOES.ReadOnly = true;
            this.produto_DIMENSOES.Visible = false;
            // 
            // produto_DETALHES
            // 
            this.produto_DETALHES.HeaderText = "produto_DETALHES";
            this.produto_DETALHES.Name = "produto_DETALHES";
            this.produto_DETALHES.ReadOnly = true;
            this.produto_DETALHES.Visible = false;
            // 
            // produto_QUANTIDADE
            // 
            this.produto_QUANTIDADE.HeaderText = "PRODUTO NO ESTOQUE";
            this.produto_QUANTIDADE.Name = "produto_QUANTIDADE";
            this.produto_QUANTIDADE.ReadOnly = true;
            this.produto_QUANTIDADE.Visible = false;
            // 
            // produto_VALOR
            // 
            this.produto_VALOR.HeaderText = "PRODUTO VALOR";
            this.produto_VALOR.Name = "produto_VALOR";
            this.produto_VALOR.ReadOnly = true;
            // 
            // produto_VALORTOTAL
            // 
            this.produto_VALORTOTAL.HeaderText = "PRODUTO VALOR TOTAL";
            this.produto_VALORTOTAL.Name = "produto_VALORTOTAL";
            this.produto_VALORTOTAL.ReadOnly = true;
            this.produto_VALORTOTAL.Visible = false;
            // 
            // produto_SERIE
            // 
            this.produto_SERIE.HeaderText = "produto_SERIE";
            this.produto_SERIE.Name = "produto_SERIE";
            this.produto_SERIE.ReadOnly = true;
            this.produto_SERIE.Visible = false;
            // 
            // produto_NOTAFISCAL
            // 
            this.produto_NOTAFISCAL.HeaderText = "produto_NOTAFISCAL";
            this.produto_NOTAFISCAL.Name = "produto_NOTAFISCAL";
            this.produto_NOTAFISCAL.ReadOnly = true;
            this.produto_NOTAFISCAL.Visible = false;
            // 
            // produto_SEQ
            // 
            this.produto_SEQ.HeaderText = "produto_SEQ";
            this.produto_SEQ.Name = "produto_SEQ";
            this.produto_SEQ.ReadOnly = true;
            this.produto_SEQ.Visible = false;
            // 
            // produto_FORNECEDOR
            // 
            this.produto_FORNECEDOR.HeaderText = "PRODUTO FORNECEDOR";
            this.produto_FORNECEDOR.Name = "produto_FORNECEDOR";
            this.produto_FORNECEDOR.ReadOnly = true;
            // 
            // produto_COMPLEMENTO
            // 
            this.produto_COMPLEMENTO.HeaderText = "produto_COMPLEMENTO";
            this.produto_COMPLEMENTO.Name = "produto_COMPLEMENTO";
            this.produto_COMPLEMENTO.ReadOnly = true;
            this.produto_COMPLEMENTO.Visible = false;
            // 
            // produto_STATUS
            // 
            this.produto_STATUS.HeaderText = "PRODUTO STATUS";
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
            // btnSalvarNovo
            // 
            this.btnSalvarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovo.Location = new System.Drawing.Point(495, 454);
            this.btnSalvarNovo.Name = "btnSalvarNovo";
            this.btnSalvarNovo.Size = new System.Drawing.Size(104, 34);
            this.btnSalvarNovo.TabIndex = 74;
            this.btnSalvarNovo.Text = "Salvar";
            this.btnSalvarNovo.UseVisualStyleBackColor = true;
            this.btnSalvarNovo.Click += new System.EventHandler(this.btnSalvarNovo_Click);
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTela.Location = new System.Drawing.Point(28, 454);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(104, 34);
            this.btnLimparTela.TabIndex = 76;
            this.btnLimparTela.Text = "Limpar";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnConsultarNovo
            // 
            this.btnConsultarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNovo.Location = new System.Drawing.Point(605, 454);
            this.btnConsultarNovo.Name = "btnConsultarNovo";
            this.btnConsultarNovo.Size = new System.Drawing.Size(104, 34);
            this.btnConsultarNovo.TabIndex = 75;
            this.btnConsultarNovo.Text = "Consultar";
            this.btnConsultarNovo.UseVisualStyleBackColor = true;
            this.btnConsultarNovo.Click += new System.EventHandler(this.btnConsultarNovo_Click);
            // 
            // btnInvalidar
            // 
            this.btnInvalidar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvalidar.Location = new System.Drawing.Point(715, 454);
            this.btnInvalidar.Name = "btnInvalidar";
            this.btnInvalidar.Size = new System.Drawing.Size(104, 34);
            this.btnInvalidar.TabIndex = 81;
            this.btnInvalidar.Text = "Invalidar";
            this.btnInvalidar.UseVisualStyleBackColor = true;
            this.btnInvalidar.Click += new System.EventHandler(this.btnInvalidar_Click);
            // 
            // txbCodEstoq
            // 
            this.txbCodEstoq.FormattingEnabled = true;
            this.txbCodEstoq.Location = new System.Drawing.Point(280, 48);
            this.txbCodEstoq.Name = "txbCodEstoq";
            this.txbCodEstoq.Size = new System.Drawing.Size(247, 23);
            this.txbCodEstoq.TabIndex = 64;
            // 
            // txbCodProd
            // 
            this.txbCodProd.FormattingEnabled = true;
            this.txbCodProd.Location = new System.Drawing.Point(17, 94);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(247, 23);
            this.txbCodProd.TabIndex = 65;
            // 
            // frmVisualizarAlterarMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 502);
            this.Controls.Add(this.tabCProduto);
            this.Controls.Add(this.btnInvalidar);
            this.Controls.Add(this.btnConsultarNovo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.btnSalvarNovo);
            this.Name = "frmVisualizarAlterarMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMov)).EndInit();
            this.tabCProduto.ResumeLayout(false);
            this.tabPagMov.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPagEstoq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarMovComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvVisualizarMov;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabCProduto;
        private System.Windows.Forms.TabPage tabPagMov;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQProdTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbDetalhes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbOp;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txbQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarNovo;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnConsultarNovo;
        private System.Windows.Forms.Button btnInvalidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbQtotal;
        private System.Windows.Forms.DateTimePicker txbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPagEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn movCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn movESTOQUECOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn movPRODUTOCOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn movDETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn movOPERACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn movQUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn movQPRODTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn movQTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn movDATA;
        private System.Windows.Forms.DataGridView dgvVisualizarMovComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_LOCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_QUANTIDADE;
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
        private System.Windows.Forms.ComboBox txbCodEstoq;
        private System.Windows.Forms.ComboBox txbCodProd;
    }
}