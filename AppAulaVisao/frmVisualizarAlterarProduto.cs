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
    public partial class frmVisualizarAlterarProduto: Form
    {

        /*********************************************************/
        //VARIÁVEIS GLOBAIS

        //Produto ProdutoOLD = new Produto();
        static int qtotal; //Quantidade total
        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Produto> listaDeProduto = new List<Produto>();

        /*********************************************************/
        //INIT

        public frmVisualizarAlterarProduto()
        {
            InitializeComponent();
        }


        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGrid(IEnumerable<Produto> produtosEncontrados)
        {
            if (produtosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeProduto = produtosEncontrados; // Se veio, preenche a grid com o resultado

            } 

            foreach (Produto produto in listaDeProduto)
            {
                //int cont =+ 1;
                dgvVisualizarProd.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }
        }

        /*********************************************************/
        // SALVAR PRODUTO EDITADO


        private void btnSalvarNovoProduto_Click(object sender, EventArgs e)
        {
            /*/
            Produto produto = new Produto();
            CarregarProdutoDoForm(produto);

            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            //Boolean Alterou = produtoCtrl.alterarProdutoMockado(produto, listaDeProduto);

            if (Alterou == true)
            {
                MessageBox.Show("Produto salvo!");
                limparTela();
            }
            else
            {
                MessageBox.Show("O Produto não pôde ser salvo.");
            }
            /*/
        }


        /*********************************************************/
        // CLICAR EM UM PRODUTO DA GRID

        private void dgvVisualizarProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // int cod = int.Parse(dgvVisualizarProd.SelectedRows[0].Cells[0].Value.ToString());

            //PEGA O CÓDIGO DO ITEM CLICADO PARA COLOCAR NO FORM
            //string cod = dgvVisualizarProd.SelectedRows[0].Cells[0].Value.ToString();
            //DataGridViewRow row = dgvVisualizarProd.SelectedRows[0];
            var campos = dgvVisualizarProd.SelectedCells.Count;
            Produto produtoEscolhido = new Produto();

            if (campos > 0)
            {
                int selectedrowindex = dgvVisualizarProd.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvVisualizarProd.Rows[selectedrowindex];

                //DEVE HAVER UM MELHOR MÉTODO DE INDEXAR

                produtoEscolhido.dadosCODIGO = Convert.ToString(selectedRow.Cells["dadosCODIGO"].Value);
                produtoEscolhido.dadosPRODUTO = Convert.ToString(selectedRow.Cells["dadosPRODUTO"].Value);
                produtoEscolhido.dadosDIMENSOES = Convert.ToString(selectedRow.Cells["dadosDIMENSOES"].Value);
                produtoEscolhido.dadosDETALHES = Convert.ToString(selectedRow.Cells["dadosDETALHES"].Value);
                produtoEscolhido.dadosOPERACAO = Convert.ToString(selectedRow.Cells["dadosOPERACAO"].Value);
                produtoEscolhido.dadosMOVIMENTACAO = int.Parse(Convert.ToString(selectedRow.Cells["dadosMOVIMENTACAO"].Value));
                produtoEscolhido.dadosQUANTIDADE = int.Parse(Convert.ToString(selectedRow.Cells["dadosQUANTIDADE"].Value));
                produtoEscolhido.dadosVALOR = float.Parse(Convert.ToString(selectedRow.Cells["dadosVALOR"].Value));
                produtoEscolhido.dadosVALORTOTAL = float.Parse(Convert.ToString(selectedRow.Cells["dadosVALORTOTAL"].Value));
                produtoEscolhido.dadosDATA = Convert.ToDateTime(selectedRow.Cells["dadosDATA"].Value);
                produtoEscolhido.dadosSERIE = Convert.ToString(selectedRow.Cells["dadosSERIE"].Value);
                produtoEscolhido.dadosNOTAFISCAL = Convert.ToString(selectedRow.Cells["dadosNOTAFISCAL"].Value);
                produtoEscolhido.dadosSEQ = Convert.ToString(selectedRow.Cells["dadosSEQ"].Value);
                produtoEscolhido.dadosFORNECEDOR = Convert.ToString(selectedRow.Cells["dadosFORNECEDOR"].Value);
                produtoEscolhido.dadosCOMPLEMENTO = Convert.ToString(selectedRow.Cells["dadosCOMPLEMENTO"].Value);
                produtoEscolhido.dadosSTATUS = Convert.ToString(selectedRow.Cells["dadosSTATUS"].Value);



                carregarProdutoNaTela(produtoEscolhido);
                /*/
                for (int i = 0; i > campos; i++)
                {
                    string a = Convert.ToString(selectedRow.Cells[i].Value);

                }
                /*/
            }


            /*/
            Produto produto = buscarProdutoDaLista(cod);
            produto = buscarProdutoDaLista(cod);
            carregarProdutoNaTela(produto);
        /*/
        }



        /*********************************************************/
        //VAI CARREGAR UM PRODUTO DA GRID PARA O FORM PARA SER ALTERADO

        public void carregarProdutoNaTela(Produto produto) 
        {
            try {
                txbCodigo.Text = produto.dadosCODIGO;
                txbNome.Text = produto.dadosPRODUTO;
                txbQuantidade.Text = (produto.dadosQUANTIDADE).ToString();
                txbValor.Text = (produto.dadosVALOR).ToString();
                txbDimensoes.Text = produto.dadosDIMENSOES;
                txbDetalhes.Text = produto.dadosDETALHES;

                cbOperacao.Text = produto.dadosOPERACAO;
                txbMovimentacao.Text = (produto.dadosMOVIMENTACAO).ToString();
                txbFornecedor.Text = produto.dadosFORNECEDOR;
                txbValorTotal.Text = (produto.dadosVALORTOTAL).ToString();
                txbSerie.Text = produto.dadosSERIE;
                txbData.Text = (produto.dadosDATA).ToString();
                txbNotaFiscal.Text = produto.dadosNOTAFISCAL;
                txbSeq.Text = produto.dadosSEQ;
                txbComplemento.Text = produto.dadosCOMPLEMENTO;

                txbStatus.Text = produto.dadosSTATUS;

                
                txbQuantidadeTotal.Text = (qtotal).ToString();
                checkMovimentacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception source: {0}", ex.Source);
                
                //Não conseguiu definir os campos
            }

            /*/
            if (produto.dadosSTATUS == true)
            {
                txbStatus.Text = "VALIDO";
            }
            else
            {
                txbStatus.Text = "INVALIDO";
            }/*/
        }


        /*********************************************************/
        //VAI CARREGAR DO FORM PARA UM PRODUTO

        private void CarregarProdutoDoForm(Produto produto) 
        {
            produto.dadosCODIGO = txbCodigo.Text;
            produto.dadosPRODUTO = txbNome.Text;
            produto.dadosQUANTIDADE = int.Parse(txbQuantidade.Text);
            produto.dadosVALOR = float.Parse(txbValor.Text);
            produto.dadosDIMENSOES = txbDimensoes.Text;
            produto.dadosDETALHES = txbDetalhes.Text;

            produto.dadosFORNECEDOR = txbFornecedor.Text;
            produto.dadosOPERACAO = cbOperacao.Text;
            produto.dadosMOVIMENTACAO = int.Parse(txbMovimentacao.Text);
            produto.dadosQUANTIDADE = int.Parse(txbQuantidadeTotal.Text);
            produto.dadosVALORTOTAL = float.Parse(txbQuantidadeTotal.Text);
            produto.dadosSERIE = txbSerie.Text;
            produto.dadosDATA = DateTime.Parse(txbData.Text);
            produto.dadosNOTAFISCAL = txbNotaFiscal.Text;
            produto.dadosSEQ = txbSeq.Text;
            produto.dadosCOMPLEMENTO = txbComplemento.Text;

           
            produto.dadosSTATUS = txbStatus.Text;

        }


        /*********************************************************/
        // CHAMA A BUSCA DE UM PRODUTO PELO SEU CÓDIGO

        public Produto buscarProdutoDaLista(string _codigo) 
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            if (listaDeProduto == null)
            {
                listaDeProduto = produtoCtrl.carregarProdutos();
            }

            return produtoCtrl.buscarProdutoDaLista(_codigo);

            //return produtoCtrl.buscarProdutoDaListaMockada(_codigo, listaDeProduto);

        }

        /*********************************************************/
        //O CONSULTA PRODUTO QUE FARÁ AS BUSCAS



