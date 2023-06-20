using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hotelaria
{
    public partial class PaginaLogin : Form
    {
        
        Thread thread;
        public PaginaLogin()
        {
            InitializeComponent();
            getNome.Text = "luizugulino";
            getSenha.Text = "0123";
        }

        /// <summary>
        /// Essa metodo serve para realizar conexão com banco de dados e validar entrada do usuario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void getBTentrar_Click(object sender, EventArgs e)
        {
            if (verificar()) {
                if (ValidateLogin(getNome.Text, getSenha.Text) == true)
                {
                    thread = new Thread(abrirJanela);
                    thread.TrySetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Usuario não cadastrado no sistema, ou dados incorretos", "MENSAGEM", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        ///  Essa metado serva para verificar se duas textbox estão vazias
        /// </summary>
        /// <returns></returns>
        public Boolean verificar()
        {
            if (String.IsNullOrEmpty(getNome.Text) || String.IsNullOrEmpty(getSenha.Text))
            {
                MessageBox.Show(" Por favor Preencher os campos Associado e senha.", "MENSAGEM", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// metedo para estar verificando conta no banco de dados
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean ValidateLogin(string username, string password)
        {
            
            string connectionString = "server=localhost;database=merceariareis;uid=root;pwd=012304";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
               
                    connection.Open();
                    string query = "SELECT * FROM db_contas WHERE Nome_conta = '"+ username + "' AND Nome_senha = '"+ password + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    if (result > 0) {
                        return true;
                    } else { return false; }

               
               
            }
        }

        public void abrirJanela(object obj)
        {
            Application.Run(new PaginaPrincipal());
        }

        private void getNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
