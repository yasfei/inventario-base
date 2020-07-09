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
    public partial class frmCadastrarMov : Form
    {
        static Estoque estoqueEscolhido;
        static Produto produtoEscolhido;
        static int qProdEstoque; //QUANTIDADE DE PRODUTO NO ESTOQUE
        static int qMov; //QUANTIDADE DA MOVIMENTAÇÃO
        static int qTot; // QUANTIDADE TOTAL DE ITENS NO ESTOQUE
        static String opMov; //OPERAÇÃO DA MOVIMENTAÇÃO
        static int qProdTotal; //QUANTIDADE TOTAL DE PRODUTO NO BANCO


        /*********************************************************/
        // INIT
        public frmCadastrarMov()
        {
            InitializeComponent();
        }


        /*********************************************************/

        private void frmCadastrarMov_Load(object sender, EventArgs e)
        {
            txbCodigo.Text = geradorCod();

            //Preenchendo o combobox de Estoque
            EstoqueCtrl EstoqueCtrl = new EstoqueCtrl();
            var estoquesLista = EstoqueCtrl.getEstoques();
            
            txbNomeEstoq.DisplayMember = "estoqueLOCAL";
            txbCodEstoq.DisplayMember = "estoqueCODIGO";
            //cbLocal.ValueMember = "estoqueCODIGO";

            txbNomeEstoq.DataSource = estoquesLista;
            txbCodEstoq.DataSource = estoquesLista;

            //txbNomeEstoq.Text = "Selecione um estoque válido";
            //txbCodEstoq.Text = "";
            txbNomeEstoq.SelectedIndex = -1;
            txbCodEstoq.SelectedIndex = -1;


            //Preenchendo o combobox de Produto
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            var produtoLista = produtoCtrl.buscarValidos();

            txbNomeProd.DisplayMember = "dadosPRODUTO";
            txbCodProd.DisplayMember = "dadosCODIGO";
            //cbLocal.ValueMember = "estoqueCODIGO";

            txbNomeProd.DataSource = produtoLista;
            txbCodProd.DataSource = produtoLista;

            //txbNomeProd.Text = "Selecione um produto válido";
            //txbCodProd.Text = "";
            txbNomeProd.SelectedIndex = -1;
            txbCodProd.SelectedIndex = -1;

        }

        /*********************************************************/
        //GERADOR DE CÓDIGO ALEATÓRIO

        private String geradorCod()
        {
            Random randNum = new Random();
            String codGerado = (randNum.Next(999999)).ToString();
            return codGerado;

        }


        /*********************************************************/
        // MUDAR OS COMBOBOX PARA CADA ESCOLHA

        private void txbCodProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produto produtoSelecionado = new Produto();
            //var produtoSelecionado = txbCodProd.SelectedItem;
            //produtoSelecionado = new Produto();
            produtoEscolhido = ((txbCodProd as ComboBox).SelectedItem as Produto);
            if (produtoEscolhido != null)
            {
                txbNomeProd.Text = (produtoEscolhido.dadosPRODUTO).ToString();
                txbNomeProd.SelectedItem = "dadosPRODUTO";
                //txbNomeProd.DisplayMember = "dadosPRODUTO";
                //txbNomeProd.Text = produtoSelecionado.dadosPRODUTO";

                checkMovComp();
            }

        }

        private void txbNomeProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtoEscolhido = ((txbNomeProd as ComboBox).SelectedItem as Produto);
            if (produtoEscolhido != null)
            {
                txbCodProd.SelectedItem = "dadosCODIGO";
                txbCodProd.DisplayMember = "dadosCODIGO";

                checkMovComp();
            }
        }

        private void txbCodEstoq_SelectedIndexChanged(object sender, EventArgs e)
        {
            estoqueEscolhido = ((txbCodEstoq as ComboBox).SelectedItem as Estoque);
            if (estoqueEscolhido != null)
            {
                txbNomeEstoq.Text = (estoqueEscolhido.estoqueLOCAL).ToString();
                txbNomeEstoq.SelectedItem = "estoqueLOCAL";
                //txbNomeEstoq.DisplayMember = "estoqueLOCAL";
                txbQtotal.Text = (estoqueEscolhido.estoqueQUANTIDADE).ToString();
                qTot = estoqueEscolhido.estoqueQUANTIDADE;

                checkMovComp();
            }
        }

        private void txbNomeEstoq_SelectedIndexChanged(object sender, EventArgs e)
        {
            estoqueEscolhido = ((txbNomeEstoq as ComboBox).SelectedItem as Estoque);
            if (estoqueEscolhido != null)
            {
                txbCodEstoq.SelectedItem = "estoqueCODIGO";
                txbCodEstoq.DisplayMember = "estoqueCODIGO";
                txbQtotal.Text = (estoqueEscolhido.estoqueQUANTIDADE).ToString();
                qTot = estoqueEscolhido.estoqueQUANTIDADE;

                checkMovComp();
            }
        }

        /*********************************************************/
        // CHECA A ÚLTIMA MOVIMENTAÇÃO COMPLETA DO PRODUTO E ESTOQUE ESCOLHIDO

        private void checkMovComp()
        {
            if ((produtoEscolhido != null) && (estoqueEscolhido != null)) //Só busca se PRODUTO e ESTOQUE já tiverem sido escolhidos
            {
                String codProd = produtoEscolhido.dadosCODIGO;
                String codEstoq = estoqueEscolhido.estoqueCODIGO;

                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                //List<Produto> listaMov
                List<MovComp> listaMovComp = estoqueCtrl.MovCompComEstoqueProduto(codProd, codEstoq);

                if (listaMovComp.Count() != 0) // SE A LISTA RETORNOU ALGO, PEGARÁ O PRIMEIRO
                {
                    MovComp movCompEncontrada = listaMovComp.First();
                    txbQProdEstoq.Text = (movCompEncontrada.mov_QPRODESTOQ).ToString(); //QUANTIDADE DO PRODUTO NO ESTOQUE
                    qProdEstoque = movCompEncontrada.mov_QPRODESTOQ;

                    qTot = movCompEncontrada.estoque_QUANTIDADE; //QUANTIDADE DE ITENS NO ESTOQUE
                    qProdTotal = movCompEncontrada.produto_QUANTIDADE; //QUANTIDADE TOTAL DO PRODUTO
                }
                else //SE CHECAR A LISTA E NÃO TIVER NADA
                {
                    txbQProdEstoq.Text = "";
                    qProdEstoque = 0;
                }
            } 
        }

        /*********************************************************/
        // CHECA A ÚLTIMA MOVIMENTAÇÃO COMPLETA DO PRODUTO E ESTOQUE ESCOLHIDO

        private void checkMovOp()
        {
            if ((qProdEstoque != 0) && (opMov != null)) //Só busca se PRODUTO e ESTOQUE já tiverem sido escolhidos
            {
                int qMoviment = 0;
                int estoqueTotal = estoqueEscolhido.estoqueQUANTIDADE;
                switch (opMov)
                {
                    case "ENTRADA DE FORNECEDOR":
                        qMoviment = qProdEstoque + qMov; //SOMA QUANDO ENTRA
                        txbQProdEstoq.Text = qMoviment.ToString(); // soma na quantidade do produto no estoque
                        qProdTotal = (produtoEscolhido.dadosQUANTIDADE) + qMov; // soma nq quantidade total do produto
                        qTot = estoqueTotal + qMov; //soma na quantidade total do estoque
                        txbQtotal.Text = qTot.ToString();
                        break;
                    case "VENDA DE MERCADORIAS":
                        qMoviment = qProdEstoque - qMov; //DIMINUI QUANDO VENDE
                        txbQProdEstoq.Text = qMoviment.ToString();
                        qProdTotal = (produtoEscolhido.dadosQUANTIDADE) - qMov; // soma nq quantidade total do produto
                        qTot = estoqueTotal - qMov;
                        txbQtotal.Text = qTot.ToString();
                        break;
                    case "DEMONSTRACAO":
                        qMoviment = qProdEstoque - qMov; //DIMININUI QUANDO SAI PARA DEMONSTRAÇÃO
                        txbQProdEstoq.Text = qMoviment.ToString();
                        qProdTotal = (produtoEscolhido.dadosQUANTIDADE) - qMov; // soma nq quantidade total do produto
                        qTot = estoqueTotal - qMov;
                        txbQtotal.Text = qTot.ToString();
                        break;
                    case "SERVICO":
                        qMoviment = qProdEstoque + qMov; //SOMA QUANDO ENTRA PARA SERVIÇO
                        txbQProdEstoq.Text = qMoviment.ToString();
                        qProdTotal = (produtoEscolhido.dadosQUANTIDADE) + qMov; // soma nq quantidade total do produto
                        qTot = estoqueTotal + qMov;
                        txbQtotal.Text = qTot.ToString();
                        break;
                    default:
                        break;
                }

                if (qMoviment < 0) //CHECAR SE O VALOR FICA NEGATIVO
                {
                    MessageBox.Show("Não há itens suficientes no estoque para esta movimentação.");
                    qMov = 0;
                    txbQ.Text = "0";
                    txbQProdEstoq.Text = qProdEstoque.ToString();
                    qProdTotal = produtoEscolhido.dadosQUANTIDADE;
                    qTot = 0;
                    txbQtotal.Text = estoqueTotal.ToString();
                }

            }
        }




        /*********************************************************/
        // SALVA A MOVA MOVIMENTAÇÃO

        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            Movimentacao mov = new Movimentacao();
            //CarregarProdutoDoForm(produto);

            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            if (estoqueCtrl.SalvarNovaMov(mov) == true)
            {
                MessageBox.Show("Movimentação salva com sucesso!");
                limparTela();
            }
            else
            {
                MessageBox.Show("A Movimentação não pode ser salva.");
            }
        }


        /*********************************************************/
        // LIMPA A TELA

        private void limparTela()
        {
            txbCodigo.Text = "";
            txbCodEstoq.SelectedIndex = -1;
            txbCodProd.SelectedIndex = -1;
            txbNomeProd.Text = "";
            txbDetalhes.Text = "";
            txbQ.Text = "";
            txbQProdEstoq.Text = "";
            txbQtotal.Text = "";
            txbData.Text = "";
            txbNomeEstoq.SelectedIndex = -1;
            txbNomeProd.SelectedIndex = -1;
            txbOp.SelectedIndex = -1;
            produtoEscolhido = null;
            estoqueEscolhido = null;
            qProdEstoque = 0;
            qProdTotal = 0;
            qMov = 0;
            qTot = 0;
            opMov = "";
        }


        /*********************************************************/
        // VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            limparTela();
            this.Close();
        }

        /*********************************************************/
        // CHAMA O LIMPAR

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        /*********************************************************/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*********************************************************/

        private void txbQ_TextChanged(object sender, EventArgs e)
        {
            int i; // VALIDAR INT
            if ((txbQ.Text == null) || (txbQ.Text == "") || (!int.TryParse(txbQ.Text, out i)))
            {
                txbQ.Text = "0";
                qMov = 0;

            }
            qMov = int.Parse(txbQ.Text);
            if ((opMov != ""))
            {
                checkMovOp();
            }
        }

        /*********************************************************/

        private void txbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            opMov = txbOp.Text;
            if ((opMov != ""))
            {
                checkMovOp();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*********************************************************/

        private void btnEntreEstoq_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrarMovEstoques frmMovEstoques = new frmCadastrarMovEstoques();

            frmMovEstoques.ShowDialog();
            this.Close();



        }

        /*********************************************************/






































    }
}
