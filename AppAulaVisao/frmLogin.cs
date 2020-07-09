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
    public partial class frmLogin : Form
    {

        /*********************************************************/
        // INIT

        public frmLogin()
        {
            InitializeComponent();
        }

        /*********************************************************/
        // ENTRAR

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Login = txbUsuario.Text;
            user.Senha = txbSenha.Text;

            this.Tag = user;
        }

        /*********************************************************/
        //

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        //

        private void btnVisualizarP_Click(object sender, EventArgs e)
        {
            frmVisualizarProdutos novaVisualizacao = new frmVisualizarProdutos();

            bool FormOpen = false;
            foreach (Form S in Application.OpenForms) //Checar se Form já está aberto e impedir que abra mais de um
            {
                if (S is frmVisualizarProdutos)
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
        //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /*********************************************************/
        //
    }
}
