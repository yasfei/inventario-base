using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Negocio;
using LINQtoCSV;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Reflection;
using System.IO;
using System.Text;
using System.Dynamic;

namespace InventarioDados
{
    public class EstoqueDAO
    {
        //PATH GLOBAL
        //string headerMov = "CODIGO; ESTOQUECOD; PRODUTOCOD; DETALHES; OPERACAO; QUANTIDADE; QPRODTOTAL; QTOTAL; DATA";
        //string headerProd = "CODIGO; PRODUTO; DIMENSOES; DETALHES; OPERACAO; MOVIMENTACAO; QUANTIDADE; VALOR; VALORTOTAL; DATA; SERIE; NOTAFISCAL; SEQ; FORNECEDOR; COMPLEMENTO; STATUS";
        //string headerEstoq = "CODIGO; LOCAL; DETALHES; QUANTIDADE; DATA";


        // VARIÁVEL GLOBAL DO ARQUIVO DE ESTOQUES
        private static IEnumerable<Estoque> arquivoEstoquesBruto;
        public static IEnumerable<Estoque> dadosArquivoEstoquesBruto
        {
            get { return arquivoEstoquesBruto; }
            set { arquivoEstoquesBruto = value; }
        }


        // VARIÁVEL GLOBAL DO ARQUIVO DE MOVIMENTACOES
        private static IEnumerable<Movimentacao> arquivoMovimentacoesBruto;
        public static IEnumerable<Movimentacao> dadosArquivoMovimentacoesBruto
        {
            get { return arquivoMovimentacoesBruto; }
            set { arquivoMovimentacoesBruto = value; }
        }


        // VARIÁVEL GLOBAL DO ARQUIVO DE MOVIMENTACOES
        private static IEnumerable<MovComp> arquivoMovCompBruto;
        public static IEnumerable<MovComp> dadosArquivoMovCompBruto
        {
            get { return arquivoMovCompBruto; }
            set { arquivoMovCompBruto = value; }
        }


        /*********************************************************/

        public Boolean salvarMovimentacao(Movimentacao Movimentacao)
        {
            Boolean salvo = false;
            salvo = true;

            return salvo;
        }
        /*********************************************************/

        public Boolean alterarMov(Movimentacao Movimentacao)
        {
            Boolean salvo = false;

            salvo = true;

            return salvo;
        }
        /*********************************************************/

        public List<Movimentacao> carregarMovimentacao()
        {
            List<Movimentacao> listaDeMovimentacao = new List<Movimentacao>();
            mockListaDeMovimentacao(listaDeMovimentacao);
            return listaDeMovimentacao;
        }


        /*********************************************************/


        public void mockListaDeMovimentacao(List<Movimentacao> listaDeMovimentacao)
        {
            Movimentacao Movimentacao1 = new Movimentacao();
            Movimentacao1.movCODIGO = "11111";
            Movimentacao1.movESTOQUECOD = "22222";
            Movimentacao1.movPRODUTOCOD = "33333";
            Movimentacao1.movDETALHES = "CTHULLU'S CALL";
            Movimentacao1.movOPERACAO = "VENDA DE MERCADORIAS";
            Movimentacao1.movQUANTIDADE = 5;
            Movimentacao1.movQPRODESTOQ = 3;
            Movimentacao1.movQPRODTOTAL = 10;
            Movimentacao1.movQTOTAL = 15;
            Movimentacao1.movDATA = DateTime.Parse("13/06/2013 17:54:22");

            listaDeMovimentacao.Add(Movimentacao1);




            Movimentacao Movimentacao2 = new Movimentacao();
            Movimentacao2.movCODIGO = "22222";
            Movimentacao2.movESTOQUECOD = "33333";
            Movimentacao2.movPRODUTOCOD = "44444";
            Movimentacao2.movDETALHES = "SPAWNING EVIL";
            Movimentacao2.movOPERACAO = "ENTRADA DE FORNECEDOR";
            Movimentacao2.movQUANTIDADE = 2;
            Movimentacao1.movQPRODESTOQ = 5;
            Movimentacao2.movQPRODTOTAL = 8;
            Movimentacao2.movQTOTAL = 48;
            Movimentacao2.movDATA = DateTime.Parse("31/06/2011 17:14:11");

            listaDeMovimentacao.Add(Movimentacao1);

        }

        /*********************************************************/

        public Boolean salvarEstoque(Estoque Estoque)
        {
            Boolean salvo = false;
            salvo = true;

            return salvo;
        }

        /*********************************************************/

        public Boolean salvarMov(Movimentacao _mov)
        {
            Boolean salvo = false;
            salvo = true;

            return salvo;
        }


        /*********************************************************/

        public Boolean alterarEstoque(Estoque Estoque)
        {
            Boolean salvo = false;

            salvo = true;

            return salvo;
        }

        /*********************************************************/

        public List<Estoque> carregarEstoques()
        {
            List<Estoque> listaDeEstoque = new List<Estoque>();
            mockListaDeEstoque(listaDeEstoque);
            return listaDeEstoque;
        }


        /*********************************************************/


