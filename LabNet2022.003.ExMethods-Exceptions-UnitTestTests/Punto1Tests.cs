using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2022._003.ExMethods_Exceptions_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest.Tests
{
    [TestClass()]
    public class Punto1Tests
    {
        [TestMethod()]
        public void DividirTest()
        {
            int numero = 4;
            int resultado;
            int resultadoEsperado = 1;
            Punto1 ejercicioUno = new Punto1();

            resultado = ejercicioUno.Dividir(numero);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}