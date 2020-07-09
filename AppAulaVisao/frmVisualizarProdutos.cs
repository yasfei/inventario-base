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
    public partial class frmVisualizarProdutos : Form
    {


        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Produto> listaDeProduto = new List<Produto>();
        //listaDeProduto = ArquivoCtrl.arquivoProdutos;


        /*********************************************************/
        // INIT

        public frmVisualizarProdutos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGrid()
        {

            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();
            //Chama o CarregarProduto do Controller que chama uma variável gobal de DAO (dados) 
            listaDeProduto = ProdutoCtrl.carregarProdutos();

            foreach (Produto produto in listaDeProduto)
            {
                dgvVisualizarProd.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }
        }

        /*********************************************************/
        // CARREGAR NO FORM

        private void frmVisualizarProdutos_Load(object sender, EventArgs e)
        {
            ProdutoCtrl ProdutoCtrl = new ProdutoCtrl();

            listaDeProduto = ProdutoCtrl.carregarProdutos();
            CarregarGrid();
            //gpbDados.Enabled = false;
        }

        /*********************************************************/
        // CARREGA DO FORM PARA UM PRODUTO

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
            produto.dadosVALORTOTAL = int.Parse(txbQuantidadeTotal.Text);
            produto.dadosSERIE = txbSerie.Text;
            produto.dadosDATA = DateTime.Parse(txbData.Text);
            produto.dadosNOTAFISCAL = txbNotaFiscal.Text;
            produto.dadosSEQ = txbSeq.Text;
            produto.dadosCOMPLEMENTO = txbComplemento.Text;

            produto.dadosSTATUS = txbStatus.Text;

            /*/
            if (produto.dadosSTATUS == true)
            {
                txbStatus.Text = "VALIDO";
            }
            else
            {
                txbStatus.Text = "INVALIDO";
            }
            /*/

        }

        /*********************************************************/
        //FECHAR E VOLTAR

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.BringToFront();
            this.Close();
        }

        /*********************************************************/
        // CLICAR EM ITEM ESPECÍFICO


        private void dgvVisualizarProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int cod = int.Parse(dgvVisualizarProd.SelectedRows[0].Cells[0].Value.ToString());
            
            string cod = dgvVisualizarProd.SelectedRows[0].Cells[0].Value.ToString();


            Produto produto = buscarProdutoDaLista(cod);

            carregarProdutoNaTela(produto);

        }

        /*********************************************************/
        // CARREGAR O PRODUTO NA TELA

        public void carregarProdutoNaTela(Produto produto)
        {

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

            //txbValor.Text = 

            /*/
            if (produto.dadosSTATUS == true)
            {
                txbStatus.Text = "VALIDO";
            }
            else
            {
                txbStatus.Text = "INVALIDO";
            }
            /*/
        }

        /*********************************************************/
        // FAZ A BUSCA QUANDO O PRODUTO É CLICADO NA GRID

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
        //FECHAR E VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)

        {
            frmHome home = new frmHome();
            home.BringToFront();
            this.Close();
        }

        /*********************************************************/


        private void dgvVisualizarProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*********************************************************/


        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        /*********************************************************/

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        //ABRE UMA NOVA TELA DE CONSULTA

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

    }
}
