using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelaria
{
    public partial class PaginaCadastroCliente : Form
    {
        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        public PaginaCadastroCliente()
        {
            InitializeComponent();
            getCpf.MaxLength = 11;
            getNome.MaxLength = 20;
            getIdadeMes.MaxLength = 2;
            getIdadeAno.MaxLength = 4;
            getIdade.MaxLength = 2;
            getEndN.MaxLength = 2;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            if (Verficar() == true)
            {
                String nome = getNome.Text;
                String cpf = getCpf.Text;
                Boolean sexoMasculino = getMasculino.Checked;
                Boolean sexoMFerminio = GetFerminino.Checked;
                Boolean sexo;
                if (sexoMasculino == true) { sexo = true; } else { sexo = false; }
                String Date = "" + getIdadeAno.Text + "-" + getIdadeMes.Text + "-" + getIdade.Text;
                String endereco = "" + getEndRua.Text + "," + getEndN.Text + "," + getEndB.Text + "," + getEndRe.Text;


                using (MySqlConnection conexao = new MySqlConnection(banco))
                {
                    try
                    {
                        conexao.Open();

                        string consulta = "INSERT INTO clientes (nome,cpf,sexo,idade,endereco) VALUES (@valor1,@valor2,@valor3,@valor4,@valor5)";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexao))
                        {
                            comando.Parameters.AddWithValue("@valor1", nome);
                            comando.Parameters.AddWithValue("@valor2", cpf);
                            comando.Parameters.AddWithValue("@valor3", sexo);
                            comando.Parameters.AddWithValue("@valor4", Date);
                            comando.Parameters.AddWithValue("@valor5", endereco);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Dados Cadastrados com sucesso!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limparCaixas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Ocorreu um erro.", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }




            }
            else
            {
                MessageBox.Show(" Por favor preencher todos os dados com *.", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private Boolean Verficar()
        {
            if (String.IsNullOrEmpty(getNome.Text) || String.IsNullOrEmpty(getCpf.Text)
                || String.IsNullOrEmpty(getIdade.Text) || String.IsNullOrEmpty(getEndRua.Text)
                || String.IsNullOrEmpty(getEndN.Text) || String.IsNullOrEmpty(getEndB.Text)
                || String.IsNullOrEmpty(getIdadeAno.Text) || String.IsNullOrEmpty(getIdadeMes.Text)
                || (getMasculino.Checked == false && GetFerminino.Checked == false)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void limparCaixas()
        {

            getNome.Clear();
            getCpf.Clear();
            getIdade.Clear();
            getEndRua.Clear();
            getEndN.Clear();
            getEndB.Clear();
            getEndRe.Clear();
            getIdadeMes.Clear();
            getIdadeAno.Clear();
            getMasculino.Checked = false;
            GetFerminino.Checked = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCaixas();
        }

        public bool IsNumeric(string input)
        {
            bool isNumeric = double.TryParse(input, out _);
            return isNumeric;
        }
        public bool IsInteger(string input)
        {
            bool isInteger = int.TryParse(input, out _);
            return isInteger;
        }
    }
}
