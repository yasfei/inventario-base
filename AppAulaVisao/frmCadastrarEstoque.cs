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
    public partial class frmCadastrarEstoque : Form
    {
        /*********************************************************/
        // INIT
        public frmCadastrarEstoque()
        {
            InitializeComponent();
        }

        /*********************************************************/
        // SALVA O NOVO ESTOQUE

        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            //CarregarProdutoDoForm(produto);

            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            if (estoqueCtrl.SalvarNovoEstoque(estoque) == true)
            {
                MessageBox.Show("Estoque salvo com sucesso!");
                limparTela();
            }
            else
            {
                MessageBox.Show("O estoque não pode ser salvo.");
            }
        }


        /*********************************************************/
        // LIMPA A TELA

        private void limparTela()
        {
            txbCodigo.Text = "";
            txbLocal.Text = "";
            txbDetalhes.Text = "";
            txbQ.Text = "";
            txbData.Text = "";
        }


        /*********************************************************/
        // VOLTAR

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /*********************************************************/
        // CHAMA O LIMPAR

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        /*********************************************************/


    }
}
