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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            desativarMenu();

           
        }

        /// <summary>
        /// Metodo para realizar troca de painel princial, abrindo outra forms no painel.
        /// </summary>
        /// <param name="subJanela"></param>
        private void abrirSubJanela(Form subJanela)
        {
            if (subjanela.Controls.Count > 0)
            {
                subjanela.Controls.Clear();
            }

            subJanela.TopLevel = false;
            subJanela.Dock = DockStyle.Fill;
            subjanela.Controls.Add(subJanela);
            subjanela.Tag = subJanela;
            subJanela.Show();
        }

        /// <summary>
        /// Metodo para realizar mudança de estado do menu
        /// </summary>
        /// <param name="menu"></param>
        private void aparecerMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                esconderMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        /// <summary>
        /// Metodo para desativar os estado dos menu
        /// </summary>
        private void desativarMenu()
        {
            painelReservas.Visible = false;
            painelCadastros.Visible = false;


        }

        /// <summary>
        /// Metodo para mudar estados menu conforme seu atual estado mudando para falso.
        /// </summary>
        private void esconderMenu()
        {
            if (painelReservas.Visible == true) { painelReservas.Visible = false; }
            if (painelCadastros.Visible == true) { painelCadastros.Visible = false; }
        }


        /// <summary>
        ///  Esse metodos tem como objetio click de ação para realizar visualiação das opções abaixo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void controleCadastro_Click_1(object sender, EventArgs e)
        {
            aparecerMenu(painelCadastros);
        }

        private void controleReservas_Click_1(object sender, EventArgs e)
        {
            aparecerMenu(painelReservas);
        }



        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ControleChecking_Click(object sender, EventArgs e)
        {
            abrirSubJanela(new PaginaChecking());
            esconderMenu();
        }

        private void bReservaVigente_Click(object sender, EventArgs e)
        {
            esconderMenu();
            abrirSubJanela(new PaginaDiaVigente());
           
        }

        private void bFinalizarOperacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bReservasProximos_Click(object sender, EventArgs e)
        {
            esconderMenu();
            abrirSubJanela(new PaginaFuturasReservas());
        }
    }
}
