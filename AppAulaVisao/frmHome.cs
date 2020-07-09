using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioControle;
using Negocio;


namespace InventarioVisao
{
    public partial class frmHome : Form
    {


        /*********************************************************/
        //VARIÁVEIS GLOBAIS

        int X = 0;
        int Y = 0;

        /*********************************************************/
        //INIT

        public frmHome()
        {
            InitializeComponent();
            //ArquivoCtrl arquivoCtrl = new ArquivoCtrl();
            //arquivoCtrl.lerArquivo();




            //Chama uma função no controller de Produto para ele se comunicar com o DAO (dados)
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            produtoCtrl.lerArquivo();

            //Chama uma função no controller de Estoque para ele se comunicar com o DAO (dados)
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            estoqueCtrl.lerArquivo();


            //PARA POSSIBILITAR O MOVER/ARRASTAR SEM BORDA
            this.MouseDown += new MouseEventHandler(frm_MouseDown);
            this.MouseMove += new MouseEventHandler(frm_MouseMove);


            //TRATAMENTO VISUAL //Não usando
            picBNimal.BackColor = Color.Transparent;
            //picBNimal.Location = thePointRelativeToTheBackImage;
        }

        /*********************************************************/
        // PARA MOVER/ARRASTAR SEM BORDA

        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

       
        /*********************************************************/
        //CARREGAR O LOGIN INICIAL

        private void frmHome_Load_1(object sender, EventArgs e)
        {
            /*/
            {
                Boolean loginInvalido = true;
                while (loginInvalido == true)
                {

                    frmLogin frm = new frmLogin();

                    DialogResult resultado = frm.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        Usuario user = (Usuario)frm.Tag;

                        if (user.Login.Equals("admin") && user.Senha.Equals("admin"))
                        {
                            //MessageBox.Show("OK");
                            loginInvalido = false;
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos");


                        }
                    }
                }
            }
           /*/

        }

        /*********************************************************/
        //CONSULTAR PRODUTO

        private void btnConsultarProduto_Click(object sender, EventArgs e)
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
        //ALTERAR/EDITAR PRODUTOS

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            frmVisualizarAlterarProduto novaVisualizacao = new frmVisualizarAlterarProduto();

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
                novaVisualizacao.BringToFront();
            }
            else
            {
                novaVisualizacao.ShowDialog();
            }

            /*/
            //Checar se Form já está aberto e impedir que abra mais de um
            if (!novaVisualizacao.Visible) { novaVisualizacao.Show(); }
            else { novaVisualizacao.BringToFront(); }
            /*/
        }

        /*********************************************************/
        //CADASTRAR NOVO PRODUTO

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto novoProduto = new frmCadastrarProduto();

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
                novoProduto.BringToFront();
            }
            else
            {
                novoProduto.ShowDialog();
            }

            /*/
            //Checar se Form já está aberto e impedir que abra mais de um
            if (!novoProduto.Visible) { novoProduto.Show(); }
            else { novoProduto.BringToFront(); }
            /*/

        }

        /*********************************************************/
        //LISTAR PRODUTOS

        private void btnListarProduto_Click(object sender, EventArgs e)
        {
            frmListarProduto novoListar = new frmListarProduto();

            //Checar se Form já está aberto e impedir que abra mais de um
            //if (!novoListar.Visible) { novoListar.Show(); }
            //else { novoListar.BringToFront(); }

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmListarProduto)
                {
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                novoListar.BringToFront();
            }
            else
            {
                novoListar.ShowDialog();
            }

        }

        /*********************************************************/
        // FECHAR A APLICAÇÃO

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*********************************************************/
        // ABRIR TELA DE RELATÓRIOS  //ANTIGO (NÃO FUNCIONAVA)

            /*/
        private void btnRelatorio_Click2(object sender, EventArgs e)
        {
            frmRelatorios novoRelatorio = new frmRelatorios();

            //Checar se Form já está aberto e impedir que abra mais de um
            if (!novoRelatorio.Visible) { novoRelatorio.Show(); }
            else { novoRelatorio.BringToFront(); }
        }
            /*/

        /*********************************************************/
        // ABRIR TELA DE RELATÓRIOS

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            frmRelatorios novoRelatorio = new frmRelatorios();
            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmRelatorios)
                {
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                novoRelatorio.BringToFront();
            }
            else
            {
                novoRelatorio.ShowDialog();
            }
        }

        /*********************************************************/
        // TESTE

        private void btnTESTE_Click(object sender, EventArgs e)
        {
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            //produtoCtrl.btnTESTE();
        }


        /*********************************************************/

        private void btnArquivo_Click(object sender, EventArgs e)
        {

            frmInfoArquivo abrirInfoArquivo = new frmInfoArquivo();
            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmRelatorios)
                {
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                abrirInfoArquivo.BringToFront();
            }
            else
            {
                abrirInfoArquivo.ShowDialog();
            }
        }

        /*********************************************************/

        private void btnConsultarEstoq_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque novaConsulta = new frmConsultarEstoque();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmConsultarEstoque)
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

        private void btnConsultarMov_Click(object sender, EventArgs e)
        {
            frmConsultarMov novaConsulta = new frmConsultarMov();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmConsultarMov)
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

        private void btnCadastrarEstoq_Click(object sender, EventArgs e)
        {
            frmCadastrarEstoque novaConsulta = new frmCadastrarEstoque();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmCadastrarEstoque)
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

        private void btnCadastrarMov_Click(object sender, EventArgs e)
        {
            frmCadastrarMov novaConsulta = new frmCadastrarMov();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmCadastrarMov)
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




    }

}
