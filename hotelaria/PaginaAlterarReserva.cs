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
    public partial class PaginaAlterarReserva : Form
    {
        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        public PaginaAlterarReserva()
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

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listView.SelectedItems[0];
                setNReserva.Text = selectedItem.SubItems[0].Text;
                getCpf.Text = selectedItem.SubItems[1].Text;
                getEntrada.Text = selectedItem.SubItems[2].Text;
                getSaida.Text = selectedItem.SubItems[3].Text;
                GetValor.Text = selectedItem.SubItems[4].Text;
                getNq.Text = selectedItem.SubItems[5].Text;
                getAtivo.Text = selectedItem.SubItems[6].Text;
            }
            else
            {
                setNReserva.Text = "NULL";
                getCpf.Clear();
                getEntrada.Clear();
                getSaida.Clear();
                getNq.Clear();
                getAtivo.Clear();

            }
        }
        private void carregarView()
        {

            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM reservas";
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

        private void getConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (getConfirmar.Checked == true)
            {
                buttonAlterar.BackColor = Color.Lime;

            }
            else
            {
                buttonAlterar.BackColor = Color.White;
            }
        }
    }
}
