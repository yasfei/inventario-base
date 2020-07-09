using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Pessoa
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        int tipoEnd;

        public int TipoEnd
        {
            get { return tipoEnd; }
            set { tipoEnd = value; }
        }

        string end;

        public string End
        {
            get { return end; }
            set { end = value; }
        }
        
        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        int cidade;

        public int Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        string estCivil;

        public string EstCivil
        {
            get { return estCivil; }
            set { estCivil = value; }
        }

        bool filhos;

        public bool Filhos
        {
            get { return filhos; }
            set { filhos = value; }
        }

        bool animais;

        public bool Animais
        {
            get { return animais; }
            set { animais = value; }
        }
    }
}
