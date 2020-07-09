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
using System.Dynamic;
using System.IO;
using System.Text;
using MoreLinq;

namespace InventarioDados
{

    public class ProdutoDao
    {
        //PATH GLOBAL
        //string headerProduto = "CODIGO; PRODUTO; DIMENSOES; DETALHES; OPERACAO; MOVIMENTACAO; QUANTIDADE; VALOR; VALORTOTAL; DATA; SERIE; NOTAFISCAL; SEQ; FORNECEDOR; COMPLEMENTO; STATUS";
       


        //VARIÁVEL GLOBAL
        private static IEnumerable<Produto> arquivoProdutosBruto;
        public static IEnumerable<Produto> dadosArquivoProdutosBruto
        {
            get { return arquivoProdutosBruto; }
            set { arquivoProdutosBruto = value; }
        }

        /*********************************************************/
        // SALVA O NOVO PRODUTO   (SEM BD)

        public Boolean salvarProduto(Produto Produto)
        {
            Boolean salvo = false;
            salvo = true;

            return salvo;
        }


        /*********************************************************/
        // FAZ A ALTERAÇÃO DO PRODUTO EXISTENTE   (SEM BD)

        public Boolean alterarProduto(Produto Produto)
        {
            Boolean salvo = false;

            salvo = true;

            return salvo;
        }

        /*********************************************************/
        //CARREGA A LISTA MOCK DE PRODUTOS (NÃO ESTÁ USANDO)

        public List<Produto> carregarProdutos()
        {
            List<Produto> listaDeProdutos = new List<Produto>();
            mockListaDeProdutos(listaDeProdutos);
            return listaDeProdutos;
        }


        /*********************************************************/
        // MOCK DE PRODUTOS

        public void mockListaDeProdutos(List<Produto> listaDeProdutos)
        {
            Produto Produto1 = new Produto();
            Produto1.dadosCODIGO = "123456";
            Produto1.dadosPRODUTO = "SANCTIFIED WITH DYNAMITE";
            Produto1.dadosQUANTIDADE = 50;
            Produto1.dadosVALOR = 1.50;
            Produto1.dadosDIMENSOES = "24cm/34cm";
            Produto1.dadosDETALHES = "DIE DIE DYNAMITE";
            Produto1.dadosFORNECEDOR = "POWERWOLF";

            Produto1.dadosOPERACAO = "ENTRADA DE FORNECEDOR";
            Produto1.dadosMOVIMENTACAO = 10;
            Produto1.dadosVALORTOTAL = 90.00;
            Produto1.dadosSERIE = "HOLY WAR";
            Produto1.dadosDATA = DateTime.Parse("14/06/2007 15:34:02");
            Produto1.dadosNOTAFISCAL = "HOLY WAR";
            Produto1.dadosSEQ = "HOLY WAR";
            Produto1.dadosCOMPLEMENTO = "HOLY WAR HOLY WAR HOLY WAR";

            listaDeProdutos.Add(Produto1);



            Produto Produto2 = new Produto();
            Produto1.dadosCODIGO = "654321";
            Produto1.dadosPRODUTO = "HALL OF THE MOUNTAIN KING";
            Produto1.dadosQUANTIDADE = 30;
            Produto1.dadosVALOR = 2.50;
            Produto1.dadosDIMENSOES = "27m/33cm";
            Produto1.dadosDETALHES = "I'M THE MOUNTAIN KING";
            Produto1.dadosFORNECEDOR = "RAINBOW";

            Produto1.dadosOPERACAO = "ENTRADA DE FORNECEDOR";
            Produto1.dadosMOVIMENTACAO = 5;
            Produto1.dadosVALORTOTAL = 57.50;
            Produto1.dadosSERIE = "TRY BUT YOU CANNOT ESCAPE";
            Produto1.dadosDATA = DateTime.Parse("13/06/2013 17:54:22");
            Produto1.dadosNOTAFISCAL = "ARE YOU NOT AFRAID?";
            Produto1.dadosSEQ = "ARE YOU NOT AFRAID?";
            Produto1.dadosCOMPLEMENTO = "ARE YOU NOT AFRAID?";

            listaDeProdutos.Add(Produto1);

        }

