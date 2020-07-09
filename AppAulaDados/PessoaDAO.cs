using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDados
{
    public class PessoaDAO
    {
        public void SalvarNoArquivo(Pessoa _pessoa)
        {
            try
            {
                string path = @"E:\bd.txt";
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_pessoa.Nome + ";");
                escritor.Write(_pessoa.Tel + ";");
                escritor.Write(_pessoa.TipoEnd + ";");
                escritor.Write(_pessoa.End + ";");
                escritor.Write(_pessoa.Cidade + ";");
                escritor.Write(_pessoa.Estado + ";");
                escritor.Write(_pessoa.Sexo + ";");
                escritor.Write(_pessoa.EstCivil + ";");

                //Controle dos Componentes CheckBox
                string combo = "";

                if (_pessoa.Filhos)
                {
                    combo = "1";
                }
                else
                {
                    combo = "0";
                }
                if (_pessoa.Animais)
                {
                    combo = combo + "1";
                }
                else
                {
                    combo = combo + "0";
                }

                escritor.Write(combo + ";");
                escritor.WriteLine();

                escritor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Pessoa> AbrirDoArquivo()
        {
            string path = @"E:\bd.txt";
            List<Pessoa> listaPessoas = new List<Pessoa>();

            try
            {
                StreamReader leitor = new StreamReader(path);

                String texto = leitor.ReadToEnd();

                char[] separadorLinhas = { '\n' };
                char[] separadorCampos = { ';' };

                string[] linhas = texto.Split(separadorLinhas);

                for (int i = 0; i < linhas.Length - 1; i++)
                {
                    string[] campos = linhas[i].Split(separadorCampos);

                    Pessoa p = new Pessoa();

                    p.Nome = campos[0];
                    p.Tel = campos[1];
                    p.TipoEnd = Int16.Parse(campos[2]);
                    p.End = campos[3];
                    p.Estado = Int16.Parse(campos[4]);
                    p.Cidade = Int16.Parse(campos[5]);

                    p.Sexo = campos[6];
                    p.EstCivil = campos[7];

                    if (Int16.Parse(campos[8]) == 00)
                    {
                        p.Filhos = false;
                        p.Animais = false;
                    }
                    if (Int16.Parse(campos[8]) == 10)
                    {
                        p.Filhos = true;
                        p.Animais = false;
                    }
                    if (Int16.Parse(campos[8]) == 11)
                    {
                        p.Filhos = true;
                        p.Animais = true;
                    }
                    if (Int16.Parse(campos[8]) == 01)
                    {
                        p.Filhos = false;
                        p.Animais = true;
                    }

                    int id = listaPessoas.Count + 1;
                    
                    p.Id = id;

                    listaPessoas.Add(p);
                }
                
                leitor.Close();
                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
