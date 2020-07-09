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
    public partial class frmRelatorioPreview : Form
    {

        /*********************************************************/
        //INIT

        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Produto> listaDeProd = new List<Produto>();
        IEnumerable<Estoque> listaDeEstoq = new List<Estoque>();
        IEnumerable<Movimentacao> listaDeMov = new List<Movimentacao>();
        IEnumerable<MovComp> listaDeMovComp = new List<MovComp>();

        public frmRelatorioPreview()
        {
            InitializeComponent();
            //CarregarGrid();
        }


        /*********************************************************/
        //LOAD FORM
        
        private void frmRelatorioPreview_Load(object sender, System.EventArgs e)
        {
            // set to your font you want.
            //this.dgvVisualizarRel.DefaultCellStyle.Font = new Font("Lucida Sans Unicode", 8);
        }
        
      
        /*********************************************************/
        //CHECAR QUAL TIPO DE RELATÓRIO É

        public void checkTipo(dynamic dadosEncontrados, String tipoDeRel, String nomeLocal, String nomeRel, Boolean _Status, Boolean _Header)
        {
            String Status, Header;
            if (_Status == false)
            {
                Status = "Sim";
            } else
            {
                Status = "Não";
            }
            if (_Header == false)
            {
                Header = "Sim";
            }
            else
            {
                Header = "Não";
            }


            if (tipoDeRel == "mov")
            {
                List<Movimentacao> movsEncon = dadosEncontrados;
                CarregarGridMov(movsEncon, nomeLocal, nomeRel, Status, Header);

            }
            else if (tipoDeRel == "prod")
            {
                List<Produto> prodEncon = dadosEncontrados;
                CarregarGridProd(prodEncon, nomeLocal, nomeRel, Status, Header);
            }
            else if (tipoDeRel == "estoq")
            {
                List<Estoque> estoqEncon = dadosEncontrados;
                CarregarGridEstoq(estoqEncon, nomeLocal, nomeRel, Status, Header);
            }
            else if (tipoDeRel == "movcomp")
            {
                List<MovComp> estoqEncon = dadosEncontrados;
                CarregarGridMovComp(estoqEncon, nomeLocal, nomeRel, Status, Header);
            }

        }


        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGridMov(IEnumerable<Movimentacao> produtosEncontrados, String nomeLocal, String nomeRel, String _Status, String _Header)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            //String caminhoArquivos = controle.dadosCaminhoArquivos;
            String[] headerMov = estoqueCtrl.getHeaderMov();

            dgvVisualizarRel.ColumnCount = headerMov.Count();
            dgvVisualizarRel.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerMov)
            {
                //dgvVisualizarRel.Columns.Add(prop);
                dgvVisualizarRel.Columns[index].Name = prop;
                index++;
            }

            if (produtosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeMov = produtosEncontrados; // Se veio, preenche a grid com o resultado
            }

            foreach (Movimentacao m in listaDeMov)
            {
                //int cont =+ 1;
               dgvVisualizarRel.Rows.Add(m.movCODIGO, m.movESTOQUECOD, m.movPRODUTOCOD, m.movDETALHES, m.movOPERACAO, m.movQUANTIDADE, m.movQPRODTOTAL, m.movQTOTAL, m.movDATA);

            }

            // DADOS PARA O PREENCHIMENTO DAS LABELS
            String tipoRel = nomeRel;
            String tipoResult = "Movimentação";
            String alvoRel = nomeLocal;
            int quant = listaDeMov.Count();

            DateTime localDate = DateTime.Now;
            String nomeArquivo = "Arquivos/Relatórios/" + nomeLocal + "_" + nomeRel + "_" + localDate.ToString("dd-MM-yyyy_H\\hmm") + ".csv";


            preencherLabels(tipoRel, tipoResult, alvoRel, quant, nomeArquivo, _Status, _Header);
        }



        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGridProd(IEnumerable<Produto> produtosEncontrados, String nomeLocal, String nomeRel, String _Status, String _Header)
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            String[] headerProd = produtoCtrl.getHeaderProd();


            dgvVisualizarRel.ColumnCount = headerProd.Count();
            dgvVisualizarRel.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerProd)
            {
                //dgvVisualizarRel.Columns.Add(prop);
                dgvVisualizarRel.Columns[index].Name = prop;
                index++;
            }

            if (produtosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeProd = produtosEncontrados; // Se veio, preenche a grid com o resultado
            }

            foreach (Produto produto in listaDeProd)
            {
                //int cont =+ 1;
                dgvVisualizarRel.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }


            // DADOS PARA O PREENCHIMENTO DAS LABELS
            String tipoRel = nomeRel;
            String tipoResult = "Produto";
            String alvoRel = nomeLocal;
            int quant = listaDeProd.Count();
            String nomeArquivo = "Arquivos/Relatórios/" + nomeLocal + "_" + nomeRel + ".csv";

            preencherLabels(tipoRel, tipoResult, alvoRel, quant, nomeArquivo, _Status, _Header);
        }

        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA


        public void CarregarGridEstoq(IEnumerable<Estoque> produtosEncontrados, String nomeLocal, String nomeRel, String _Status, String _Header)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            String[] headerEstoq = estoqueCtrl.getHeaderEstoq();


            dgvVisualizarRel.ColumnCount = headerEstoq.Count();
            dgvVisualizarRel.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerEstoq)
            {
                //dgvVisualizarRel.Columns.Add(prop);
                dgvVisualizarRel.Columns[index].Name = prop;
                index++;
            }

            if (produtosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeEstoq = produtosEncontrados; // Se veio, preenche a grid com o resultado
            }

            foreach (Estoque e in listaDeEstoq)
            {
                //int cont =+ 1;
                dgvVisualizarRel.Rows.Add(e.estoqueCODIGO, e.estoqueLOCAL, e.estoqueDETALHES, e.estoqueQUANTIDADE, e.estoqueDATA);
            }


            // DADOS PARA O PREENCHIMENTO DAS LABELS
            String tipoRel = nomeRel;
            String tipoResult = "Estoque";
            String alvoRel = nomeLocal;
            int quant = listaDeEstoq.Count();
            String nomeArquivo = "Arquivos/Relatórios/" + nomeLocal + "_" + nomeRel + ".csv";

            preencherLabels(tipoRel, tipoResult, alvoRel, quant, nomeArquivo, _Status, _Header);
        }


        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA


        public void CarregarGridMovComp(IEnumerable<MovComp> dadosEncontrados, String nomeLocal, String nomeRel, String _Status, String _Header)
        {
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            String[] headerMovComp = estoqueCtrl.getHeaderMovComp();


            dgvVisualizarRel.ColumnCount = headerMovComp.Count();
            dgvVisualizarRel.ColumnHeadersVisible = true;

            int index = 0;
            foreach (String prop in headerMovComp)
            {
                //dgvVisualizarRel.Columns.Add(prop);
                dgvVisualizarRel.Columns[index].Name = prop;
                index++;
            }

            if (dadosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaDeMovComp = dadosEncontrados; // Se veio, preenche a grid com o resultado
            }

            foreach (MovComp e in listaDeMovComp)
            {
                //int cont =+ 1;
                dgvVisualizarRel.Rows.Add(e.mov_CODIGO, e.mov_DETALHES, e.mov_OPERACAO, e.mov_QUANTIDADE, e.mov_DATA, e.produto_CODIGO,
                          e.produto_PRODUTO, e.produto_DIMENSOES, e.produto_DETALHES, e.produto_QUANTIDADE, e.produto_VALOR, e.produto_VALORTOTAL,
                          e.produto_SERIE, e.produto_NOTAFISCAL, e.produto_SEQ, e.produto_FORNECEDOR, e.produto_COMPLEMENTO,
                          e.produto_STATUS, e.estoque_CODIGO, e.estoque_LOCAL, e.estoque_DETALHES, e.estoque_QUANTIDADE
                          );
            }


            // DADOS PARA O PREENCHIMENTO DAS LABELS
            String tipoRel = nomeRel;
            String tipoResult = "Movimentação Completa";
            String alvoRel = nomeLocal;
            int quant = listaDeMovComp.Count();
            String nomeArquivo = "Arquivos/Relatórios/" + nomeLocal + "_" + nomeRel + ".csv";

            preencherLabels(tipoRel, tipoResult, alvoRel, quant, nomeArquivo, _Status, _Header);
        }


        /*********************************************************/
        //FECHAR

        private void btnInvalidar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*********************************************************/
        // PREENCHE A TELA COM OS DADOS DO RELATÓRIO CRIADO


        private void preencherLabels(String tipoRel, String tipoResult, String alvoRel, int quant, String nomeArquivo, String _Status, String _Header)
        {
            lblTipoRelRel.Text = tipoRel;
            lblTipoResultRel.Text = tipoResult;
            lblAlvoRel.Text = alvoRel;
            lblTotalRel.Text = quant.ToString();
            lblArquivoRel.Text = nomeArquivo;
            lblStatus.Text = _Status;
            lblHeader.Text = _Header;

            DateTime localDate = DateTime.Now;
            lblDataRel.Text = localDate.ToString();
        }

        /*********************************************************/


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVisualizarRel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