        /*********************************************************/
        //TENTA LER O ARQUIVO OU CRIA UM NOVO


        public void lerArquivo()
        //public List<Produto> lerArquivo()
        {
            ControleDAO controle = new ControleDAO();
            String caminhoArquivos = controle.dadosCaminhoArquivos;
            String[] headerProduto = controle.dadosHeaderProd;
            

            string pathProduto = System.IO.Path.Combine(caminhoArquivos, "inventario_nimal.csv");

            // if (Directory.Exists(caminhoArquivos)) // Testa se o diretório existe
            // {

            System.IO.Directory.CreateDirectory(caminhoArquivos); // VAI CRIAR O DIRETÓRIO SE ELE NÃO EXISTIR
            if (!File.Exists(pathProduto)) //O ARQUIVO NÃO EXISTE NA PASTA
            {
                using (StreamWriter newborn = File.CreateText(pathProduto))
                {
                    newborn.WriteLine(headerProduto); //Criou e já escreveu o header.
                    dadosArquivoProdutosBruto = null;
                }

            }
            else //O ARQUIVO  EXISTE NA PASTA
            {
                dadosArquivoProdutosBruto = CSVtoIENUMProd(pathProduto); //Chama o conversor

            }

        }

        /*********************************************************/
        //CONVERTE CSV PARA LISTA IENUMERABLE

        public IEnumerable<Produto> CSVtoIENUMProd (String _pathProduto) { 

        //Se comunica com o arquivo de produtos

        CsvContext cc = new CsvContext();
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ';',
                    FirstLineHasColumnNames = true,
                    FileCultureName = "pt-BR" // default is the current culture
                };

                //IEnumerable<string> produtos = new IEnumerable<string>();


                IEnumerable<Produto> produtos =
                    cc.Read<Produto>(_pathProduto, inputFileDescription);

                var produtosByCod =
                from p in produtos
                orderby p.dadosCODIGO
                select new
                {
                    p.dadosCODIGO,
                    p.dadosPRODUTO,
                    p.dadosDIMENSOES,
                    p.dadosDETALHES,
                    p.dadosOPERACAO,
                    p.dadosMOVIMENTACAO,
                    p.dadosQUANTIDADE,
                    p.dadosVALOR,
                    p.dadosVALORTOTAL,
                    p.dadosDATA,
                    p.dadosSERIE,
                    p.dadosNOTAFISCAL,
                    p.dadosSEQ,
                    p.dadosFORNECEDOR,
                    p.dadosCOMPLEMENTO,
                    p.dadosSTATUS
                };
                //Console.Write("O primeiro produto é:" + produtosByCod.First().dadosCODIGO);
                //produtosByCod.Dump();

                //Joga na variável Global
                //dadosArquivoProdutos = produtos.ToList();

                //Joga na variável Global Bruta
                return produtos;


            }

        /*********************************************************/
        // ARMAZENAR LISTA DO ARQUIVO EM UM BD SQL

        public DataTable preencherBanco()
        {
            //Se comunica com o arquivo de produtos

            CsvContext cc = new CsvContext();
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ';',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            IEnumerable<Produto> produtos =
                cc.Read<Produto>("C:/Users/yasmin.feitosa/Documents/Visual Studio 2015/Projects/Inventario Base/inventario_nimal.csv", inputFileDescription);

            /*/
            var produtosByCod =
            from p in produtos
            orderby p.dadosCODIGO
            select new
            {
                p.dadosCODIGO,
                p.dadosPRODUTO,
                p.dadosDIMENSOES,
                p.dadosDETALHES,
                p.dadosOPERACAO,
                p.dadosMOVIMENTACAO,
                p.dadosQUANTIDADE,
                p.dadosVALOR,
                p.dadosVALORTOTAL,
                p.dadosDATA,
                p.dadosSERIE,
                p.dadosNOTAFISCAL,
                p.dadosSEQ,
                p.dadosFORNECEDOR,
                p.dadosCOMPLEMENTO,
                p.dadosSTATUS
            };
            /*/

            var tb = new DataTable(typeof(Produto).Name);

            PropertyInfo[] props = typeof(Produto).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var produto in produtos)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(produto, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }




            /*/


            IEnumerable<System.Data.DataRow> queryProjects =
                (IEnumerable<System.Data.DataRow>)(from System.Data.DataRow p in produtos.AsEnumerable()
                                         //orderby p.Field < string >("Codigo") == dadosCODIGO
                                         select new
                                          // where p.Field<int>("STREAM_ID") == StreamID
                                          //select new
                                         {
                                             //PROJECT_ID = p.Field<int>("PROJECT_ID"),
                                             //PROJECT_NAME = p.Field<int>("PROJECT_NAME")
                                             /*/
            /*/
            p.dadosCODIGO,
            p.dadosPRODUTO,
            p.dadosDIMENSOES,
            p.dadosDETALHES,
            p.dadosOPERACAO,
            p.dadosMOVIMENTACAO,
            p.dadosQUANTIDADE,
            p.dadosVALOR,
            p.dadosVALORTOTAL,
            p.dadosDATA,
            p.dadosSERIE,
            p.dadosNOTAFISCAL,
            p.dadosSEQ,
            p.dadosFORNECEDOR,
            p.dadosCOMPLEMENTO,
            p.dadosSTATUS

        });
/*/
            /*/
                        produtosByCod.Columns.Add(
                            new DataColumn()
                            {
                                DataType = System.Type.GetType("System.String"),//or other type
                                ColumnName = "Name"      //or other column name
                        }
                        );

                        foreach (var element in query)
                        {
                            var row = MyDataTable.NewRow();
                            row["Name"] = element.NewObject;
                            myDataTable.Rows.Add(row);
                        }
                          /*/

        

        /*********************************************************/
        // 
        /*/
        public IEnumerable<Produto> buscarEspecificoTESTE()
        {
            // List<Produto> produtosByCod = new List<Produto>();
            //IEnumerable<Produto> produtosByCod = dadosArquivoProdutosBruto;

            // var  produtosByCod = dadosArquivoProdutos;

            IEnumerable<Produto> query = arquivoProdutosBruto.Where(produto => produto.dadosSTATUS == "VALIDO");
            var result = query;

            var produtosByCod =
            from p in dadosArquivoProdutosBruto
            where p.dadosSTATUS == "VALIDO"
            orderby p.dadosCODIGO
            select new
            {
                p.dadosCODIGO,
                p.dadosPRODUTO,
                p.dadosDIMENSOES,
                p.dadosDETALHES,
                p.dadosOPERACAO,
                p.dadosMOVIMENTACAO,
                p.dadosQUANTIDADE,
                p.dadosVALOR,
                p.dadosVALORTOTAL,
                p.dadosDATA,
                p.dadosSERIE,
                p.dadosNOTAFISCAL,
                p.dadosSEQ,
                p.dadosFORNECEDOR,
                p.dadosCOMPLEMENTO,
                p.dadosSTATUS
            };



            var produtosByCod2 =
            from p in dadosArquivoProdutosBruto
            where p.dadosSTATUS == "VALIDO"
            orderby p.dadosCODIGO
            select new
            {
                p.dadosCODIGO,
                p.dadosPRODUTO,
                p.dadosDIMENSOES,
                p.dadosDETALHES,
                p.dadosOPERACAO,
                p.dadosMOVIMENTACAO,
                p.dadosQUANTIDADE,
                p.dadosVALOR,
                p.dadosVALORTOTAL,
                p.dadosDATA,
                p.dadosSERIE,
                p.dadosNOTAFISCAL,
                p.dadosSEQ,
                p.dadosFORNECEDOR,
                p.dadosCOMPLEMENTO,
                p.dadosSTATUS
            };




            //List<Produto> result = produtosByCod.ToList<Produto>();

            //return produtosByCod.ToList();
            // return produtosByCod.ToList();

            return result;
            //return produtosByCod.Cast<Produto>();  //Retorna IEnumerable
            //List<Produto> listaEncontrada = new List<Produto>(produtosByCod);
            //return (produtosByCod.Cast<Produto>()).ToList();

        }
        /*/