        public void mockListaDeEstoque(List<Estoque> listaDeEstoque)
        {
            Estoque Estoque1 = new Estoque();
            Estoque1.estoqueCODIGO = "11111";
            Estoque1.estoqueLOCAL = "RAVENHEAD FONSECA";
            Estoque1.estoqueDETALHES = "ORDEN OGAN";
            //Estoque1.estoqueOPERACAO = "VENDA DE MERCADORIAS";
            Estoque1.estoqueQUANTIDADE = 35;
            Estoque1.estoqueDATA = DateTime.Parse("13/06/2013 17:54:22");

            listaDeEstoque.Add(Estoque1);



            Estoque Estoque2 = new Estoque();
            Estoque1.estoqueCODIGO = "22222";
            Estoque1.estoqueLOCAL = "FINLAND RJ";
            Estoque1.estoqueDETALHES = "SOLDIER OF THREE ARMIES";
            //Estoque1.estoqueOPERACAO = "DEMONSTRACAO";
            Estoque1.estoqueQUANTIDADE = 15;
            Estoque1.estoqueDATA = DateTime.Parse("15/02/2014 13:44:22");

            listaDeEstoque.Add(Estoque2);


            Estoque Estoque3 = new Estoque();
            Estoque1.estoqueCODIGO = "33333";
            Estoque1.estoqueLOCAL = "UKRAINE ITAIPUACU";
            Estoque1.estoqueDETALHES = "NOWHERE";
            //Estoque1.estoqueOPERACAO = "SERVICO";
            Estoque1.estoqueQUANTIDADE = 48;
            Estoque1.estoqueDATA = DateTime.Parse("13/02/2017 21:45:22");

            listaDeEstoque.Add(Estoque3);

            Estoque Estoque4 = new Estoque();
            Estoque1.estoqueCODIGO = "44444";
            Estoque1.estoqueLOCAL = "ARMENIA NITEROI";
            Estoque1.estoqueDETALHES = "MARINE";
            //Estoque1.estoqueOPERACAO = "ENTRADA DE FORNECEDOR";
            Estoque1.estoqueQUANTIDADE = 15;
            Estoque1.estoqueDATA = DateTime.Parse("12/05/2016 23:46:22");

            listaDeEstoque.Add(Estoque4);


            Estoque Estoque5 = new Estoque();
            Estoque1.estoqueCODIGO = "55555";
            Estoque1.estoqueLOCAL = "IRELAND CURITIBA";
            Estoque1.estoqueDETALHES = "CAMOUFLAGE";
            //Estoque1.estoqueOPERACAO = "ENTRADA DE FORNECEDOR";
            Estoque1.estoqueQUANTIDADE = 15;
            Estoque1.estoqueDATA = DateTime.Parse("12/05/2016 23:46:22");

            listaDeEstoque.Add(Estoque5);
        }

        /*********************************************************/
        //VAI LER OU CRIAR UM ARQUIVO

        public void lerArquivo()
        //public List<Estoque> lerArquivo()
        {
            ControleDAO controle = new ControleDAO();
            String caminhoArquivos = controle.dadosCaminhoArquivos;
            String[] headerEstoq = controle.dadosHeaderEstoq;

            string pathEstoque = System.IO.Path.Combine(caminhoArquivos, "estoques_nimal.csv");

            System.IO.Directory.CreateDirectory(caminhoArquivos); // VAI CRIAR O DIRETÓRIO SE ELE NÃO EXISTIR
            if (!File.Exists(pathEstoque)) //O ARQUIVO NÃO EXISTE NA PASTA
            {
                using (StreamWriter newborn = File.CreateText(pathEstoque))
                {
                    newborn.WriteLine(headerEstoq); //Criou e já escreveu o header.
                    dadosArquivoEstoquesBruto = null;
                }

            }
            else //O ARQUIVO  EXISTE NA PASTA
            {
                arquivoEstoquesBruto = CSVtoIENUMEstoq(pathEstoque); //Chama o conversor

            }
        }

        /*********************************************************/
        //VERFICA SE O ARQUIVO DE MOVIMENTAÇÃO EXISTE, SE SIM, CHAMA O LEITOR


        public void verificarArquivoMov()
        {
            ControleDAO controle = new ControleDAO();
            String caminhoArquivos = controle.dadosCaminhoArquivos;
            String[] headerMov = controle.dadosHeaderMov;

            string pathMovimentacao = System.IO.Path.Combine(caminhoArquivos, "movimentacoes_nimal.csv");

            //string pathMovimentacao = caminhoArquivos + "/movimentacoes_nimal.csv";

            System.IO.Directory.CreateDirectory(caminhoArquivos); // VAI CRIAR O DIRETÓRIO SE ELE NÃO EXISTIR
            if (!File.Exists(pathMovimentacao)) //O ARQUIVO NÃO EXISTE NA PASTA
            {
                using (StreamWriter newbornMov = File.CreateText(pathMovimentacao))
                {
                    newbornMov.WriteLine(headerMov); //Criou e já escreveu o header.
                    dadosArquivoMovimentacoesBruto = null;
                }

            }
            else //O ARQUIVO  EXISTE NA PASTA
            {
                arquivoMovimentacoesBruto = CSVtoIENUMMov(pathMovimentacao); //Chama o conversor

            }
        }


        /*********************************************************/
        // SELECIONA A MOVIMENTAÇÃO COMPLETA

        public void verificarMovComp()
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var Produtos = ProdutoDao.dadosArquivoProdutosBruto;

            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;


