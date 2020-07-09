using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioControle;
using Negocio;
using System.Dynamic;

namespace InventarioVisao
{
    public partial class frmRelatorios : Form
    {

        /*********************************************************/
        //VARIÁVEIS GLOBAIS

        int X = 0;
        int Y = 0;

        //Opções
        Boolean Status = false;
        Boolean Header = false;

        /*********************************************************/
        // INIT

        public frmRelatorios()
        {
            InitializeComponent();

            //PARA POSSIBILITAR O MOVER/ARRASTAR SEM BORDA
            this.MouseDown += new MouseEventHandler(frm_MouseDown);
            this.MouseMove += new MouseEventHandler(frm_MouseMove);

        }

        /*********************************************************/
        // PARA MOVER/ARRASTAR SEM BORDA

        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }


        /*********************************************************/
        // LOAD FORM

        private void frmRelatorios_Load(object sender, EventArgs e)
        {

            //COMBOBOX DINÂMICO
            //ComboBox cbLocal = new ComboBox();
            //cbLocal.Name = "cbLocal";
            //cbLocal.Size = new Size(90, 15);
            //cmb.Location = new Point(10, 10);
            //Atribui o Evento
            cbLocal.SelectedIndexChanged += new System.EventHandler(this.EventoSelectedIndexChanged);
            //Adiciona o Controle no Form
            //this.Controls.Add(cbLocal);


            EstoqueCtrl EstoqueCtrl = new EstoqueCtrl();
            var estoquesLista = EstoqueCtrl.getEstoques();

            cbLocal.DisplayMember = "estoqueLOCAL";
            cbLocal.ValueMember = "estoqueCODIGO";

            cbLocal.DataSource = estoquesLista;


            /*/
            foreach (Estoque estoque in estoquesLista)
            {
                //cbLocal.Items.Add(new {Value = estoque.estoqueCODIGO});
            }
            /*/

        }

