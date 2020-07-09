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
    public class EstoqueCtrl
    {
        //VARIÁVEIS GLOBAIS
        //Boolean status = false;
        //Boolean header = false;


        /*********************************************************/
        //SALVA UM NOVO ESTOQUE VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public Boolean SalvarNovoEstoque(Estoque _estoque)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();

            if (verificarCamposObrigatoriosEstoque(_estoque) == false)
            {
                return false;
            }

            if (estoqueDAO.salvarEstoque(_estoque) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************/
        //SALVA UM NOVO PRODUTO VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public Boolean SalvarNovaMov(Movimentacao _mov)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();

            if (verificarCamposObrigatoriosMov(_mov) == false)
            {
                return false;
            }

            if (estoqueDAO.salvarMov(_mov) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************/
        // EDITA ESTOQUE VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public Boolean alterarEstoque(Estoque _Estoque)
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();

            if (verificarCamposObrigatoriosEstoque(_Estoque) == false)
            {
                return false;
            }

            if (EstoqueDao.alterarEstoque(_Estoque) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*********************************************************/
        // EDITA MOVIMENTAÇÃO VERIFICANDO OS CAMPOS OBRIGATÓRIOS

        public Boolean alterarMov(Movimentacao _mov)
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();

            if (verificarCamposObrigatoriosMov(_mov) == false)
            {
                return false;
            }

            if (EstoqueDao.alterarMov(_mov) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*********************************************************/
        // EDITA ESTOQUE VERIFICANDO OS CAMPOS OBRIGATÓRIOS (DA LISTA MOCKADA)

        public Boolean alterarEstoqueMockado(Estoque _Estoque, List<Estoque> listaMockada)
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();

            if (verificarCamposObrigatoriosEstoque(_Estoque) == false)
            {
                return false;
            }
            foreach (Estoque Estoque in listaMockada)
            {
                if (Estoque.estoqueCODIGO == _Estoque.estoqueCODIGO)
                {
                    listaMockada.Remove(Estoque);
                    listaMockada.Add(_Estoque);
                    return true;
                }
            }
            return false;
        }


        /*********************************************************/
        // CARREGA ESTOQUES DO ARQUIVO
        // CHAMA UM VARIÁVEL GLOBAL JÁ PREENCHIDA DE DAO (DADOS)

        //COM IENUMERABLE
        public IEnumerable<Estoque> carregarEstoques()
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();
            return EstoqueDAO.dadosArquivoEstoquesBruto;
        }

        /*********************************************************/
        // CHAMA A LEITURA DO ARQUIVO INTEIRO
        // SE COMUNICA COM O DAO (DADOS) PARA ELE LER O ARQUIVO DE ESTOQUES

        public void lerArquivo()
        {
            //LÊ OS ESTOQUES
            EstoqueDAO EstoqueDao = new EstoqueDAO();
            EstoqueDao.lerArquivo();
            EstoqueDao.verificarArquivoMov();
            EstoqueDao.verificarMovComp();
            //return EstoqueDao.lerArquivo();

        }


        /*********************************************************/
        // VERIFICA OS CAMPOS OBRIGATÓRIOS DE ESTOQUE

        public Boolean verificarCamposObrigatoriosEstoque(Estoque Estoque)
        {
            Boolean semErros = true;

            if (Estoque.estoqueCODIGO == null || Estoque.estoqueCODIGO == "")
            {
                semErros = false;
            }

            if (Estoque.estoqueLOCAL == null || Estoque.estoqueLOCAL.Trim() == "")
            {
                semErros = false;
            }

            if (Estoque.estoqueQUANTIDADE == 0)
            {
                semErros = false;
            }

            /*/
            if (Estoque.estoqueOPERACAO == null || Estoque.estoqueOPERACAO.Trim() == "")
            {
                semErros = false;
            }
            /*/

            return semErros;
        }


        /*********************************************************/
        // VERIFICA OS CAMPOS OBRIGATÓRIOS DE MOVIMENTAÇÃO

        public Boolean verificarCamposObrigatoriosMov(Movimentacao Movimentacao)
        {
            Boolean semErros = true;

            if (Movimentacao.movCODIGO == null || Movimentacao.movCODIGO.Trim() == "")
            {
                semErros = false;
            }

            if (Movimentacao.movPRODUTOCOD == null || Movimentacao.movPRODUTOCOD.Trim() == "")
            {
                semErros = false;
            }

            if (Movimentacao.movESTOQUECOD == null || Movimentacao.movESTOQUECOD.Trim() == "")
            {
                semErros = false;
            }

            if (Movimentacao.movOPERACAO == null || Movimentacao.movOPERACAO.Trim() == "")
            {
                semErros = false;
            }

            if (Movimentacao.movQUANTIDADE == 0)
            {
                semErros = false;
            }

            return semErros;
        }



        /*********************************************************/
        // FAZ A BUSCA DO Estoque NA LISTA PELO CÓDIGO (PARA BUSCAR SÓ UM)


        public Estoque buscarEstoqueDaLista(string _estoqueCODIGO)
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();

            IEnumerable<Estoque> listaDeEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET
            Estoque EstoqueEncontrado = null;

            //EstoqueDao.mockListaDeEstoques(listaDeEstoques);

            foreach (Estoque Estoque in listaDeEstoques)
            {
                bool result = string.Compare(Estoque.estoqueCODIGO, _estoqueCODIGO, true) == 0;
                // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                if ((result == true))
                {
                    // RETORNA O Estoque SE O STATUS DELE FOR VÁLIDO (DEVE EXISTIR SOMENTE UM VÁLIDO, SE EXISTIR MAIS DE UM, ELE PEGARÁ O PRIMEIRO)
                    EstoqueEncontrado = Estoque;
                    break;
                }
                else  //Não há Estoque válido
                {
                    EstoqueEncontrado = null;
                }
            }
            return EstoqueEncontrado;
        }


        /*********************************************************/
        // FAZ A BUSCA DO ESTOQUE NA LISTA PELO CODIGO DO ESTOQUE (PARA BUSCAR UMA LISTA DE IGUAIS)


        public IEnumerable<Estoque> buscarEstoqueDaListaPorCodigo(string _estoqueCODIGO)
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();

            IEnumerable<Estoque> listaDeEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET

            List<Estoque> estoquesEncontrados = new List<Estoque>(); // Cria uma nova lista com os Estoque encontrados na busca

            //EstoqueDao.mockListaDeEstoques(listaDeEstoques);

            foreach (Estoque Estoque in listaDeEstoques)
            {
                bool result = string.Compare(Estoque.estoqueCODIGO, _estoqueCODIGO, true) == 0;
                // (Retorna -1 se A > B)  (Retorna 0 se A = B)  (Retorna 1 se A menor que B)

                if (result == true)
                {
                    estoquesEncontrados.Add(Estoque); //Adiciona o Estoque à lista de escolhidos.
                }
            }

            if (estoquesEncontrados.Count() != 0) //Resultados encontrados
            {
                return estoquesEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }

        }


        /*********************************************************/
        // FAZ A BUSCA DO Estoque NA LISTA PELO NOME DO Estoque (PARA BUSCAR UMA LISTA DE IGUAIS)


        public List<Estoque> buscarEstoqueDaListaPorNome(string _estoqueLOCAL)
        {
            EstoqueDAO EstoqueDAO = new EstoqueDAO();
            List<Estoque> estoqueEncontrados = new List<Estoque>();

            IEnumerable<Estoque> listaDeEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _estoqueLOCAL.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Estoque Estoque in listaDeEstoques)
            {
                string[] palavras = Estoque.estoqueLOCAL.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada Estoque
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if (palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper())
                        {
                            estoqueEncontrados.Add(Estoque); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um Estoque
                        }
                    }
                }
            }
            if (estoqueEncontrados.Count() != 0)  //Resultados encontrados
            {
                return estoqueEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }


        /*********************************************************/
        // FAZ A BUSCA DO Estoque NA LISTA PELO NOME E PELO CÓDIGO

        public List<Estoque> buscarEstoqueDaListaPorCodigoEPorNome(string _estoqueLOCAL, string _estoqueCODIGO)
        {
            EstoqueDAO EstoqueDAO = new EstoqueDAO();
            List<Estoque> EstoquesEncontrados = new List<Estoque>();


            IEnumerable<Estoque> listaDeEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _estoqueLOCAL.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Estoque Estoque in listaDeEstoques)
            {
                string[] palavras = Estoque.estoqueLOCAL.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada Estoque
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if ((palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper()) && (Estoque.estoqueCODIGO == _estoqueCODIGO))
                        {
                            EstoquesEncontrados.Add(Estoque); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um Estoque
                        }
                    }
                }
            }
            if (EstoquesEncontrados.Count() != 0) //Resultados encontrados
            {
                return EstoquesEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }

        /*********************************************************/
        // RECUPERA A LISTA DE ESTOQUES DE ESTOQUEDAO


        public List<Estoque> getEstoques()
        {
            IEnumerable<Estoque> listaDeEstoques = EstoqueDAO.dadosArquivoEstoquesBruto;
            //List<String> Locais = new List<string>();

            /*/
            if (listaDeEstoques.Count() != 0) {
                foreach (Estoque estoque in listaDeEstoques) {
                    Locais.Add(estoque.estoqueLOCAL);
                }
            } else {
                Locais.Add("Não há locais disponíveis");
            }
            /*/

            return listaDeEstoques.ToList<Estoque>();
            //return Locais;
        }


        /*********************************************************/
        // RECUPERA A LISTA DE MOVIMENTOS DE ESTOQUEDAO

        public List<Movimentacao> getMov()
        {
            IEnumerable<Movimentacao> listaDeMov = EstoqueDAO.dadosArquivoMovimentacoesBruto;
            return listaDeMov.ToList<Movimentacao>();
        }

        /*********************************************************/
        // RECUPERA A LISTA DE MOVIMENTOS DE ESTOQUEDAO

        public List<MovComp> getMovComp()
        {
            IEnumerable<MovComp> listaDeMovComp = EstoqueDAO.dadosArquivoMovCompBruto;
            return listaDeMovComp.ToList();
        }


        /*********************************************************/
        //RECUPERAR O HEADER DE MOVIMENTAÇÃO

        public String[] getHeaderMov()
        {
            ControleDAO controle = new ControleDAO();
            String[] headerMov = controle.dadosHeaderMov;
            return headerMov;

        }

        /*********************************************************/
        //RECUPERAR O HEADER DE ESTOQUE

        public String[] getHeaderEstoq()
        {
            ControleDAO controle = new ControleDAO();
            String[] headerEstoq = controle.dadosHeaderEstoq;
            return headerEstoq;

        }

        /*********************************************************/
        //RECUPERAR O HEADER DE MOVIMENTAÇÃO COMPLETA

        public String[] getHeaderMovComp()
        {
            ControleDAO controle = new ControleDAO();
            String[] headerMovComp = controle.dadosHeaderMovComp;
            return headerMovComp;

        }

        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE LOCAL


        public List<Movimentacao> relatorioMovLocal(string _localescolhido, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            var arquivoMovimentacoes = EstoqueDAO.dadosArquivoMovimentacoesBruto; //Pega o arquivo de Movimentações
            //var Codlist = new List<String> { }; //Lista de códigos alocados 
            List<Movimentacao> movListaUnicos = new List<Movimentacao>();


            if (arquivoMovimentacoes != null)
            {
               List<Movimentacao> resultadoBusca = estoqueDAO.buscarMovLocal(_localescolhido);

               movListaUnicos = (resultadoBusca.Select(m => new Movimentacao()
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
                               })
                              .DistinctBy(d => d.movCODIGO)
                              .OrderByDescending(d => d.movDATA))
                              .ToList();

          /*/ // SE NÃO FOR USAR O DISTINCTBY DO MORELINQ, DEVE-SE FAZER ASSIM:
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
                }/*/
            }

            else { // Se arquivoMovimentacoes == null

                return movListaUnicos;
            }

            List <dynamic> novoProdutosMoviment = movListaUnicos.ToList<dynamic>();
            estoqueDAO.prepararCSV(novoProdutosMoviment, _nomeLocal,  _nomeRel,  _tipoRel,  _Status,  _Header);
            return movListaUnicos;
        }


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE OPERAÇÃO


        public List<Estoque> relatorioEstoqOperacao(string _opEscolhida, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            var arquivoEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //Pega o arquivo de Movimentações
            List<Estoque> estoqListaUnicos = new List<Estoque>();


            if (arquivoEstoques != null)
            {
                List<Estoque> resultadoBusca = estoqueDAO.buscarEstoqOperacao(_opEscolhida);

                estoqListaUnicos = (resultadoBusca.Select(e => new Estoque()
                                    {
                                        estoqueCODIGO = e.estoqueCODIGO,
                                        estoqueLOCAL = e.estoqueLOCAL,
                                        estoqueDETALHES = e.estoqueDETALHES,
                                        //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                        estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                        estoqueDATA = e.estoqueDATA
                                    })
                                       .DistinctBy(d => d.estoqueCODIGO)
                                       .OrderByDescending(d => d.estoqueDATA))
                                       .ToList();
            }

            else { // Se arquivoMovimentacoes == null

                return estoqListaUnicos;
            }

            List<dynamic> novoProdutosEstoq = estoqListaUnicos.ToList<dynamic>();
            estoqueDAO.prepararCSV(novoProdutosEstoq, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return estoqListaUnicos;
        }


        /*********************************************************/
        // CONTROLLER DO RELATÓRIO DE OPERAÇÃO


        public List<Estoque> relatorioEstoqAudit(DateTime _dataEscolhida, String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            var arquivoEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //Pega o arquivo de Movimentações
            List<Estoque> estoqListaUnicos = new List<Estoque>();

            if (arquivoEstoques != null)
            {
                
                List<Estoque> resultadoBusca = estoqueDAO.buscarEstoqAudit(_dataEscolhida, _nomeLocal);

                /*/
                estoqListaUnicos = (resultadoBusca.Select(e => new Estoque()
                                        {
                                            estoqueCODIGO = e.estoqueCODIGO,
                                            estoqueLOCAL = e.estoqueLOCAL,
                                            estoqueDETALHES = e.estoqueDETALHES,
                                            //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                            estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                            estoqueDATA = e.estoqueDATA
                                        })
                                       //.DistinctBy(d => d.estoqueCODIGO) // Não pegará só um na auditoria
                                       .OrderByDescending(d => d.estoqueDATA))
                                       .ToList();
               /*/


                estoqListaUnicos = resultadoBusca;
            }

            else { // Se arquivoMovimentacoes == null

                return estoqListaUnicos;
            }

            List<dynamic> novoProdutosEstoq = estoqListaUnicos.ToList<dynamic>();
            estoqueDAO.prepararCSV(novoProdutosEstoq, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return estoqListaUnicos;
        }

        /*********************************************************/

            public List<Estoque> relatorioEstoqRel(String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
            {
                EstoqueDAO estoqueDAO = new EstoqueDAO();
                var arquivoEstoques = EstoqueDAO.dadosArquivoEstoquesBruto; //Pega o arquivo de Movimentações
                List<Estoque> estoqListaUnicos = new List<Estoque>();

                if (arquivoEstoques != null)
                {
                    List<Estoque> resultadoBusca = estoqueDAO.buscarEstoqRel(_nomeRel);

                /*/
                    estoqListaUnicos = (resultadoBusca.Select(e => new Estoque()
                                            {
                                                estoqueCODIGO = e.estoqueCODIGO,
                                                estoqueLOCAL = e.estoqueLOCAL,
                                                estoqueDETALHES = e.estoqueDETALHES,
                                                //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                                estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                                estoqueDATA = e.estoqueDATA
                                            })
                                           //.DistinctBy(d => d.estoqueCODIGO) // Não pegará só um na auditoria
                                           .OrderByDescending(d => d.estoqueDATA))
                                           .ToList();
               /*/
                estoqListaUnicos = resultadoBusca;
                }

                else { // Se arquivoMovimentacoes == null

                    return estoqListaUnicos;
                }

                List<dynamic> novoProdutosEstoq = estoqListaUnicos.ToList<dynamic>();
                estoqueDAO.prepararCSV(novoProdutosEstoq, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
                return estoqListaUnicos;
        }


      /*********************************************************/

        public List<Movimentacao> relatorioMovRel(String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            var arquivoMovs = EstoqueDAO.dadosArquivoMovimentacoesBruto; //Pega o arquivo de Movimentações
            List<Movimentacao> movListaUnicos = new List<Movimentacao>();

            if (arquivoMovs != null)
            {
                List<Movimentacao> resultadoBusca = estoqueDAO.buscarMovRel(_nomeRel);

                /*/
                    estoqListaUnicos = (resultadoBusca.Select(e => new Estoque()
                                            {
                                                estoqueCODIGO = e.estoqueCODIGO,
                                                estoqueLOCAL = e.estoqueLOCAL,
                                                estoqueDETALHES = e.estoqueDETALHES,
                                                //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                                estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                                estoqueDATA = e.estoqueDATA
                                            })
                                           //.DistinctBy(d => d.estoqueCODIGO) // Não pegará só um na auditoria
                                           .OrderByDescending(d => d.estoqueDATA))
                                           .ToList();
               /*/
                movListaUnicos = resultadoBusca;
            }

            else { // Se arquivoMovimentacoes == null

                return movListaUnicos;
            }

            List<dynamic> novoMovsRel = movListaUnicos.ToList<dynamic>();
            estoqueDAO.prepararCSV(novoMovsRel, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return movListaUnicos;
        }


        /*********************************************************/

        public List<MovComp> relatorioMovCompRel(String _nomeLocal, String _nomeRel, String _tipoRel, Boolean _Status, Boolean _Header)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            var arquivoMovs = EstoqueDAO.dadosArquivoMovimentacoesBruto; //Pega o arquivo de Movimentações
            List<MovComp> movListaUnicos = new List<MovComp>();

            if (arquivoMovs != null)
            {
                List<MovComp> resultadoBusca = estoqueDAO.buscarMovCompRel(_nomeLocal);


                /*/
                movListaUnicos = (resultadoBusca.Select(e => new Estoque()
                                {
                                    estoqueCODIGO = e.estoqueCODIGO,
                                    estoqueLOCAL = e.estoqueLOCAL,
                                    estoqueDETALHES = e.estoqueDETALHES,
                                    //e.estoqueOPERACAO = e.estoqueOPERACAO,
                                    estoqueQUANTIDADE = e.estoqueQUANTIDADE,
                                    estoqueDATA = e.estoqueDATA
                                })
                               //.DistinctBy(d => d.estoqueCODIGO) // Não pegará só um na auditoria
                               .OrderByDescending(d => d.estoqueDATA))
                               .ToList();
               
               // /*/ movListaUnicos = resultadoBusca;
            }

            else { // Se arquivoMovimentacoes == null

                return movListaUnicos;
            }

            List<dynamic> novoMovsRel = movListaUnicos.ToList<dynamic>();
            estoqueDAO.prepararCSV(novoMovsRel, _nomeLocal, _nomeRel, _tipoRel, _Status, _Header);
            return movListaUnicos;
        }


        /*********************************************************/
        // FAZ A BUSCA DO ITEM NA LISTA PELO NOME DO PRODUTO (PARA BUSCAR UMA LISTA DE IGUAIS)


        public List<Estoque> buscarItemDaListaPorNome(string _cod)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            List<Estoque> itensEncontrados = new List<Estoque>();

            IEnumerable<Estoque> listaDeItens = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _cod.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Estoque estoque in listaDeItens)
            {
                string[] palavras = estoque.estoqueCODIGO.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada produto
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if (palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper())
                        {
                            itensEncontrados.Add(estoque); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um produto
                        }
                    }
                }
            }
            if (itensEncontrados.Count() != 0)  //Resultados encontrados
            {
                return itensEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }


        /*********************************************************/
        // FAZ A BUSCA DO ITEM NA LISTA PELO NOME E PELO CÓDIGO

        public List<Estoque> buscarItemDaListaPorCodigoEPorNome(string _cod, string _nome)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            List<Estoque> itensEncontrados = new List<Estoque>();
            List<Produto> prodEncontrados = new List<Produto>();

            IEnumerable<Estoque> listaDeItens = EstoqueDAO.dadosArquivoEstoquesBruto; //pega a variável global com o arquivo pelo GET

            string[] palavrasBusca = _nome.Split(' '); //Faz uma lista de palavras por nome fornecido
            foreach (Estoque estoque in listaDeItens)
            {
                string[] palavras = estoque.estoqueLOCAL.Split(' '); //Faz uma lista de palavras por nome
                foreach (string palavraBusca in palavrasBusca) //Percorre a lista de palavras do nome fornecido
                {
                    string palavraBuscaResult = new string(palavraBusca.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                    foreach (string palavra in palavras) //Percorre a lista de palavras de cada produto
                    {
                        string palavraResult = new string(palavra.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
                        if ((palavraResult.Trim().ToUpper() == palavraBuscaResult.Trim().ToUpper()) && (estoque.estoqueCODIGO == _cod))
                        {
                            itensEncontrados.Add(estoque); //Checa se palavra é igual à alguma palavra do nome fornecido
                            break; //Se encontrar a mesma palavra em um só nome, vai mar como um produto
                        }
                    }
                }
            }

            if (itensEncontrados.Count() != 0) //Resultados encontrados
            {
                return itensEncontrados;
            }
            else // Não encontrado
            {
                return null;
            }
        }

        /*********************************************************/
        // SELECT MOVCOMP EM DETERMINADO ESTOQUE

        public List<MovComp> consultarMovCompEmEstoque(String _estoqueCod)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            List<MovComp> lista = estoqueDAO.buscarMovCompEstoque(_estoqueCod);
            return lista;

        }

        /*********************************************************/
        // SELECT MOVCOMP EM DETERMINADO ESTOQUE E PRODUTO

        public List<MovComp> MovCompComEstoqueProduto(String _codProd, String _codEstoq)
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            List<MovComp> lista = estoqueDAO.buscarMovCompEstoqueProd(_codProd, _codEstoq);
            List<MovComp> ListaUnicos = new List<MovComp>();

            ListaUnicos = (lista.Select(movcomp => new MovComp()
            {
                //ADICIONA OS DADOS DE MOVIMENTACAO ESCOLHIDA
                mov_CODIGO = movcomp.mov_CODIGO,
                mov_DETALHES = movcomp.mov_DETALHES,
                mov_OPERACAO = movcomp.mov_OPERACAO,
                mov_DATA = movcomp.mov_DATA,

                //ADICIONA OS DADOS DE PRODUTO AFETADO
                produto_CODIGO = movcomp.produto_CODIGO,
                produto_PRODUTO = movcomp.produto_PRODUTO,
                produto_DIMENSOES = movcomp.produto_DIMENSOES,
                produto_DETALHES = movcomp.produto_DETALHES,
                produto_QUANTIDADE = movcomp.produto_QUANTIDADE,
                produto_VALOR = movcomp.produto_VALOR,
                produto_VALORTOTAL = movcomp.produto_VALORTOTAL,
                produto_SERIE = movcomp.produto_SERIE,
                produto_NOTAFISCAL = movcomp.produto_NOTAFISCAL,
                produto_SEQ = movcomp.produto_SEQ,
                produto_FORNECEDOR = movcomp.produto_FORNECEDOR,
                produto_COMPLEMENTO = movcomp.produto_COMPLEMENTO,
                produto_STATUS = movcomp.produto_STATUS,

                //ADICIONA OS DADOS DE ESTOQUE AFETADO
                estoque_CODIGO = movcomp.estoque_CODIGO,
                estoque_LOCAL = movcomp.estoque_LOCAL,
                estoque_DETALHES = movcomp.estoque_DETALHES,
                estoque_QUANTIDADE = movcomp.estoque_QUANTIDADE
            })
                                   .DistinctBy(d => d.mov_CODIGO)
                                   .OrderByDescending(d => d.mov_DATA))
                                   .ToList();
            return ListaUnicos;

        }
        /*********************************************************/












    }
}
