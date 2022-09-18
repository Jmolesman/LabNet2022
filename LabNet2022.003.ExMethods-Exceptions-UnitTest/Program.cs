using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet2022._003.ExMethods_Exceptions_UnitTest.Logica;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1 ejercicioUno = new Punto1();
            ejercicioUno.IniciarEjercicioUno();

            Punto2 ejercicioDos = new Punto2();
            ejercicioDos.IniciarEjercicioDos();

            Console.Clear();
            Console.WriteLine("* << Inciso 3 >> *");
            try
            {
                Console.WriteLine("Probando Excepciones");
                CapaLogicaExcepcion.NoSosChuckNorrisDividiendo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generado: {ex.Message}");
                Console.WriteLine($"Tipo de excepcion: {ex.GetType()}.");
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("* << Inciso 4 >> *");
            Console.WriteLine("Desea agregar un mensaje a la excepcion personalizada?");
            Console.WriteLine("En caso contrario solo presione <Enter>");
            string frase = Console.ReadLine();
            CapaLogicaExcepcion.ChuckNorrisInfinitoExcepcion(frase);
        }
    }
}
