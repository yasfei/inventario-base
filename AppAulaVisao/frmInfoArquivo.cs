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
    public partial class frmInfoArquivo : Form
    {
        //VARIÁVEIS GLOBAIS
        static List<Produto> arquivoProd;
        static List<Estoque> arquivoEstoq;
        static List<Movimentacao> arquivoMov;


        /*********************************************************/

        public frmInfoArquivo()
        {
            InitializeComponent();
            recuperarArquivos();

        }

        /*********************************************************/


        public void recuperarArquivos()
        {
            //RECUPERAR ARQUIVO DE PRODUTOS
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            arquivoProd = produtoCtrl.getProdutos();

            //RECUPERAR ARQUIVO DE ESTOQUES
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            arquivoEstoq = estoqueCtrl.getEstoques();

            //RECUPERAR ARQUIVO DE ESTOQUES
            arquivoMov = estoqueCtrl.getMov();

        }

        /*********************************************************/

        private void frmInfoArquivo_Load(object sender, EventArgs e)
        {

        }



        /*********************************************************/

        private void calcularInfo(object sender, EventArgs e)
        {

        }


        /*********************************************************/
        //FECHAR E VOLTAR

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Close();
            home.BringToFront();
        }

        /*********************************************************/


        private void preencherLabels(String tipoRel, String tipoResult, String alvoRel, int quant, String nomeArquivo)
        {
            lblNomeArq.Text = tipoRel;
            lblLocalArq.Text = tipoResult;
            lblTipoArq.Text = alvoRel;

            lblTotalProd.Text = quant.ToString();
            lblUnicProd.Text = nomeArquivo;
            lblValProd.Text = alvoRel;
            lblInvProd.Text = quant.ToString();

            lblTotalEstoq.Text = nomeArquivo;
            lblTotalMov.Text = nomeArquivo;


        }

        /*********************************************************/

        private void btnOpenArq_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblLocalArq.Text = folderBrowserDialog1.SelectedPath;
            }


            /*/
            if (ofdSelecionarLocal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(ofdSelecionarLocal.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
            /*/
        }


        /*********************************************************/

        private void btnSalvarInfo_Click(object sender, EventArgs e)
        {




        }

        /*********************************************************/












    }
}
