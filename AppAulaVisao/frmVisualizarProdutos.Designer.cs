namespace InventarioVisao
{
    partial class frmVisualizarProdutos
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
            this.dgvVisualizarProd = new System.Windows.Forms.DataGridView();
            this.dadosCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosDIMENSOES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosDETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosOPERACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosMOVIMENTACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosQUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosVALORTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosNOTAFISCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosFORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosCOMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.tabCProduto = new System.Windows.Forms.TabControl();
            this.tabPagProduto = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbFornecedor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbDetalhes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txbDimensoes = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.tabPagEstoque = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbSeq = new System.Windows.Forms.TextBox();
            this.txbNotaFiscal = new System.Windows.Forms.TextBox();
            this.txbSerie = new System.Windows.Forms.TextBox();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.txbQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbMovimentacao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsultarNovoProduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.btnSalvarNovoProduto = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProd)).BeginInit();
            this.tabCProduto.SuspendLayout();
            this.tabPagProduto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPagEstoque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvVisualizarProd);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 429);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos Arquivados";
            // 
            // dgvVisualizarProd
            // 
            this.dgvVisualizarProd.AllowUserToAddRows = false;
            this.dgvVisualizarProd.AllowUserToDeleteRows = false;
            this.dgvVisualizarProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dadosCODIGO,
            this.dadosPRODUTO,
            this.dadosDIMENSOES,
            this.dadosDETALHES,
            this.dadosOPERACAO,
            this.dadosMOVIMENTACAO,
            this.dadosQUANTIDADE,
            this.dadosVALOR,
            this.dadosVALORTOTAL,
            this.dadosDATA,
            this.dadosSERIE,
            this.dadosNOTAFISCAL,
            this.dadosSEQ,
            this.dadosFORNECEDOR,
            this.dadosCOMPLEMENTO,
            this.dadosSTATUS});
            this.dgvVisualizarProd.Location = new System.Drawing.Point(15, 23);
            this.dgvVisualizarProd.Name = "dgvVisualizarProd";
            this.dgvVisualizarProd.ReadOnly = true;
            this.dgvVisualizarProd.RowHeadersVisible = false;
            this.dgvVisualizarProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarProd.Size = new System.Drawing.Size(314, 393);
            this.dgvVisualizarProd.TabIndex = 40;
            // 
            // dadosCODIGO
            // 
            this.dadosCODIGO.HeaderText = "Código";
            this.dadosCODIGO.Name = "dadosCODIGO";
            this.dadosCODIGO.ReadOnly = true;
            this.dadosCODIGO.Width = 80;
            // 
            // dadosPRODUTO
            // 
            this.dadosPRODUTO.HeaderText = "Nome";
            this.dadosPRODUTO.Name = "dadosPRODUTO";
            this.dadosPRODUTO.ReadOnly = true;
            this.dadosPRODUTO.Width = 145;
            // 
            // dadosDIMENSOES
            // 
            this.dadosDIMENSOES.HeaderText = "Dimensões";
            this.dadosDIMENSOES.Name = "dadosDIMENSOES";
            this.dadosDIMENSOES.ReadOnly = true;
            // 
            // dadosDETALHES
            // 
            this.dadosDETALHES.HeaderText = "Detalhes";
            this.dadosDETALHES.Name = "dadosDETALHES";
            this.dadosDETALHES.ReadOnly = true;
            // 
            // dadosOPERACAO
            // 
            this.dadosOPERACAO.HeaderText = "Operação";
            this.dadosOPERACAO.Name = "dadosOPERACAO";
            this.dadosOPERACAO.ReadOnly = true;
            // 
            // dadosMOVIMENTACAO
            // 
            this.dadosMOVIMENTACAO.HeaderText = "Movimentação";
            this.dadosMOVIMENTACAO.Name = "dadosMOVIMENTACAO";
            this.dadosMOVIMENTACAO.ReadOnly = true;
            // 
            // dadosQUANTIDADE
            // 
            this.dadosQUANTIDADE.HeaderText = "Quantidade";
            this.dadosQUANTIDADE.Name = "dadosQUANTIDADE";
            this.dadosQUANTIDADE.ReadOnly = true;
            // 
            // dadosVALOR
            // 
            this.dadosVALOR.HeaderText = "Valor";
            this.dadosVALOR.Name = "dadosVALOR";
            this.dadosVALOR.ReadOnly = true;
            // 
            // dadosVALORTOTAL
            // 
            this.dadosVALORTOTAL.HeaderText = "Valor Total";
            this.dadosVALORTOTAL.Name = "dadosVALORTOTAL";
            this.dadosVALORTOTAL.ReadOnly = true;
            // 
            // dadosDATA
            // 
            this.dadosDATA.HeaderText = "Data";
            this.dadosDATA.Name = "dadosDATA";
            this.dadosDATA.ReadOnly = true;
            // 
            // dadosSERIE
            // 
            this.dadosSERIE.HeaderText = "Série";
            this.dadosSERIE.Name = "dadosSERIE";
            this.dadosSERIE.ReadOnly = true;
            // 
            // dadosNOTAFISCAL
            // 
            this.dadosNOTAFISCAL.HeaderText = "Nota Fiscal";
            this.dadosNOTAFISCAL.Name = "dadosNOTAFISCAL";
            this.dadosNOTAFISCAL.ReadOnly = true;
            // 
            // dadosSEQ
            // 
            this.dadosSEQ.HeaderText = "Seq";
            this.dadosSEQ.Name = "dadosSEQ";
            this.dadosSEQ.ReadOnly = true;
            // 
            // dadosFORNECEDOR
            // 
            this.dadosFORNECEDOR.HeaderText = "Fornecedor";
            this.dadosFORNECEDOR.Name = "dadosFORNECEDOR";
            this.dadosFORNECEDOR.ReadOnly = true;
            // 
            // dadosCOMPLEMENTO
            // 
            this.dadosCOMPLEMENTO.HeaderText = "Complemento";
            this.dadosCOMPLEMENTO.Name = "dadosCOMPLEMENTO";
            this.dadosCOMPLEMENTO.ReadOnly = true;
            // 
            // dadosSTATUS
            // 
            this.dadosSTATUS.HeaderText = "Status";
            this.dadosSTATUS.Name = "dadosSTATUS";
            this.dadosSTATUS.ReadOnly = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(372, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(271, 34);
            this.label26.TabIndex = 50;
            this.label26.Text = "Visualizar Produtos";
            // 
            // tabCProduto
            // 
            this.tabCProduto.Controls.Add(this.tabPagProduto);
            this.tabCProduto.Controls.Add(this.tabPagEstoque);
            this.tabCProduto.Location = new System.Drawing.Point(378, 59);
            this.tabCProduto.Name = "tabCProduto";
            this.tabCProduto.SelectedIndex = 0;
            this.tabCProduto.Size = new System.Drawing.Size(561, 382);
            this.tabCProduto.TabIndex = 58;
            // 
            // tabPagProduto
            // 
            this.tabPagProduto.Controls.Add(this.groupBox3);
            this.tabPagProduto.Location = new System.Drawing.Point(4, 22);
            this.tabPagProduto.Name = "tabPagProduto";
            this.tabPagProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagProduto.Size = new System.Drawing.Size(553, 356);
            this.tabPagProduto.TabIndex = 0;
            this.tabPagProduto.Text = "Dados de Produto";
            this.tabPagProduto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbStatus);
            this.groupBox3.Controls.Add(this.txbFornecedor);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txbValor);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txbDetalhes);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txbCodigo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txbNome);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txbDimensoes);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txbQuantidade);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 341);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Status:";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(280, 48);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(247, 24);
            this.txbStatus.TabIndex = 36;
            // 
            // txbFornecedor
            // 
            this.txbFornecedor.Location = new System.Drawing.Point(280, 243);
            this.txbFornecedor.Multiline = true;
            this.txbFornecedor.Name = "txbFornecedor";
            this.txbFornecedor.Size = new System.Drawing.Size(247, 87);
            this.txbFornecedor.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(277, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Fornecedor:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(280, 186);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(247, 24);
            this.txbValor.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(277, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 16);
            this.label20.TabIndex = 25;
            this.label20.Text = "Valor:";
            // 
            // txbDetalhes
            // 
            this.txbDetalhes.Location = new System.Drawing.Point(17, 243);
            this.txbDetalhes.Multiline = true;
            this.txbDetalhes.Name = "txbDetalhes";
            this.txbDetalhes.Size = new System.Drawing.Size(247, 87);
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
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(17, 94);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(510, 24);
            this.txbNome.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 16);
            this.label24.TabIndex = 7;
            this.label24.Text = "Nome:";
            // 
            // txbDimensoes
            // 
            this.txbDimensoes.Location = new System.Drawing.Point(17, 140);
            this.txbDimensoes.Name = "txbDimensoes";
            this.txbDimensoes.Size = new System.Drawing.Size(247, 24);
            this.txbDimensoes.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 16);
            this.label25.TabIndex = 8;
            this.label25.Text = "Dimensões:";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(18, 186);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(247, 24);
            this.txbQuantidade.TabIndex = 3;
            // 
            // tabPagEstoque
            // 
            this.tabPagEstoque.Controls.Add(this.groupBox1);
            this.tabPagEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabPagEstoque.Name = "tabPagEstoque";
            this.tabPagEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstoque.Size = new System.Drawing.Size(553, 356);
            this.tabPagEstoque.TabIndex = 1;
            this.tabPagEstoque.Text = "Dados de Estoque";
            this.tabPagEstoque.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOperacao);
            this.groupBox1.Controls.Add(this.txbComplemento);
            this.groupBox1.Controls.Add(this.txbSeq);
            this.groupBox1.Controls.Add(this.txbNotaFiscal);
            this.groupBox1.Controls.Add(this.txbSerie);
            this.groupBox1.Controls.Add(this.txbValorTotal);
            this.groupBox1.Controls.Add(this.txbQuantidadeTotal);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbMovimentacao);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txbData);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 347);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // cbOperacao
            // 
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "NENHUMA",
            "ENTRADA DE FORNECEDOR",
            "VENDA DE MERCADORIAS",
            "DEMONSTRACAO",
            "SERVICO"});
            this.cbOperacao.Location = new System.Drawing.Point(17, 48);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(247, 23);
            this.cbOperacao.TabIndex = 7;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(17, 243);
            this.txbComplemento.Multiline = true;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(509, 87);
            this.txbComplemento.TabIndex = 15;
            // 
            // txbSeq
            // 
            this.txbSeq.Location = new System.Drawing.Point(280, 186);
            this.txbSeq.Name = "txbSeq";
            this.txbSeq.Size = new System.Drawing.Size(247, 24);
            this.txbSeq.TabIndex = 14;
            // 
            // txbNotaFiscal
            // 
            this.txbNotaFiscal.Location = new System.Drawing.Point(17, 186);
            this.txbNotaFiscal.Name = "txbNotaFiscal";
            this.txbNotaFiscal.Size = new System.Drawing.Size(247, 24);
            this.txbNotaFiscal.TabIndex = 13;
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(17, 140);
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(247, 24);
            this.txbSerie.TabIndex = 11;
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Location = new System.Drawing.Point(280, 94);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.ReadOnly = true;
            this.txbValorTotal.Size = new System.Drawing.Size(247, 24);
            this.txbValorTotal.TabIndex = 10;
            // 
            // txbQuantidadeTotal
            // 
            this.txbQuantidadeTotal.Location = new System.Drawing.Point(17, 94);
            this.txbQuantidadeTotal.Name = "txbQuantidadeTotal";
            this.txbQuantidadeTotal.ReadOnly = true;
            this.txbQuantidadeTotal.Size = new System.Drawing.Size(247, 24);
            this.txbQuantidadeTotal.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Complemento:";
            // 
            // txbMovimentacao
            // 
            this.txbMovimentacao.Location = new System.Drawing.Point(280, 48);
            this.txbMovimentacao.Name = "txbMovimentacao";
            this.txbMovimentacao.Size = new System.Drawing.Size(247, 24);
            this.txbMovimentacao.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Quantidade Total:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(277, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Seq:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Nota Fiscal:";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(280, 140);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(247, 24);
            this.txbData.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Série:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(277, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Data:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(277, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Movimentação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Operação:";
            // 
            // btnConsultarNovoProduto
            // 
            this.btnConsultarNovoProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNovoProduto.Location = new System.Drawing.Point(713, 458);
            this.btnConsultarNovoProduto.Name = "btnConsultarNovoProduto";
            this.btnConsultarNovoProduto.Size = new System.Drawing.Size(104, 34);
            this.btnConsultarNovoProduto.TabIndex = 60;
            this.btnConsultarNovoProduto.Text = "Consultar";
            this.btnConsultarNovoProduto.UseVisualStyleBackColor = true;
            this.btnConsultarNovoProduto.Click += new System.EventHandler(this.btnConsultarNovoProduto_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(823, 458);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 34);
            this.btnVoltar.TabIndex = 62;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProduto.Location = new System.Drawing.Point(382, 458);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(104, 34);
            this.btnLimparProduto.TabIndex = 61;
            this.btnLimparProduto.Text = "Limpar";
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            // 
            // btnSalvarNovoProduto
            // 
            this.btnSalvarNovoProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovoProduto.Location = new System.Drawing.Point(603, 458);
            this.btnSalvarNovoProduto.Name = "btnSalvarNovoProduto";
            this.btnSalvarNovoProduto.Size = new System.Drawing.Size(104, 34);
            this.btnSalvarNovoProduto.TabIndex = 59;
            this.btnSalvarNovoProduto.Text = "Salvar";
            this.btnSalvarNovoProduto.UseVisualStyleBackColor = true;
            // 
            // frmVisualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.btnConsultarNovoProduto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimparProduto);
            this.Controls.Add(this.btnSalvarNovoProduto);
            this.Controls.Add(this.tabCProduto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label26);
            this.Name = "frmVisualizarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Produtos";
            this.Load += new System.EventHandler(this.frmVisualizarProdutos_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProd)).EndInit();
            this.tabCProduto.ResumeLayout(false);
            this.tabPagProduto.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPagEstoque.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvVisualizarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosDIMENSOES;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosDETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosOPERACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosMOVIMENTACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosQUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosVALORTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosDATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosSERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosNOTAFISCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosFORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosCOMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosSTATUS;
        private System.Windows.Forms.TabControl tabCProduto;
        private System.Windows.Forms.TabPage tabPagProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbFornecedor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbDetalhes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txbDimensoes;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TabPage tabPagEstoque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbOperacao;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbSeq;
        private System.Windows.Forms.TextBox txbNotaFiscal;
        private System.Windows.Forms.TextBox txbSerie;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.TextBox txbQuantidadeTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbMovimentacao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsultarNovoProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.Button btnSalvarNovoProduto;
    }
}