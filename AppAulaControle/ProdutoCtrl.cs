using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using InventarioDados;
using LINQtoCSV;
using MoreLinq;




namespace InventarioControle
{
    public class ProdutoCtrl
    {
        /*********************************************************/
        //SALVA UM NOVO PRODUTO VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public String SalvarProduto(Produto _Produto)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            List<Produto> listaValidos = new List<Produto>();
            listaValidos = ProdutoDao.buscaCodValido(_Produto.dadosCODIGO);

            if (verificarCamposObrigatorios(_Produto) == false) //CHECA SE OS CAMPOS OBRIGATÓRIOS ESTÃO PREENCHIDOS
            {
                return "campos";
            }

            if (listaValidos.Count() > 0) //CHECA SE HÁ OUTRO ITEM COM ESTE CÓDIGO
            {
                return "cod";
            }
            
            if (ProdutoDao.salvarProduto(_Produto) == true) // VAI TENTAR SALVAR NO DAO
            {
                return "ok";
            }
            else //DAO NÃO CONSEGUIU SALVAR
            {
                return "vish";
            }
        }

        /*********************************************************/
        // EDITA PRODUTO VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public Boolean alterarProduto(Produto _Produto)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();

            if (verificarCamposObrigatorios(_Produto) == false)
            {
                return false;
            }

            if (ProdutoDao.alterarProduto(_Produto) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************/
        // EDITA PRODUTO VERIFICANDO OS CAMPOS OBRIGATÓRIOS (DA LISTA MOCKADA)

        public Boolean alterarProdutoMockado(Produto _Produto, List<Produto> listaMockada)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();

            if (verificarCamposObrigatorios(_Produto) == false)
            {
                return false;
            }
            foreach (Produto Produto in listaMockada)
            {
                if (Produto.dadosCODIGO == _Produto.dadosCODIGO)
                {
                    listaMockada.Remove(Produto);
                    listaMockada.Add(_Produto);
                    return true;
                }
            }
            return false;
        }


        /*********************************************************/
        // CARREGA PRODUTOS DO ARQUIVO
        // CHAMA UM VARIÁVEL GLOBAL JÁ PREENCHIDA DE DAO (DADOS)

        /*/
            //COM LIST 
        public List<Produto> carregarProdutos()
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            return ProdutoDao.dadosArquivoProdutos;
        }
        /*/