/*/
        public Produto buscarProdutoDaListaPorNome(string _nome)
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            if (listaDeProduto == null || listaDeProduto.Count == 0)
            {
                listaDeProduto = produtoCtrl.carregarProdutos();
            }
            return produtoCtrl.buscarProdutoDaListaPorNome(_nome);
        }

        /*********************************************************/


/*/
        public Produto buscarProdutoDaListaPorCodigoEPorNome(string _cod, string _nome)
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            if (listaDeProduto == null || listaDeProduto.Count == 0)
            {
                listaDeProduto = produtoCtrl.carregarProdutos();
            }
            return produtoCtrl.buscarProdutoDaListaPorCodigoEPorNome(_cod, _nome);
        }


        /*********************************************************/
        //LOAD (É NECESSÁRIO?)


        private void frmVisualizarAlterarProduto_Load_1(object sender, EventArgs e)
        {
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            listaDeProduto = ProdutoCtrl.carregarProdutos();
            CarregarGrid(listaDeProduto);
        }


        /*********************************************************/
        //LIMPAR TELA

        private void limparTela()
        {
            txbCodigo.Text = "";
            txbNome.Text = "";
            //txbStatus.Text = "";
            txbQuantidade.Text = "";
            txbValor.Text = "";
            txbDimensoes.Text = "";
            txbDetalhes.Text = "";

            cbOperacao.Text = "";
            txbMovimentacao.Text = "";
            txbFornecedor.Text = "";
            txbQuantidadeTotal.Text = "";
            txbValorTotal.Text = "";
            txbSerie.Text = "";
            txbData.Text = "";
            txbNotaFiscal.Text = "";
            txbSeq.Text = "";
            txbComplemento.Text = "";

        }


        /*********************************************************/
        //VAI CHAMAR O CHECKMOVIMENTAÇÃO

        private void checkMovimentacao_TextChanged(object sender, EventArgs e)
        {
            checkMovimentacao();
        }


        /*********************************************************/
        //QUANDO MOVIMENTAÇÃO/VALOR/OPERAÇÃO FOR MODIFICADO, O VALORTOTAL E QUANTIDADETOTAL DEVERÃO SER ATUALIZADOS

        private void checkMovimentacao()
        {

            //Control control = (Control)sender;
            double valorUnit, vtotal;
            int quant, moviment, qtotalinit; // qtotal é global
            string operacao;


            try {
                //TESTANDO SE QUANTIDADE ESTÁ PREENCHIDO
                if ((txbQuantidade != null) && (txbQuantidade.Text != "0"))
                {
                    quant = int.Parse(txbQuantidade.Text);
                } else
                { valorUnit = 0; quant = 0; qtotalinit = 0; }

                //TESTANDO SE QUANTIDADETOTAL ESTÁ PREENCHIDO
                if ((txbQuantidadeTotal != null) && (txbQuantidadeTotal.Text != "0"))
                {
                    qtotalinit = int.Parse(txbQuantidadeTotal.Text);
                } else
                { qtotalinit = quant; }

                //TESTANDO SE VALOR UNITÁRIO ESTÁ PREENCHIDO
                if ((txbValor != null) && (txbValor.Text != "0"))
                {
                    valorUnit = double.Parse(txbValor.Text);
                } else
                { valorUnit = 0; vtotal = 0; }

                //TESTANDO SE MOVIMENTACAO ESTÁ PREENCHIDO
                if ((txbMovimentacao != null) && (txbMovimentacao.Text != "0"))
                {
                    moviment = int.Parse(txbMovimentacao.Text);
                    //value.ToString("C"); //OutPut : $12345.12
                } else
                { moviment = 0;
                    operacao = "NENHUMA"; }


                //TESTANDO SE OPERACAO ESTÁ PREENCHIDO
                if ((cbOperacao != null) && (cbOperacao.Text != "NENHUMA"))
                {
                    operacao = null;

                    if (cbOperacao.Text == "ENTRADA DE FORNECEDOR")
                    {
                        operacao = "COMPRA"; // QuantidadeTotal = QuantidadeTotal + Movimentação
                        qtotal = qtotalinit + moviment;
                    }
                    else {
                        if (cbOperacao.Text == "VENDA DE MERCADORIAS")
                        {
                            operacao = "VENDA"; // QuantidadeTotal = QuantidadeTotal - Movimentação
                            qtotal = qtotalinit - moviment;
                        }
                        else {
                            if (cbOperacao.Text == "DEMONSTRACAO")
                            {
                                operacao = "DEMO"; // QuantidadeTotal = QuantidadeTotal - Movimentação
                                qtotal = qtotalinit - moviment;
                            }
                            else {
                                if (cbOperacao.Text == "SERVICO")
                                {
                                    operacao = "REPARO"; // QuantidadeTotal = QuantidadeTotal + Movimentação
                                    qtotal = qtotalinit + moviment;
                                }
                            }
                        }
                    }
                    qtotalinit = 0;
                }
                else {
                    moviment = 0;
                    operacao = "NENHUMA";
                }


                //TESTANDO SE OPERACAO ESTÁ PREENCHIDO (PELO MÉTODO DE OUTRA FUNÇÃO)
                // var qtotalOperacao = checkOperacao(qtotal, moviment);
                //qtotal = qtotalOperacao.Key;
                // operacao = qtotalOperacao.Value;



                //FAZENDO OS CÁLCULOS

                if ((operacao != "NENHUMA") || (operacao != null))
                {
                    vtotal = qtotal * valorUnit;
                    txbValorTotal.Text = vtotal.ToString("C"); //OutPut : $12345.12
                    txbQuantidadeTotal.Text = qtotal.ToString();
                    qtotal = 0;

                } else {
                    vtotal = quant * valorUnit;
                    txbValorTotal.Text = vtotal.ToString("C"); //OutPut : $12345.12
                    txbQuantidadeTotal.Text = qtotal.ToString();
                    qtotal = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception source: {0}", ex.Source);
            }
        }

        /*********************************************************/
        // VOLTAR

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Activate();
            this.Close();
            //home.BringToFront();
        }
        
        /*********************************************************/
        // LIMPAR TELA

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        /*********************************************************/
        // CONSULTAR NOVO

        private void btnConsultarNovoProduto_Click(object sender, EventArgs e)
        {
            frmConsultarProduto novaConsulta = new frmConsultarProduto();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmConsultarProduto)
                {
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                novaConsulta.BringToFront();
            }
            else
            {
                novaConsulta.ShowDialog();
            }

            /*/
            //Checar se Form já está aberto e impedir que abra mais de um
            if (!novaConsulta.Visible) { novaConsulta.Show(); }
            else { novaConsulta.BringToFront(); }
            /*/
        }

        /*********************************************************/
        // PARA USAR NO TESTE DE OPERACAO (PELO MÉTODO DE OUTRA FUNÇÃO)

        /*/
        private KeyValuePair<int, string> checkOperacao(int quanttotal, int moviment)
        {

            string operacao;
            int total;

            if ((cbOperacao != null) && (cbOperacao.Text != "NENHUMA"))
            {
                operacao = null;

                if (cbOperacao.Text == "ENTRADA DE FORNECEDOR")
                {
                    operacao = "COMPRA"; // QuantidadeTotal = QuantidadeTotal + Movimentação
                    total = quanttotal + moviment;
                }
                else {
                    if (cbOperacao.Text == "VENDA DE MERCADORIAS")
                    {
                        operacao = "VENDA"; // QuantidadeTotal = QuantidadeTotal - Movimentação
                        total = quanttotal - moviment;
                    }
                    else {
                        if (cbOperacao.Text == "DEMONSTRACAO")
                        {
                            operacao = "DEMO"; // QuantidadeTotal = QuantidadeTotal - Movimentação
                            total = quanttotal - moviment;
                        }
                        else {
                            if (cbOperacao.Text == "SERVICO")
                            {
                                operacao = "REPARO"; // QuantidadeTotal = QuantidadeTotal + Movimentação
                                total = quanttotal + moviment;
                            }
                        }
                    }
                }
            }
            else {
                moviment = 0;
                operacao = "NENHUMA";
                total = quanttotal;
            }

            return new KeyValuePair<int, string>(total, operacao);


        }
        /*/

        /*********************************************************/

    }


}
