using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Negocio
{
    public class Estoque
    {
        /*********************************************************/
        //

        [CsvColumn(Name = "CODIGO", FieldIndex = 1)]
        public string estoqueCODIGO { get; set; }

        [CsvColumn(Name = "LOCAL", FieldIndex = 2)]
        public string estoqueLOCAL { get; set; } // NOME

        [CsvColumn(Name = "DETALHES", FieldIndex = 3)]
        public string estoqueDETALHES { get; set; }

        //[CsvColumn(Name = "OPERACAO", FieldIndex = 5)]
        //public string estoqueOPERACAO { get; set; }

        [CsvColumn(Name = "QUANTIDADE", FieldIndex = 4)]
        public int estoqueQUANTIDADE { get; set; } //QUANTIDADE TOTAL DE ITENS ALOCADOS

        [CsvColumn(Name = "DATA", FieldIndex = 5, OutputFormat = "dd/MMM/AA HH:mm:ss")]
        public DateTime estoqueDATA { get; set; } //DATA DA ÚLTIMA ENTRADA OU SAÍDA?

    }

    /*********************************************************/
    //

    public class Movimentacao
    {
        [CsvColumn(Name = "CODIGO", FieldIndex = 1)]
        public string movCODIGO { get; set; }

        [CsvColumn(Name = "ESTOQUECOD", FieldIndex = 2)]
        public string movESTOQUECOD { get; set; }

        [CsvColumn(Name = "PRODUTOCOD", FieldIndex = 3)]
        public string movPRODUTOCOD { get; set; }

        [CsvColumn(Name = "DETALHES", FieldIndex = 4)]
        public string movDETALHES { get; set; }

        [CsvColumn(Name = "OPERACAO", FieldIndex = 5)]
        public string movOPERACAO { get; set; } // OPERAÇÃO DA MOVIMENTAÇÃO 

        [CsvColumn(Name = "QUANTIDADE", FieldIndex = 6)]
        public int movQUANTIDADE { get; set; } //QUANTIDADE MOVIMENTADA // EX: +2 UNIDADES (TINHA 6) ((((FK COM PRODUTO-MOVIMENTACAO))))

        [CsvColumn(Name = "QPRODESTOQ", FieldIndex = 7)]
        public int movQPRODESTOQ { get; set; } //QUANTIDADE TOTAL DE PRODUTO ESPECÍFICO RETORNADA DO ESTOQUE //EX: FICOU COM 8 (DO PRODUTO ESPECÍFICO)
        
        [CsvColumn(Name = "QPRODTOTAL", FieldIndex = 8)]
        public int movQPRODTOTAL { get; set; }  //QUANTIDADE TOTAL DE PRODUTO EXISTENTE NO BANCO //EX: SE TINHA 12 NO BANCO (6 EM OUTRO ESTOQUE) FICA COM 14 NO TOTAL // ((((FK COM PRODUTO - QUANTIDADE ))))

        [CsvColumn(Name = "QTOTAL", FieldIndex = 9)]
        public int movQTOTAL { get; set; } //QUANTIDADE TOTAL RETORNADA AO ESTOQUE //EX: POSSUI 48 ITENS NO TOTAL DO ESTOQUE (SENDO 8 DO PRODUTO ESPECÍFICO DA MOVIMENTAÇÃO) ((((FK COM ESTOQUE-QUANTIDADE))))

        [CsvColumn(Name = "DATA", FieldIndex = 10, OutputFormat = "dd/MMM/AA HH:mm:ss")]
        public DateTime movDATA { get; set; } //DATA DA MOVIMENTAÇÃO

    }


        /*********************************************************/
        //

        public class MovComp
        {
            // MOVIMENTAÇÃO
            [CsvColumn(Name = "mov_CODIGO", FieldIndex = 1)]
            public string mov_CODIGO { get; set; }

            /*/
            [CsvColumn(Name = "mov_ESTOQUECOD", FieldIndex = 2)]
            public string mov_ESTOQUECOD { get; set; }

            [CsvColumn(Name = "mov_PRODUTOCOD", FieldIndex = 3)]
            public string mov_PRODUTOCOD { get; set; }
            /*/

            [CsvColumn(Name = "mov_DETALHES", FieldIndex = 2)]
            public string mov_DETALHES { get; set; }

            [CsvColumn(Name = "mov_OPERACAO", FieldIndex = 3)]
            public string mov_OPERACAO { get; set; } // OPERAÇÃO DA MOVIMENTAÇÃO 

            [CsvColumn(Name = "mov_QUANTIDADE", FieldIndex = 4)]
            public int mov_QUANTIDADE { get; set; } //QUANTIDADE MOVIMENTADA // EX: +2 UNIDADES (TINHA 6) ((((FK COM PRODUTO-MOVIMENTACAO))))
            
            [CsvColumn(Name = "mov_QPRODESTOQ", FieldIndex = 5)]
            public int mov_QPRODESTOQ { get; set; } //QUANTIDADE TOTAL DE PRODUTO ESPECÍFICO RETORNADA DO ESTOQUE //EX: FICOU COM 8 (DO PRODUTO ESPECÍFICO) // ((((FK COM PRODUTO - QUANTIDADE ))))

            /*/
            [CsvColumn(Name = "mov_QPRODTOTAL", FieldIndex = 7)]
            public int mov_QPRODTOTAL { get; set; } //QUANTIDADE TOTAL DE PRODUTO EXISTENTE NO BANCO //EX: SE TINHA 12 NO BANCO (6 EM OUTRO ESTOQUE) FICA COM 14 NO TOTAL // ((((FK COM PRODUTO - QUANTIDADE ))))

            [CsvColumn(Name = "mov_QTOTAL", FieldIndex = 8)]
            public int mov_QTOTAL { get; set; } //QUANTIDADE TOTAL RETORNADA NO ESTOQUE //EX: POSSUI 48 ITENS NO TOTAL DO ESTOQUE (SENDO 8 DO PRODUTO ESPECÍFICO DA MOVIMENTAÇÃO) ((((FK COM ESTOQUE-QUANTIDADE))))
            /*/

            [CsvColumn(Name = "mov_DATA", FieldIndex = 6, OutputFormat = "dd/MMM/AA HH:mm:ss")]
            public DateTime mov_DATA { get; set; } //DATA DA MOVIMENTAÇÃO


            // PRODUTO
            [CsvColumn(Name = "produto_CODIGO", FieldIndex = 7)] // ((((FK COM MOVIMENTAÇÃO - CODPRODUTO))))
            public string produto_CODIGO { get; set; }

            [CsvColumn(Name = "produto_PRODUTO", FieldIndex = 8)]
            public string produto_PRODUTO { get; set; }

            [CsvColumn(Name = "produto_DIMENSOES", FieldIndex = 9)]
            public string produto_DIMENSOES { get; set; }

            [CsvColumn(Name = "produto_DETALHES", FieldIndex = 10)]
            public string produto_DETALHES { get; set; }

            /*/
            [CsvColumn(Name = "produto_OPERACAO", FieldIndex = 14)]
            public string produto_OPERACAO { get; set; }

            [CsvColumn(Name = "produto_MOVIMENTACAO", FieldIndex = 15)] // ((((FK COM MOVIMENTAÇÃO - QUANTIDADE ))))
            public int produto_MOVIMENTACAO { get; set; }
            /*/

            [CsvColumn(Name = "produto_QUANTIDADE", FieldIndex = 11)] // ((((FK COM MOVIMENTAÇÃO - QPRODTOTAL))))
            public int produto_QUANTIDADE { get; set; }

            [CsvColumn(Name = "produto_VALOR", FieldIndex = 12)]
            public double produto_VALOR { get; set; }

            [CsvColumn(Name = "produto_VALORTOTAL", FieldIndex = 13)]
            public double produto_VALORTOTAL { get; set; }

            /*/
            [CsvColumn(Name = "produto_DATA", FieldIndex = 19, OutputFormat = "dd/MMM/AA HH:mm:ss")]
            public DateTime produto_DATA { get; set; }
            /*/    

            [CsvColumn(Name = "produto_SERIE", FieldIndex = 14)]
            public string produto_SERIE { get; set; }

            [CsvColumn(Name = "produto_NOTAFISCAL", FieldIndex = 15)]
            public string produto_NOTAFISCAL { get; set; }

            [CsvColumn(Name = "produto_SEQ", FieldIndex = 16)]
            public string produto_SEQ { get; set; }

            [CsvColumn(Name = "produto_FORNECEDOR", FieldIndex = 17)]
            public string produto_FORNECEDOR { get; set; }

            [CsvColumn(Name = "produto_COMPLEMENTO", FieldIndex = 18)]
            public string produto_COMPLEMENTO { get; set; }

            [CsvColumn(Name = "produto_STATUS", FieldIndex = 19)]
            public string produto_STATUS { get; set; }



            //ESTOQUE
            [CsvColumn(Name = "estoque_CODIGO", FieldIndex = 20)]
            public string estoque_CODIGO { get; set; }

            [CsvColumn(Name = "estoque_LOCAL", FieldIndex = 21)]
            public string estoque_LOCAL { get; set; } // NOME

            [CsvColumn(Name = "estoque_DETALHES", FieldIndex = 22)]
            public string estoque_DETALHES { get; set; }

            //[CsvColumn(Name = "OPERACAO", FieldIndex = 5)]
            //public string estoqueOPERACAO { get; set; }

            [CsvColumn(Name = "estoque_QUANTIDADE", FieldIndex = 23)]
            public int estoque_QUANTIDADE { get; set; } //QUANTIDADE TOTAL DE ITENS ALOCADOS

            /*/
            [CsvColumn(Name = "estoque_DATA", FieldIndex = 30, OutputFormat = "dd/MMM/AA HH:mm:ss")]
            public DateTime estoque_DATA { get; set; } //DATA DA ÚLTIMA ENTRADA OU SAÍDA?
            /*/
        }

        /*********************************************************/

    
}

                              