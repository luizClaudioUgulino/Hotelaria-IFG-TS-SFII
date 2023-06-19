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
    public partial class PaginaChecking : Form
    {
        String banco = "server=localhost;database=merceariareis;uid=root;pwd=012304";
        Boolean confirmar = false;

        String ValortotalDiaria;
        String quartoEscolha;
        int valorTotal;


        public PaginaChecking()
        {
            InitializeComponent();
            ListQuartos.View = View.Details;
            ListQuartos.LabelEdit = true;
            ListQuartos.AllowColumnReorder = true;
            ListQuartos.FullRowSelect = true;
            ListQuartos.GridLines = true;

            getCpf.MaxLength = 11;
            getEntradaAno.MaxLength = 4;
            getEntradaDia.MaxLength = 2;
            GetEntradaMes.MaxLength = 2;
            getIdReserva.MaxLength = 4;
            getSaidaMes.MaxLength = 2;
            getSaidaDia.MaxLength = 2;
            getSaidaAno.MaxLength = 4;

            ListQuartos.Columns.Add("N/Q", 60, HorizontalAlignment.Left);
            ListQuartos.Columns.Add("DISP", 90, HorizontalAlignment.Left);
            ListQuartos.Columns.Add("V/Diaria", 60, HorizontalAlignment.Left);
            ListQuartos.Columns.Add("M/oculpação", 90, HorizontalAlignment.Left);
            ListQuartos.Columns.Add("Detalhes", 200, HorizontalAlignment.Left);
            CarregarDados();
        }

       


        private void CarregarDados()
        {
            ListQuartos.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(banco))
            {
                string query = "SELECT * FROM quartos WHERE disponibilidade = 'Disponível'";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        ListViewItem item = new ListViewItem(reader["numero_quarto"].ToString());
                        item.SubItems.Add(reader["disponibilidade"].ToString());
                        item.SubItems.Add(reader["valor_diaria"].ToString());
                        item.SubItems.Add(reader["numero_max_pessoas"].ToString());
                        item.SubItems.Add(reader["detalhes"].ToString());
                        ListQuartos.Items.Add(item);

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void ListQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListQuartos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListQuartos.SelectedItems[0];
                quartoEscolha = selectedItem.SubItems[0].Text;
                setNumero.Text = quartoEscolha;
                ValortotalDiaria = selectedItem.SubItems[2].Text;

            }
            else
            {
                quartoEscolha = "";
                ValortotalDiaria = "";
            }
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            if (Verficar() == true)
            {
                confirmar = true;

                String dateEntrada = "" + getEntradaDia.Text + "/" + GetEntradaMes.Text + "/" + getEntradaAno.Text;
                String datesaida = "" + getSaidaDia.Text + "/" + getSaidaMes.Text + "/" + getSaidaAno.Text;
                DateTime dataInicial = DateTime.ParseExact(dateEntrada, "dd/MM/yyyy", null);
                DateTime dataFinal = DateTime.ParseExact(datesaida, "dd/MM/yyyy", null);
                TimeSpan diferenca = dataFinal - dataInicial;
                int dias = diferenca.Days;
                // MessageBox.Show(ValortotalDiaria);
                if (double.TryParse(ValortotalDiaria, out double valorTotal2))
                {
                    int calculo = dias * (int)Math.Round(valorTotal2, MidpointRounding.AwayFromZero);
                    valorTotal = calculo;
                }
                else { MessageBox.Show("Valor invalido"); }

                buttonCadastrar.BackColor = Color.Lime;
                saidaValorTotal.Text = valorTotal.ToString();


            }
            else
            {
                confirmar = false;
                MessageBox.Show("Por favor preencher todos os campos.", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void limparCampos()
        {
            getCpf.Clear();
            getIdReserva.Clear();
            getSaidaAno.Clear();
            getSaidaMes.Clear();
            getSaidaDia.Clear();
            getEntradaDia.Clear();
            GetEntradaMes.Clear();
            getEntradaAno.Clear();
            setNumero.Text = "NULL";
            confirmar = false;
        }

        private Boolean Verficar()
        {
            if (String.IsNullOrEmpty(getCpf.Text) || String.IsNullOrEmpty(getIdReserva.Text)
                || String.IsNullOrEmpty(getEntradaDia.Text) || String.IsNullOrEmpty(getEntradaAno.Text)
                || String.IsNullOrEmpty(GetEntradaMes.Text) || String.IsNullOrEmpty(getSaidaDia.Text)
                || String.IsNullOrEmpty(getSaidaMes.Text) || String.IsNullOrEmpty(getSaidaAno.Text)
                || setNumero.Text == "NULL"
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

            if (confirmar == true && Verficar() == true)
            {

                int idReservar = int.Parse(getIdReserva.Text);
                String cpf = getCpf.Text;
                String Entrada = "" + getEntradaAno.Text + "-" + GetEntradaMes.Text + "-" + getEntradaDia.Text;
                String Saida = "" + getSaidaAno.Text + "-" + getSaidaMes.Text + "-" + getSaidaDia.Text;


                using (MySqlConnection connection = new MySqlConnection(banco))
                {
                    string query = "INSERT INTO reservas (id_reserva, CPF_cliente, data_entrada, data_saida, valor_total_reserva,numero_quarto,disponibilidade) " +
                                   "VALUES (@valor1, @valor2, @valor3, @valor4, @valor5,@valor6, @valor7)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@valor1", idReservar);
                    command.Parameters.AddWithValue("@valor2", cpf);
                    command.Parameters.AddWithValue("@valor3", Entrada);
                    command.Parameters.AddWithValue("@valor4", Saida);
                    command.Parameters.AddWithValue("@valor5", valorTotal);
                    command.Parameters.AddWithValue("@valor6", quartoEscolha);
                    command.Parameters.AddWithValue("@valor7", "aberto");

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados inseridos com sucesso!");
                            limparCampos();
                            buttonCadastrar.BackColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível inserir os dados. Algum dado inserido incorretamente.");

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Primeiro acione botão confirmar");

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
