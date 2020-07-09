namespace InventarioVisao
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.ckbHeader = new System.Windows.Forms.CheckBox();
            this.btnProdutoAudit = new System.Windows.Forms.Button();
            this.ckbRelatorioStatus = new System.Windows.Forms.CheckBox();
            this.btnProdutoVal = new System.Windows.Forms.Button();
            this.btnProdutoInv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCodAudit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEstoqueAudit = new System.Windows.Forms.Button();
            this.dateTAudit = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.BtnMovLocal = new System.Windows.Forms.Button();
            this.BtnProdutoLocal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CbOperacao = new System.Windows.Forms.ComboBox();
            this.BtnEstoqueOp = new System.Windows.Forms.Button();
            this.BtnProdutoOp = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEstoqueRel = new System.Windows.Forms.Button();
            this.btnMovRel = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.picBNimal = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcbCodRelComp = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMovCompRel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBNimal)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbHeader
            // 
            this.ckbHeader.AutoSize = true;
            this.ckbHeader.Location = new System.Drawing.Point(19, 55);
            this.ckbHeader.Name = "ckbHeader";
            this.ckbHeader.Size = new System.Drawing.Size(115, 20);
            this.ckbHeader.TabIndex = 1;
            this.ckbHeader.Text = "Sem Cabeçalho";
            this.ckbHeader.UseVisualStyleBackColor = true;
            this.ckbHeader.CheckedChanged += new System.EventHandler(this.ckbHeader_CheckedChanged);
            // 
            // btnProdutoAudit
            // 
            this.btnProdutoAudit.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoAudit.Location = new System.Drawing.Point(18, 122);
            this.btnProdutoAudit.Name = "btnProdutoAudit";
            this.btnProdutoAudit.Size = new System.Drawing.Size(131, 39);
            this.btnProdutoAudit.TabIndex = 17;
            this.btnProdutoAudit.Text = "Produto";
            this.btnProdutoAudit.UseVisualStyleBackColor = true;
            this.btnProdutoAudit.Click += new System.EventHandler(this.btnProdutoAudit_Click);
            // 
            // ckbRelatorioStatus
            // 
            this.ckbRelatorioStatus.AutoSize = true;
            this.ckbRelatorioStatus.Location = new System.Drawing.Point(19, 29);
            this.ckbRelatorioStatus.Name = "ckbRelatorioStatus";
            this.ckbRelatorioStatus.Size = new System.Drawing.Size(99, 20);
            this.ckbRelatorioStatus.TabIndex = 1;
            this.ckbRelatorioStatus.Text = "Sem STATUS";
            this.ckbRelatorioStatus.UseVisualStyleBackColor = true;
            this.ckbRelatorioStatus.CheckedChanged += new System.EventHandler(this.ckbRelatorioStatus_CheckedChanged);
            // 
            // btnProdutoVal
            // 
            this.btnProdutoVal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoVal.Location = new System.Drawing.Point(12, 25);
            this.btnProdutoVal.Name = "btnProdutoVal";
            this.btnProdutoVal.Size = new System.Drawing.Size(177, 39);
            this.btnProdutoVal.TabIndex = 4;
            this.btnProdutoVal.Text = "Válidos";
            this.btnProdutoVal.UseVisualStyleBackColor = true;
            this.btnProdutoVal.Click += new System.EventHandler(this.btnProdutoVal_Click);
            // 
            // btnProdutoInv
            // 
            this.btnProdutoInv.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoInv.Location = new System.Drawing.Point(12, 71);
            this.btnProdutoInv.Name = "btnProdutoInv";
            this.btnProdutoInv.Size = new System.Drawing.Size(177, 39);
            this.btnProdutoInv.TabIndex = 2;
            this.btnProdutoInv.Text = "Inválidos";
            this.btnProdutoInv.UseVisualStyleBackColor = true;
            this.btnProdutoInv.Click += new System.EventHandler(this.btnProdutoInv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnProdutoInv);
            this.groupBox2.Controls.Add(this.btnProdutoVal);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 169);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Novo Relatório";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbCodAudit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnEstoqueAudit);
            this.groupBox3.Controls.Add(this.btnProdutoAudit);
            this.groupBox3.Controls.Add(this.dateTAudit);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(553, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 180);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auditoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Código:";
            // 
            // txbCodAudit
            // 
            this.txbCodAudit.Location = new System.Drawing.Point(18, 90);
            this.txbCodAudit.Name = "txbCodAudit";
            this.txbCodAudit.Size = new System.Drawing.Size(267, 26);
            this.txbCodAudit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "A partir de:";
            // 
            // btnEstoqueAudit
            // 
            this.btnEstoqueAudit.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueAudit.Location = new System.Drawing.Point(155, 122);
            this.btnEstoqueAudit.Name = "btnEstoqueAudit";
            this.btnEstoqueAudit.Size = new System.Drawing.Size(130, 39);
            this.btnEstoqueAudit.TabIndex = 18;
            this.btnEstoqueAudit.Text = "Estoque";
            this.btnEstoqueAudit.UseVisualStyleBackColor = true;
            this.btnEstoqueAudit.Click += new System.EventHandler(this.BtnEstoqueAudit_Click);
            // 
            // dateTAudit
            // 
            this.dateTAudit.Location = new System.Drawing.Point(18, 42);
            this.dateTAudit.MaxDate = new System.DateTime(2017, 3, 31, 16, 11, 21, 0);
            this.dateTAudit.Name = "dateTAudit";
            this.dateTAudit.Size = new System.Drawing.Size(267, 26);
            this.dateTAudit.TabIndex = 15;
            this.dateTAudit.Value = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.cbLocal);
            this.groupBox5.Controls.Add(this.BtnMovLocal);
            this.groupBox5.Controls.Add(this.BtnProdutoLocal);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(234, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 109);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Local";
            // 
            // cbLocal
            // 
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(18, 26);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(268, 24);
            this.cbLocal.TabIndex = 6;
            // 
            // BtnMovLocal
            // 
            this.BtnMovLocal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovLocal.Location = new System.Drawing.Point(155, 55);
            this.BtnMovLocal.Name = "BtnMovLocal";
            this.BtnMovLocal.Size = new System.Drawing.Size(131, 39);
            this.BtnMovLocal.TabIndex = 8;
            this.BtnMovLocal.Text = "Movimentação";
            this.BtnMovLocal.UseVisualStyleBackColor = true;
            this.BtnMovLocal.Click += new System.EventHandler(this.BtnMovLocal_Click);
            // 
            // BtnProdutoLocal
            // 
            this.BtnProdutoLocal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutoLocal.Location = new System.Drawing.Point(18, 55);
            this.BtnProdutoLocal.Name = "BtnProdutoLocal";
            this.BtnProdutoLocal.Size = new System.Drawing.Size(131, 39);
            this.BtnProdutoLocal.TabIndex = 7;
            this.BtnProdutoLocal.Text = "Produto";
            this.BtnProdutoLocal.UseVisualStyleBackColor = true;
            this.BtnProdutoLocal.Click += new System.EventHandler(this.BtnProdutoLocal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.ckbRelatorioStatus);
            this.groupBox4.Controls.Add(this.ckbHeader);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 146);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(19, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Opção 4";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(19, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Opção 3";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.CbOperacao);
            this.groupBox6.Controls.Add(this.BtnEstoqueOp);
            this.groupBox6.Controls.Add(this.BtnProdutoOp);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(234, 335);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 109);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operação";
            // 
            // CbOperacao
            // 
            this.CbOperacao.FormattingEnabled = true;
            this.CbOperacao.Items.AddRange(new object[] {
            "ENTRADA DE FORNECEDOR",
            "VENDA DE MERCADORIAS",
            "DEMONSTRACAO",
            "SERVICO"});
            this.CbOperacao.Location = new System.Drawing.Point(18, 25);
            this.CbOperacao.Name = "CbOperacao";
            this.CbOperacao.Size = new System.Drawing.Size(268, 24);
            this.CbOperacao.TabIndex = 12;
            // 
            // BtnEstoqueOp
            // 
            this.BtnEstoqueOp.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstoqueOp.Location = new System.Drawing.Point(155, 55);
            this.BtnEstoqueOp.Name = "BtnEstoqueOp";
            this.BtnEstoqueOp.Size = new System.Drawing.Size(131, 39);
            this.BtnEstoqueOp.TabIndex = 14;
            this.BtnEstoqueOp.Text = "Estoque";
            this.BtnEstoqueOp.UseVisualStyleBackColor = true;
            this.BtnEstoqueOp.Click += new System.EventHandler(this.BtnEstoqueOp_Click);
            // 
            // BtnProdutoOp
            // 
            this.BtnProdutoOp.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutoOp.Location = new System.Drawing.Point(18, 55);
            this.BtnProdutoOp.Name = "BtnProdutoOp";
            this.BtnProdutoOp.Size = new System.Drawing.Size(131, 39);
            this.BtnProdutoOp.TabIndex = 13;
            this.BtnProdutoOp.Text = "Produto";
            this.BtnProdutoOp.UseVisualStyleBackColor = true;
            this.BtnProdutoOp.Click += new System.EventHandler(this.BtnProdutoOp_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(772, 620);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 35);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnEstoqueRel
            // 
            this.btnEstoqueRel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueRel.Location = new System.Drawing.Point(12, 25);
            this.btnEstoqueRel.Name = "btnEstoqueRel";
            this.btnEstoqueRel.Size = new System.Drawing.Size(177, 39);
            this.btnEstoqueRel.TabIndex = 2;
            this.btnEstoqueRel.Text = "Estoques";
            this.btnEstoqueRel.UseVisualStyleBackColor = true;
            this.btnEstoqueRel.Click += new System.EventHandler(this.btnEstoqueRel_Click);
            // 
            // btnMovRel
            // 
            this.btnMovRel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovRel.Location = new System.Drawing.Point(12, 70);
            this.btnMovRel.Name = "btnMovRel";
            this.btnMovRel.Size = new System.Drawing.Size(177, 39);
            this.btnMovRel.TabIndex = 2;
            this.btnMovRel.Text = "Movimentação";
            this.btnMovRel.UseVisualStyleBackColor = true;
            this.btnMovRel.Click += new System.EventHandler(this.btnMovRel_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.picBNimal);
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.groupBox4);
            this.groupBox9.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(874, 602);
            this.groupBox9.TabIndex = 53;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gerador de Relatórios";
            // 
            // picBNimal
            // 
            this.picBNimal.BackColor = System.Drawing.Color.Transparent;
            this.picBNimal.Image = ((System.Drawing.Image)(resources.GetObject("picBNimal.Image")));
            this.picBNimal.Location = new System.Drawing.Point(553, 31);
            this.picBNimal.Name = "picBNimal";
            this.picBNimal.Size = new System.Drawing.Size(304, 183);
            this.picBNimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBNimal.TabIndex = 57;
            this.picBNimal.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.tcbCodRelComp);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.btnMovCompRel);
            this.groupBox7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(234, 459);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 126);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Relatório Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Código:";
            // 
            // tcbCodRelComp
            // 
            this.tcbCodRelComp.Location = new System.Drawing.Point(18, 40);
            this.tcbCodRelComp.Name = "tcbCodRelComp";
            this.tcbCodRelComp.Size = new System.Drawing.Size(268, 26);
            this.tcbCodRelComp.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "Produto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMovCompRel
            // 
            this.btnMovCompRel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovCompRel.Location = new System.Drawing.Point(155, 72);
            this.btnMovCompRel.Name = "btnMovCompRel";
            this.btnMovCompRel.Size = new System.Drawing.Size(131, 39);
            this.btnMovCompRel.TabIndex = 23;
            this.btnMovCompRel.Text = "Movimentação";
            this.btnMovCompRel.UseVisualStyleBackColor = true;
            this.btnMovCompRel.Click += new System.EventHandler(this.btnMovCompRel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnEstoqueRel);
            this.groupBox1.Controls.Add(this.btnMovRel);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outros";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 39);
            this.button5.TabIndex = 24;
            this.button5.Text = "Novo Relatório";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 663);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBNimal)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbHeader;
        private System.Windows.Forms.Button btnProdutoAudit;
        private System.Windows.Forms.CheckBox ckbRelatorioStatus;
        private System.Windows.Forms.Button btnProdutoInv;
        private System.Windows.Forms.Button btnProdutoVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTAudit;
        private System.Windows.Forms.Button btnEstoqueAudit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnMovLocal;
        private System.Windows.Forms.Button BtnProdutoLocal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnEstoqueOp;
        private System.Windows.Forms.Button BtnProdutoOp;
        private System.Windows.Forms.ComboBox CbOperacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCodAudit;
        private System.Windows.Forms.Button btnEstoqueRel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMovRel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMovCompRel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcbCodRelComp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox picBNimal;
    }
}