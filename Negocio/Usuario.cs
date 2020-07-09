using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
