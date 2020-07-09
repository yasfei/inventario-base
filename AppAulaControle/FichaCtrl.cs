using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using InventarioDados;

namespace InventarioControle
{
    public class FichaCtrl
    {
        public Boolean SalvarFicha(Ficha _Ficha)
        {
            FichaDao FichaDao = new FichaDao();

            if (verificarCamposObrigatorios(_Ficha) == false)
            {
                return false;
            }

            if (FichaDao.salvarFicha(_Ficha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public Boolean alterarFicha(Ficha _Ficha)
        {
            FichaDao FichaDao = new FichaDao();

            if (verificarCamposObrigatorios(_Ficha) == false)
            {
                return false;
            }


            if (FichaDao.alterarFicha(_Ficha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean alterarFichaMockado(Ficha _Ficha, List<Ficha> listaMockada)
        {
            FichaDao FichaDao = new FichaDao();

            if (verificarCamposObrigatorios(_Ficha) == false)
            {
                return false;
            }
            foreach (Ficha Ficha in listaMockada)
            {
                if (Ficha.Nome.Trim() == _Ficha.Nome.Trim())
                {
                    listaMockada.Remove(Ficha);
                    listaMockada.Add(_Ficha);
                    return true;
                }
            }
            return false;



        }
        public List<Ficha> carregarFichas()
        {
            FichaDao FichaDao = new FichaDao();
            return FichaDao.carregarFichas();
        }


        public Boolean verificarCamposObrigatorios(Ficha Ficha)
        {
            Boolean semErros = true;
            if (Ficha.Nome == null || Ficha.Nome.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Casta == null || Ficha.Casta.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Origem == null || Ficha.Origem.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Signo == null || Ficha.Signo.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Ciclo == null || Ficha.Ciclo.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Jogador == null || Ficha.Jogador.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Sexo == null || Ficha.Sexo.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.DivCam == null || Ficha.DivCam.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Caract == null || Ficha.Caract.Trim() == "")
            {
                semErros = false;
            }
            if (Ficha.Propried == null || Ficha.Propried.Trim() == "")
            {
                semErros = false;
            }
            return semErros;
        }

        public List<Pessoa> CarregarPessoas()
        {
            PessoaDAO dao = new PessoaDAO();

            return dao.AbrirDoArquivo();
        }
        public Ficha buscarFichaDaLista(string _nome)
        {
            FichaDao FichaDao = new FichaDao();
            List<Ficha> listaDeFichas = new List<Ficha>();
            FichaDao.mockListaDeFichas(listaDeFichas);

            foreach (Ficha Ficha in listaDeFichas)
            {
                if (Ficha.Nome.Trim() == _nome.Trim())
                {
                    return Ficha;
                }
            }
            return null;


        }
        public Ficha buscarFichaDaListaMockada(string _nome, List<Ficha> listaDeFichasMockada)
        {


            foreach (Ficha Ficha in listaDeFichasMockada)
            {
                if (Ficha.Nome.Trim() == _nome.Trim())
                {
                    return Ficha;
                }
            }
            return null;


        }
        public Ficha buscarFichaDaListaPorJogador(string _jogador)
        {
            FichaDao FichaDao = new FichaDao();
            List<Ficha> listaDeFichas = new List<Ficha>();
            FichaDao.mockListaDeFichas(listaDeFichas);

            foreach (Ficha Ficha in listaDeFichas)
            {
                if (Ficha.Nome.Trim() == _jogador.Trim())
                {
                    return Ficha;
                }
            }
            return null;


        }
        public Ficha buscarFichaDaListaPorJogadorEPorNome(string _jogador, string _nome)
        {
            FichaDao FichaDao = new FichaDao();
            List<Ficha> listaDeFichas = new List<Ficha>();
            FichaDao.mockListaDeFichas(listaDeFichas);

            foreach (Ficha Ficha in listaDeFichas)
            {
                if (Ficha.Nome.Trim() == _jogador.Trim() && Ficha.Nome.Trim() == _nome.Trim())
                {
                    return Ficha;
                }
            }
            return null;


        }
    }
}