        //COM IENUMERABLE
        public IEnumerable<Produto> carregarProdutos()
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            return ProdutoDao.dadosArquivoProdutosBruto;
        }

        /*********************************************************/
        // CHAMA A LEITURA DO ARQUIVO INTEIRO
        // SE COMUNICA COM O DAO (DADOS) PARA ELE LER O ARQUIVO DE PRODUTOS

        public void lerArquivo()
        {
            //LÊ OS PRODUTOS
            ProdutoDao ProdutoDao = new ProdutoDao();
            ProdutoDao.lerArquivo();
            //return ProdutoDao.lerArquivo();


        }


        /*********************************************************/
        // VERIFICA OS CAMPOS OBRIGATÓRIOS DO PRODUTO

        public Boolean verificarCamposObrigatorios(Produto Produto)
        {
            Boolean semErros = true;


            if (Produto.dadosCODIGO == null || Produto.dadosCODIGO == "")
            {
                semErros = false;
            }

            if (Produto.dadosPRODUTO == null || Produto.dadosPRODUTO.Trim() == "")
            {
                semErros = false;
            }

            /*/
            if (Produto.dadosQUANTIDADE == null || Produto.dadosQUANTIDADE.Trim() == "")
            {
                semErros = false;
            }
            /*/

            if (Produto.dadosVALOR == 0)
            {
                semErros = false;
            }

            if (Produto.dadosOPERACAO == null || Produto.dadosOPERACAO.Trim() == "")
            {
                semErros = false;
            }


            /*/
            if (Produto.dadosDIMENSOES == null || Produto.dadosDIMENSOES.Trim() == "")
            {
                semErros = false;
            }

            if (Produto.dadosDETALHES == null || Produto.dadosDETALHES.Trim() == "")
            {
                semErros = false;
            }
            if (Produto.dadosFORNECEDOR == null || Produto.dadosFORNECEDOR.Trim() == "")
            {
                semErros = false;
            }
            /*/

            return semErros;
        }


        /*********************************************************/

        public String[] getHeaderProd()
        {
            ControleDAO controle = new ControleDAO();
            String[] headerProd = controle.dadosHeaderProd;
            return headerProd;

        }
        /*********************************************************/
        // RECUPERA A LISTA DE ESTOQUES DE ESTOQUEDAO


        public List<Produto> getProdutos()
        {
            IEnumerable<Produto> listaDeProdutos = ProdutoDao.dadosArquivoProdutosBruto;
            return listaDeProdutos.ToList<Produto>();
        }


        /*********************************************************/
        // FAZ A BUSCA DO PRODUTO NA LISTA PELO CÓDIGO (BUSCA POR PRODUTO IDÊNTICO)

        /*/
            public Produto buscarProdutoUnicoDaLista(Produto produtoSelecionado, List<Produto> listaDeProdutos)
            {
                Produto produtoEncontrado = null;
                //ProdutoDao.mockListaDeProdutos(listaDeProdutos);
                foreach (Produto Produto in listaDeProdutos)
                {

                    bool result = string.Compare(Produto.dadosCODIGO, _dadosCODIGO, true) == 0;
                    // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                    if ((result == true) && (Produto.dadosSTATUS == "VALIDO"))
                    {
                        // RETORNA O PRODUTO SE O STATUS DELE FOR VÁLIDO (DEVE EXISTIR SOMENTE UM VÁLIDO, SE EXISTIR MAIS DE UM, ELE PEGARÁ O PRIMEIRO)
                        produtoEncontrado = Produto;
                        break;
                    }
                    else
                    {
                        produtoEncontrado = null;
                        //Não há produto válido
                    }
                }
                return produtoEncontrado;
            }
    /*/

        /*********************************************************/
        // FAZ A BUSCA DO PRODUTO NA LISTA PELO CÓDIGO (PARA BUSCAR SÓ UM)


        public Produto buscarProdutoDaLista(string _dadosCODIGO)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();

            IEnumerable<Produto> listaDeProdutos = ProdutoDao.dadosArquivoProdutosBruto; //pega a variável global com o arquivo pelo GET
            Produto produtoEncontrado = null;

            //ProdutoDao.mockListaDeProdutos(listaDeProdutos);

            foreach (Produto Produto in listaDeProdutos)
            {
                bool result = string.Compare(Produto.dadosCODIGO, _dadosCODIGO, true) == 0;
                // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                if ((result == true) && (Produto.dadosSTATUS == "VALIDO"))
                {
                    // RETORNA O PRODUTO SE O STATUS DELE FOR VÁLIDO (DEVE EXISTIR SOMENTE UM VÁLIDO, SE EXISTIR MAIS DE UM, ELE PEGARÁ O PRIMEIRO)
                    produtoEncontrado = Produto;
                    break;
                }
                else  //Não há produto válido
                {
                    produtoEncontrado = null;
                }
            }
            return produtoEncontrado;
        }


        /*********************************************************/
        // FAZ A BUSCA NA LISTA MOCKADA

        public Produto buscarProdutoDaListaMockada(string _dadosCODIGO, List<Produto> listaDeProdutosMockada)
        {

            foreach (Produto Produto in listaDeProdutosMockada)
            {
                bool result = string.Compare(Produto.dadosCODIGO, _dadosCODIGO, true) == 0;
                // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                if (result == true)
                {
                    return Produto;
                }
                else //Não há produto válido
                {
                    return null;
                }
            }
            return null;
        }

        /*********************************************************/
        // FAZ A BUSCA DO PRODUTO NA LISTA PELO NOME DO PRODUTO (PARA BUSCAR UMA LISTA DE IGUAIS)


        public List<Produto> buscarProdutoDaListaPorCodigo(string _dadosCODIGO)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();

            IEnumerable<Produto> listaDeProdutos = ProdutoDao.dadosArquivoProdutosBruto; //pega a variável global com o arquivo pelo GET

            List<Produto> produtosEncontrados = new List<Produto>(); // Cria uma nova lista com os produtos encontrados na busca

            //ProdutoDao.mockListaDeProdutos(listaDeProdutos);

            foreach (Produto Produto in listaDeProdutos)
            {
                bool result = string.Compare(Produto.dadosCODIGO, _dadosCODIGO, true) == 0;
                // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                if (result == true)
                {
                    produtosEncontrados.Add(Produto); //Adiciona o produto à lista de escolhidos.
                }
            }

            if (produtosEncontrados.Count() != 0) //Resultados encontrados
            {
                return produtosEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }

        }


        /*********************************************************/
        // FAZ A BUSCA DO PRODUTO NA LISTA PELO NOME DO PRODUTO (PARA BUSCAR UMA LISTA DE IGUAIS)


        public List<Produto> buscarProdutoDaListaPorNome(string _dadosPRODUTO)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            List<Produto> produtosEncontrados = new List<Produto>();

            IEnumerable<Produto> listaDeProdutos = ProdutoDao.dadosArquivoProdutosBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _dadosPRODUTO.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Produto Produto in listaDeProdutos)
            {
                string[] palavras = Produto.dadosPRODUTO.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada produto
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if (palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper())
                        {
                            produtosEncontrados.Add(Produto); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um produto
                        }
                    }
                }
            }
            if (produtosEncontrados.Count() != 0)  //Resultados encontrados
            {
                return produtosEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }


        /*********************************************************/
        // FAZ A BUSCA DO PRODUTO NA LISTA PELO NOME E PELO CÓDIGO

        public List<Produto> buscarProdutoDaListaPorCodigoEPorNome(string _dadosCODIGO, string _dadosPRODUTO)
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            List<Produto> produtosEncontrados = new List<Produto>();


            IEnumerable<Produto> listaDeProdutos = ProdutoDao.dadosArquivoProdutosBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _dadosPRODUTO.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Produto Produto in listaDeProdutos)
            {
                string[] palavras = Produto.dadosPRODUTO.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada produto
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if ((palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper()) && (Produto.dadosCODIGO == _dadosCODIGO))
                        {
                            produtosEncontrados.Add(Produto); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um produto
                        }
                    }
                }
            }
            if (produtosEncontrados.Count() != 0) //Resultados encontrados
            {
                return produtosEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }

        /*********************************************************/



        /*********************************************************/
        // TESTE

            /*/
        public void btnTESTE()
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            var newborn = ProdutoDao.buscarEspecificoTESTE();
        }
        /*/

        /*********************************************************/

        /*/

    public List<Movimentacao> relatorioLocal(string _localescolhido, Boolean _Status, Boolean _Header)
    {

        ProdutoDao ProdutoDao = new ProdutoDao();
        List<Movimentacao> dadosEncontrados = ProdutoDao.buscarRelatorioProdLocal(_localescolhido);

        return dadosEncontrados;


    }
    /*/

        /*********************************************************/


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE LOCAL
        /*/

        public List<Movimentacao> relatorioLocal(string _localescolhido, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {

            IEnumerable<Movimentacao> arquivoMovimentacoes = EstoqueDAO.dadosArquivoMovimentacoesBruto; //Pega o arquivo de Movimentações
            IEnumerable<Produto> arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto; //Pega o arquivo de produtos


            var Codlist = new List<String> { }; //Lista de códigos alocados 
            List<Produto> produtosMoviment = new List<Produto>();

            if (arquivoMovimentacoes != null)
            {
                foreach (Movimentacao novaMov in arquivoMovimentacoes)
                {
                    if (novaMov.movESTOQUECOD == _localescolhido) //Checa se é o local requerido
                    {

                        foreach (Produto novoProdM in arquivoProdutos)
                        {
                            if (novaMov.movESTOQUECOD == _localescolhido)
                        }

                        if (!Codlist.Contains(novoProdM.movPRODUTOCOD)) //SE NÃO EXISTE O CÓDIGO NA LISTA de Códigos
                        {
                            Codlist.Add(novoProdM.movPRODUTOCOD); //adiciona um código de produto à lista
                            produtosMoviment.Add(novoProdM); // adiciona a movimentacao a lista
                        }
                        else // SE EXISTIR O CÓDIGO NA LISTA, CHECA A DATA 
                        {
                            List<Movimentacao> antigoProdutosMov = new List<Movimentacao>(produtosMoviment); // Cria uma cópia da lista para que ela possa ser modificada no loop
                            foreach (Movimentacao antigoProdM in antigoProdutosMov) // Roda a lista de Movimentações já preenchida
                            {
                                if (antigoProdM.movPRODUTOCOD == novoProdM.movPRODUTOCOD)
                                { //CHECA SE O CÓDIGO É O MESMO para começar a substituição

                                    if (novoProdM.movDATA > antigoProdM.movDATA)
                                    {  // CHECA SE A DATA DO NOVO É MAIOR QUE A DO ANTIGO
                                        //Se o antigo tiver a menor data, ele deve ser apagado e o novo, alocado.

                                        produtosMoviment.Remove(antigoProdM); // remove a movimentacao antiga
                                        produtosMoviment.Add(novoProdM); // adiciona a nova com a data atualizada
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else { // Se arquivoMovimentacoes == null

                return produtosMoviment;
            }

            EstoqueDAO EstoqueDao = new EstoqueDAO();
            List<dynamic> novoProdutosMoviment = produtosMoviment.ToList<dynamic>();
            EstoqueDao.prepararCSV(novoProdutosMoviment, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return produtosMoviment;
        }

        /*********************************************************/


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE LOCAL

        /*/
                public List<Movimentacao> relatorioLocal(string _localescolhido, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
                {

                    IEnumerable<Movimentacao> arquivoMovimentacoes = EstoqueDAO.dadosArquivoMovimentacoesBruto; //Pega o arquivo de Movimentações
                    IEnumerable<Produto> arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto; //Pega o arquivo de produtos


                    var Codlist = new List<String> { }; //Lista de códigos alocados 
                    List<Movimentacao> produtosMoviment = new List<Movimentacao>();


                    if (arquivoMovimentacoes != null)
                    {
                        foreach (Movimentacao novoProdM in arquivoMovimentacoes)
                        {
                            if (novoProdM.movESTOQUECOD == _localescolhido) //Checa se é o local requerido
                            {
                                if (!Codlist.Contains(novoProdM.movPRODUTOCOD)) //SE NÃO EXISTE O CÓDIGO NA LISTA de Códigos
                                {
                                    Codlist.Add(novoProdM.movPRODUTOCOD); //adiciona um código de produto à lista
                                    produtosMoviment.Add(novoProdM); // adiciona a movimentacao a lista
                                }
                                else // SE EXISTIR O CÓDIGO NA LISTA, CHECA A DATA 
                                {
                                    List<Movimentacao> antigoProdutosMov = new List<Movimentacao>(produtosMoviment); // Cria uma cópia da lista para que ela possa ser modificada no loop
                                    foreach (Movimentacao antigoProdM in antigoProdutosMov) // Roda a lista de Movimentações já preenchida
                                    {
                                        if (antigoProdM.movPRODUTOCOD == novoProdM.movPRODUTOCOD)
                                        { //CHECA SE O CÓDIGO É O MESMO para começar a substituição

                                            if (novoProdM.movDATA > antigoProdM.movDATA)
                                            {  // CHECA SE A DATA DO NOVO É MAIOR QUE A DO ANTIGO
                                                //Se o antigo tiver a menor data, ele deve ser apagado e o novo, alocado.

                                                produtosMoviment.Remove(antigoProdM); // remove a movimentacao antiga
                                                produtosMoviment.Add(novoProdM); // adiciona a nova com a data atualizada
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        foreach (Movimentacao movEmLocal in produtosMoviment) //Percorre as movimentações existentes e peneira os produtos em cada
                        {
                            foreach(Produto produtoEmLocal in arquivoProdutos)
                            {
                                movPRODUTOCOD
                            }

                        }




                    }
                    else { // Se arquivoMovimentacoes == null

                        return produtosMoviment;
                    }

                    EstoqueDAO EstoqueDao = new EstoqueDAO();
                    List<dynamic> novoProdutosMoviment = produtosMoviment.ToList<dynamic>();
                    EstoqueDao.prepararCSV(novoProdutosMoviment, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
                    return produtosMoviment;
                }

            }/*/



        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE LOCAL


        public List<Produto> relatorioProdMovLocal(string _localescolhido, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto;
            //var Codlist = new List<String> { }; //Lista de códigos alocados 
            List<Produto> produtosListaUnicos = new List<Produto>();
            if (arquivoProdutos != null)
            {
                List<Produto> resultadoBusca = produtoDAO.buscarProdMovLocal(_localescolhido);

                //produtosListaUnicos = resultadoBusca.DistinctBy(p => p.dadosCODIGO);

            produtosListaUnicos = (resultadoBusca.Select(d => new Produto()
                                  {
                                       dadosCODIGO = d.dadosCODIGO,
                                       dadosPRODUTO = d.dadosPRODUTO,
                                       dadosDIMENSOES = d.dadosDIMENSOES,
                                       dadosDETALHES = d.dadosDETALHES,
                                       dadosOPERACAO = d.dadosOPERACAO,
                                       dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                                       dadosQUANTIDADE = d.dadosQUANTIDADE,
                                       dadosVALOR = d.dadosVALOR,
                                       dadosVALORTOTAL = d.dadosVALORTOTAL,
                                       dadosDATA = d.dadosDATA,
                                       dadosSERIE = d.dadosSERIE,
                                       dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                                       dadosSEQ = d.dadosSEQ,
                                       dadosFORNECEDOR = d.dadosFORNECEDOR,
                                       dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                                       dadosSTATUS = d.dadosSTATUS
                                   })
                                   .DistinctBy(d => d.dadosCODIGO)
                                   .OrderByDescending(d => d.dadosDATA))
                                   .ToList();


                //List<Produto> produtosListaUnicos = filtrarUnico.ToList<Produto>();

                /*/
                foreach (Produto primProd in resultadoBusca)
                {
                        if (!Codlist.Contains(primProd.dadosCODIGO)) //SE NÃO EXISTE O CÓDIGO NA LISTA de Códigos
                        {
                            Codlist.Add(primProd.dadosCODIGO); //adiciona um código de produto à lista
                            produtosListaUnicos.Add(primProd); // adiciona a movimentacao a lista
                        }
                        else // SE EXISTIR O CÓDIGO NA LISTA, CHECA A DATA 
                        {
                            List<Produto> primProdutos = new List<Produto>(resultadoBusca); // Cria uma cópia da lista para que ela possa ser modificada no loop
                            foreach (Produto secProd in primProdutos) // Roda a lista de Movimentações já preenchida
                            {
                                if (primProd.dadosCODIGO == secProd.dadosCODIGO)
                                { //CHECA SE O CÓDIGO É O MESMO para começar a substituição

                                    if (secProd.dadosDATA > primProd.dadosDATA)
                                    {  // CHECA SE A DATA DO NOVO É MAIOR QUE A DO ANTIGO
                                       //Se o antigo tiver a menor data, ele deve ser apagado e o novo, alocado.

                                    produtosListaUnicos.Remove(primProd); // remove a movimentacao antiga
                                    produtosListaUnicos.Add(secProd); // adiciona a nova com a data atualizada
                                    }
                                }
                            }
                       }
                }/*/


            }  else
            { // Se arquivoMovimentacoes == null

                return produtosListaUnicos;
            }

            List<dynamic> novoProdutos = produtosListaUnicos.ToList<dynamic>();
            produtoDAO.prepararCSV(novoProdutos, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return produtosListaUnicos;

        }

        /*********************************************************/


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE PRODUTO - OPERAÇÃO


        public List<Produto> relatorioProdOperacao(string _opEscolhida, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto;
            List<Produto> produtosListaUnicos = new List<Produto>();
            if (arquivoProdutos != null)
            {
                List<Produto> resultadoBusca = produtoDAO.buscarProdOperacao(_opEscolhida);

                //produtosListaUnicos = resultadoBusca.DistinctBy(p => p.dadosCODIGO);

                produtosListaUnicos = (resultadoBusca.Select(d => new Produto()
                                      {
                                          dadosCODIGO = d.dadosCODIGO,
                                          dadosPRODUTO = d.dadosPRODUTO,
                                          dadosDIMENSOES = d.dadosDIMENSOES,
                                          dadosDETALHES = d.dadosDETALHES,
                                          dadosOPERACAO = d.dadosOPERACAO,
                                          dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                                          dadosQUANTIDADE = d.dadosQUANTIDADE,
                                          dadosVALOR = d.dadosVALOR,
                                          dadosVALORTOTAL = d.dadosVALORTOTAL,
                                          dadosDATA = d.dadosDATA,
                                          dadosSERIE = d.dadosSERIE,
                                          dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                                          dadosSEQ = d.dadosSEQ,
                                          dadosFORNECEDOR = d.dadosFORNECEDOR,
                                          dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                                          dadosSTATUS = d.dadosSTATUS
                                      })
                                       .DistinctBy(d => d.dadosCODIGO)
                                       .OrderByDescending(d => d.dadosDATA))
                                       .ToList();
            }
            else
            { // Se arquivoMovimentacoes == null

                return produtosListaUnicos;
            }

            List<dynamic> novoProdutos = produtosListaUnicos.ToList<dynamic>();
            produtoDAO.prepararCSV(novoProdutos, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return produtosListaUnicos;

        }


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE PRODUTO AUDIT

        public List<Produto> relatorioProdAudit(DateTime _dataEscolhida, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto;
            List<Produto> produtosListaUnicos = new List<Produto>();
            if (arquivoProdutos != null)
            {
                List<Produto> resultadoBusca = produtoDAO.buscarProdAudit(_dataEscolhida, _nomeLocal);

                //produtosListaUnicos = resultadoBusca.DistinctBy(p => p.dadosCODIGO);

                produtosListaUnicos = (resultadoBusca.Select(d => new Produto()
                                        {
                                            dadosCODIGO = d.dadosCODIGO,
                                            dadosPRODUTO = d.dadosPRODUTO,
                                            dadosDIMENSOES = d.dadosDIMENSOES,
                                            dadosDETALHES = d.dadosDETALHES,
                                            dadosOPERACAO = d.dadosOPERACAO,
                                            dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                                            dadosQUANTIDADE = d.dadosQUANTIDADE,
                                            dadosVALOR = d.dadosVALOR,
                                            dadosVALORTOTAL = d.dadosVALORTOTAL,
                                            dadosDATA = d.dadosDATA,
                                            dadosSERIE = d.dadosSERIE,
                                            dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                                            dadosSEQ = d.dadosSEQ,
                                            dadosFORNECEDOR = d.dadosFORNECEDOR,
                                            dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                                            dadosSTATUS = d.dadosSTATUS
                                        })
                                       //.DistinctBy(d => d.dadosCODIGO) // Não pegará só um na auditoria
                                       .OrderByDescending(d => d.dadosDATA))
                                       .ToList();

            }
            else
            { // Se arquivoMovimentacoes == null

                return produtosListaUnicos;
            }

            List<dynamic> novoProdutos = produtosListaUnicos.ToList<dynamic>();
            produtoDAO.prepararCSV(novoProdutos, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return produtosListaUnicos;

        }

        /*********************************************************/
        //CONTROLLER DE RELATÓRIO DE PRODUTO - VALIDADE

        public List<Produto> relatorioProdValidade(String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            var arquivoProdutos = ProdutoDao.dadosArquivoProdutosBruto;
            List<Produto> produtosListaUnicos = new List<Produto>();
            if (arquivoProdutos != null)
            {
                List<Produto> resultadoBusca = produtoDAO.buscarProdValidade(_nomeRel);

                //produtosListaUnicos = resultadoBusca.DistinctBy(p => p.dadosCODIGO);
                produtosListaUnicos = (resultadoBusca.Select(d => new Produto()
                                        {
                                            dadosCODIGO = d.dadosCODIGO,
                                            dadosPRODUTO = d.dadosPRODUTO,
                                            dadosDIMENSOES = d.dadosDIMENSOES,
                                            dadosDETALHES = d.dadosDETALHES,
                                            dadosOPERACAO = d.dadosOPERACAO,
                                            dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                                            dadosQUANTIDADE = d.dadosQUANTIDADE,
                                            dadosVALOR = d.dadosVALOR,
                                            dadosVALORTOTAL = d.dadosVALORTOTAL,
                                            dadosDATA = d.dadosDATA,
                                            dadosSERIE = d.dadosSERIE,
                                            dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                                            dadosSEQ = d.dadosSEQ,
                                            dadosFORNECEDOR = d.dadosFORNECEDOR,
                                            dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                                            dadosSTATUS = d.dadosSTATUS
                                        })
                                       //.DistinctBy(d => d.dadosCODIGO) // Não pegará só um na auditoria
                                       .OrderByDescending(d => d.dadosDATA))
                                       .ToList();
            }
            else
            { // Se arquivoMovimentacoes == null

                return produtosListaUnicos;
            }

            List<dynamic> novoProdutos = produtosListaUnicos.ToList<dynamic>();
            produtoDAO.prepararCSV(novoProdutos, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return produtosListaUnicos;

        }


        /*********************************************************/
        // SELECT PRODUTOS EM DETERMINADO ESTOQUE

        public List<Produto> consultarProdEmEstoque(String _estoqueCod)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            List<Produto> listaDeProdutos = produtoDAO.buscarProdMovLocal(_estoqueCod);
            return listaDeProdutos;

        }

        /*********************************************************/
        // SELECT PRODUTOS VÁLIDOS (E POSSIVELMENTE REPETIDOS)

        public List<Produto> buscarValidos()
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            List<Produto> listaDeProdutos = produtoDAO.buscarProdValidade("Prod_Valido");
            return listaDeProdutos;

        }

        /*********************************************************/
        // SELECT PRODUTOS EM DETERMINADO ESTOQUE COM DISTINCT

        public List<Produto> consultarProdEmEstoqueDIST(String _estoqueCod)
        {
            ProdutoDao produtoDAO = new ProdutoDao();
            List<Produto> listaDeProdutos = produtoDAO.buscarProdMovLocal(_estoqueCod);
            List<Produto> produtosListaUnicos = new List<Produto>();

            produtosListaUnicos = (listaDeProdutos.Select(d => new Produto()
                                    {
                                        dadosCODIGO = d.dadosCODIGO,
                                        dadosPRODUTO = d.dadosPRODUTO,
                                        dadosDIMENSOES = d.dadosDIMENSOES,
                                        dadosDETALHES = d.dadosDETALHES,
                                        dadosOPERACAO = d.dadosOPERACAO,
                                        dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                                        dadosQUANTIDADE = d.dadosQUANTIDADE,
                                        dadosVALOR = d.dadosVALOR,
                                        dadosVALORTOTAL = d.dadosVALORTOTAL,
                                        dadosDATA = d.dadosDATA,
                                        dadosSERIE = d.dadosSERIE,
                                        dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                                        dadosSEQ = d.dadosSEQ,
                                        dadosFORNECEDOR = d.dadosFORNECEDOR,
                                        dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                                        dadosSTATUS = d.dadosSTATUS
                                    })
                                      .DistinctBy(d => d.dadosCODIGO)
                                      .OrderByDescending(d => d.dadosDATA))
                                      .ToList();





            return produtosListaUnicos;

        }




        /*********************************************************/
        // CONTROLLER PRA DISTINGUIR PRODUTOS DE UMA LISTA (PELA DATA E CÓDIGO)
        /*/
        public List<Produto> distinctProduto(String _codProd, String _codEstoq)
        {
            List<Produto> produtosListaUnicos = new List<Produto>();
            ProdutoDao produtoDAO = new ProdutoDao();
            List<Produto> listaProdutos = produtoDAO.buscarProdEstoque(_codProd, _codEstoq);

                produtosListaUnicos = (listaProdutos.Select(d => new Produto()
                {
                    dadosCODIGO = d.dadosCODIGO,
                    dadosPRODUTO = d.dadosPRODUTO,
                    dadosDIMENSOES = d.dadosDIMENSOES,
                    dadosDETALHES = d.dadosDETALHES,
                    dadosOPERACAO = d.dadosOPERACAO,
                    dadosMOVIMENTACAO = d.dadosMOVIMENTACAO,
                    dadosQUANTIDADE = d.dadosQUANTIDADE,
                    dadosVALOR = d.dadosVALOR,
                    dadosVALORTOTAL = d.dadosVALORTOTAL,
                    dadosDATA = d.dadosDATA,
                    dadosSERIE = d.dadosSERIE,
                    dadosNOTAFISCAL = d.dadosNOTAFISCAL,
                    dadosSEQ = d.dadosSEQ,
                    dadosFORNECEDOR = d.dadosFORNECEDOR,
                    dadosCOMPLEMENTO = d.dadosCOMPLEMENTO,
                    dadosSTATUS = d.dadosSTATUS
                })
                                       .DistinctBy(d => d.dadosCODIGO)
                                       .OrderByDescending(d => d.dadosDATA))
                                       .ToList();
           
            return produtosListaUnicos;

        }
        /*/

        /*********************************************************/


























    }
}
 