            //dynamic result = new ExpandoObject();
            IEnumerable<MovComp> result = (from m in Movs
                                          join prod in Produtos
                                          on m.movPRODUTOCOD equals prod.dadosCODIGO
                                          join estoque in Estoques
                                          on m.movESTOQUECOD equals estoque.estoqueCODIGO
                                          where (estoque.estoqueDATA == m.movDATA) && (prod.dadosDATA == m.movDATA)
                                          select new MovComp()
                                          {

                                              //ADICIONA OS DADOS DE MOVIMENTACAO ESCOLHIDA
                                              mov_CODIGO = m.movCODIGO,
                                              mov_DETALHES = m.movDETALHES,
                                              mov_OPERACAO = m.movOPERACAO,
                                              mov_QUANTIDADE = m.movQUANTIDADE,
                                              mov_DATA = m.movDATA,

                                              //ADICIONA OS DADOS DE PRODUTO AFETADO
                                              produto_CODIGO = prod.dadosCODIGO,
                                              produto_PRODUTO = prod.dadosPRODUTO,
                                              produto_DIMENSOES = prod.dadosDIMENSOES,
                                              produto_DETALHES = prod.dadosDETALHES,
                                              produto_QUANTIDADE = prod.dadosQUANTIDADE,
                                              produto_VALOR = prod.dadosVALOR,
                                              produto_VALORTOTAL = prod.dadosVALORTOTAL,
                                              produto_SERIE = prod.dadosSERIE,
                                              produto_NOTAFISCAL = prod.dadosNOTAFISCAL,
                                              produto_SEQ = prod.dadosSEQ,
                                              produto_FORNECEDOR = prod.dadosFORNECEDOR,
                                              produto_COMPLEMENTO = prod.dadosCOMPLEMENTO,
                                              produto_STATUS = prod.dadosSTATUS,

                                              //ADICIONA OS DADOS DE ESTOQUE AFETADO
                                              estoque_CODIGO = estoque.estoqueCODIGO,
                                              estoque_LOCAL = estoque.estoqueLOCAL,
                                              estoque_DETALHES = estoque.estoqueDETALHES,
                                              estoque_QUANTIDADE = estoque.estoqueQUANTIDADE,

                                          }).ToList();



            if ((result.Count()) != 0){

                arquivoMovCompBruto = result;
            }
            else { //SE RESULT ESTIVER VAZIO
                dadosArquivoMovCompBruto = null;
            }
        }




        /*********************************************************/
        //CONVERTE CSV PARA LISTA IENUMERABLE

        public IEnumerable<Estoque> CSVtoIENUMEstoq(String _pathEstoque)
        {

            //Se comunica com o arquivo de Estoque
            CsvContext cc = new CsvContext();
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ';',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            //IEnumerable<string> Estoque = new IEnumerable<string>();

            IEnumerable<Estoque> estoques =
                cc.Read<Estoque>(_pathEstoque, inputFileDescription);

            var estoquesByCod =
            from e in estoques
            orderby e.estoqueCODIGO
            select new
            {
                e.estoqueCODIGO,
                e.estoqueLOCAL,
                e.estoqueDETALHES,
                //e.estoqueOPERACAO,
                e.estoqueQUANTIDADE,
                e.estoqueDATA
            };

            //Console.Write("O primeiro Estoque é:" + estoquesByCod.First().dadosCODIGO);
            //estoquesByCod.Dump();

            //Joga na variável Global
            //var blau = estoquesByCod.ToList();
            //var bluf = estoques.ToList();

            //Joga na variável Global Bruta
            return estoques;

        }



        /*********************************************************/
        //CONVERTE CSV PARA LISTA IENUMERABLE


        public IEnumerable<Movimentacao> CSVtoIENUMMov(String _pathMovimentacao)
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ';',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            IEnumerable<Movimentacao> movimentacoes =
                cc.Read<Movimentacao>(_pathMovimentacao, inputFileDescription);

            var movimentacoesByCod =
            from m in movimentacoes
            orderby m.movCODIGO
            select new
            {
                m.movCODIGO,
                m.movESTOQUECOD,
                m.movPRODUTOCOD,
                m.movDETALHES,
                m.movOPERACAO,
                m.movQUANTIDADE,
                m.movQPRODESTOQ,
                m.movQPRODTOTAL,
                m.movQTOTAL,
                m.movDATA
            };

