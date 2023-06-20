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
    public partial class PaginaCadastrarQuarto : Form
    {
        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        public PaginaCadastrarQuarto()
        {
            InitializeComponent();
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCaixas();
        }
        private void limparCaixas()
        {
            getNumeroQ.Clear();
            getValorDiaria.Clear();
            getNumeroMaxP.Clear();
            getDetalhes.Clear();

        }
        private Boolean verificar()
        {

            if (String.IsNullOrEmpty(getDetalhes.Text) || String.IsNullOrEmpty(getNumeroMaxP.Text)
                            || String.IsNullOrEmpty(getNumeroQ.Text) || String.IsNullOrEmpty(getValorDiaria.Text)
                            )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                int numero = int.Parse(getNumeroQ.Text);
                String disponivel = "Disponível";
                int valorDiaria = int.Parse(getValorDiaria.Text);
                int numeroMaximoPessoa = int.Parse(getNumeroMaxP.Text);
                String detalhes = getDetalhes.Text;


                using (MySqlConnection conexao = new MySqlConnection(banco))
                {
                    try
                    {
                        conexao.Open();

                        string consulta = "INSERT INTO quartos (numero_quarto,disponibilidade,valor_diaria,numero_max_pessoas,detalhes) VALUES (@valor1,@valor2,@valor3,@valor4,@valor5)";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexao))
                        {
                            comando.Parameters.AddWithValue("@valor1", numero);
                            comando.Parameters.AddWithValue("@valor2", disponivel);
                            comando.Parameters.AddWithValue("@valor3", valorDiaria);
                            comando.Parameters.AddWithValue("@valor4", numeroMaximoPessoa);
                            comando.Parameters.AddWithValue("@valor5", detalhes);

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
    }
}
