namespace InventarioVisao
{
    partial class frmCadastrarMov
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntreEstoq = new System.Windows.Forms.Button();
            this.txbOp = new System.Windows.Forms.ComboBox();
            this.txbCodEstoq = new System.Windows.Forms.ComboBox();
            this.txbNomeEstoq = new System.Windows.Forms.ComboBox();
            this.txbCodProd = new System.Windows.Forms.ComboBox();
            this.txbNomeProd = new System.Windows.Forms.ComboBox();
            this.txbData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbQtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQProdEstoq = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbDetalhes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txbQ = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvarNovo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(330, 481);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 34);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimparProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntreEstoq);
            this.groupBox1.Controls.Add(this.txbOp);
            this.groupBox1.Controls.Add(this.txbCodEstoq);
            this.groupBox1.Controls.Add(this.txbNomeEstoq);
            this.groupBox1.Controls.Add(this.txbCodProd);
            this.groupBox1.Controls.Add(this.txbNomeProd);
            this.groupBox1.Controls.Add(this.txbData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbQtotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbQProdEstoq);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txbDetalhes);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txbCodigo);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txbQ);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 386);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEntreEstoq
            // 
            this.btnEntreEstoq.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntreEstoq.Location = new System.Drawing.Point(423, 333);
            this.btnEntreEstoq.Name = "btnEntreEstoq";
            this.btnEntreEstoq.Size = new System.Drawing.Size(103, 28);
            this.btnEntreEstoq.TabIndex = 32;
            this.btnEntreEstoq.Text = "Entre Estoques";
            this.btnEntreEstoq.UseVisualStyleBackColor = true;
            this.btnEntreEstoq.Click += new System.EventHandler(this.btnEntreEstoq_Click);
            // 
            // txbOp
            // 
            this.txbOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbOp.FormattingEnabled = true;
            this.txbOp.Items.AddRange(new object[] {
            "ENTRADA DE FORNECEDOR",
            "VENDA DE MERCADORIAS",
            "DEMONSTRACAO",
            "SERVICO"});
            this.txbOp.Location = new System.Drawing.Point(279, 47);
            this.txbOp.Name = "txbOp";
            this.txbOp.Size = new System.Drawing.Size(248, 24);
            this.txbOp.TabIndex = 68;
            this.txbOp.SelectedIndexChanged += new System.EventHandler(this.txbOp_SelectedIndexChanged);
            // 
            // txbCodEstoq
            // 
            this.txbCodEstoq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbCodEstoq.FormattingEnabled = true;
            this.txbCodEstoq.Location = new System.Drawing.Point(147, 84);
            this.txbCodEstoq.Name = "txbCodEstoq";
            this.txbCodEstoq.Size = new System.Drawing.Size(114, 24);
            this.txbCodEstoq.TabIndex = 67;
            this.txbCodEstoq.SelectionChangeCommitted += new System.EventHandler(this.txbCodEstoq_SelectedIndexChanged);
            this.txbCodEstoq.Leave += new System.EventHandler(this.txbCodEstoq_SelectedIndexChanged);
            // 
            // txbNomeEstoq
            // 
            this.txbNomeEstoq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbNomeEstoq.FormattingEnabled = true;
            this.txbNomeEstoq.Location = new System.Drawing.Point(14, 114);
            this.txbNomeEstoq.Name = "txbNomeEstoq";
            this.txbNomeEstoq.Size = new System.Drawing.Size(247, 24);
            this.txbNomeEstoq.TabIndex = 66;
            this.txbNomeEstoq.SelectionChangeCommitted += new System.EventHandler(this.txbNomeEstoq_SelectedIndexChanged);
            this.txbNomeEstoq.Leave += new System.EventHandler(this.txbNomeEstoq_SelectedIndexChanged);
            // 
            // txbCodProd
            // 
            this.txbCodProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbCodProd.FormattingEnabled = true;
            this.txbCodProd.Location = new System.Drawing.Point(413, 84);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(114, 24);
            this.txbCodProd.TabIndex = 65;
            this.txbCodProd.SelectionChangeCommitted += new System.EventHandler(this.txbCodProd_SelectedIndexChanged);
            this.txbCodProd.Leave += new System.EventHandler(this.txbCodProd_SelectedIndexChanged);
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbNomeProd.FormattingEnabled = true;
            this.txbNomeProd.Location = new System.Drawing.Point(279, 114);
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(248, 24);
            this.txbNomeProd.TabIndex = 64;
            this.txbNomeProd.SelectionChangeCommitted += new System.EventHandler(this.txbNomeProd_SelectedIndexChanged);
            this.txbNomeProd.Leave += new System.EventHandler(this.txbNomeProd_SelectedIndexChanged);
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(279, 241);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(248, 22);
            this.txbData.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Total de Itens no Estoque:";
            // 
            // txbQtotal
            // 
            this.txbQtotal.Location = new System.Drawing.Point(16, 177);
            this.txbQtotal.Name = "txbQtotal";
            this.txbQtotal.ReadOnly = true;
            this.txbQtotal.Size = new System.Drawing.Size(247, 22);
            this.txbQtotal.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Código de Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Código de Estoque:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbQProdEstoq
            // 
            this.txbQProdEstoq.Location = new System.Drawing.Point(279, 177);
            this.txbQProdEstoq.Name = "txbQProdEstoq";
            this.txbQProdEstoq.ReadOnly = true;
            this.txbQProdEstoq.Size = new System.Drawing.Size(247, 22);
            this.txbQProdEstoq.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(276, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 16);
            this.label20.TabIndex = 54;
            this.label20.Text = "Total do Produto no Estoque:";
            // 
            // txbDetalhes
            // 
            this.txbDetalhes.Location = new System.Drawing.Point(16, 229);
            this.txbDetalhes.Multiline = true;
            this.txbDetalhes.Name = "txbDetalhes";
            this.txbDetalhes.Size = new System.Drawing.Size(248, 132);
            this.txbDetalhes.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 52;
            this.label21.Text = "Detalhes:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(279, 294);
            this.txbCodigo.MaxLength = 6;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.ReadOnly = true;
            this.txbCodigo.Size = new System.Drawing.Size(247, 22);
            this.txbCodigo.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 16);
            this.label22.TabIndex = 53;
            this.label22.Text = "Quantidade Movimentada:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(275, 275);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 16);
            this.label23.TabIndex = 50;
            this.label23.Text = "Código:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(275, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 16);
            this.label25.TabIndex = 51;
            this.label25.Text = "Operação:";
            // 
            // txbQ
            // 
            this.txbQ.Location = new System.Drawing.Point(14, 49);
            this.txbQ.Name = "txbQ";
            this.txbQ.Size = new System.Drawing.Size(248, 22);
            this.txbQ.TabIndex = 47;
            this.txbQ.Leave += new System.EventHandler(this.txbQ_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(217, 481);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 34);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnSalvarNovo
            // 
            this.btnSalvarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovo.Location = new System.Drawing.Point(441, 481);
            this.btnSalvarNovo.Name = "btnSalvarNovo";
            this.btnSalvarNovo.Size = new System.Drawing.Size(104, 34);
            this.btnSalvarNovo.TabIndex = 27;
            this.btnSalvarNovo.Text = "Salvar";
            this.btnSalvarNovo.UseVisualStyleBackColor = true;
            this.btnSalvarNovo.Click += new System.EventHandler(this.btnSalvarNovo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 34);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cadastrar Movimentação";
            // 
            // frmCadastrarMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvarNovo);
            this.Controls.Add(this.label10);
            this.Name = "frmCadastrarMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Movimentação";
            this.Load += new System.EventHandler(this.frmCadastrarMov_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvarNovo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbQtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQProdEstoq;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbDetalhes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txbQ;
        private System.Windows.Forms.ComboBox txbNomeProd;
        private System.Windows.Forms.ComboBox txbCodEstoq;
        private System.Windows.Forms.ComboBox txbNomeEstoq;
        private System.Windows.Forms.ComboBox txbCodProd;
        private System.Windows.Forms.ComboBox txbOp;
        private System.Windows.Forms.Button btnEntreEstoq;
    }
}