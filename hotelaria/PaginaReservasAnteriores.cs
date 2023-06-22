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
    public partial class PaginaReservasAnteriores : Form
    {
        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        public PaginaReservasAnteriores()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;


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

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas WHERE DATE(data_entrada) < CURDATE() and disponibilidade = 'fechado'";
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

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            getcpf.Clear();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            if (getcpf.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(banco))
                {
                    string query = "SELECT * FROM reservas WHERE DATE(data_entrada) < CURDATE() and disponibilidade = 'fechado' and id_reserva='" + getcpf.Text + "'";
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
            else
            {

                MessageBox.Show("Por favor preencher campo ID da reserva");
                CarregarDados();
            }
        }
    }
}
