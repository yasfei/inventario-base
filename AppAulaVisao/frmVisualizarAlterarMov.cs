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
    public partial class frmVisualizarAlterarMov : Form
    {
        /*********************************************************/
        //VARIÁVEIS GLOBAIS

        //List<Produto> listaDeProduto = new List<Produto>();
        IEnumerable<Movimentacao> listaEncontrada = new List<Movimentacao>();

        /*********************************************************/
        //INIT

        public frmVisualizarAlterarMov()
        {
            InitializeComponent();
        }

        /*********************************************************/
        //CARREGAR GRID CHAMANDO A VARIÁVEL GLOBAL QUE É PREENCHIDA NO INÍCIO DO PROGRAMA

        public void CarregarGrid(IEnumerable<Movimentacao> dadosEncontrados)
        {
            if (dadosEncontrados != null) //Checa se a lista veio com resultados da busca
            {
                listaEncontrada = dadosEncontrados; // Se veio, preenche a grid com o resultado
            }

            foreach (Movimentacao m in listaEncontrada)
            {
                dgvVisualizarMov.Rows.Add(m.movCODIGO, m.movESTOQUECOD, m.movPRODUTOCOD, m.movDETALHES, m.movOPERACAO, m.movQUANTIDADE, m.movQPRODTOTAL, m.movQTOTAL, m.movDATA);
            }
        }


        /*********************************************************/
        // CLICAR EM UMA MOV DA GRID

        private void dgvVisualizarMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var campos = dgvVisualizarMov.SelectedCells.Count;
            Movimentacao itemEscolhido = new Movimentacao();

            if (campos > 0)
            {
                int selectedrowindex = dgvVisualizarMov.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVisualizarMov.Rows[selectedrowindex];

                //DEVE HAVER UM MELHOR MÉTODO DE INDEXAR
                itemEscolhido.movCODIGO = Convert.ToString(selectedRow.Cells["movCODIGO"].Value);
                itemEscolhido.movESTOQUECOD = Convert.ToString(selectedRow.Cells["movESTOQUECOD"].Value);
                itemEscolhido.movPRODUTOCOD = Convert.ToString(selectedRow.Cells["movPRODUTOCOD"].Value);
                itemEscolhido.movDETALHES = Convert.ToString(selectedRow.Cells["movDETALHES"].Value);
                itemEscolhido.movOPERACAO = Convert.ToString(selectedRow.Cells["movOPERACAO"].Value);
                itemEscolhido.movQUANTIDADE = int.Parse(Convert.ToString(selectedRow.Cells["movQUANTIDADE"].Value));
                itemEscolhido.movQPRODTOTAL = int.Parse(Convert.ToString(selectedRow.Cells["movQPRODTOTAL"].Value));
                itemEscolhido.movQTOTAL = int.Parse(Convert.ToString(selectedRow.Cells["movQTOTAL"].Value));
                itemEscolhido.movDATA = Convert.ToDateTime(selectedRow.Cells["movDATA"].Value);
              
                carregarItemNaTela(itemEscolhido);

            }
        }


        /*********************************************************/
        //VAI CARREGAR UM PRODUTO DA GRID PARA O FORM PARA SER ALTERADO

        public void carregarItemNaTela(Movimentacao mov)
        {
            try
            {
                txbCodigo.Text = mov.movCODIGO;
                txbCodEstoq.Text = mov.movESTOQUECOD;
                txbCodProd.Text = mov.movPRODUTOCOD;
                txbDetalhes.Text = mov.movDETALHES;
                txbOp.Text = mov.movOPERACAO;
                txbQ.Text = (mov.movQUANTIDADE).ToString();
                txbQProdTotal.Text = (mov.movQPRODTOTAL).ToString();
                txbQtotal.Text = (mov.movQTOTAL).ToString();
                txbData.Text = (mov.movDATA).ToString();

                List<MovComp> listaDeItens = new List<MovComp>();
                EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
                listaDeItens = estoqueCtrl.consultarMovCompEmEstoque(mov.movESTOQUECOD);

                foreach (MovComp m in listaDeItens)
                {
                    //int cont =+ 1;
                    //dgvVisualizarMovComp.Rows.Add(e.estoqueCODIGO, e.estoqueLOCAL, e.estoqueDETALHES, e.estoqueQUANTIDADE, e.estoqueDATA);

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

        private void CarregarItemDoForm(Movimentacao mov)
        {
            /*/
            mov.movCODIGO = txbCodigo.Text;
            mov.movESTOQUECOD = txbCodEstoq.Text;
            mov.movPRODUTOCOD = txbCodProd.Text;
            mov.movDETALHES = txbDetalhes.Text;
            mov.movOPERACAO = txbOp.Text;
            mov.movQUANTIDADE= int.Parse(txbQ.Text);
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
            txbCodEstoq.Text = "";
            txbCodProd.Text = "";
            txbDetalhes.Text = "";
            txbOp.Text = "";
            txbQ.Text = "";
            txbQProdTotal.Text = "";
            txbQtotal.Text = "";
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

        private void dgvVisualizarMovComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var campos = dgvVisualizarMovComp.SelectedCells.Count;

            IEnumerable<Estoque> itemEscolhido = new List<Estoque>();

            DataGridViewRow row = dgvVisualizarMovComp.Rows[e.RowIndex];
            var codEstoque = row.Cells["estoque_CODIGO"].Value.ToString();

            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            itemEscolhido = estoqueCtrl.buscarEstoqueDaListaPorCodigo(codEstoque);


            if (campos > 0)
            {
                //Encontrou
                frmVisualizarAlterarEstoque visualizarAlterarEstoque = new frmVisualizarAlterarEstoque(); //Abre o Form pra visualizar a busca
                visualizarAlterarEstoque.CarregarGrid(itemEscolhido);
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
                    visualizarAlterarEstoque.BringToFront();

                }
                else
                {
                    visualizarAlterarEstoque.ShowDialog();

                }
            }
        }



        /*********************************************************/

























    }
}
