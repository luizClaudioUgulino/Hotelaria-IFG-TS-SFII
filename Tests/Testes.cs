using hotelaria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Assert = NUnit.Framework.Assert;

namespace Tests
{


    [TestClass]
    public class Testes
    {
        private PaginaLogin login;

        

        private PaginaPrincipal form;

        [TestInitialize]
        public void Init()
        {
          
        }

        [SetUp]
        public void SetUp()
        {
            form = new PaginaPrincipal();
            form.Show(); // Exibe o formulário durante o teste
        }

        [TearDown]
        public void TearDown()
        {
            form.Close(); // Fecha o formulário após o teste
            form.Dispose();
        }

        
        ///////////////////// Test unitario  //////////////////////
        

        [TestMethod]
        public void TestMetodoDeVerificar()
        {
            PaginaLogin pl = new PaginaLogin();
            Boolean resultado = pl.verificar();
            Assert.IsTrue(resultado);
        }

        

        [TestMethod]
        public void TestVerificarSeValorEInt()
        {
            PaginaCadastroCliente pcl = new PaginaCadastroCliente();

            pcl.getNome.Text = "sadasd";
            Boolean resultado = pcl.IsNumeric(pcl.getNome.Text);
            Assert.IsTrue(resultado);
           
        }
        [TestMethod]
        public void TestVerificarOsParametros()
        {
            PaginaCadastrarQuarto pl = new PaginaCadastrarQuarto();

            pl.getDetalhes.Text = "quartoSimples";
            pl.getValorDiaria.Text = "23";
            pl.getNumeroMaxP.Text = "2";
            pl.getNumeroQ.Text = "12";

            Boolean resultado = pl.ValidarEntradaDoParametros(int.Parse(pl.getValorDiaria.Text), int.Parse(pl.getNumeroMaxP.Text), int.Parse(pl.getNumeroQ.Text),pl.getDetalhes.Text);
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void TestVerificarCarregandoList()
        {
            PaginaAlterarReserva pl = new PaginaAlterarReserva();
            Assert.IsTrue(pl.carregarViewVerificar());
        }


        ///////////////////////////////////////////////////////////



        [TestMethod]
        public void TesteIntegracao()
        {
            PaginaLogin form = new PaginaLogin();

            form.Show();

            Thread.Sleep(1000);
            // Obtém a referência para a caixa de texto e define um valor
            TextBox textBox = form.Controls.Find("getNome", true).FirstOrDefault() as TextBox;
            textBox.Text = "luizugulino";

            TextBox textBox2 = form.Controls.Find("getSenha", true).FirstOrDefault() as TextBox;
            textBox2.Text = "0123";

            Thread.Sleep(1000);

            // Obtém a referência para o botão e simula o clique
            Button button = form.Controls.Find("getBTentrar", true).FirstOrDefault() as Button;
            button.PerformClick();
            Thread.Sleep(1000);
            // Realiza asserções para verificar se o botão foi clicado com sucesso
            Assert.AreEqual("Botão clicado!", textBox.Text);
            Assert.AreEqual("Botão clicado!", textBox2.Text);




        }




    }

}