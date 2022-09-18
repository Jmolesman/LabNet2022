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
    public class Punto2Tests
    {
        [TestMethod()]
        [DataRow(4, 2, 2)]
        [DataRow(8898, 56, 158)]
        [DataRow(77, 3, 25)]
        [DataRow(142, 12, 11)]
        [DataRow(-11, 2, -5)]
        [DataRow(-99, 3, -33)]
        public void DividirTestConMultiplesValores(int dividendo, int divisor, int resultadoEsperado)
        {
            int resultado;
            Punto2 ejercicioDos = new Punto2();

            resultado = ejercicioDos.Dividir(dividendo, divisor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}