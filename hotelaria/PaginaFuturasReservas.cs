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

            listView.Columns.Add("id_reserva", 100, HorizontalAlignment.Left);
            listView.Columns.Add("cpf", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Entrada", 130, HorizontalAlignment.Left);
            listView.Columns.Add("saida", 130, HorizontalAlignment.Left);
            listView.Columns.Add("valor reserva", 100, HorizontalAlignment.Left);
            listView.Columns.Add("numero quarto", 100, HorizontalAlignment.Left);
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
            if (Verficar() == true)
            {

                String data = "" + getano.Text + "-" + getmes.Text + "-" + getdia.Text;

                if (String.IsNullOrEmpty(getId.Text))
                {

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
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(banco))
                    {
                        string query = "SELECT * FROM reservas WHERE DATE(data_entrada) = '" + data + "' and disponibilidade = 'aberto' and CPF_cliente ='" + getId.Text + "'";
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

            }
            else
            {
                MessageBox.Show("Por favor preencher data");
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
    }
}
