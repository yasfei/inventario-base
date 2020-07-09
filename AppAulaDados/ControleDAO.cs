using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using InventarioDados;
using LINQtoCSV;

namespace InventarioDados     
{
    public class ControleDAO  //CONTROLE DE DADOS GERAIS
    {

        // VARIÁVEIS GLOBAIS

        private static String caminhoArquivos = "C:/Users/yasmin.feitosa/Documents/Visual Studio 2015/Projects/Inventario Base/Arquivos";


        private static String[] headerMov = {   "CODIGO", "ESTOQUECOD", "PRODUTOCOD", "DETALHES", "OPERACAO",
                                                "QUANTIDADE", "QPRODTOTAL", "QTOTAL", "DATA" };

        private static String[] headerProd = {  "CODIGO", "PRODUTO", "DIMENSOES", "DETALHES", "OPERACAO",
                                                "MOVIMENTACAO", "QUANTIDADE", "VALOR", "VALORTOTAL", "DATA",
                                                "SERIE", "NOTAFISCAL", "SEQ", "FORNECEDOR", "COMPLEMENTO", "STATUS" };

        private static String[] headerEstoq = { "CODIGO", "LOCAL", "DETALHES", "QUANTIDADE", "DATA" };


        private static String[] headerMovComp = { "mov_CODIGO", "mov_DETALHES", "mov_OPERACAO","mov_QUANTIDADE",
                                                  "mov_DATA","produto_CODIGO", "produto_PRODUTO",
                                                  "produto_DIMENSOES", "produto_DETALHES","produto_QUANTIDADE",
                                                  "produto_VALOR", "produto_VALORTOTAL", "produto_SERIE",
                                                  "produto_NOTAFISCAL", "produto_SEQ", "produto_FORNECEDOR",
                                                  "produto_COMPLEMENTO", "produto_STATUS","estoque_CODIGO",
                                                  "estoque_LOCAL", "estoque_DETALHES", "estoque_QUANTIDADE"};



        /*********************************************************/

        public String[] dadosHeaderMov
        {
            get { return headerMov; }
            set { headerMov = value; }
        }

        /*********************************************************/

        public String[] dadosHeaderProd
        {
            get { return headerProd; }
            set { headerProd = value; }
        }

        /*********************************************************/

        public String[] dadosHeaderEstoq
        {
            get { return headerEstoq; }
            set { headerEstoq = value; }
        }

        /*********************************************************/

        public String dadosCaminhoArquivos
        {
            get { return caminhoArquivos; }
            set { caminhoArquivos = value; }
        }

        /*********************************************************/


        public String[] dadosHeaderMovComp
        {
            get { return headerMovComp; }
            set { headerMovComp = value; }
        }
        /*********************************************************/














    }
}
