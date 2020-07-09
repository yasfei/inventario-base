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
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            InitializeComponent();
        }

        /*********************************************************/
        // CADASTRAR NOVO PRODUTO

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarEstoque novoEstoque = new frmCadastrarEstoque();

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
                novoEstoque.BringToFront();
            }
            else
            {
                novoEstoque.ShowDialog();
            }
        }

        /*********************************************************/
        //CONSULTAR PRODUTOS

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmVisualizarAlterarEstoque visualizarAlterar = new frmVisualizarAlterarEstoque(); //Abre o Form pra visualizar a busca
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl(); // Abre o Controller pra fazer a busca
            List<Estoque> itensEncontrados = new List<Estoque>(); // Cria uma nova lista com os produtos encontrados na busca


            if ((txbConsultCodigo.Text != null && txbConsultCodigo.Text.Trim() != "") && txbConsultNome.Text == null || txbConsultNome.Text.Trim() == "")
            { //TESTA SE O CÓDIGO ESTÁ PREENCHIDO E O NOME ESTÁ EM BRANCO

                itensEncontrados = estoqueCtrl.buscarItemDaListaPorNome(txbConsultCodigo.Text);
                //Produto produto = novaconsulta.buscarProdutoDaLista (txbConsultCodigo.Text); //PROCURA PELO CÓDIGO

            }
            else
                if ((txbConsultCodigo.Text == null || txbConsultCodigo.Text.Trim() == "") && txbConsultNome.Text != null && txbConsultNome.Text.Trim() != "")
            { //TESTA SE O CÓDIGO ESTÁ EM BRANCO E O NOME ESTÁ PREENCHIDO

                itensEncontrados = estoqueCtrl.buscarItemDaListaPorNome(txbConsultNome.Text.Trim()); //PRODCURA PELO NOME
                                                                                                           //Produto produto = novaconsulta.buscarProdutoDaListaPorNome(txbConsultNome.Text.Trim());

            }

            else
                    if ((txbConsultCodigo.Text != null && txbConsultCodigo.Text.Trim() != "") && txbConsultNome.Text != null && txbConsultNome.Text.Trim() != "")
            { //TESTA SE O CÓDIGO E NOME ESTÃO PREENCHIDOS

                itensEncontrados = estoqueCtrl.buscarItemDaListaPorCodigoEPorNome(txbConsultCodigo.Text, txbConsultNome.Text.Trim()); //PRODCURA PELO NOME E PELO CÓDIGO
                                                                                                                                            //Produto produto = novaconsulta.buscarProdutoDaListaPorCodigoEPorNome(txbConsultCodigo.Text, txbConsultNome.Text.Trim());

            }

            if (itensEncontrados != null)
            {
                //Encontrou
                visualizarAlterar.CarregarGrid(itensEncontrados);
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
                    visualizarAlterar.BringToFront();

                }
                else
                {
                    visualizarAlterar.ShowDialog();

                }

                /*/
                //Checar se Form já está aberto e impedir que abra mais de um
                if (!visualizarAlterarProduto.Visible)
                {
                    visualizarAlterarProduto.Show();
                    visualizarAlterarProduto.Visible = true;
                }
                else { visualizarAlterarProduto.BringToFront(); }
                /*/



            }
            else
            {
                MessageBox.Show("Produto não encontado.");
                //visualizarAlterarProduto.CarregarGrid(null);
                //Deve mandar um alert dizendo que não houve resultados na busca e não ir para a tela de alterarProduto
            }

        }

        /*********************************************************/
        // LISTA MOCK

        public void mockListaDeProdutos(List<Produto> listaDeProdutos)
        {
            /*/
            Produto Produto1 = new Produto();
            Produto1.Nome = "Hazel";
            Produto1.Casta = "Hashmalim";
            Produto1.Origem = "Celestial / Exilada";
            Produto1.Signo = "Lua";
            Produto1.Ciclo = "5º Ma'on";
            Produto1.Jogador = "Yaaz";
            Produto1.Sexo = "Feminino";
            Produto1.DivCam = "Controle Gravitacional ; Luz e Trevas - Trevas ; Visão Espiritual ; Controlar o Tecido ; Controlar Almas ; Controle Molecular ; Implantar Ilusões ; Ler Emoções ; Fusão com as Trevas ; Abalo Espiritual ; Forma de Sombra	; Ressurreição ; Criar vida ; Solidificar a Escuridão ; Transporte Espiritual ; Cortina de Aço ; Ilusão Assassina";
            Produto1.Caract = "Cárcere do Avatar ; Carisma ; Reflexos Rápidos ; Vida Mortal ; Asas Afiadas";
            Produto1.Propried = "Synchress: Arma Celestial ; Flickblades: Arma Branca (8x) ; Beretta 92FS: Arma de Fogo ; Crânio ; Harley Davidson 1200 Custom: Motocicleta";

            listaDeProdutos.Add(Produto1);



            Produto Produto2 = new Produto();
            Produto2.Nome = "Kamui";
            Produto2.Casta = "Elohim";
            Produto2.Origem = "Celestial";
            Produto2.Signo = "Terra";
            Produto2.Ciclo = "4º Zebul";
            Produto2.Jogador = "K";
            Produto2.Sexo = "Masculino";
            Produto2.DivCam = "Controle Gravitacional ; Ler Emoções ; Controlar o Tecido ; Transporte Espiritual";
            Produto2.Caract = "Reflexos Rápidos ; Vida Mortal";
            Produto2.Propried = " - ";

            listaDeProdutos.Add(Produto2);
            /*/
        }

        /*********************************************************/
        //LIMPAR OS CAMPOS DE CONSULTA

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsultNome.Text = "";
            txbConsultCodigo.Text = "";
            txbConsultCodigo.Focus();

        }

        /*********************************************************/
        //FECHA A JANELA

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*********************************************************/












































    }
}
