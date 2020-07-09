namespace InventarioVisao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalvarArq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.menuC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbCadPrincipal = new System.Windows.Forms.GroupBox();
            this.gpbEnd = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.ltbTipoEnd = new System.Windows.Forms.ListBox();
            this.gpbComplementares = new System.Windows.Forms.GroupBox();
            this.gpbFamiliar = new System.Windows.Forms.GroupBox();
            this.ckbAnimais = new System.Windows.Forms.CheckBox();
            this.ckbFilhos = new System.Windows.Forms.CheckBox();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mniArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.iSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.iSair = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaSalvar = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuC.SuspendLayout();
            this.gpbCadPrincipal.SuspendLayout();
            this.gpbEnd.SuspendLayout();
            this.gpbComplementares.SuspendLayout();
            this.gpbFamiliar.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarArq
            // 
            /*/
            this.btnSalvarArq.Location = new System.Drawing.Point(12, 460);
            this.btnSalvarArq.Name = "btnSalvarArq";
            this.btnSalvarArq.Size = new System.Drawing.Size(107, 23);
            this.btnSalvarArq.TabIndex = 0;
            this.btnSalvarArq.Text = "Salvar no Arquivo";
            this.btnSalvarArq.UseVisualStyleBackColor = true;
            this.btnSalvarArq.Click += new System.EventHandler(this.btnSalvarArq_Click);
            /*/
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.ContextMenuStrip = this.menuC;
            this.txbNome.Location = new System.Drawing.Point(62, 34);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(254, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.Text = "Digite seu nome";
            this.txbNome.Click += new System.EventHandler(this.txbNome_Click);
            // 
            // menuC
            // 
            this.menuC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLimpar});
            this.menuC.Name = "menuC";
            this.menuC.Size = new System.Drawing.Size(112, 26);
            this.menuC.Opening += new System.ComponentModel.CancelEventHandler(this.menuC_Opening);
            // 
            // miLimpar
            // 
            this.miLimpar.Name = "miLimpar";
            this.miLimpar.Size = new System.Drawing.Size(111, 22);
            this.miLimpar.Text = "Limpar";
            this.miLimpar.Click += new System.EventHandler(this.miLimpar_Click);
            // 
            // mtbTel
            // 
            this.mtbTel.ContextMenuStrip = this.menuC;
            this.mtbTel.Location = new System.Drawing.Point(412, 34);
            this.mtbTel.Mask = "(99) 0000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(142, 20);
            this.mtbTel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tel:";
            // 
            // gpbCadPrincipal
            // 
            this.gpbCadPrincipal.Controls.Add(this.txbNome);
            this.gpbCadPrincipal.Controls.Add(this.label2);
            this.gpbCadPrincipal.Controls.Add(this.label1);
            this.gpbCadPrincipal.Controls.Add(this.mtbTel);
            this.gpbCadPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gpbCadPrincipal.Name = "gpbCadPrincipal";
            this.gpbCadPrincipal.Size = new System.Drawing.Size(619, 85);
            this.gpbCadPrincipal.TabIndex = 5;
            this.gpbCadPrincipal.TabStop = false;
            this.gpbCadPrincipal.Text = "Dados Principais";
            // 
            // gpbEnd
            // 
            this.gpbEnd.Controls.Add(this.label6);
            this.gpbEnd.Controls.Add(this.txbEndereco);
            this.gpbEnd.Controls.Add(this.label5);
            this.gpbEnd.Controls.Add(this.label4);
            this.gpbEnd.Controls.Add(this.label3);
            this.gpbEnd.Controls.Add(this.cmbCidade);
            this.gpbEnd.Controls.Add(this.cmbEstado);
            this.gpbEnd.Controls.Add(this.ltbTipoEnd);
            this.gpbEnd.Location = new System.Drawing.Point(12, 124);
            this.gpbEnd.Name = "gpbEnd";
            this.gpbEnd.Size = new System.Drawing.Size(619, 156);
            this.gpbEnd.TabIndex = 6;
            this.gpbEnd.TabStop = false;
            this.gpbEnd.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(153, 56);
            this.txbEndereco.Multiline = true;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(253, 73);
            this.txbEndereco.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Endereço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade:";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "São Paulo",
            "Belo Horizonte",
            "Araruama",
            "Niterói"});
            this.cmbCidade.Location = new System.Drawing.Point(441, 108);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(146, 21);
            this.cmbCidade.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "SP"});
            this.cmbEstado.Location = new System.Drawing.Point(441, 55);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(146, 21);
            this.cmbEstado.TabIndex = 1;
            // 
            // ltbTipoEnd
            // 
            this.ltbTipoEnd.FormattingEnabled = true;
            this.ltbTipoEnd.Items.AddRange(new object[] {
            "Rua",
            "Av.",
            "Trav.",
            "Alameda",
            "Rod."});
            this.ltbTipoEnd.Location = new System.Drawing.Point(21, 55);
            this.ltbTipoEnd.Name = "ltbTipoEnd";
            this.ltbTipoEnd.Size = new System.Drawing.Size(120, 95);
            this.ltbTipoEnd.TabIndex = 0;
            this.ltbTipoEnd.SelectedIndexChanged += new System.EventHandler(this.ltbTipoEnd_SelectedIndexChanged);
            // 
            // gpbComplementares
            // 
            this.gpbComplementares.Controls.Add(this.gpbFamiliar);
            this.gpbComplementares.Controls.Add(this.gpbSexo);
            this.gpbComplementares.Location = new System.Drawing.Point(12, 296);
            this.gpbComplementares.Name = "gpbComplementares";
            this.gpbComplementares.Size = new System.Drawing.Size(619, 129);
            this.gpbComplementares.TabIndex = 7;
            this.gpbComplementares.TabStop = false;
            this.gpbComplementares.Text = "Dados Complementares";
            // 
            // gpbFamiliar
            // 
            this.gpbFamiliar.Controls.Add(this.ckbAnimais);
            this.gpbFamiliar.Controls.Add(this.ckbFilhos);
            this.gpbFamiliar.Controls.Add(this.rdbSolteiro);
            this.gpbFamiliar.Controls.Add(this.rdbCasado);
            this.gpbFamiliar.Location = new System.Drawing.Point(271, 23);
            this.gpbFamiliar.Name = "gpbFamiliar";
            this.gpbFamiliar.Size = new System.Drawing.Size(316, 100);
            this.gpbFamiliar.TabIndex = 5;
            this.gpbFamiliar.TabStop = false;
            this.gpbFamiliar.Text = "Familiar";
            // 
            // ckbAnimais
            // 
            this.ckbAnimais.AutoSize = true;
            this.ckbAnimais.Location = new System.Drawing.Point(150, 67);
            this.ckbAnimais.Name = "ckbAnimais";
            this.ckbAnimais.Size = new System.Drawing.Size(62, 17);
            this.ckbAnimais.TabIndex = 5;
            this.ckbAnimais.Text = "Animais";
            this.ckbAnimais.UseVisualStyleBackColor = true;
            // 
            // ckbFilhos
            // 
            this.ckbFilhos.AutoSize = true;
            this.ckbFilhos.Location = new System.Drawing.Point(150, 20);
            this.ckbFilhos.Name = "ckbFilhos";
            this.ckbFilhos.Size = new System.Drawing.Size(53, 17);
            this.ckbFilhos.TabIndex = 4;
            this.ckbFilhos.Text = "Filhos";
            this.ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(14, 19);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 2;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(14, 67);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 3;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(33, 23);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 100);
            this.gpbSexo.TabIndex = 4;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(30, 21);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(30, 69);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AllowUserToDeleteRows = false;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome});
            this.dgvCadastro.Location = new System.Drawing.Point(646, 12);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.RowHeadersVisible = false;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(295, 413);
            this.dgvCadastro.TabIndex = 8;
            this.dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 240;
            // 
            // temp
            // 
            this.temp.Interval = 1000;
            this.temp.Tick += new System.EventHandler(this.temp_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(817, 470);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(31, 13);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "0000";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniArquivo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1146, 24);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // mniArquivo
            // 
            this.mniArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSalvar,
            this.separador,
            this.iSair});
            this.mniArquivo.Name = "mniArquivo";
            this.mniArquivo.Size = new System.Drawing.Size(61, 20);
            this.mniArquivo.Text = "&Arquivo";
            // 
            // iSalvar
            // 
            this.iSalvar.Name = "iSalvar";
            this.iSalvar.Size = new System.Drawing.Size(105, 22);
            this.iSalvar.Text = "S&alvar";
            this.iSalvar.Click += new System.EventHandler(this.iSalvar_Click);
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(102, 6);
            // 
            // iSair
            // 
            this.iSair.Name = "iSair";
            this.iSair.Size = new System.Drawing.Size(105, 22);
            this.iSair.Text = "Sai&r";
            this.iSair.Click += new System.EventHandler(this.iSair_Click);
            // 
            // janelaSalvar
            // 
            this.janelaSalvar.DefaultExt = "txt";
            this.janelaSalvar.FileName = "bd";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(574, 446);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Armas\nTipo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 592);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.gpbComplementares);
            this.Controls.Add(this.gpbEnd);
            this.Controls.Add(this.gpbCadPrincipal);
            this.Controls.Add(this.btnSalvarArq);
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventario_App";
   //         this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuC.ResumeLayout(false);
            this.gpbCadPrincipal.ResumeLayout(false);
            this.gpbCadPrincipal.PerformLayout();
            this.gpbEnd.ResumeLayout(false);
            this.gpbEnd.PerformLayout();
            this.gpbComplementares.ResumeLayout(false);
            this.gpbFamiliar.ResumeLayout(false);
            this.gpbFamiliar.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarArq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbCadPrincipal;
        private System.Windows.Forms.GroupBox gpbEnd;
        private System.Windows.Forms.ListBox ltbTipoEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbComplementares;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox gpbFamiliar;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.CheckBox ckbAnimais;
        private System.Windows.Forms.CheckBox ckbFilhos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.Timer temp;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ContextMenuStrip menuC;
        private System.Windows.Forms.ToolStripMenuItem miLimpar;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mniArquivo;
        private System.Windows.Forms.ToolStripMenuItem iSalvar;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripMenuItem iSair;
        private System.Windows.Forms.SaveFileDialog janelaSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

