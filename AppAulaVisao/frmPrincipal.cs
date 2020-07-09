using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using InventarioControle;

namespace InventarioVisao
{
    public partial class frmPrincipal : Form
    {


        List<Pessoa> listaPessoas = new List<Pessoa>();

        /*********************************************************/
        // INIT

        public frmPrincipal()
        {
            InitializeComponent();
        }


        /*********************************************************/
        // 

        /*/
        private void btnSalvarArq_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaCtrl controle = new PessoaCtrl();

                Pessoa p = CarregarPessoaDoForm();

                controle.SalvarPessoa(p);

                AdicionarPessoaNaGrid(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /*/

        /*********************************************************/
        //

        /*/   private void frmPrincipal_Load(object sender, EventArgs e)
            {
                frmLogin frm = new frmLogin();

                DialogResult resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    Usuario user = (Usuario)frm.Tag;

                    if (user.Login.Equals("aluno") && user.Senha.Equals("123"))
                    {
                        MessageBox.Show("OK");
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

                CarregarGrid();

                temp.Enabled = true;
            }
    /*/

        /*********************************************************/
        //

        private void txbNome_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
        }

        /*********************************************************/
        //

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        //

        private void ltbTipoEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        //

        private Pessoa CarregarPessoaDoForm()
        {
            Pessoa p = new Pessoa();

            p.Nome = txbNome.Text;
            p.Tel = mtbTel.Text;
            p.TipoEnd = (int)ltbTipoEnd.SelectedIndex;
            p.End = txbEndereco.Text;
            p.Estado = (int)cmbEstado.SelectedIndex;
            p.Cidade = (int)cmbCidade.SelectedIndex;

            if (rdbMasculino.Checked)
            {
                p.Sexo = "masculino";
            }
            else
            {
                p.Sexo = "feminino";
            }
            if (rdbCasado.Checked)
            {
                p.EstCivil = "casado";
            }
            else
            {
                p.EstCivil = "solteiro";
            }

            p.Filhos = ckbFilhos.Checked;
            p.Animais = ckbAnimais.Checked;

            return p;
        }


        /*********************************************************/
        //

        private void CarregarFormDePessoa(Pessoa _pessoa)
        {
            txbNome.Text = _pessoa.Nome;
            mtbTel.Text = _pessoa.Tel;
            ltbTipoEnd.SelectedIndex = _pessoa.TipoEnd;
            txbEndereco.Text = _pessoa.End;
            cmbEstado.SelectedIndex = _pessoa.Estado;
            cmbCidade.SelectedIndex = _pessoa.Cidade;

            if (_pessoa.Sexo == "masculino")
            {
                rdbMasculino.Checked = true;
            }
            else
            {
                rdbFeminino.Checked = true;
            }
            if (_pessoa.EstCivil == "casado")
            {
                rdbCasado.Checked = true;
            }
            else
            {
                rdbSolteiro.Checked = true;
            }

            ckbFilhos.Checked = _pessoa.Filhos;
            ckbAnimais.Checked = _pessoa.Animais;
        }

        /*********************************************************/
        //

        public void AdicionarPessoaNaGrid(Pessoa _pessoa)
        {
            dgvCadastro.Rows.Add(dgvCadastro.Rows.Count + 1, _pessoa.Nome);
        }

        /*********************************************************/
        //

        public void CarregarGrid()
        {
            PessoaCtrl controle = new PessoaCtrl();

            listaPessoas = controle.CarregarPessoas();

            foreach (Pessoa ps in listaPessoas)
            {
                dgvCadastro.Rows.Add(ps.Id, ps.Nome);
            }
        }

        /*********************************************************/
        //

        private void dgvCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int16.Parse( dgvCadastro.SelectedRows[0].Cells[0].Value.ToString() );

            Pessoa pessoa = BuscarPessoaDaLista(id);

            CarregarFormDePessoa(pessoa);
        }

        /*********************************************************/
        //

        private Pessoa BuscarPessoaDaLista(int _id)
        {
            try
            {
                foreach (Pessoa ps in listaPessoas)
                {
                    if (ps.Id == _id)
                    {
                        return ps;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /*********************************************************/
        //

        private void temp_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        /*********************************************************/
        //

        private void miLimpar_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(txbNome))
            {
                txbNome.Text = "";
            }
            if (this.Tag.Equals(mtbTel))
            {
                mtbTel.Clear();
            }
        }

        /*********************************************************/
        //

        private void menuC_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip mn = (ContextMenuStrip)sender;
            
            this.Tag = mn.SourceControl;
        }

        /*********************************************************/
        //

        private void iSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (janelaSalvar.ShowDialog() == DialogResult.OK)
                {
                    string camimhoArquivo = janelaSalvar.FileName;
                    
                    MessageBox.Show(camimhoArquivo);
                }

                //PessoaCtrl controle = new PessoaCtrl();

                //Pessoa p = CarregarPessoaDoForm();

                //controle.SalvarPessoa(p);

                //AdicionarPessoaNaGrid(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*********************************************************/
        //

        private void iSair_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.BringToFront();
            
            this.Close();
        }

        /*********************************************************/
        //

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*********************************************************/
        //
    }
}
