using hotelaria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Assert = NUnit.Framework.Assert;

namespace Tests
{


    [TestClass]
    public class Testes
    {
        private PaginaLogin login;

        PaginaLogin pl = new PaginaLogin();

        private PaginaLogin form;

        [TestInitialize]
        public void Init()
        {
          
        }

        [SetUp]
        public void SetUp()
        {
            form = new PaginaLogin();
            form.Show(); // Exibe o formulário durante o teste
        }

        [TearDown]
        public void TearDown()
        {
            form.Close(); // Fecha o formulário após o teste
        }

        /// <summary>
        /// Teste de unitario.
        /// </summary>

        [TestMethod]
        public void TestComBancoDeDados()
        {
            Boolean resultado = pl.ValidateLogin("luizugulino", "0123");
            Assert.AreEqual(true, resultado);
        }


        [TestMethod]
        public void TestGetDados()
        {
            Boolean resultado = pl.verificar();
            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Teste de Integração do sistema.
        /// </summary>


        [Test]
        public void TesteIntegracao()
        {

            Button botao = form.Controls["getBTentrar_Click"] as Button;
            botao.PerformClick();

            // Chama a função que deseja testar
            bool resultado = form.abrirJanela(obj: new PaginaPrincipal());

            // Verifica o resultado da função
            Assert.IsTrue(resultado);



        }




    }

}