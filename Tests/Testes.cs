using hotelaria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
   

    [TestClass]
    public class Testes
    {
        private PaginaLogin login;
        [TestInitialize] public void Init() {
        
        login = new PaginaLogin();
        
        }


        [TestMethod]
        public void TestMethod1()
        {
            
            
            int valor1 = 2;
            int valor2 = 3;
            int resultadoEsperado = 5;

            // Act (Ação)
            int resultado = 5;

            // Assert (Verificação)
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
