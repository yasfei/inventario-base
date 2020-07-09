using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using InventarioDados;
using LINQtoCSV;

namespace InventarioControle     
{
    class ControleCtrl                    //CONTROLLER DE CONTROLE DE DADOS
    {

        /*********************************************************/



        public void lerArquivos()

        {
            //Chama uma função no controller de Produto para ele se comunicar com o DAO (dados)
            ProdutoCtrl produtoCtrl = new ProdutoCtrl();
            produtoCtrl.lerArquivo();

            //Chama uma função no controller de Estoque para ele se comunicar com o DAO (dados)
            EstoqueCtrl estoqueCtrl = new EstoqueCtrl();
            estoqueCtrl.lerArquivo();

        }

 

        /*********************************************************/



















    }
}
