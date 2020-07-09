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
    public partial class frmCadastrarMovEstoques : Form
    {
        static Estoque estoqueEscolhido, estoqueEscolhidoOLD;
        static Produto produtoEscolhido;
        static int qProdEstoque, qProdEstoqueOLD; //QUANTIDADE DE PRODUTO NO ESTOQUE
        static int qMov; //QUANTIDADE DA MOVIMENTAÇÃO
        static int qTot, qTotOLD; // QUANTIDADE TOTAL DE ITENS NO ESTOQUE
        static String opMov = "SERVICO";
        static int qProdTotal; //QUANTIDADE TOTAL DE PRODUTO NO BANCO


        /*********************************************************/
        // INIT
        public frmCadastrarMovEstoques()
        {
            InitializeComponent();
        }


        /*********************************************************/

        private void frmCadastrarMovEstoques_Load(object sender, EventArgs e)
        {
            txbQ.Text = "Selecione produtos/estoques antes";
            txbCodigo.Text = geradorCod();
            txbDetalhes.Text = "Movimentação feita entre estoques. \r\n";
            txbOp.Text = opMov;


            EstoqueCtrl EstoqueCtrl = new EstoqueCtrl();

            //Preenchendo o combobox de Estoque DESTINO
            var estoquesLista = EstoqueCtrl.getEstoques();

            txbNomeEstoq.DisplayMember = "estoqueLOCAL";
            txbCodEstoq.DisplayMember = "estoqueCODIGO";

            txbNomeEstoq.DataSource = estoquesLista;
            txbCodEstoq.DataSource = estoquesLista;

            txbNomeEstoq.SelectedIndex = -1;
            txbCodEstoq.SelectedIndex = -1;

            //Preenchendo o combobox de Estoque ORIGEM
            var estoquesListaOLD = EstoqueCtrl.getEstoques();

            txbNomeEstoqOLD.DisplayMember = "estoqueLOCAL";
            txbCodEstoqOLD.DisplayMember = "estoqueCODIGO";

            txbNomeEstoqOLD.DataSource = estoquesListaOLD;
            txbCodEstoqOLD.DataSource = estoquesListaOLD;

            txbNomeEstoqOLD.SelectedIndex = -1;
            txbCodEstoqOLD.SelectedIndex = -1;


            listaProd_Load();

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


        private void listaProd_Load()
        {
            if (estoqueEscolhidoOLD != null)
            {
                //LISTA DE PRODUTO DEVERÁ SER BASEADA NO ESTOQUE ORIGEM ESCOLHIDO
                //Preenchendo o combobox de Produto 
                ProdutoCtrl produtoCtrl = new ProdutoCtrl();
                var produtoLista = produtoCtrl.consultarProdEmEstoqueDIST(estoqueEscolhidoOLD.estoqueCODIGO);

                txbNomeProd.DisplayMember = "dadosPRODUTO";
                txbCodProd.DisplayMember = "dadosCODIGO";

                txbNomeProd.DataSource = produtoLista;
                txbCodProd.DataSource = produtoLista;

                txbNomeProd.SelectedIndex = -1;
                txbCodProd.SelectedIndex = -1;

            }
            else //SE ESTOQUE NÃO ESTIVER SIDO ESCOLHIDO AINDA
            {
                txbNomeProd.DisplayMember = "Escolha um estoque de origem primeiro";
            }

        }





        /*********************************************************/
        // MUDAR OS COMBOBOX PARA CADA ESCOLHA DE PRODUTO

        private void txbCodProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            produtoEscolhido = ((txbCodProd as ComboBox).SelectedItem as Produto);
            if (produtoEscolhido != null)
            {
                txbNomeProd.Text = (produtoEscolhido.dadosPRODUTO).ToString();
                txbNomeProd.SelectedItem = "dadosPRODUTO";

                checkMovComp(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
                checkMovCompOLD();
                checkEstoqsProd();
            }

        }

        private void txbNomeProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            produtoEscolhido = ((txbNomeProd as ComboBox).SelectedItem as Produto);
            if (produtoEscolhido != null)
            {
                txbCodProd.Text = (produtoEscolhido.dadosCODIGO).ToString();
                txbCodProd.SelectedItem = "dadosCODIGO";
                //txbCodProd.DisplayMember = "dadosCODIGO";

                checkMovComp(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
                checkMovCompOLD();
                checkEstoqsProd();
            }
        }


        /*********************************************************/
        // MUDAR OS COMBOBOX PARA CADA ESCOLHA DE ESTOQUE DESTINO

        private void txbCodEstoq_SelectedIndexChanged(object sender, EventArgs e)
        {
            estoqueEscolhido = ((txbCodEstoq as ComboBox).SelectedItem as Estoque);
            if (estoqueEscolhido != null)
            {
                txbNomeEstoq.Text = (estoqueEscolhido.estoqueLOCAL).ToString();
                txbNomeEstoq.SelectedItem = "estoqueLOCAL";
             
                txbQtotal.Text = (estoqueEscolhido.estoqueQUANTIDADE).ToString();
                qTot = estoqueEscolhido.estoqueQUANTIDADE;

                checkMovComp(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
                checkEstoqsProd();
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

                checkMovComp(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
                checkEstoqsProd();
            }
        }

        /*********************************************************/
        // MUDAR OS COMBOBOX PARA CADA ESCOLHA DE ESTOQUE ORIGEM

        private void txbCodEstoqOLD_SelectedIndexChanged(object sender, EventArgs e)
        {

            estoqueEscolhidoOLD = ((txbCodEstoqOLD as ComboBox).SelectedItem as Estoque);
            if (estoqueEscolhidoOLD != null)
            {
                txbNomeEstoqOLD.Text = (estoqueEscolhidoOLD.estoqueLOCAL).ToString();
                txbNomeEstoqOLD.SelectedItem = "estoqueLOCAL";

                txbQtotalOLD.Text = (estoqueEscolhidoOLD.estoqueQUANTIDADE).ToString();
                qTotOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

                checkMovCompOLD(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
            }
            listaProd_Load();
            checkEstoqsProd();
        }

        private void txbNomeEstoqOLD_SelectedIndexChanged(object sender, EventArgs e)
        {

            estoqueEscolhidoOLD = ((txbNomeEstoqOLD as ComboBox).SelectedItem as Estoque);
            if (estoqueEscolhidoOLD != null)
            {
                txbCodEstoqOLD.SelectedItem = "estoqueCODIGO";
                txbCodEstoqOLD.DisplayMember = "estoqueCODIGO";

                txbQtotalOLD.Text = (estoqueEscolhidoOLD.estoqueQUANTIDADE).ToString();
                qTotOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

                checkMovCompOLD(); // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
            }
            listaProd_Load();
            checkEstoqsProd();
        }


        /*********************************************************/
        // CHECA A ÚLTIMA MOVIMENTAÇÃO COMPLETA DO PRODUTO E ESTOQUE ESCOLHIDO

        private void checkMovComp() // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
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
                    txbQProdEstoq.Text = (movCompEncontrada.mov_QPRODESTOQ).ToString();
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

        private void checkMovCompOLD() // ESSE CHECK PESQUISARÁ SOBRE O ESTOQUE NOVO
        {
            if ((produtoEscolhido != null) && (estoqueEscolhidoOLD != null)) //Só busca se PRODUTO e ESTOQUE já tiverem sido escolhidos
            {
                String codProd = produtoEscolhido.dadosCODIGO;
                String codEstoq = estoqueEscolhidoOLD.estoqueCODIGO;

                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                //List<Produto> listaMov
                List<MovComp> listaMovComp = estoqueCtrl.MovCompComEstoqueProduto(codProd, codEstoq);

                if (listaMovComp.Count() != 0) // SE A LISTA RETORNOU ALGO, PEGARÁ O PRIMEIRO
                {
                    MovComp movCompEncontrada = listaMovComp.First();
                    txbQProdEstoqOLD.Text = (movCompEncontrada.mov_QPRODESTOQ).ToString();
                    qProdEstoqueOLD = movCompEncontrada.mov_QPRODESTOQ;

                    qTotOLD = movCompEncontrada.estoque_QUANTIDADE; //QUANTIDADE DE ITENS NO ESTOQUE
                    qProdTotal = movCompEncontrada.produto_QUANTIDADE; //QUANTIDADE TOTAL DO PRODUTO



                }
                else //SE CHECAR A LISTA E NÃO TIVER NADA
                {
                    txbQProdEstoqOLD.Text = "";
                    qProdEstoqueOLD = 0;
                }
            }
        }


        /*********************************************************/
        // CHECA OPERAÇÃO E ATUALIZA OS VALORES NA TELA

        private void checkMovOp()
        {
            if ((qProdEstoqueOLD != 0) || (qMov != 0)) //Só busca se PRODUTO e ESTOQUE já tiverem sido escolhidos
            {
                //int qMoviment = 0;
                int estoqueTotal = estoqueEscolhido.estoqueQUANTIDADE;
                int estoqueTotalOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

                int qMoviment = qProdEstoque + qMov; //SOMA NO NOVO
                int qMovimentOLD = qProdEstoqueOLD - qMov; //DIMINUI DO ANTIGO

                txbQProdEstoq.Text = qMoviment.ToString();
                txbQProdEstoqOLD.Text = qMovimentOLD.ToString();

                qTot = estoqueTotal + qMov; //SOMA NO NOVO
                qTotOLD = estoqueTotalOLD - qMov; //DIMINUI DO ANTIGO

                txbQtotal.Text = qTot.ToString();
                txbQtotalOLD.Text = qTotOLD.ToString();


                if ((qMovimentOLD < 0) && (qTotOLD < 0)) //CHECAR SE O VALOR FICA NEGATIVO NO ORIGEM
                {
                    checkNegativo();
                }
                else if ((qMovimentOLD < 0) && (qTotOLD >= 0))
                {
                    DialogResult dialogResult = MessageBox.Show("Não há produtos suficientes no estoque de origem para esta movimentação. \r\nTem certeza que quer continuar a operação? \r\nA movimentação será subtraída da quantidade total do estoque.", "Atenção!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        qMoviment = qProdEstoque + qMov; //SOMA NO NOVO
                        txbQProdEstoq.Text = qMoviment.ToString();
                        txbQProdEstoqOLD.Text = (0).ToString();

                        qTot = estoqueTotal + qMov; //SOMA NO NOVO
                        qTotOLD = estoqueTotalOLD - qMov; //DIMINUI DO ANTIGO

                        txbQtotal.Text = qTot.ToString();
                        txbQtotalOLD.Text = qTotOLD.ToString();

                        if (qTotOLD < 0) //CHECAR SE O VALOR FICA NEGATIVO NO ORIGEM
                        {
                            checkNegativo();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        checkNegativo();
                    }
                }

            } else if (qMov == 0)
            {
                //Não faz nada e reseta
                int estoqueTotal = estoqueEscolhido.estoqueQUANTIDADE;
                int estoqueTotalOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

                qMov = 0;
                txbQ.Text = "0";
                txbQProdEstoq.Text = qProdEstoque.ToString();
                txbQProdEstoqOLD.Text = qProdEstoque.ToString();
                qTot = 0;
                qTotOLD = 0;
                txbQtotal.Text = estoqueTotal.ToString();
                txbQtotalOLD.Text = estoqueTotal.ToString();
            }

            else //Se não tiver itens no estoque origem
            {
                DialogResult dialogResult = MessageBox.Show("Não há produtos suficientes no estoque de origem para esta movimentação. \r\nTem certeza que quer continuar a operação? \r\nA movimentação será subtraída da quantidade total do estoque.", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int estoqueTotal = estoqueEscolhido.estoqueQUANTIDADE;
                    int estoqueTotalOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

                    int qMoviment = qProdEstoque + qMov; //SOMA NO NOVO
                    txbQProdEstoq.Text = qMoviment.ToString();
                    txbQProdEstoqOLD.Text = (0).ToString();

                    qTot = estoqueTotal + qMov; //SOMA NO NOVO
                    qTotOLD = estoqueTotalOLD - qMov; //DIMINUI DO ANTIGO

                    txbQtotal.Text = qTot.ToString();
                    txbQtotalOLD.Text = qTotOLD.ToString();

                    if (qTotOLD < 0) //CHECAR SE O VALOR FICA NEGATIVO NO ORIGEM
                    {
                        checkNegativo();
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    checkNegativo();
                }


            }
        }

        /*********************************************************/
        //ENTRA SE A QUANTIDADE TOTAL FOR NEGATIVO

        private void checkNegativo()
        {
            MessageBox.Show("Não há produtos suficientes no estoque de origem para esta movimentação. \r\nQuantidade Total não pode ser nagativa.", "Atenção!");

            int estoqueTotal = estoqueEscolhido.estoqueQUANTIDADE;
            int estoqueTotalOLD = estoqueEscolhidoOLD.estoqueQUANTIDADE;

            qMov = 0;
            txbQ.Text = "0";
            txbQProdEstoq.Text = qProdEstoque.ToString();
            txbQProdEstoqOLD.Text = qProdEstoque.ToString();
            qTot = 0;
            qTotOLD = 0;
            txbQtotal.Text = estoqueTotal.ToString();
            txbQtotalOLD.Text = estoqueTotal.ToString();
        }

        /*********************************************************/
        // SALVA A MOVA MOVIMENTAÇÃO

        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            Boolean okMov, okEstoqOr, okEstoqDes, okProd;
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();

            Movimentacao novaMov = new Movimentacao();
            novaMov.movCODIGO = txbCodigo.Text;
            novaMov.movESTOQUECOD = estoqueEscolhido.estoqueCODIGO;
            novaMov.movPRODUTOCOD = produtoEscolhido.dadosCODIGO;
            novaMov.movDETALHES = txbDetalhes.Text;
            novaMov.movOPERACAO = opMov;
            novaMov.movQUANTIDADE = qMov;
            novaMov.movQPRODESTOQ = qProdEstoque;
            novaMov.movQPRODTOTAL = qProdTotal;
            novaMov.movQTOTAL = qTot;
            novaMov.movDATA = DateTime.Parse(txbData.Text);

            okMov = estoqueCtrl.SalvarNovaMov(novaMov); //CHECA SE SALVOU A MOVIMENTAÇÃO


            Estoque estoqDestUpdate = new Estoque();
            estoqDestUpdate.estoqueCODIGO = estoqueEscolhido.estoqueCODIGO;
            estoqDestUpdate.estoqueLOCAL = estoqueEscolhido.estoqueLOCAL;
            estoqDestUpdate.estoqueDETALHES = estoqueEscolhido.estoqueDETALHES;
            estoqDestUpdate.estoqueQUANTIDADE = qTot;
            estoqDestUpdate.estoqueDATA = DateTime.Parse(txbData.Text);

            okEstoqDes = estoqueCtrl.alterarEstoque(estoqDestUpdate); //CHECA SE ALTEROU O ESTOQUE DESTINO


            Estoque estoqOrigUpdate = new Estoque();
            estoqOrigUpdate.estoqueCODIGO = estoqueEscolhidoOLD.estoqueCODIGO;
            estoqOrigUpdate.estoqueLOCAL = estoqueEscolhidoOLD.estoqueLOCAL;
            estoqOrigUpdate.estoqueDETALHES = estoqueEscolhidoOLD.estoqueDETALHES;
            estoqOrigUpdate.estoqueQUANTIDADE = qTotOLD;
            estoqOrigUpdate.estoqueDATA = DateTime.Parse(txbData.Text);

            okEstoqOr = estoqueCtrl.alterarEstoque(estoqOrigUpdate); //CHECA SE ALTEROU O ESTOQUE ORIGEM


            Produto produtoUpdate = new Produto();
            produtoUpdate.dadosCODIGO = produtoEscolhido.dadosCODIGO;
            produtoUpdate.dadosPRODUTO = produtoEscolhido.dadosPRODUTO;
            produtoUpdate.dadosDIMENSOES = produtoEscolhido.dadosDIMENSOES;
            produtoUpdate.dadosDETALHES = produtoEscolhido.dadosDETALHES;
            produtoUpdate.dadosOPERACAO = opMov; //ULTIMA OPERAÇÃO FEITA
            produtoUpdate.dadosMOVIMENTACAO = qMov; //ÚLTIMA MOVIMENTAÇÃO FEITA
            produtoUpdate.dadosQUANTIDADE = qProdEstoque; //QUANTIDADE TOTAL NO ESTOQUE
            produtoUpdate.dadosVALOR = produtoEscolhido.dadosVALOR;
            produtoUpdate.dadosVALORTOTAL = (produtoEscolhido.dadosVALOR) * qProdTotal; //VALOR TOTAL DA QUANTIDADE DE PRODUTOS
            produtoUpdate.dadosDATA = DateTime.Parse(txbData.Text);
            produtoUpdate.dadosSERIE = produtoEscolhido.dadosSERIE;
            produtoUpdate.dadosNOTAFISCAL = produtoEscolhido.dadosNOTAFISCAL;
            produtoUpdate.dadosSEQ = produtoEscolhido.dadosSEQ;
            produtoUpdate.dadosFORNECEDOR = produtoEscolhido.dadosFORNECEDOR;
            produtoUpdate.dadosCOMPLEMENTO = produtoEscolhido.dadosCOMPLEMENTO;
            produtoUpdate.dadosSTATUS = produtoEscolhido.dadosSTATUS;

            okProd = produtoCtrl.alterarProduto(produtoUpdate); //CHECA SE ALTEROU O PRODUTO


            if ((okMov == true)&&(okEstoqOr == true)&&(okEstoqDes == true)&&( okProd == true)) //CHECA SE TODOS ESTÃO APTOS A SEREM SALVOS
            {
                //DEVE SALVAR OS TRÊS JUNTOS
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
            //txbOp.SelectedIndex = -1;

            produtoEscolhido = null;
            qMov = 0;
            opMov = "";

            estoqueEscolhido = null;
            qProdEstoque = 0;
            qTot = 0;

            estoqueEscolhidoOLD = null;
            qProdEstoqueOLD = 0;
            qTotOLD = 0;


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

        private void txbQ_TextChanged(object sender, EventArgs e)
        {
            int i; // VALIDAR INT
            if ((txbQ.Text == null) || (txbQ.Text == "") || (!int.TryParse(txbQ.Text, out i)))
            {
                txbQ.Text = "0";
                qMov = 0;

            }
            qMov = int.Parse(txbQ.Text);
            //if ((qMov != 0))
            //{
                checkMovOp();
            //}
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


        private void checkEstoqsProd()
        {
            if (txbQ.Enabled == false)
            {
                if ((estoqueEscolhido != null) && (estoqueEscolhidoOLD != null) && (produtoEscolhido != null))
                {
                    txbQ.Clear();
                    txbQ.Enabled = true;
                }
                else
                {
                    txbQ.Text = "Selecione produtos/estoques antes";
                }
            }
        }




























    }
}

