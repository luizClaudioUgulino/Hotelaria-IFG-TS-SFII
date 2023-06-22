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

            // Simula o clique no botão
            object value = form.controleCadastro_Click_1.PerformClick();

            // Verifica se o resultado esperado ocorreu
            // (pode ser uma verificação em um banco de dados, uma validação de dados, etc.)
            Assert.IsTrue(form.getBTentrar_Click);

            // Outras verificações...



        }




    }

}