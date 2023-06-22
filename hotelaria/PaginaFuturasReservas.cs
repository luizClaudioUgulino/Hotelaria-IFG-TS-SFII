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
    public partial class PaginaFuturasReservas : Form
    {
        public PaginaFuturasReservas()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            getano.MaxLength = 4;
            getdia.MaxLength = 2;
            getmes.MaxLength = 2;

            listView.Columns.Add("ID reserva", 100, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", 140, HorizontalAlignment.Left);
            listView.Columns.Add("Entrada", 130, HorizontalAlignment.Left);
            listView.Columns.Add("Saida", 130, HorizontalAlignment.Left);
            listView.Columns.Add("Valor reserva", 150, HorizontalAlignment.Left);
            listView.Columns.Add("Numero do quarto", 170, HorizontalAlignment.Left);
            CarregarDados();
        }



        private void CarregarDados()
        {
            listView.Items.Clear();

            String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas WHERE DATE(data_entrada) > CURDATE() and disponibilidade = 'aberto'";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        ListViewItem item = new ListViewItem(reader["id_reserva"].ToString());
                        item.SubItems.Add(reader["CPF_cliente"].ToString());
                        item.SubItems.Add(reader["data_entrada"].ToString());
                        item.SubItems.Add(reader["data_saida"].ToString());
                        item.SubItems.Add(reader["valor_total_reserva"].ToString());
                        item.SubItems.Add(reader["numero_quarto"].ToString());

                        listView.Items.Add(item);

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void bAtualizar_Click(object sender, EventArgs e)
        {
            String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
            listView.Items.Clear();
            if (Verficar() == true && String.IsNullOrEmpty(getId.Text))
            {

                String data = "" + getano.Text + "-" + getmes.Text + "-" + getdia.Text;

                using (MySqlConnection connection = new MySqlConnection(banco))
                {
                    string query = "SELECT * FROM reservas WHERE DATE(data_entrada) = '" + data + "' and disponibilidade = 'aberto'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            ListViewItem item = new ListViewItem(reader["id_reserva"].ToString());
                            item.SubItems.Add(reader["CPF_cliente"].ToString());
                            item.SubItems.Add(reader["data_entrada"].ToString());
                            item.SubItems.Add(reader["data_saida"].ToString());
                            item.SubItems.Add(reader["valor_total_reserva"].ToString());
                            item.SubItems.Add(reader["numero_quarto"].ToString());

                            listView.Items.Add(item);

                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
            else if (Verficar() == false && getId.Text != "")
            {

                String data = "" + getano.Text + "-" + getmes.Text + "-" + getdia.Text;

                using (MySqlConnection connection = new MySqlConnection(banco))
                {
                    string query = "SELECT * FROM reservas WHERE disponibilidade = 'aberto' and id_reserva ='" + getId.Text + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            ListViewItem item = new ListViewItem(reader["id_reserva"].ToString());
                            item.SubItems.Add(reader["CPF_cliente"].ToString());
                            item.SubItems.Add(reader["data_entrada"].ToString());
                            item.SubItems.Add(reader["data_saida"].ToString());
                            item.SubItems.Add(reader["valor_total_reserva"].ToString());
                            item.SubItems.Add(reader["numero_quarto"].ToString());

                            listView.Items.Add(item);

                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
            else if (Verficar() == true && getId.Text != "")
            {
                String data = "" + getano.Text + "-" + getmes.Text + "-" + getdia.Text;

                using (MySqlConnection connection = new MySqlConnection(banco))
                {
                    string query = "SELECT * FROM reservas WHERE DATE(data_entrada) = '" + data + "' and disponibilidade = 'aberto' and id_reserva ='" + getId.Text + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            ListViewItem item = new ListViewItem(reader["id_reserva"].ToString());
                            item.SubItems.Add(reader["CPF_cliente"].ToString());
                            item.SubItems.Add(reader["data_entrada"].ToString());
                            item.SubItems.Add(reader["data_saida"].ToString());
                            item.SubItems.Add(reader["valor_total_reserva"].ToString());
                            item.SubItems.Add(reader["numero_quarto"].ToString());

                            listView.Items.Add(item);

                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
            else if (Verficar() == false && getId.Text != "")
            {
                CarregarDados();
            }  

        }
            
        
        private Boolean Verficar()
        {
            if (String.IsNullOrEmpty(getdia.Text) || String.IsNullOrEmpty(getmes.Text)
                || String.IsNullOrEmpty(getano.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            getId.Clear();
            getdia.Clear();
            getmes.Clear();
            getano.Clear();
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

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica se o valor está fora do intervalo permitido
            int valor;
            if (!int.TryParse(textBox.Text, out valor) || valor < 2020 || valor > 2026)
            {
                textBox.Text = string.Empty; // Limpa o valor do TextBox
                e.Cancel = true; // Cancela o evento de validação
            }
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica se o valor está fora do intervalo permitido
            int valor;
            if (!int.TryParse(textBox.Text, out valor) || valor < 1 || valor > 31)
            {
                textBox.Text = string.Empty; // Limpa o valor do TextBox
                e.Cancel = true; // Cancela o evento de validação
            }
        }

    }
}
