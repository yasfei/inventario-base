using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using InventarioDados;

namespace InventarioControle
{
    public class PessoaCtrl
    {
        public void SalvarPessoa(Pessoa _pessoa)
        {
            PessoaDAO dao = new PessoaDAO();

            dao.SalvarNoArquivo(_pessoa);
        }

        public List<Pessoa> CarregarPessoas()
        {
            PessoaDAO dao = new PessoaDAO();

            return dao.AbrirDoArquivo();
        }
    }
}