            return movimentacoes;

        }


        /*********************************************************/
        //SELECT DE MOVIMENTAÇÃO - LOCAL

        public List<Movimentacao> buscarMovLocal(String _localescolhido)
        {
            //IEnumerable<Produto> query = arquivoProdutosBruto.Where(produto => produto.dadosSTATUS == "VALIDO");
            //var result = query;

            //var Produtos = dadosArquivoProdutosBruto;
            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;

            List<Movimentacao> result = (from m in Movs
                                          join estoque in Estoques
                                          on m.movESTOQUECOD equals estoque.estoqueCODIGO
                                          where estoque.estoqueCODIGO == _localescolhido
                                          
                                          // group prod by produto.dadosCODIGO into g
                                          select new Movimentacao()
                                          {
                                              movCODIGO = m.movCODIGO,
                                              movESTOQUECOD = m.movESTOQUECOD,
                                              movPRODUTOCOD = m.movPRODUTOCOD,
                                              movDETALHES = m.movDETALHES,
                                              movOPERACAO = m.movOPERACAO,
                                              movQUANTIDADE = m.movQUANTIDADE,
                                              movQPRODESTOQ = m.movQPRODESTOQ,
                                              movQPRODTOTAL = m.movQPRODTOTAL,
                                              movQTOTAL = m.movQTOTAL,
                                              movDATA = m.movDATA
                                          }).ToList();

            return result;
        }



        /*********************************************************/
        //SELECT DE ESTOQUE - OPERAÇÃO

        public List<Estoque> buscarEstoqOperacao(String _opEscolhida)
        {
            //IEnumerable<Produto> query = arquivoProdutosBruto.Where(produto => produto.dadosSTATUS == "VALIDO");
            //var result = query;

            //var Produtos = dadosArquivoProdutosBruto;
            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;

            List<Estoque> result = (from e in Estoques
                                        join m in Movs
                                        on e.estoqueCODIGO equals m.movESTOQUECOD
                                        where m.movOPERACAO == _opEscolhida

                                        // group prod by produto.dadosCODIGO into g
                                        select new Estoque()
                                          {
                                         estoqueCODIGO = e.estoqueCODIGO,
                                         estoqueLOCAL = e.estoqueLOCAL,
                                         estoqueDETALHES = e.estoqueDETALHES,
                                         //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                         estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                         estoqueDATA = e.estoqueDATA
                                          }).ToList();

            return result;
        }



        /*********************************************************/
        //SELECT DE ESTOQUE - AUDITORIA

        public List<Estoque> buscarEstoqAudit(DateTime _dataEscolhida, String _nomeLocal)
        {
            var Estoques = dadosArquivoEstoquesBruto;
            //var Movs = dadosArquivoMovimentacoesBruto;

            List<Estoque> result = (from e in Estoques
                                        //join m in Movs
                                        //on e.estoqueCODIGO equals m.movESTOQUECOD
                                        where (e.estoqueDATA >= _dataEscolhida) && (e.estoqueCODIGO == _nomeLocal)
                                        select new Estoque()
                                        {
                                            estoqueCODIGO = e.estoqueCODIGO,
                                            estoqueLOCAL = e.estoqueLOCAL,
                                            estoqueDETALHES = e.estoqueDETALHES,
                                            //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                            estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                            estoqueDATA = e.estoqueDATA
                                        }).ToList();

            return result;
        }


        /*********************************************************/
        //SELECT DE RELATÓRIO DE ESTOQUE

        public List<Estoque> buscarEstoqRel(String _nomeLocal)
        {
            var Estoques = dadosArquivoEstoquesBruto;
            //var Movs = dadosArquivoMovimentacoesBruto;

            List<Estoque> result = (from e in Estoques
                                         //join m in Movs
                                         //on e.estoqueCODIGO equals m.movESTOQUECOD
                                         //where 
                                         select new Estoque()
                                         {
                                             estoqueCODIGO = e.estoqueCODIGO,
                                             estoqueLOCAL = e.estoqueLOCAL,
                                             estoqueDETALHES = e.estoqueDETALHES,
                                             //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                             estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                             estoqueDATA = e.estoqueDATA
                                         }).ToList();
         return result;
        }
        /*********************************************************/
        //SELECT DE RELATÓRIO DE MOVIMENTAÇÃO

        public List<Movimentacao> buscarMovRel(String _nomeLocal)
        {

            var Movs = dadosArquivoMovimentacoesBruto;

            List<Movimentacao> result = (from m in Movs
                                         //join estoque in Estoques
                                         //on m.movESTOQUECOD equals estoque.estoqueCODIGO
                                         //where estoque.estoqueCODIGO == _nomeLocal
                                         select new Movimentacao()
                                           {
                                               movCODIGO = m.movCODIGO,
                                               movESTOQUECOD = m.movESTOQUECOD,
                                               movPRODUTOCOD = m.movPRODUTOCOD,
                                               movDETALHES = m.movDETALHES,
                                               movOPERACAO = m.movOPERACAO,
                                               movQUANTIDADE = m.movQUANTIDADE,
                                               movQPRODTOTAL = m.movQPRODTOTAL,
                                               movQTOTAL = m.movQTOTAL,
                                               movDATA = m.movDATA
                                           })//.OrderByDescending(d => d.movDATA))
                                           .ToList();
            return result;
        }

        /*********************************************************/
        //SELECT DE MOVIMENTAÇÃO COMPLETA

        public List<MovComp> buscarMovCompRel(String _nomeLocal)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var Produtos = ProdutoDao.dadosArquivoProdutosBruto;

            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;


            List<MovComp> result = new List<MovComp>();

            //dynamic result = new ExpandoObject();
            result = (from m in Movs
                      join prod in Produtos
                      on m.movPRODUTOCOD equals prod.dadosCODIGO
                      join estoque in Estoques
                      on m.movESTOQUECOD equals estoque.estoqueCODIGO
                      where (m.movCODIGO == _nomeLocal) && (estoque.estoqueDATA == m.movDATA) && (prod.dadosDATA == m.movDATA)
                      select new MovComp()
                      {

                          //ADICIONA OS DADOS DE MOVIMENTACAO ESCOLHIDA
                          mov_CODIGO = m.movCODIGO,
                          //mov_ESTOQUECOD = m.movESTOQUECOD,
                          //mov_PRODUTOCOD = m.movPRODUTOCOD,
                          mov_DETALHES = m.movDETALHES,
                          mov_OPERACAO = m.movOPERACAO,
                          mov_QUANTIDADE = m.movQUANTIDADE,
                          mov_QPRODESTOQ = m.movQPRODESTOQ,
                          //mov_QPRODTOTAL = m.movQPRODTOTAL,
                          //mov_QTOTAL = m.movQTOTAL,
                          mov_DATA = m.movDATA,

                          /*/
                          result.Add("mov_CODIGO", m.movCODIGO),
                          result.Add("mov_ESTOQUECOD", m.movCODIGO),
                          result.Add("mov_PRODUTOCOD", m.movPRODUTOCOD),
                          result.Add("mov_DETALHES", m.movDETALHES),
                          result.Add("mov_OPERACAO", m.movOPERACAO),
                          result.Add("mov_QUANTIDADE", m.movQUANTIDADE),
                          result.Add("mov_QPRODTOTAL", m.movQPRODTOTAL),
                          result.Add("mov_QTOTAL", m.movQTOTAL),
                          result.Add("mov_DATA", m.movDATA),
                          /*/

                          //ADICIONA OS DADOS DE PRODUTO AFETADO
                          produto_CODIGO = prod.dadosCODIGO,
                          produto_PRODUTO = prod.dadosPRODUTO,
                          produto_DIMENSOES = prod.dadosDIMENSOES,
                          produto_DETALHES = prod.dadosDETALHES,
                          //produto_OPERACAO = prod.dadosOPERACAO,
                          //produto_MOVIMENTACAO = prod.dadosMOVIMENTACAO,
                          produto_QUANTIDADE = prod.dadosQUANTIDADE,
                          produto_VALOR = prod.dadosVALOR,
                          produto_VALORTOTAL = prod.dadosVALORTOTAL,
                          //produto_DATA = prod.dadosDATA,
                          produto_SERIE = prod.dadosSERIE,
                          produto_NOTAFISCAL = prod.dadosNOTAFISCAL,
                          produto_SEQ = prod.dadosSEQ,
                          produto_FORNECEDOR = prod.dadosFORNECEDOR,
                          produto_COMPLEMENTO = prod.dadosCOMPLEMENTO,
                          produto_STATUS = prod.dadosSTATUS,



                          /*/
                          result.Add("produto_CODIGO", prod.dadosCODIGO),
                          result.Add("produto_PRODUTO", prod.dadosPRODUTO),
                          result.Add("produto_DIMENSOES", prod.dadosDIMENSOES),
                          result.Add("produto_DETALHES", prod.dadosDETALHES),
                          result.Add("produto_OPERACAO", prod.dadosOPERACAO),
                          result.Add("produto_MOVIMENTACAO", prod.dadosMOVIMENTACAO),
                          result.Add("produto_QUANTIDADE", prod.dadosQUANTIDADE),
                          result.Add("produto_VALOR", prod.dadosVALOR),
                          result.Add("produto_VALORTOTAL", prod.dadosVALORTOTAL),
                          result.Add("produto_DATA", prod.dadosDATA),
                          result.Add("produto_SERIE", prod.dadosSERIE),
                          result.Add("produto_NOTAFISCAL", prod.dadosNOTAFISCAL),
                          result.Add("produto_SEQ", prod.dadosSEQ),
                          result.Add("produto_FORNECEDOR", prod.dadosFORNECEDOR),
                          result.Add("produto_COMPLEMENTO", prod.dadosCOMPLEMENTO),
                          result.Add("produto_STATUS", prod.dadosSTATUS),
                          /*/

                          //ADICIONA OS DADOS DE ESTOQUE AFETADO
                          estoque_CODIGO = estoque.estoqueCODIGO,
                          estoque_LOCAL = estoque.estoqueLOCAL,
                          estoque_DETALHES = estoque.estoqueDETALHES,
                          estoque_QUANTIDADE = estoque.estoqueQUANTIDADE,
                          //estoque_DATA = estoque.estoqueDATA



                          /*/
                          result.Add("estoque_CODIGO", estoque.estoqueCODIGO),
                          result.Add("estoque_LOCAL", estoque.estoqueLOCAL),
                          result.Add("estoque_DETALHES", estoque.estoqueDETALHES),
                          result.Add("estoque_QUANTIDADE", estoque.estoqueQUANTIDADE),
                          result.Add("estoque_DATA", estoque.estoqueDATA)
                          /*/

                      }).ToList();
                      //.OrderByDescending(d => d.movDATA)) 

          
            return result;
        }














        /*********************************************************/
        // TRANSFORMA CADA ITEM DA LISTA EM UMA STRING 
        //não é o melhor método para escrever no CSV

        public String objToString(String _tipoRel, Boolean _Header)
        {
            ControleDAO controle = new ControleDAO();
            String headerString = "";

            if (_tipoRel == "mov"){

            int i = 0;
                List<String> _header = controle.dadosHeaderMov.ToList<String>();
                //var headerSemSTATUS = _header.ToList<String>();
                //headerSemSTATUS.Remove("STATUS");

                if (_Header == true)
                {
                    var headerSemSTATUS = _header.ToList<String>();
                    try
                    {
                        headerSemSTATUS.Remove("STATUS");
                        _header = headerSemSTATUS;
                    }
                    catch
                    {
                        //Não conseguiu remover o campo STATUS
                    }
                }

            foreach (String campo in _header)
                {
                    //List<String> headerNovo = new List<string>();
                    //headerNovo.Add(campo);

                    //if (!((campo == "STATUS") && (_tipoRel == "prod") && (_Status == true)))
                    //{  //Se status retornar true, é porque será SEM STATUS
                    // SE campo NÃO for igual a Status, Prod e True

                    if (i == 0) //Primeiro campo
                    {
                        headerString = campo;
                    }
                    /*/else if ((i - 1) == (_header.Count()))
                    { //Último campo
                        headerString = headerString + "; " + campo;
                    }/*/
                    else //Se forem os campos do meio
                    {
                        headerString = headerString + "; " + campo;
                    }
                    i++;
                }
            }
            else if (_tipoRel == "estoq")
            {
                int i = 0;
                List<String> _header = controle.dadosHeaderEstoq.ToList<String>();


                if (_Header == true)
                {
                    var headerSemSTATUS = _header.ToList<String>();
                    try
                    {
                        headerSemSTATUS.Remove("STATUS");
                        _header = headerSemSTATUS;
                    }
                    catch
                    {
                        //Não conseguiu remover o campo STATUS
                    }
                }


                foreach (String campo in _header)
                {
                    if (i == 0) //Primeiro campo
                    {
                        headerString = campo;
                    }/*/
                    else if ((i - 1) == (_header.Count()))
                    { //Último campo
                        headerString = headerString + "; " + campo;
                    }/*/
                    else //Se forem os campos do meio
                    {
                        headerString = headerString + "; " + campo;
                    }
                    i++;
                }
            } else if (_tipoRel == "movcomp")
            {
                int i = 0;
                List<String> _header = controle.dadosHeaderMovComp.ToList<String>();

                if (_Header == true)
                {
                    var headerSemSTATUS = _header.ToList<String>();
                    try
                    {
                        headerSemSTATUS.Remove("STATUS");
                        _header = headerSemSTATUS;
                    }
                    catch
                    {
                        //Não conseguiu remover o campo STATUS
                    }
                }


                foreach (String campo in _header)
                {
                    if (i == 0) //Primeiro campo
                    {
                        headerString = campo;
                    }/*/
                    else if ((i - 1) == (_header.Count()))
                    { //Último campo
                        headerString = headerString + "; " + campo;
                    }/*/
                    else //Se forem os campos do meio
                    {
                        headerString = headerString + "; " + campo;
                    }
                    i++;


                }

            }


            return headerString;

        }


        /*********************************************************/
        // PREPARA E ESCREVE O CSV DO RELATÓRIO


        public void prepararCSV(List<dynamic> moviment, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            ControleDAO controle = new ControleDAO();
            String caminhoArquivos = controle.dadosCaminhoArquivos;
            string relatorioPath = caminhoArquivos + "/Relatórios"; //ONDE O RELATÓRIO SERÁ SALVO
            DateTime localDate = DateTime.Now;
            String relatorioFile = relatorioPath + "/" + _nomeLocal + "_" + _nomeRel + "_" + localDate.ToString("dd-MM-yyyy_H\\hmm") + ".csv";

            //SOBREESCREVE O ARQUIVO DE MESMO NOME
            using (var writer = new StreamWriter(relatorioFile, false, Encoding.UTF8))
            {

                // var headerSemSTATUS = header.ToList<String>();
                //headerSemSTATUS.Remove("STATUS");

                //var movimentSemSTATUS = moviment.ToList<String>();
                //movimentSemSTATUS.Remove("STATUS");

                //var prodSemSTATUS = prod.Select(p => new { "dadosSTATUS" = p.dadosSTATUS }).ToList();


                var headerString = objToString(_tipoRel, _Header); //Preencheu o campo header, vai escrevê-lo como String agora

                if (_Header == false)
                { //Se header retornar true, é porque será SEM HEADER
                    writer.WriteLine(headerString);

                }

                foreach (var item in moviment)
                {
                    //var toExclude = new HashSet<string>();
                    // String sfsokfo = string.Join("; ", props.Select(p => p.GetValue(item, null)));
                    //delete item.dadosSTATUS;

                    var typeItem = item.GetType();

                    //var propriedades = item.GetType().GetProperties();
                    //var propertyInfo = item.GetType().GetProperties();
                    //var propriedades = propertyInfo.GetValue();
                    String itemString = "";
                    int i = 0;
                    foreach (PropertyInfo propriedade in typeItem.GetProperties())
                    {
                        
                        if (!(((propriedade.Name == "movSTATUS")||(propriedade.Name == "estoqSTATUS")) && (_Status == true)))
                        {  //Se status retornar true, é porque será SEM STATUS
                           // SE campo NÃO for igual a Status, Prod e True

                            //val.Add((item.GetValue(objeto) ?? "").ToString());

                            if (i == 0) //Primeiro campo
                            {
                                //var val = propriedade.GetValue();
                                //itemString = propriedade.ToString();
                                itemString = (propriedade.GetValue(item, null)).ToString();

                            }/*/
                            else if ((i - 1) == (propriedades.Count()))
                            { //Último campo

                                itemString = headerString + "; " + propriedade;

                            }/*/
                            else //Se forem os campos do meio
                            {
                                //itemString = itemString + "; " + propriedade.ToString();
                                itemString = itemString + "; " + (propriedade.GetValue(item, null)).ToString();
                            }

                            i++;
                        }
                    }

                    //Já pode escrever a primeira linha
                    writer.WriteLine(itemString);

                }
            }
        }
        /*********************************************************/


        /*/
                if (_Header == false)
                { //Se header retornar true, é porque será SEM HEADER

                    //writer.WriteLine(string.Join("; ", props.Select(p => p.Name)));
                    writer.WriteLine(string.Join("; ", header.Select(p => p.Name)));
                    //writer.WriteLine(header);

                }
/*/






        /*********************************************************/

        //writer.Close();



        /*/
        // create the rows you need to append
        StringBuilder sb = new StringBuilder();
        foreach (Movimentacao row in moviment)
            sb.AppendFormat(",{0}", row);

        // flush all rows once time.
        File.AppendAllText(relatorioFile, sb.ToString(), Encoding.UTF8);
        /*/





        /*/
            //RECUPERA UM RELATÓRIO JÁ EXISTENTE
            Type itemType = null;
            dynamic relatorioSalvo;
            //var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name);
            //IOrderedEnumerable<PropertyInfo> props = null;
            String header = null;
            if (_tipoRel == "Mov") //VAI LER UMA LISTA DE MOVIMENTAÇÕES
            {
                itemType = typeof(Movimentacao);
                IEnumerable<Movimentacao> arquivoRel = lerRelatorio(_nomeRel, relatorioFile, _tipoRel); //Vai checar se o relatório existe e pegar o arquivo dele.
                relatorioSalvo = typeof(Movimentacao);
                relatorioSalvo = arquivoRel;
                header = headerMov;
            }
            else {

                if (_tipoRel == "Prod") //VAI LER UMA LISTA DE PRODUTOS
                {
                    itemType = typeof(Produto);
                    IEnumerable<Produto> arquivoRel = lerRelatorio(_nomeRel, relatorioFile, _tipoRel); //Vai checar se o relatório existe e pegar o arquivo dele.
                    relatorioSalvo = typeof(Produto);
                    relatorioSalvo = arquivoRel;
                    header = headerProd;
                }
                else {
                    if (_tipoRel == "Estoq") //VAI LER UMA LISTA DE PRODUTOS
                    {
                        itemType = typeof(Estoque);
                        IEnumerable<Estoque> arquivoRel = lerRelatorio(_nomeRel, relatorioFile, _tipoRel); //Vai checar se o relatório existe e pegar o arquivo dele.
                        relatorioSalvo = typeof(Estoque);
                        relatorioSalvo = arquivoRel;
                        header = headerEstoq;
                    }
                    else //VAI LER UMA LISTA CUSTOMIZADA
                    {
                        itemType = typeof(Movimentacao);
                        dynamic arquivoRel = lerRelatorio(_nomeRel, relatorioFile, _tipoRel); //Vai checar se o relatório existe e pegar o arquivo dele.
                        relatorioSalvo = typeof(Movimentacao);
                        relatorioSalvo = arquivoRel;
                        header = headerMov;
                    }
                }
            }

           var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
           /*/


        /*/
    public dynamic lerRelatorio(String _nomeRel, String relatorioFile, String _tipoRel)
    {

        System.IO.Directory.CreateDirectory(caminhoArquivos); // VAI CRIAR O DIRETÓRIO SE ELE NÃO EXISTIR
                                                              //File.Create(relatorioFile).Close(); // VAI CRIAR O ARQUIVO SE ELE NÃO EXISTIR

        //var oldRel;

        if (_tipoRel == "Mov") //VAI LER UMA LISTA DE MOVIMENTAÇÕES
        {
            //IEnumerable<Movimentacao> oldRel = null;
            if (!File.Exists(relatorioFile)) //O ARQUIVO NÃO EXISTE NA PASTA
            {
                using (StreamWriter newbornMov = File.CreateText(relatorioFile))
                {
                    newbornMov.WriteLine(headerMov); //Criou e já escreveu o header
                    return null;
                }
            }
            else //O ARQUIVO  EXISTE NA PASTA
            {
                return CSVtoIENUMMov(relatorioFile);

            }


        }
        else {

            if (_tipoRel == "Prod") //VAI LER UMA LISTA DE PRODUTOS
            {
                if (!File.Exists(relatorioFile)) //O ARQUIVO NÃO EXISTE NA PASTA
                {
                    using (StreamWriter newbornMov = File.CreateText(relatorioFile))
                    {
                        newbornMov.WriteLine(headerProd); //Criou e já escreveu o header
                        return null;
                    }
                }
                else //O ARQUIVO  EXISTE NA PASTA
                {

                    ProdutoDao ProdutoDAO = new ProdutoDao();
                    return ProdutoDAO.CSVtoIENUMProd(relatorioFile);

                }


            }
            else {
                if (_tipoRel == "Estoq") //VAI LER UMA LISTA DE PRODUTOS
                {

                    if (!File.Exists(relatorioFile)) //O ARQUIVO NÃO EXISTE NA PASTA
                    {
                        using (StreamWriter newbornMov = File.CreateText(relatorioFile))
                        {
                            newbornMov.WriteLine(headerEstoq); //Criou e já escreveu o header
                            return null;
                        }
                    }
                    else //O ARQUIVO  EXISTE NA PASTA
                    {
                        return CSVtoIENUMEstoq(relatorioFile);

                    }


                }
                else //VAI LER UMA LISTA CUSTOMIZADA
                {
                    if (!File.Exists(relatorioFile)) //O ARQUIVO NÃO EXISTE NA PASTA
                    {
                        using (StreamWriter newbornMov = File.CreateText(relatorioFile))
                        {

                            //newbornMov.WriteLine(headerEstoq); //Criou e já escreveu o header
                            //IEnumerable<Movimentacao> oldRelMovo = null;
                            return null;
                        }
                    }
                    else //O ARQUIVO  EXISTE NA PASTA
                    {
                        return CSVtoIENUMEstoq(relatorioFile);

                    }
                }
            }
        }
    }
    /*/

        /*********************************************************/
        //SELECT DE MOVIMENTAÇÃO COMPLETA POR ESTOQUE

        public List<MovComp> buscarMovCompEstoque(String _codEstoque)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var Produtos = ProdutoDao.dadosArquivoProdutosBruto;
            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;
            
            List<MovComp> result = new List<MovComp>();

            //dynamic result = new ExpandoObject();
            result = (from m in Movs
                      join prod in Produtos
                      on m.movPRODUTOCOD equals prod.dadosCODIGO
                      join estoque in Estoques
                      on m.movESTOQUECOD equals estoque.estoqueCODIGO
                      where (estoque.estoqueCODIGO == _codEstoque) && (estoque.estoqueDATA == m.movDATA) && (prod.dadosDATA == m.movDATA)
                      select new MovComp()
                      {

                          //ADICIONA OS DADOS DE MOVIMENTACAO ESCOLHIDA
                          mov_CODIGO = m.movCODIGO,
                          mov_DETALHES = m.movDETALHES,
                          mov_OPERACAO = m.movOPERACAO,
                          mov_DATA = m.movDATA,

                          //ADICIONA OS DADOS DE PRODUTO AFETADO
                          produto_CODIGO = prod.dadosCODIGO,
                          produto_PRODUTO = prod.dadosPRODUTO,
                          produto_DIMENSOES = prod.dadosDIMENSOES,
                          produto_DETALHES = prod.dadosDETALHES,
                          produto_QUANTIDADE = prod.dadosQUANTIDADE,
                          produto_VALOR = prod.dadosVALOR,
                          produto_VALORTOTAL = prod.dadosVALORTOTAL,
                          produto_SERIE = prod.dadosSERIE,
                          produto_NOTAFISCAL = prod.dadosNOTAFISCAL,
                          produto_SEQ = prod.dadosSEQ,
                          produto_FORNECEDOR = prod.dadosFORNECEDOR,
                          produto_COMPLEMENTO = prod.dadosCOMPLEMENTO,
                          produto_STATUS = prod.dadosSTATUS,

                          //ADICIONA OS DADOS DE ESTOQUE AFETADO
                          estoque_CODIGO = estoque.estoqueCODIGO,
                          estoque_LOCAL = estoque.estoqueLOCAL,
                          estoque_DETALHES = estoque.estoqueDETALHES,
                          estoque_QUANTIDADE = estoque.estoqueQUANTIDADE

                      }).ToList();
            return result;
        }


        /*********************************************************/
        //SELECT DE MOVIMENTAÇÃO COMPLETA POR ESTOQUE

        public List<MovComp> buscarMovCompEstoqueProd(String _codProd, String _codEstoq)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var Produtos = ProdutoDao.dadosArquivoProdutosBruto;
            var Estoques = dadosArquivoEstoquesBruto;
            var Movs = dadosArquivoMovimentacoesBruto;

            List<MovComp> result = new List<MovComp>();

            //dynamic result = new ExpandoObject();
            result = (from m in Movs
                      join prod in Produtos
                      on m.movPRODUTOCOD equals prod.dadosCODIGO
                      join estoque in Estoques
                      on m.movESTOQUECOD equals estoque.estoqueCODIGO
                      where (estoque.estoqueCODIGO == _codEstoq) && (prod.dadosCODIGO == _codProd) && (estoque.estoqueDATA == m.movDATA) && (prod.dadosDATA == m.movDATA)
                      select new MovComp()
                      {
                          //ADICIONA OS DADOS DE MOVIMENTACAO ESCOLHIDA
                          mov_CODIGO = m.movCODIGO,
                          mov_DETALHES = m.movDETALHES,
                          mov_OPERACAO = m.movOPERACAO,
                          mov_DATA = m.movDATA,

                          //ADICIONA OS DADOS DE PRODUTO AFETADO
                          produto_CODIGO = prod.dadosCODIGO,
                          produto_PRODUTO = prod.dadosPRODUTO,
                          produto_DIMENSOES = prod.dadosDIMENSOES,
                          produto_DETALHES = prod.dadosDETALHES,
                          produto_QUANTIDADE = prod.dadosQUANTIDADE,
                          produto_VALOR = prod.dadosVALOR,
                          produto_VALORTOTAL = prod.dadosVALORTOTAL,
                          produto_SERIE = prod.dadosSERIE,
                          produto_NOTAFISCAL = prod.dadosNOTAFISCAL,
                          produto_SEQ = prod.dadosSEQ,
                          produto_FORNECEDOR = prod.dadosFORNECEDOR,
                          produto_COMPLEMENTO = prod.dadosCOMPLEMENTO,
                          produto_STATUS = prod.dadosSTATUS,

                          //ADICIONA OS DADOS DE ESTOQUE AFETADO
                          estoque_CODIGO = estoque.estoqueCODIGO,
                          estoque_LOCAL = estoque.estoqueLOCAL,
                          estoque_DETALHES = estoque.estoqueDETALHES,
                          estoque_QUANTIDADE = estoque.estoqueQUANTIDADE

                      }).ToList();
            return result;
        }























    }
}
