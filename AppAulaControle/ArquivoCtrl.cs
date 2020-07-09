using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LINQtoCSV;
using Negocio;
using LinqToExcel;

namespace InventarioControle
{
    public class ArquivoCtrl
    {
        //não usarei este controller?

       /*********************************************************/

        //public static List<Produto> arquivoProdutos = new List<Produto>();

        private static List<Produto> arquivoProdutos;
        public static List<Produto> dadosArquivoProdutos
        {
            get { return arquivoProdutos; }
            set { arquivoProdutos = value; }
        }

      /*********************************************************/


        public static void Main(string[] args)
        //public static void Main()
        {
            CsvContext cc = new CsvContext();

            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ';',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            //IEnumerable<string> produtos = new IEnumerable<string>();


            IEnumerable<Produto> produtos =
                cc.Read<Produto>("C:/Users/yasmin.feitosa/Documents/Visual Studio 2015/Projects/Inventario Base/inventario_nimal.csv", inputFileDescription);

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

            foreach (var item in produtosByCod)
            {
                Console.WriteLine(item);
            }









            // NOT SHOWN IN EXAMPLE IN ARTICLE
            // ReadFileWithExceptionHandling();


            // ------------------
            // Simple Read example



            /*/
            CsvContext cc = new CsvContext();

            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            IEnumerable<Produto> produtos =
                cc.Read<Produto>("../../Arquivo/inventario_nimal.csv", inputFileDescription);

            var produtosByCod =
                from p in produtos
                orderby p.dadosCODIGO
                select new { p.dadosCODIGO, p.dadosPRODUTO, p.dadosQUANTIDADE, p.dadosVALOR, p.dadosDIMENSOES, p.dadosDETALHES, p.dadosFORNECEDOR, p.dadosOPERACAO, p.dadosMOVIMENTACAO, p.dadosVALORTOTAL, p.dadosSERIE, p.dadosDATA, p.dadosNOTAFISCAL, p.dadosSEQ, p.dadosCOMPLEMENTO };

            foreach (var item in produtosByCod) { Console.WriteLine(item); }
        }

        /*/

        }

        /*********************************************************/







        public void lerArquivo()
        //public List<Produto> lerArquivo()
        {

            CsvContext cc = new CsvContext();

            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ';',
                FirstLineHasColumnNames = true,
                FileCultureName = "pt-BR" // default is the current culture
            };

            //IEnumerable<string> produtos = new IEnumerable<string>();


            IEnumerable<Produto> produtos =
                cc.Read<Produto>("C:/Users/yasmin.feitosa/Documents/Visual Studio 2015/Projects/Inventario Base/inventario_nimal.csv", inputFileDescription);

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

            dadosArquivoProdutos = produtos.ToList();

            /*/
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
            /*/

            /*/
            foreach (var item in produtosByCod)
            {
                Console.WriteLine(item);
            }
            /*/

        }

        /*********************************************************/























        public static void ShowErrorMessage(string errorMessage)
        {
            // show errorMessage to user
            // .....
        }

        /*********************************************************/

        public static void ReadFileWithExceptionHandling()
        {
            try
            {
                CsvContext cc = new CsvContext();

                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    MaximumNbrExceptions = 50 // limit number of aggregated exceptions to 50
                };

                IEnumerable<Produto> produtos =
                    cc.Read<Produto>("../../ Arquivo / inventario_nimal.csv", inputFileDescription);

                // NOT SHOWN IN EXAMPLE IN ARTICLE
                foreach (var item in produtos) { Console.WriteLine(item); }

                // Do data processing
                // ...........

            }

            catch (AggregatedException ae)
            {
                // Process all exceptions generated while processing the file

                List<Exception> innerExceptionsList =
                    (List<Exception>)ae.Data["InnerExceptionsList"];

                foreach (Exception e in innerExceptionsList)
                {
                    ShowErrorMessage(e.Message);
                }
            }
            catch (DuplicateFieldIndexException dfie)
            {
                // name of the class used with the Read method - in this case "Product"
                string typeName = Convert.ToString(dfie.Data["TypeName"]);

                // Names of the two fields or properties that have the same FieldIndex
                string fieldName = Convert.ToString(dfie.Data["FieldName"]);
                string fieldName2 = Convert.ToString(dfie.Data["FieldName2"]);

                // Actual FieldIndex that the two fields have in common
                int commonFieldIndex = Convert.ToInt32(dfie.Data["Index"]);

                // Do some processing with this information
                // .........


                // Inform user of error situation
                ShowErrorMessage(dfie.Message);
            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
            }
        }



    }
}