        /*********************************************************/
        // TRANSFORMA CADA ITEM DA LISTA DE MOVIMENTAÇÃO EM UMA STRING 
        //não é o melhor método para escrever no CSV

        public String objToString(String _tipoRel, Boolean _Status)
        {
            ControleDAO controle = new ControleDAO();
            String headerString = "";

            if (_tipoRel == "prod") {
                int i = 0;
                List<String> _header = controle.dadosHeaderProd.ToList<String>(); ;


                if (_Status == true) // Se status retornar true, é porque será SEM STATUS
                { // Vai criar outra lista header só que sem o campo STATUS

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
                    }
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

                var headerString = objToString(_tipoRel, _Status); //Preencheu o campo header, vai escrevê-lo como String agora

                if (_Header == false)
                { //Se header retornar true, é porque será SEM HEADER
                    writer.WriteLine(headerString);
                }

                foreach (var item in moviment)
                {

                    var typeItem = item.GetType();
                    String itemString = "";
                    int i = 0;
                    foreach (PropertyInfo propriedade in typeItem.GetProperties())
                    {
                        if (!((propriedade.Name == "dadosSTATUS") && (_Status == true)))
                        {  //Se status retornar true, é porque será SEM STATUS
                           // SE campo NÃO for igual a Status, Prod e True

                            if (i == 0) //Primeiro campo
                            {
                                itemString = (propriedade.GetValue(item, null)).ToString();
                            }
                            else //Se forem os campos do meio
                            {
                                itemString = itemString + "; " + (propriedade.GetValue(item, null)).ToString();
                            }
                            i++;

                        } else {
                            //Se for o campo STATUS e SEMSTATUS for true
                            //Não faz nada
                        }
                    }
                    //Já pode escrever a primeira linha
                    writer.WriteLine(itemString);

                }
            }
        }

        /*********************************************************/
        // SELECT DE PRODUTOS EM ESTOQUE

        public List<Produto> buscarProdMovLocal(String _localescolhido)
        {
            //IEnumerable<Produto> query = arquivoProdutosBruto.Where(produto => produto.dadosSTATUS == "VALIDO");
            //var result = query;

            var Produtos = dadosArquivoProdutosBruto;
            var Estoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            var Movs = EstoqueDAO.dadosArquivoMovimentacoesBruto;



            List<Produto> result = (from produto in Produtos
                                          join mov in Movs
                                          on produto.dadosCODIGO equals mov.movPRODUTOCOD
                                          where produto.dadosCODIGO == mov.movPRODUTOCOD
                                          join estoque in Estoques
                                          on mov.movESTOQUECOD equals estoque.estoqueCODIGO
                                          where estoque.estoqueCODIGO == _localescolhido


                                            // group prod by produto.dadosCODIGO into g
                                          select new Produto()
                                          {
                                              dadosCODIGO = produto.dadosCODIGO,
                                              dadosPRODUTO = produto.dadosPRODUTO,
                                              dadosDIMENSOES = produto.dadosDIMENSOES,
                                              dadosDETALHES = produto.dadosDETALHES,
                                              dadosOPERACAO = produto.dadosOPERACAO,
                                              dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                              dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                              dadosVALOR = produto.dadosVALOR,
                                              dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                              dadosDATA = produto.dadosDATA,
                                              dadosSERIE = produto.dadosSERIE,
                                              dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                              dadosSEQ = produto.dadosSEQ,
                                              dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                              dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                              dadosSTATUS = produto.dadosSTATUS
                                          }).ToList();



           

            /*/
            produtosListaUnicos = (from r in resultadoBusca
                                   group r by r.dadosCODIGO into g
                                   select new Produto()
                                   {
                                       dadosCODIGO = g.Key,
                                       dadosDATA = g.Max(t => t.dadosDATA)
                                   }).ToList();
            /*/


            return result;
        }


