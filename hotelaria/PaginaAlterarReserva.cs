using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            getCpf.MaxLength = 11;
            getNq.MaxLength = 3;
            GetValor.MaxLength = 5;
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("ID", 60, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", 130, HorizontalAlignment.Left);
            listView.Columns.Add("Entrada", 90, HorizontalAlignment.Left);
            listView.Columns.Add("Saida", 90, HorizontalAlignment.Left);
            listView.Columns.Add("Valor total", 80, HorizontalAlignment.Left);
            listView.Columns.Add("N° quarto", 150, HorizontalAlignment.Left);
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            int idReserva;
            string cpfCliente;
            DateTime dataEntrada;
            DateTime dataSaida;
            decimal valorTotal;
            int numeroQuarto;
            string disponibilidade;

            idReserva = int.Parse(setNReserva.Text);
            cpfCliente = getCpf.Text;
            valorTotal = decimal.Parse(GetValor.Text);
            numeroQuarto = int.Parse(getNq.Text);
            disponibilidade = getAtivo.Text;
            if (getConfirmar.Checked == true) { AtualizarReserva(idReserva, cpfCliente, valorTotal, numeroQuarto, disponibilidade); } else
            {
                MessageBox.Show("Por favor clickar em confirmar");
            }
            carregarView();
            
        }

        private void AtualizarReserva(int idReserva, string cpfCliente, decimal valorTotal, int numeroQuarto, string disponibilidade)
        {
            string connectionString = "server=localhost;database=merceariareis;uid=root;pwd=012304"; // Substitua pela sua string de conexão

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cria o comando SQL
                    string sql = "UPDATE reservas SET CPF_cliente = @cpfCliente, valor_total_reserva = @valorTotal, numero_quarto = @numeroQuarto, disponibilidade = @disponibilidade WHERE id_reserva = @idReserva";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    // Define os parâmetros do comando
                    command.Parameters.AddWithValue("@cpfCliente", cpfCliente);
                    command.Parameters.AddWithValue("@valorTotal", valorTotal);
                    command.Parameters.AddWithValue("@numeroQuarto", numeroQuarto);
                    command.Parameters.AddWithValue("@disponibilidade", disponibilidade);
                    command.Parameters.AddWithValue("@idReserva", idReserva);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Reserva atualizada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar a reserva: " + ex.Message);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado é um número ou uma tecla de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
        }


        public Boolean carregarViewVerificar()
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
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    return false;
                }
            }

        }

    }
}
