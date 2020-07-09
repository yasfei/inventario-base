namespace InventarioVisao
{
    partial class frmCadastrarEstoque
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvarNovo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(256, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 34);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbData);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txbDetalhes);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txbCodigo);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txbLocal);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txbQ);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 287);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(244, 139);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(209, 22);
            this.txbData.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(241, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Data:";
            // 
            // txbDetalhes
            // 
            this.txbDetalhes.Location = new System.Drawing.Point(17, 185);
            this.txbDetalhes.Multiline = true;
            this.txbDetalhes.Name = "txbDetalhes";
            this.txbDetalhes.Size = new System.Drawing.Size(436, 87);
            this.txbDetalhes.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 166);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 33;
            this.label21.Text = "Detalhes:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(17, 47);
            this.txbCodigo.MaxLength = 6;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(436, 22);
            this.txbCodigo.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 16);
            this.label22.TabIndex = 34;
            this.label22.Text = "Quantidade:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(14, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 16);
            this.label23.TabIndex = 31;
            this.label23.Text = "Código:";
            // 
            // txbLocal
            // 
            this.txbLocal.Location = new System.Drawing.Point(17, 93);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(436, 22);
            this.txbLocal.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 32;
            this.label24.Text = "Local/Nome:";
            // 
            // txbQ
            // 
            this.txbQ.Location = new System.Drawing.Point(17, 139);
            this.txbQ.Name = "txbQ";
            this.txbQ.Size = new System.Drawing.Size(209, 22);
            this.txbQ.TabIndex = 29;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(143, 371);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 34);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarNovo
            // 
            this.btnSalvarNovo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovo.Location = new System.Drawing.Point(367, 371);
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
            this.label10.Location = new System.Drawing.Point(18, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(333, 34);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cadastrar Novo Estoque";
            // 
            // frmCadastrarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 418);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvarNovo);
            this.Controls.Add(this.label10);
            this.Name = "frmCadastrarEstoque";
            this.Text = "Cadastrar Estoque";
            //this.Load += new System.EventHandler(this.frmCadastrarEstoque_Load);
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbDetalhes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txbQ;
    }
}