        /*********************************************************/

        public List<Produto> buscarProdOperacao(String _opEscolhida)
        {
            var Produtos = dadosArquivoProdutosBruto;
            //var Estoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            var Movs = EstoqueDAO.dadosArquivoMovimentacoesBruto;

            List<Produto> result = (from produto in Produtos
                                          join mov in Movs
                                          on produto.dadosCODIGO equals mov.movPRODUTOCOD
                                          where mov.movOPERACAO == _opEscolhida

                                          // group prod by produto.dadosCODIGO into g
                                          select new Produto()
                                          {
                                              dadosCODIGO = produto.dadosCODIGO,
                                              dadosPRODUTO = produto.dadosPRODUTO,
                                              dadosDIMENSOES = produto.dadosDIMENSOES,
                                              dadosDETALHES = produto.dadosDETALHES,
                                              dadosOPERACAO = produto.dadosOPERACAO,
                                              dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                              dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                              dadosVALOR = produto.dadosVALOR,
                                              dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                              dadosDATA = produto.dadosDATA,
                                              dadosSERIE = produto.dadosSERIE,
                                              dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                              dadosSEQ = produto.dadosSEQ,
                                              dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                              dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                              dadosSTATUS = produto.dadosSTATUS
                                          }).ToList();


            return result;
        }



        /*********************************************************/

        public List<Produto> buscarProdAudit(DateTime _dataEscolhida, String _nomeLocal)
        {

            var Produtos = dadosArquivoProdutosBruto;
            //var Estoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            //var Movs = EstoqueDAO.dadosArquivoMovimentacoesBruto;

            List<Produto> result = (from produto in Produtos
                                          //join mov in Movs
                                          //on produto.dadosCODIGO equals mov.movPRODUTOCOD
                                          where (produto.dadosDATA >= _dataEscolhida) && (produto.dadosCODIGO == _nomeLocal)

                                          // group prod by produto.dadosCODIGO into g
                                          select new Produto()
                                          {
                                              dadosCODIGO = produto.dadosCODIGO,
                                              dadosPRODUTO = produto.dadosPRODUTO,
                                              dadosDIMENSOES = produto.dadosDIMENSOES,
                                              dadosDETALHES = produto.dadosDETALHES,
                                              dadosOPERACAO = produto.dadosOPERACAO,
                                              dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                              dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                              dadosVALOR = produto.dadosVALOR,
                                              dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                              dadosDATA = produto.dadosDATA,
                                              dadosSERIE = produto.dadosSERIE,
                                              dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                              dadosSEQ = produto.dadosSEQ,
                                              dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                              dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                              dadosSTATUS = produto.dadosSTATUS
                                          }).ToList();

            return result;
        }


        /*********************************************************/


        public List<Produto> buscarProdValidade(String _nomeLocal)
        {
            String validade = "";
            if (_nomeLocal == "Prod_Valido")
            {
                validade = "VALIDO";
            } else
            {
                validade = "INVALIDO";
            }

            var Produtos = dadosArquivoProdutosBruto;
            //var Estoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            var Movs = EstoqueDAO.dadosArquivoMovimentacoesBruto;

            List<Produto> result = (from produto in Produtos
                                              //join mov in Movs
                                              //on produto.dadosCODIGO equals mov.movPRODUTOCOD
                                          where (produto.dadosSTATUS == validade)

                                          // group prod by produto.dadosCODIGO into g
                                          select new Produto()
                                          {
                                              dadosCODIGO = produto.dadosCODIGO,
                                              dadosPRODUTO = produto.dadosPRODUTO,
                                              dadosDIMENSOES = produto.dadosDIMENSOES,
                                              dadosDETALHES = produto.dadosDETALHES,
                                              dadosOPERACAO = produto.dadosOPERACAO,
                                              dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                              dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                              dadosVALOR = produto.dadosVALOR,
                                              dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                              dadosDATA = produto.dadosDATA,
                                              dadosSERIE = produto.dadosSERIE,
                                              dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                              dadosSEQ = produto.dadosSEQ,
                                              dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                              dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                              dadosSTATUS = produto.dadosSTATUS
                                          }).ToList();

            return result;
        }


