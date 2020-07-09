namespace InventarioVisao
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnListarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.picBNimal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArquivoStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarMov = new System.Windows.Forms.Button();
            this.btnConsultarMov = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEstoq = new System.Windows.Forms.Button();
            this.btnConsultarEstoq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBNimal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(523, 470);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCadastrarProduto);
            this.groupBox1.Controls.Add(this.btnConsultarProduto);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.groupBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(161, 32);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(131, 39);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click_1);
            // 
            // btnListarProduto
            // 
            this.btnListarProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProduto.Location = new System.Drawing.Point(15, 32);
            this.btnListarProduto.Name = "btnListarProduto";
            this.btnListarProduto.Size = new System.Drawing.Size(131, 39);
            this.btnListarProduto.TabIndex = 3;
            this.btnListarProduto.Text = "Listar";
            this.btnListarProduto.UseVisualStyleBackColor = true;
            this.btnListarProduto.Click += new System.EventHandler(this.btnListarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(157, 32);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(131, 39);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.Location = new System.Drawing.Point(11, 32);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(131, 39);
            this.btnConsultarProduto.TabIndex = 1;
            this.btnConsultarProduto.Text = "Consultar";
            this.btnConsultarProduto.UseVisualStyleBackColor = true;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacoes.Location = new System.Drawing.Point(15, 81);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(131, 39);
            this.btnInformacoes.TabIndex = 6;
            this.btnInformacoes.Text = "Informações";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // picBNimal
            // 
            this.picBNimal.BackColor = System.Drawing.Color.Transparent;
            this.picBNimal.Image = ((System.Drawing.Image)(resources.GetObject("picBNimal.Image")));
            this.picBNimal.Location = new System.Drawing.Point(317, 12);
            this.picBNimal.Name = "picBNimal";
            this.picBNimal.Size = new System.Drawing.Size(321, 202);
            this.picBNimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBNimal.TabIndex = 47;
            this.picBNimal.TabStop = false;
            this.picBNimal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.picBNimal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 78);
            this.label1.TabIndex = 48;
            this.label1.Text = "Controlador\r\n     de Inventario";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "— Consulta de Itens —";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblArquivoStatus);
            this.groupBox2.Controls.Add(this.btnArquivo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnInformacoes);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(328, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status:";
            this.groupBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.groupBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(233, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "INVALIDO\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Local:";
            // 
            // lblArquivoStatus
            // 
            this.lblArquivoStatus.AutoSize = true;
            this.lblArquivoStatus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoStatus.Location = new System.Drawing.Point(233, 23);
            this.lblArquivoStatus.Name = "lblArquivoStatus";
            this.lblArquivoStatus.Size = new System.Drawing.Size(59, 15);
            this.lblArquivoStatus.TabIndex = 7;
            this.lblArquivoStatus.Text = "INVALIDO\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Arquivo:";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivo.Location = new System.Drawing.Point(161, 81);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(131, 39);
            this.btnArquivo.TabIndex = 5;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnRelatorio);
            this.groupBox5.Controls.Add(this.btnListarProduto);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(328, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 85);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Outros";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnCadastrarMov);
            this.groupBox3.Controls.Add(this.btnConsultarMov);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimentação";
            // 
            // btnCadastrarMov
            // 
            this.btnCadastrarMov.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMov.Location = new System.Drawing.Point(157, 32);
            this.btnCadastrarMov.Name = "btnCadastrarMov";
            this.btnCadastrarMov.Size = new System.Drawing.Size(131, 39);
            this.btnCadastrarMov.TabIndex = 2;
            this.btnCadastrarMov.Text = "Cadastrar";
            this.btnCadastrarMov.UseVisualStyleBackColor = true;
            this.btnCadastrarMov.Click += new System.EventHandler(this.btnCadastrarMov_Click);
            // 
            // btnConsultarMov
            // 
            this.btnConsultarMov.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMov.Location = new System.Drawing.Point(11, 32);
            this.btnConsultarMov.Name = "btnConsultarMov";
            this.btnConsultarMov.Size = new System.Drawing.Size(131, 39);
            this.btnConsultarMov.TabIndex = 1;
            this.btnConsultarMov.Text = "Consultar";
            this.btnConsultarMov.UseVisualStyleBackColor = true;
            this.btnConsultarMov.Click += new System.EventHandler(this.btnConsultarMov_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnCadastrarEstoq);
            this.groupBox4.Controls.Add(this.btnConsultarEstoq);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 85);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estoque";
            // 
            // btnCadastrarEstoq
            // 
            this.btnCadastrarEstoq.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstoq.Location = new System.Drawing.Point(157, 32);
            this.btnCadastrarEstoq.Name = "btnCadastrarEstoq";
            this.btnCadastrarEstoq.Size = new System.Drawing.Size(131, 39);
            this.btnCadastrarEstoq.TabIndex = 2;
            this.btnCadastrarEstoq.Text = "Cadastrar";
            this.btnCadastrarEstoq.UseVisualStyleBackColor = true;
            this.btnCadastrarEstoq.Click += new System.EventHandler(this.btnCadastrarEstoq_Click);
            // 
            // btnConsultarEstoq
            // 
            this.btnConsultarEstoq.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstoq.Location = new System.Drawing.Point(11, 32);
            this.btnConsultarEstoq.Name = "btnConsultarEstoq";
            this.btnConsultarEstoq.Size = new System.Drawing.Size(131, 39);
            this.btnConsultarEstoq.TabIndex = 1;
            this.btnConsultarEstoq.Text = "Consultar";
            this.btnConsultarEstoq.UseVisualStyleBackColor = true;
            this.btnConsultarEstoq.Click += new System.EventHandler(this.btnConsultarEstoq_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBNimal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBNimal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox picBNimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Label lblArquivoStatus;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCadastrarMov;
        private System.Windows.Forms.Button btnConsultarMov;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCadastrarEstoq;
        private System.Windows.Forms.Button btnConsultarEstoq;
    }
}