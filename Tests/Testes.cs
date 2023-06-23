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
        public void TestGetDados2()
        {
            PaginaLogin pl = new PaginaLogin();
            Boolean resultado = pl.verificar();
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void TestGetDados3()
        {
            PaginaLogin pl = new PaginaLogin();
            Boolean resultado = pl.verificar();
            Assert.IsTrue(resultado);
        }

        
        ///////////////////////////////////////////////////////////
        


        [Test]
        public void TesteIntegracao()
        {


        }




    }

}