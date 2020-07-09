using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Forms;

using LINQtoCSV;



namespace Negocio
{
    public class Produto
    {

        [CsvColumn(Name = "CODIGO", FieldIndex = 1)]
        public string dadosCODIGO { get; set; }

        [CsvColumn(Name = "PRODUTO", FieldIndex = 2)]
        public string dadosPRODUTO { get; set; }

        [CsvColumn(Name = "DIMENSOES", FieldIndex = 3)]
        public string dadosDIMENSOES { get; set; }

        [CsvColumn(Name = "DETALHES", FieldIndex = 4)]
        public string dadosDETALHES { get; set; }

        [CsvColumn(Name = "OPERACAO", FieldIndex = 5)]
        public string dadosOPERACAO { get; set; }

        [CsvColumn(Name = "MOVIMENTACAO", FieldIndex = 6)]
        public int dadosMOVIMENTACAO { get; set; }

        [CsvColumn(Name = "QUANTIDADE", FieldIndex = 7)]
        public int dadosQUANTIDADE { get; set; }

        [CsvColumn(Name = "VALOR", FieldIndex = 8)]
        public double dadosVALOR { get; set; }

        [CsvColumn(Name = "VALORTOTAL", FieldIndex = 9)]
        public double dadosVALORTOTAL { get; set; }

        [CsvColumn(Name = "DATA", FieldIndex = 10, OutputFormat = "dd/MMM/AA HH:mm:ss")]
        public DateTime dadosDATA { get; set; }

        [CsvColumn(Name = "SERIE", FieldIndex = 11)]
        public string dadosSERIE { get; set; }

        [CsvColumn(Name = "NOTAFISCAL", FieldIndex = 12)]
        public string dadosNOTAFISCAL { get; set; }

        [CsvColumn(Name = "SEQ", FieldIndex = 13)]
        public string dadosSEQ { get; set; }

        [CsvColumn(Name = "FORNECEDOR", FieldIndex = 14)]
        public string dadosFORNECEDOR { get; set; }

        [CsvColumn(Name = "COMPLEMENTO", FieldIndex = 15)]
        public string dadosCOMPLEMENTO { get; set; }

        [CsvColumn(Name = "STATUS", FieldIndex = 16)]
        public string dadosSTATUS { get; set; }

        //[CsvColumn(Name = "LOCALCOD", FieldIndex = 17)]
        //public Array dadosLOCALCOD { get; set; }






        /*/
        [CsvColumn(Name = "Código", FieldIndex = 1)]
        public string Name { get; set; }

        [CsvColumn(FieldIndex = 2, OutputFormat = "dd MMM HH:mm:ss")]
        public DateTime LaunchDate { get; set; }

        [CsvColumn(FieldIndex = 3, CanBeNull = false, OutputFormat = "C")]
        public decimal Price { get; set; }

        [CsvColumn(FieldIndex = 4)]
        public string Country { get; set; }

        [CsvColumn(FieldIndex = 5)]
        public string Description { get; set; }
        /*/


        /*/
                int CODIGO;
                string PRODUTO;
                string DIMENSOES;
                string DETALHES;
                string OPERACAO;
                int MOVIMENTACAO;
                int QUANTIDADE;
                double VALOR;
                double VALORTOTAL;
                DateTime DATA;
                string SERIE;
                string NOTAFISCAL;
                string SEQ;
                string FORNECEDOR;
                string COMPLEMENTO;
                bool STATUS;




                public int dadosCODIGO
                {
                    get { return CODIGO; }
                    set { CODIGO = value; }
                }



                public string dadosPRODUTO
                {
                    get { return PRODUTO; }
                    set { PRODUTO = value; }
                }


                public string dadosDIMENSOES
                {
                    get { return DIMENSOES; }
                    set { DIMENSOES = value; }
                }


                public string dadosDETALHES
                {
                    get { return DETALHES; }
                    set { DETALHES = value; }
                }

                public string dadosOPERACAO
                {
                    get { return OPERACAO; }
                    set { OPERACAO = value; }
                }

                public int dadosMOVIMENTACAO
                {
                    get { return MOVIMENTACAO; }
                    set { MOVIMENTACAO = value; }
                }

                public int dadosQUANTIDADE
                {
                    get { return QUANTIDADE; }
                    set { QUANTIDADE = value; }
                }

                public double dadosVALOR
                {
                    get { return VALOR; }
                    set { VALOR = value; }
                }

                public double dadosVALORTOTAL
                {
                    get { return VALORTOTAL; }
                    set { VALORTOTAL = value; }
                }

                public DateTime dadosDATA
                {
                    get { return DATA; }
                    set { DATA = value; }
                }

                public string dadosSERIE
                {
                    get { return SERIE; }
                    set { SERIE = value; }
                }

                public string dadosNOTAFISCAL
                {
                    get { return NOTAFISCAL; }
                    set { NOTAFISCAL = value; }
                }

                public string dadosSEQ
                {
                    get { return SEQ; }
                    set { SEQ = value; }
                }

                public string dadosFORNECEDOR
                {
                    get { return FORNECEDOR; }
                    set { FORNECEDOR = value; }
                }

                public string dadosCOMPLEMENTO
                {
                    get { return COMPLEMENTO; }
                    set { COMPLEMENTO = value; }
                }

                public bool dadosSTATUS
                {
                    get { return STATUS; }
                    set { STATUS = value; }
                }
                
        /*/
    }
}
