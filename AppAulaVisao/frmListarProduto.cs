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
    public partial class frmListarProduto : Form
    {

        //VARIÁVEIS GLOBAIS
        static String tipoListar;


        /*********************************************************/
        //INIT

        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Produto> listaDeProduto = new List<Produto>();

        public frmListarProduto()
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

            /*/
            foreach (Produto produto in listaDeProduto)
            {
                dgvVisualizarListar.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }
            /*/

            //PARA INICIAR COM UMA LISTA DE PRODUTOS
            tipoListar = "prod";
            checkTipo(tipoListar);
        }

        /*********************************************************/
        //FECHAR JANELA/VOLTAR

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Close();
            home.BringToFront();
        }

        /*********************************************************/
        // CLICAR EM CONTEÚDO DA CÉLULA DA GRID

        private void dgvVisualizarProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //OLD
            //int cod = int.Parse(dgvVisualizarProd.SelectedRows[0].Cells[0].Value.ToString());

            var campos = dgvVisualizarListar.SelectedCells.Count;
            Produto produtoEscolhido = new Produto();

            if (campos > 0)
            {
                int selectedrowindex = dgvVisualizarListar.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVisualizarListar.Rows[selectedrowindex];

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


                //Fazer a busca por código para preencher a grid com semelhantes
                ProdutoCtrl ProdutoCtrl = new ProdutoCtrl(); // Abre o Controller pra fazer a busca
                List<Produto> produtosEncontrados = new List<Produto>(); // Cria uma nova lista com os produtos encontrados na busca
                produtosEncontrados = ProdutoCtrl.buscarProdutoDaListaPorCodigo(produtoEscolhido.dadosCODIGO);


                //Abrir o novo form com a grid encontrada
                frmVisualizarAlterarProduto editarProduto = new frmVisualizarAlterarProduto();

                editarProduto.CarregarGrid(produtosEncontrados);
                editarProduto.carregarProdutoNaTela(produtoEscolhido);

                bool FormOpen = false;
                foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
                {
                    if (S is frmVisualizarAlterarProduto)
                    {
                        FormOpen = true;
                    }
                }
                if (FormOpen == true)
                {
                    editarProduto.BringToFront();
                }
                else
                {
                    editarProduto.ShowDialog();
                }
                /*/
                //Checar se Form já está aberto e impedir que abra mais de um
                if (!editarProduto.Visible) { editarProduto.Show(); }
                    else { editarProduto.BringToFront(); }
                /*/


            }

            //Fazer a busca por código
            // Produto produto = buscarProduto(cod);

            //VAI PASSAR PARA O EDITA AQUI
            //carregarProdutoNaTela(produto);
        }
       
        /*********************************************************/
        // ATUALIZAR LISTA

        private void atualizar_Lista()
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            produtoCtrl.lerArquivo();
            CarregarGrid();
            //dgvVisualizarProd.Refresh();
        }


        /*********************************************************/
        // FAZER A BUSCA POR NOME

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
        /*/

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

        /*/

        /*********************************************************/
        // É necessário?

            /*/
        private void dgvVisualizarProd_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        /*/


        /*********************************************************/
        //LIMPA A GRID E CHAMA O ATUALIZAR

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            //dgvVisualizarProd.DataSource = "";
            //dgvVisualizarProd.DataSource = null;
            dgvVisualizarListar.Rows.Clear();
            // dgvVisualizarProd.DataBind();
            atualizar_Lista();
        }

        /*********************************************************/
        //CHAMA O CONSULTAR

        private void btnConsultar_Click(object sender, EventArgs e)
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
        //ABRIR O CADASTRAR

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto cadastrar = new frmCadastrarProduto();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmCadastrarProduto)
                {
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                cadastrar.BringToFront();
            }
            else
            {
                cadastrar.ShowDialog();
            }

            /*/
            //Checar se Form já está aberto e impedir que abra mais de um
            if (!cadastrar.                ) { cadastrar.Show(); }
            else { cadastrar.BringToFront(); }
            
            /*/
            //this.Close();
        }

        /*********************************************************/
        //CHECAR QUAL TIPO DE RELATÓRIO É

        public void checkTipo(String tipoDeRel)
        {
            if (tipoDeRel == "mov")
            {
                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                List<Movimentacao> movsEncon = estoqueCtrl.getMov();
                CarregarGridMov(movsEncon);

            }
            else if (tipoDeRel == "prod")
            {
                ProdutoCtrl produtoCtrl = new ProdutoCtrl();
                List<Produto> prodEncon = produtoCtrl.getProdutos();
                CarregarGridProd(prodEncon);
            }
            else if (tipoDeRel == "estoq")
            {
                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                List<Estoque> estoqEncon = estoqueCtrl.getEstoques();
                CarregarGridEstoq(estoqEncon);
            }
            else if (tipoDeRel == "movcomp")
            {
                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                List<MovComp> estoqEncon = estoqueCtrl.getMovComp();
                CarregarGridMovComp(estoqEncon);
            }

        }


        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGridMov(IEnumerable<Movimentacao> dadosEncontrados)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            //String caminhoArquivos = controle.dadosCaminhoArquivos;
            String[] headerMov = estoqueCtrl.getHeaderMov();

            dgvVisualizarListar.ColumnCount = headerMov.Count();
            dgvVisualizarListar.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerMov)
            {
                //dgvVisualizarListar.Columns.Add(prop);
                dgvVisualizarListar.Columns[index].Name = prop;
                index++;
            }

            /*/
            if (dadosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeMov = dadosEncontrados; // Se veio, preenche a grid com o resultado
            }
            /*/
            dgvVisualizarListar.Rows.Clear();
            foreach (Movimentacao m in dadosEncontrados)
            {
                //int cont =+ 1;
                dgvVisualizarListar.Rows.Add(m.movCODIGO, m.movESTOQUECOD, m.movPRODUTOCOD, m.movDETALHES, m.movOPERACAO, m.movQUANTIDADE, m.movQPRODTOTAL, m.movQTOTAL, m.movDATA);

            }
        }



        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGridProd(IEnumerable<Produto> dadosEncontrados)
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            String[] headerProd = produtoCtrl.getHeaderProd();


            dgvVisualizarListar.ColumnCount = headerProd.Count();
            dgvVisualizarListar.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerProd)
            {
                //dgvVisualizarListar.Columns.Add(prop);
                dgvVisualizarListar.Columns[index].Name = prop;
                index++;
            }
            dgvVisualizarListar.Rows.Clear();
            foreach (Produto produto in dadosEncontrados)
            {
                //int cont =+ 1;
                dgvVisualizarListar.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }
          }


        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA


        public void CarregarGridEstoq(IEnumerable<Estoque> dadosEncontrados)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            String[] headerEstoq = estoqueCtrl.getHeaderEstoq();


            dgvVisualizarListar.ColumnCount = headerEstoq.Count();
            dgvVisualizarListar.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerEstoq)
            {
                //dgvVisualizarListar.Columns.Add(prop);
                dgvVisualizarListar.Columns[index].Name = prop;
                index++;
            }
            dgvVisualizarListar.Rows.Clear();
            foreach (Estoque e in dadosEncontrados)
            {
                //int cont =+ 1;
                dgvVisualizarListar.Rows.Add(e.estoqueCODIGO, e.estoqueLOCAL, e.estoqueDETALHES, e.estoqueQUANTIDADE, e.estoqueDATA);
            }
        }

        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGridMovComp(IEnumerable<MovComp> dadosEncontrados)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            String[] headerMovComp = estoqueCtrl.getHeaderMovComp();


            dgvVisualizarListar.ColumnCount = headerMovComp.Count();
            dgvVisualizarListar.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerMovComp)
            {
                //dgvVisualizarListar.Columns.Add(prop);
                dgvVisualizarListar.Columns[index].Name = prop;
                index++;
            }
            dgvVisualizarListar.Rows.Clear();
            foreach (MovComp e in dadosEncontrados)
            {
                //int cont =+ 1;
                dgvVisualizarListar.Rows.Add(e.mov_CODIGO, e.mov_DETALHES, e.mov_OPERACAO, e.mov_QUANTIDADE, e.mov_DATA, e.produto_CODIGO,
                          e.produto_PRODUTO, e.produto_DIMENSOES, e.produto_DETALHES, e.produto_QUANTIDADE, e.produto_VALOR, e.produto_VALORTOTAL,
                          e.produto_SERIE, e.produto_NOTAFISCAL, e.produto_SEQ, e.produto_FORNECEDOR, e.produto_COMPLEMENTO,
                          e.produto_STATUS, e.estoque_CODIGO, e.estoque_LOCAL, e.estoque_DETALHES, e.estoque_QUANTIDADE
                          );
            }

        }


        /*********************************************************/
        //  BOTÕES DE LISTAR

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            tipoListar = "prod";
            checkTipo(tipoListar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoListar = "estoq";
            checkTipo(tipoListar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoListar = "mov";
            checkTipo(tipoListar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipoListar = "movcomp";
            checkTipo(tipoListar);
        }


        /*********************************************************/
    }
}