        /*********************************************************/
        /*/

        public List<Produto> buscarProdEstoque(String _codProd, String _codEstoq)
        {
            var Produtos = dadosArquivoProdutosBruto;
            var Estoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            var Movs = EstoqueDAO.dadosArquivoMovimentacoesBruto;

            List<Produto> result = (from produto in Produtos
                                    join mov in Movs
                                    on produto.dadosCODIGO equals mov.movPRODUTOCOD
                                    where produto.dadosCODIGO == mov.movPRODUTOCOD
                                    join estoque in Estoques
                                    on mov.movESTOQUECOD equals estoque.estoqueCODIGO
                                    where (estoque.estoqueCODIGO == _codEstoq) && (produto.dadosCODIGO == _codProd)


                                    // group prod by produto.dadosCODIGO into g
                                    select new Produto()
                                    {
                                        dadosCODIGO = produto.dadosCODIGO,
                                        dadosPRODUTO = produto.dadosPRODUTO,
                                        dadosDIMENSOES = produto.dadosDIMENSOES,
                                        dadosDETALHES = produto.dadosDETALHES,
                                        dadosOPERACAO = produto.dadosOPERACAO,
                                        dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                        dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                        dadosVALOR = produto.dadosVALOR,
                                        dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                        dadosDATA = produto.dadosDATA,
                                        dadosSERIE = produto.dadosSERIE,
                                        dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                        dadosSEQ = produto.dadosSEQ,
                                        dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                        dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                        dadosSTATUS = produto.dadosSTATUS
                                    }).ToList();
            return result;
        }
        /*/


        /*********************************************************/
        //BUSCA PARA VALIDAÇÃO DE CADASTRO/ALTERAÇÃO

        public List<Produto> buscaCodValido(String _codProd)
        {
            var Produtos = dadosArquivoProdutosBruto;

            List<Produto> result = (from produto in Produtos
                                    where ((produto.dadosCODIGO == _codProd) && (produto.dadosSTATUS == "VALIDO"))

                                    select new Produto()
                                    {
                                        dadosCODIGO = produto.dadosCODIGO,
                                        dadosPRODUTO = produto.dadosPRODUTO,
                                        dadosDIMENSOES = produto.dadosDIMENSOES,
                                        dadosDETALHES = produto.dadosDETALHES,
                                        dadosOPERACAO = produto.dadosOPERACAO,
                                        dadosMOVIMENTACAO = produto.dadosMOVIMENTACAO,
                                        dadosQUANTIDADE = produto.dadosQUANTIDADE,
                                        dadosVALOR = produto.dadosVALOR,
                                        dadosVALORTOTAL = produto.dadosVALORTOTAL,
                                        dadosDATA = produto.dadosDATA,
                                        dadosSERIE = produto.dadosSERIE,
                                        dadosNOTAFISCAL = produto.dadosNOTAFISCAL,
                                        dadosSEQ = produto.dadosSEQ,
                                        dadosFORNECEDOR = produto.dadosFORNECEDOR,
                                        dadosCOMPLEMENTO = produto.dadosCOMPLEMENTO,
                                        dadosSTATUS = produto.dadosSTATUS
                                    }).ToList();

            return result;
        }



        /*********************************************************/









    }
}
