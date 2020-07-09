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
    public partial class frmVisualizarAlterarEstoque : Form
    {
        /*********************************************************/
        //VARIÁVEIS GLOBAIS

        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Estoque> listaEncontrada = new List<Estoque>();

        /*********************************************************/
        //INIT

        public frmVisualizarAlterarEstoque()
        {
            InitializeComponent();
        }

        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGrid(IEnumerable<Estoque> dadosEncontrados)
        {
            if (dadosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaEncontrada = dadosEncontrados; // Se veio, preenche a grid com o resultado

            }

            /*/
            //NÃO LISTARÁ OS PRODUTOS AQUI
            foreach (Produto produto in listaEncontrada)
            {
                //int cont =+ 1;
                dgvVisualizarEstoq.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);
            }
            /*/

            foreach (Estoque e in listaEncontrada)
            {
                dgvVisualizarEstoq.Rows.Add(e.estoqueCODIGO, e.estoqueLOCAL, e.estoqueDETALHES, e.estoqueQUANTIDADE, e.estoqueDATA);
            }
        }


        /*********************************************************/
        // CLICAR EM UM ESTOQUE DA GRID

        private void dgvVisualizarEstoq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var campos = dgvVisualizarEstoq.SelectedCells.Count;
            Estoque itemEscolhido = new Estoque();

            if (campos > 0)
            {
                int selectedrowindex = dgvVisualizarEstoq.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVisualizarEstoq.Rows[selectedrowindex];

                //DEVE HAVER UM MELHOR MÉTODO DE INDEXAR
                itemEscolhido.estoqueCODIGO = Convert.ToString(selectedRow.Cells["estoqueCODIGO"].Value);
                itemEscolhido.estoqueLOCAL = Convert.ToString(selectedRow.Cells["estoqueLOCAL"].Value);
                itemEscolhido.estoqueDETALHES = Convert.ToString(selectedRow.Cells["estoqueDETALHES"].Value);
                itemEscolhido.estoqueQUANTIDADE = int.Parse(Convert.ToString(selectedRow.Cells["estoqueQUANTIDADE"].Value));
                itemEscolhido.estoqueDATA = Convert.ToDateTime(selectedRow.Cells["estoqueDATA"].Value);

                carregarItemNaTela(itemEscolhido);

            }
        }


        /*********************************************************/
        //VAI CARREGAR UM PRODUTO DA GRID PARA O FORM PARA SER ALTERADO

        public void carregarItemNaTela(Estoque estoq)
        {
            try
            {
                txbCodigo.Text = estoq.estoqueCODIGO;
                txbLocal.Text = estoq.estoqueLOCAL;
                txbDetalhes.Text = estoq.estoqueDETALHES;
                txbQ.Text = (estoq.estoqueQUANTIDADE).ToString();
                txbData.Text = (estoq.estoqueDATA).ToString();

                List<MovComp> listaDeItens = new List<MovComp>();
                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                //listaDeItens = produtoCtrl.consultarProdEmEstoque(estoq.estoqueCODIGO);
                listaDeItens = estoqueCtrl.consultarMovCompEmEstoque(estoq.estoqueCODIGO);


                foreach (MovComp m in listaDeItens)
                {
                    //int cont =+ 1;
                    //dgvVisualizarMovComp.Rows.Add(produto.dadosCODIGO, produto.dadosPRODUTO, produto.dadosDIMENSOES, produto.dadosDETALHES, produto.dadosOPERACAO, produto.dadosMOVIMENTACAO, produto.dadosQUANTIDADE, produto.dadosVALOR, produto.dadosVALORTOTAL, produto.dadosDATA, produto.dadosSERIE, produto.dadosNOTAFISCAL, produto.dadosSEQ, produto.dadosFORNECEDOR, produto.dadosCOMPLEMENTO, produto.dadosSTATUS);

                    DataGridViewRow row = (DataGridViewRow)dgvVisualizarMovComp.Rows[0].Clone();

                    row.Cells["movCODIGO"].Value = m.mov_CODIGO;
                    row.Cells["movDETALHES"].Value = m.mov_DETALHES;
                    row.Cells["movOPERACAO"].Value = m.mov_OPERACAO;
                    row.Cells["movDATA"].Value = m.mov_DATA;

                    row.Cells["produto_CODIGO"].Value = m.produto_CODIGO;
                    row.Cells["produto_PRODUTO"].Value = m.produto_PRODUTO;
                    row.Cells["produto_DIMENSOES"].Value = m.produto_DIMENSOES;
                    row.Cells["produto_DETALHES"].Value = m.produto_DETALHES;
                    row.Cells["produto_QUANTIDADE"].Value = m.produto_QUANTIDADE;
                    row.Cells["produto_VALOR"].Value = m.produto_VALOR;
                    row.Cells["produto_VALORTOTAL"].Value = m.produto_VALORTOTAL;
                    row.Cells["produto_SERIE"].Value = m.produto_SERIE;
                    row.Cells["produto_FORNECEDOR"].Value = m.produto_FORNECEDOR;
                    row.Cells["produto_COMPLEMENTO"].Value = m.produto_COMPLEMENTO;
                    row.Cells["produto_STATUS"].Value = m.produto_STATUS;

                    row.Cells["estoque_CODIGO"].Value = m.estoque_CODIGO;
                    row.Cells["estoque_LOCAL"].Value = m.estoque_LOCAL;
                    row.Cells["estoque_DETALHES"].Value = m.estoque_DETALHES;
                    row.Cells["estoque_QUANTIDADE"].Value = m.estoque_QUANTIDADE;

                    dgvVisualizarMovComp.Rows.Add(row);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O item não pode ser carregado. \r\n Exception source: {0}", ex.Source);
                //Não conseguiu definir os campos
            }
        }


        /*********************************************************/
        //VAI CARREGAR DO FORM PARA UMA MOV

        private void CarregarItemDoForm(Estoque estoq)
        {
            //DEVE ABRIR O PRODUTO ESCOLHIDO NA TELA DE VISUALIZARALTERARPRODUTO?


            /*/
            mov.movCODIGO = txbCodigo.Text;
            mov.movESTOQUECOD = txbCodEstoq.Text;
            mov.movPRODUTOCOD = txbCodProd.Text;
            mov.movDETALHES = txbDetalhes.Text;
            mov.movOPERACAO = txbOp.Text;
            mov.movQUANTIDADE = int.Parse(txbQ.Text);
            mov.movQPRODTOTAL = int.Parse(txbQProdTotal.Text);
            mov.movQTOTAL = int.Parse(txbQtotal.Text);
            mov.movDATA = DateTime.Parse(txbData.Text);
            /*/

        }

        /*********************************************************/
        //LIMPAR TELA

        private void limparTela()
        {
            txbCodigo.Text = "";
            txbLocal.Text = "";
            txbDetalhes.Text = "";
            txbQ.Text = "";
            txbData.Text = "";
            dgvVisualizarMovComp = null;

        }

        /*********************************************************/
        // VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Activate();
            this.Close();
            //home.BringToFront();
        }

        /*********************************************************/
        // LIMPAR TELA

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            limparTela();
        }


        /*********************************************************/
        // INVALIDAR ITEM

        private void btnInvalidar_Click(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        // SALVAR NOVO ITEM

        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        // CONSULTAR NOVO ITEM

        private void btnConsultarNovo_Click(object sender, EventArgs e)
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
        }

        /*********************************************************/
        // CLICAR EM UM PRODUTO DA GRID ABRIRÁ O VISUALIZAR-ALTERAR-PRODUTO

        private void dgvVisualizarMovComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var campos = dgvVisualizarMovComp.SelectedCells.Count;

            IEnumerable<Produto> itemEscolhido = new List<Produto>();
            //var codProduto = (dgvVisualizarMovComp.SelectedCells(produto_CODIGO.Value.ToString());
            //var codProduto = (DataRowView)dgvVisualizarMovComp.SelectedCells[0].Value;
            //var codProduto = dgvVisualizarMovComp.Rows["produto_CODIGO"].Cells[0].ValueToString();


            DataGridViewRow row = dgvVisualizarMovComp.Rows[e.RowIndex];
            var codProduto = row.Cells["produto_CODIGO"].Value.ToString();

            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            itemEscolhido = produtoCtrl.buscarProdutoDaListaPorCodigo(codProduto);


            if (campos > 0)
            {
                //Encontrou
                frmVisualizarAlterarProduto visualizarAlterarProduto = new frmVisualizarAlterarProduto(); //Abre o Form pra visualizar a busca
                visualizarAlterarProduto.CarregarGrid(itemEscolhido);
                this.Close();

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
                    visualizarAlterarProduto.BringToFront();
                }
                else
                {
                    visualizarAlterarProduto.ShowDialog();
                }
            }
        }

        /*********************************************************/














    
    }
}
