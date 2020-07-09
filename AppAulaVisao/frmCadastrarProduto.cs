using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using InventarioControle;



namespace InventarioVisao
{
    public partial class frmCadastrarProduto : Form
    {
        static int qProdTotal;
        static float vProd, vProdTotal;


        /*********************************************************/
        // INIT

        public frmCadastrarProduto()
        {
            InitializeComponent();

        }


        /*********************************************************/
        // INIT

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            cbOperacao.Text = "ENTRADA DE FORNECEDOR";
            txbStatus.Text = "VALIDO";

        }


        /*********************************************************/
        // SALVA O NOVO PRODUTO

        private void btnSalvarNovoProduto_Click(object sender, EventArgs e)
        {
            String okProd;
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();

            Produto produtoNovo = new Produto();
            produtoNovo.dadosCODIGO = txbCodigo.Text;
            produtoNovo.dadosPRODUTO = txbNome.Text;
            produtoNovo.dadosDIMENSOES = txbDimensoes.Text;
            produtoNovo.dadosDETALHES = txbDetalhes.Text;
            produtoNovo.dadosOPERACAO = cbOperacao.Text; //ULTIMA OPERAÇÃO FEITA
            produtoNovo.dadosMOVIMENTACAO = int.Parse(txbMovimentacao.Text); //ÚLTIMA MOVIMENTAÇÃO FEITA
            produtoNovo.dadosQUANTIDADE = int.Parse(txbQuantidade.Text); //QUANTIDADE TOTAL NO ESTOQUE
            produtoNovo.dadosVALOR = vProd;
            produtoNovo.dadosVALORTOTAL = vProdTotal; //VALOR TOTAL DA QUANTIDADE DE PRODUTOS
            produtoNovo.dadosDATA = DateTime.Parse(txbData.Text);
            produtoNovo.dadosSERIE = txbSerie.Text;
            produtoNovo.dadosNOTAFISCAL = txbNotaFiscal.Text;
            produtoNovo.dadosSEQ = txbSeq.Text;
            produtoNovo.dadosFORNECEDOR = txbFornecedor.Text;
            produtoNovo.dadosCOMPLEMENTO = txbComplemento.Text;
            produtoNovo.dadosSTATUS = txbStatus.Text;

            okProd = produtoCtrl.SalvarProduto(produtoNovo); //CHECA SE ALTEROU O PRODUTO

            
            if (okProd == "ok")
            {
                MessageBox.Show("Produto salvo com sucesso!");
                limparTela();
            }
            else if (okProd == "campos")
            {
                MessageBox.Show("O produto não foi salvo.");
            }
            else if (okProd == "cod")
            {
                //Encontrou outro item válido com o mesmo código
                DialogResult dialogResult = MessageBox.Show("Não há produtos suficientes no estoque de origem para esta movimentação. \r\nTem certeza que quer continuar a operação? \r\nA movimentação será subtraída da quantidade total do estoque.", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    checkNegativo();
                }
            }
            else
            {
                MessageBox.Show("O produto não foi salvo.");
            }
        }

        /*********************************************************/
        // LIMPA A TELA

        private void limparTela()
        {
            txbCodigo.Text = "";
            //txbStatus.Text = "";
            txbNome.Text = "";
            txbQuantidade.Text = "";
            txbValor.Text = "";
            txbDimensoes.Text = "";
            txbDetalhes.Text = "";
            txbFornecedor.Text = "";
            cbOperacao.Text = "";
            txbMovimentacao.Text = "";
            txbQuantidadeTotal.Text = "";
            txbValorTotal.Text = "";
            txbSerie.Text = "";
            txbData.Text = null;
            txbNotaFiscal.Text = "";
            txbSeq.Text = "";
            txbComplemento.Text = "";
        }

        /*********************************************************/
        // Carrega Produto do FORM
        // É necessário?

            /*/
        private void CarregarProdutoDoForm(Produto produto)
        {

            produto.dadosCODIGO = txbCodigo.Text;
            produto.dadosPRODUTO = txbNome.Text;
            produto.dadosQUANTIDADE = int.Parse(txbQuantidade.Text);
            produto.dadosVALOR = int.Parse(txbValor.Text);
            produto.dadosDIMENSOES = txbDimensoes.Text;
            produto.dadosDETALHES = txbDetalhes.Text;

            produto.dadosFORNECEDOR = txbFornecedor.Text;
            produto.dadosOPERACAO = cbOperacao.Text;
            produto.dadosMOVIMENTACAO = int.Parse(txbMovimentacao.Text);
            produto.dadosQUANTIDADE = int.Parse(txbQuantidadeTotal.Text);

        }
        /*/


        /*********************************************************/
        // VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {   
            /*/
            frmHome home = new frmHome();
            home.BringToFront();
            /*/
            this.Close();
        }

        /*********************************************************/
        // CHAMA O LIMPAR

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            limparTela();
        }


        /*********************************************************/
        //QUANTIDADE TOTAL SERÁ A MESMA DA MOVIMENTAÇÃO

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            int i; // VALIDAR INT
            if ((txbQuantidade.Text == null) || (txbQuantidade.Text == "") || (!int.TryParse(txbQuantidade.Text, out i)))
            {
                txbQuantidade.Text = "0";
                qProdTotal = 0;
            }
            qProdTotal = int.Parse(txbQuantidade.Text);
            txbMovimentacao.Text = txbQuantidade.Text;

            calculoValorQuant();
        }

        /*********************************************************/
        //CÁLCULO DE VALOR E QUANTIDADE TOTAL
        private void calculoValorQuant()
        {
            if ((txbValor.Text != null) && (txbQuantidade.Text != null))
            {
                txbQuantidadeTotal.Text = (qProdTotal).ToString();

                vProdTotal = vProd * qProdTotal;
                txbValorTotal.Text = (vProdTotal).ToString("0.00"); ;
            }


        }
        /*********************************************************/

        private void txbValor_Leave(object sender, EventArgs e)
        {
            float f;
            if (float.TryParse(txbValor.Text, out f))
            {
                vProd = float.Parse(txbValor.Text);
            } else
            {
                vProd = 0;
            }
            calculoValorQuant();
        }


        /*********************************************************/

        private void txbMovimentacao_Leave(object sender, EventArgs e)
        {
            int i; // VALIDAR INT
            if ((txbMovimentacao.Text == null) || (txbMovimentacao.Text == "") || (!int.TryParse(txbMovimentacao.Text, out i)))
            {
                txbMovimentacao.Text = "0";
                qProdTotal = 0;
            }
            qProdTotal = int.Parse(txbMovimentacao.Text);
            txbQuantidade.Text = txbMovimentacao.Text;

            calculoValorQuant();

        }

        /*********************************************************/
        // CHAMA O SALVAR

        /*********************************************************/

    }
}