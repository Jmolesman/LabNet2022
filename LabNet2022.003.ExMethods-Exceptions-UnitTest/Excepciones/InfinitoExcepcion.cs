using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest.Excepciones
{
    public class InfinitoExcepcion : Exception
    {
        public InfinitoExcepcion(string frase) : base (ComprobarFrase(frase))
        {

        }
        private static string ComprobarFrase(string frase)
        {
            if (string.IsNullOrEmpty(frase) || string.IsNullOrWhiteSpace(frase))
            {
                frase = "Solo Chuck Norris puede contar hasta el infinito";
            }
            return frase;
        }

        public override string Message => $"Patada Giratoria!!!!!!\n{ base.Message }";

    }
}
