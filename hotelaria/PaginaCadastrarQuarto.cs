﻿using MySql.Data.MySqlClient;
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
            getNumeroMaxP.MaxLength = 2;
            getDetalhes.MaxLength = 50;
            getNumeroQ.MaxLength = 3;
            getValorDiaria.MaxLength = 5;
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica se o valor está fora do intervalo permitido
            int valor;
            if (!int.TryParse(textBox.Text, out valor) || valor < 1 || valor > 12)
            {
                textBox.Text = string.Empty; // Limpa o valor do TextBox
                e.Cancel = true; // Cancela o evento de validação
            }
        }

        public bool ValidarEntradaDoParametros(int param1, int param2, int param3, string param4)
        {
            bool areValid = true;

            // Verifica se param1, param2 e param3 são do tipo int
            if (!(param1 is int) || !(param2 is int) || !(param3 is int))
            {
                areValid = false;
            }

            // Verifica se param4 é do tipo string
            if (!(param4 is string))
            {
                areValid = false;
            }

            return areValid;
        }
        

    }
}
