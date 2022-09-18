using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest.Extensiones
{
    public static class ExtensionesInt
    {
        public static int DividirPorCero(this int numero)
        {
            return numero / 0;
        }
    }
}