        private void EventoSelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /*********************************************************/
        //FECHAR E VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Close();
            home.BringToFront();
        }


        /*********************************************************/
        //MUDAR AS OPÇÕES DE STATUS

        private void ckbRelatorioStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRelatorioStatus.Checked)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
        }

        /*********************************************************/
        //MUDAR AS OPÇÕES DE CABEÇALHO

        private void ckbHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHeader.Checked)
            {
                Header = true;
            }
            else
            {
                Header = false;
            }
        }

        /*********************************************************/
        // FAZ A BUSCA PELO RELATÓRIO DE LOCAL-MOVIMENTAÇÃO

        private void BtnMovLocal_Click(object sender, EventArgs e)
        {
            

               //Para pegar os resultados e criar o arquivo
               EstoqueCtrl EstoqueCtrl = new EstoqueCtrl();
            
            //int cboIndex = cbLocal.SelectedIndex;
            String localEscolhido = (cbLocal.SelectedValue).ToString();
            String nomeLocal = cbLocal.Text;
            String nomeRel = "Mov_Local";
            String tipoRel = "mov";
            List <Movimentacao> dadosEncontrados = EstoqueCtrl.relatorioMovLocal(localEscolhido, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para este local.");
            }

            
        }

        /*********************************************************/
        // ABRIR A PREVIEW DEPOIS DE PEGAR O RESULTADO DA BUSCA

        private void relatorioPreview(dynamic dadosEncontrados, String tipoRel, String nomeLocal, String nomeRel, Boolean Status, Boolean Header)
        {

            frmRelatorioPreview relprev = new frmRelatorioPreview();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmRelatorioPreview)
                {
                    relprev.checkTipo(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                relprev.checkTipo(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
                relprev.BringToFront();
            }
            else
            {
                relprev.checkTipo(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
                relprev.ShowDialog();
            }
        }

        /*********************************************************/
        // FAZ A BUSCA PELO RELATÓRIO DE LOCAL-PRODUTO


        private void BtnProdutoLocal_Click(object sender, EventArgs e)
        {

            //Para pegar os resultados e criar o arquivo
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            //int cboIndex = cbLocal.SelectedIndex;
            String localEscolhido = (cbLocal.SelectedValue).ToString();
            String nomeLocal = cbLocal.Text;
            String nomeRel = "Prod_Local";
            String tipoRel = "prod";
            List<Produto> dadosEncontrados = ProdutoCtrl.relatorioProdMovLocal(localEscolhido, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para este local.");
            }


    }

        /*********************************************************/
        //

        private void BtnProdutoOp_Click(object sender, EventArgs e)
        {

            //Para pegar os resultados e criar o arquivo
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            //String opEscolhida = (CbOperacao.SelectedValue).ToString();
            String opEscolhida = (CbOperacao.Text).ToString();
            String nomeLocal = CbOperacao.Text;
            String nomeRel = "Prod_Op";
            String tipoRel = "prod";
            List<Produto> dadosEncontrados = ProdutoCtrl.relatorioProdOperacao(opEscolhida, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }


        }


        /*********************************************************/
        //

        private void BtnEstoqueOp_Click(object sender, EventArgs e)
        {

            //Para pegar os resultados e criar o arquivo
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();

            //String opEscolhida = (CbOperacao.SelectedValue).ToString();
            String opEscolhida = (CbOperacao.Text).ToString();
            String nomeLocal = CbOperacao.Text;
            String nomeRel = "Estoque_Op";
            String tipoRel = "estoq";
            List<Estoque> dadosEncontrados = estoqueCtrl.relatorioEstoqOperacao(opEscolhida, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        }


        /*********************************************************/
        // AUDITORIA DE PRODUTO


        private void btnProdutoAudit_Click(object sender, EventArgs e)
        {
            //Para pegar os resultados e criar o arquivo
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            //DateTime dataEscolhida = DateTime.Parse(dateTAudit.Text);
            DateTime dataEscolhida = dateTAudit.Value.Date;
            String nomeLocal = txbCodAudit.Text; //codigo escolhido
            //String nomeLocal = CbOperacao.Text;
            String nomeRel = "Prod_Audit";
            String tipoRel = "prod";
            List<Produto> dadosEncontrados = ProdutoCtrl.relatorioProdAudit(dataEscolhida, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }




        }

        /*********************************************************/
        // AUDITORIA DE ESTOQUE

        private void BtnEstoqueAudit_Click(object sender, EventArgs e)
        {

            //Para pegar os resultados e criar o arquivo
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();

            //String opEscolhida = (CbOperacao.SelectedValue).ToString();
            //String opEscolhida = (CbOperacao.Text).ToString();
            DateTime dataEscolhida = dateTAudit.Value.Date;
            String nomeLocal = txbCodAudit.Text; //codigo escolhido
            String nomeRel = "Estoque_Audit";
            String tipoRel = "estoq";
            List<Estoque> dadosEncontrados = estoqueCtrl.relatorioEstoqAudit(dataEscolhida, nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        
    }

        /*********************************************************/
        // RELATÓRIO DE PRODUTOS VÁLIDOS

        private void btnProdutoVal_Click(object sender, EventArgs e)
        {

            //Para pegar os resultados e criar o arquivo
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            String nomeLocal = "Produtos Válidos"; //codigo escolhido
            String nomeRel = "Prod_Valido";
            String tipoRel = "prod";
            List<Produto> dadosEncontrados = ProdutoCtrl.relatorioProdValidade(nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }

        }


        /*********************************************************/
        //


        private void btnProdutoInv_Click(object sender, EventArgs e)
        {
            //Para pegar os resultados e criar o arquivo
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            String nomeLocal = "Produtos Inválidos"; //codigo escolhido
            String nomeRel = "Prod_Invalido";
            String tipoRel = "prod";
            List<Produto> dadosEncontrados = ProdutoCtrl.relatorioProdValidade(nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        }

        /*********************************************************/
        //

        private void btnEstoqueRel_Click(object sender, EventArgs e)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();

            //String opEscolhida = (CbOperacao.Text).ToString();
            String nomeLocal = "Estoques"; //codigo escolhido
            String nomeRel = "Estoque_Rel";
            String tipoRel = "estoq";
            List<Estoque> dadosEncontrados = estoqueCtrl.relatorioEstoqRel(nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        }


        /*********************************************************/
        //

        private void btnMovRel_Click(object sender, EventArgs e)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();

            //String opEscolhida = (CbOperacao.Text).ToString();
            String nomeLocal = "Movimentações"; //codigo escolhido
            String nomeRel = "Mov_Rel";
            String tipoRel = "mov";
            List<Movimentacao> dadosEncontrados = estoqueCtrl.relatorioMovRel(nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        }

        /*********************************************************/
        //

        private void btnMovCompRel_Click(object sender, EventArgs e)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();

            //String codEscolhido = tcbCodRelComp.Text;
            String nomeLocal = tcbCodRelComp.Text;
            String nomeRel = "MovCompleta_Rel";
            String tipoRel = "movcomp";
            List<MovComp> dadosEncontrados = estoqueCtrl.relatorioMovCompRel(nomeLocal, nomeRel, tipoRel, Status, Header);

            if (dadosEncontrados.Count() != 0) //Resultados encontrados
            {
                relatorioPreview(dadosEncontrados, tipoRel, nomeLocal, nomeRel, Status, Header);
            }
            else // Não encontrado
            {
                MessageBox.Show("Não há relatórios disponíveis para esta operação.");
            }
        }

        /*********************************************************/
        //









    }
}

