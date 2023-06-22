using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelaria
{
    public partial class PaginaDiaVigente : Form
    {
        public PaginaDiaVigente()
        {
            InitializeComponent();
            DateTime dataAtual = DateTime.Now;
            String dataFormatada = dataAtual.ToString("dd-MM-yyyy");
            setdia.Text = dataFormatada;

            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;


            listView.Columns.Add("ID reserva", 100, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Entrada", 130, HorizontalAlignment.Left);
            listView.Columns.Add("Saida", 130, HorizontalAlignment.Left);
            listView.Columns.Add("Valor reserva", 150, HorizontalAlignment.Left);
            listView.Columns.Add("Numero do quarto", 170, HorizontalAlignment.Left);
            CarregarDados();
        }

        private void bAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDadosPesquisaAtual(getId.Text);

        }

        /// <summary>
        /// Metodo tem como objetivo para realizar atualizar do listView , conforme o banco de dados.
        /// </summary>
        private void CarregarDados()
        {
            listView.Items.Clear();

            DateTime dataAtual = DateTime.Now;
            String dataFormatada = dataAtual.ToString("yyyy-MM-dd");
            String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";

            using (MySqlConnection connection = new MySqlConnection(banco))
            {

                string query = "SELECT * FROM reservas WHERE DATE(data_entrada) = '" + dataFormatada + "' and disponibilidade = 'aberto'";
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

        /// <summary>
        /// Metodo para atualizar listview com id de pesquisa personalizada. 
        /// </summary>
        /// <param name="valorPesquisa"></param>
        private void CarregarDadosPesquisaAtual(String valorPesquisa)
        {
            String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas WHERE DATE(data_entrada) = CURDATE() and disponibilidade = 'aberto' and id_reserva='" + valorPesquisa + "'";
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

        private void bLimpar_Click(object sender, EventArgs e)
        {
            getId.Clear();
            CarregarDados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
