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
    public partial class PaginaCheckout : Form
    {
        String Disponibilidade, id_reserva;
        Boolean confirmar;

        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        public PaginaCheckout()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("ID", 60, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", 90, HorizontalAlignment.Left);
            listView.Columns.Add("Entrada", 90, HorizontalAlignment.Left);
            listView.Columns.Add("Saida", 90, HorizontalAlignment.Left);
            listView.Columns.Add("valor total", 80, HorizontalAlignment.Left);
            listView.Columns.Add("N° quarto", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Disponível", 100, HorizontalAlignment.Left);
            carregarView();
        }

        private void carregarView()
        {

            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas WHERE disponibilidade = 'aberto'";
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
                        item.SubItems.Add(reader["disponibilidade"].ToString());


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


        private void carregarView1()
        {

            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas WHERE disponibilidade = 'aberto' and id_reserva = '" + id_reserva + "'";
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
                        item.SubItems.Add(reader["disponibilidade"].ToString());


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


        private void button2_Click(object sender, EventArgs e)
        {
            if (getid.Text != null || getid.Text != "")
            {
                confirmar = true;
                button1.BackColor = Color.Lime;
            }
            else
            {
                MessageBox.Show("Por favor selecionar uma das opções da tabela.");
                button1.BackColor = Color.White;
                carregarView();
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem;
            if (listView.SelectedItems.Count > 0)
            {

                selectedItem = listView.SelectedItems[0];
                Disponibilidade = selectedItem.SubItems[6].Text;
                id_reserva = selectedItem.SubItems[0].Text;

            }
            else
            {
                selectedItem = null;
                Disponibilidade = null;
                id_reserva = null;
                button1.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (getid.Text != "")
            {
                carregarView1();

            }
            else
            {
                MessageBox.Show("Por favor coloca id da reserva");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getid.Clear();
            carregarView();
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Disponibilidade != null && id_reserva != null)
            {
                if (confirmar == true)
                {
                    MySqlConnection connection = new MySqlConnection(banco);

                    try
                    {
                        // Abrir a conexão com o banco de dados
                        connection.Open();

                        // Comando SQL para atualizar o dado na tabela
                        string sql = "UPDATE reservas SET disponibilidade = 'fechado' WHERE id_reserva = '" + id_reserva + "'";

                        // Executar o comando SQL
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        int linhasAfetadas = command.ExecuteNonQuery();


                        MessageBox.Show("Dados atualizados com sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de atualizar os dados");
                    }
                    finally
                    {
                        // Fechar a conexão com o banco de dados
                        connection.Close();
                    }


                    carregarView();
                    button1.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Antes de Realizar Checkout, Deverá primeiro confirma.");
                }

            }
            else
            {
                MessageBox.Show("Por favor selecionar uma das opções da tabela.");
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
    }
}
