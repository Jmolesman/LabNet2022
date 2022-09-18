using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet2022._003.ExMethods_Exceptions_UnitTest.Extensiones;
using LabNet2022._003.ExMethods_Exceptions_UnitTest.Excepciones;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest.Logica
{
    class CapaLogicaExcepcion
    {
        public static void NoSosChuckNorrisDividiendo()
        {
            int resultado;

            try
            {
                Console.WriteLine("Ingrese un numero para realizar una division por 0 (Solo Enteros)");
                Console.Write("Ingrese por favor un numero ==> ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Intentando realizar {numero}/0");
                resultado = numero.DividirPorCero();
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ChuckNorrisInfinitoExcepcion(string frase)
        {
            double divisor = 0.0;
            double numero;
            double resultado;
            bool excepcionInfinitaActivada = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("* << Inciso 4 >> *");
                    Console.WriteLine("Ingrese un numero para intentar calcular el infinito (Solo Enteros)");
                    Console.Write("Ingrese por favor un numero ==> ");
                    numero = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Intentando calcular el infinito {numero}/0.0");
                    resultado = numero / divisor;

                    if (double.IsInfinity(resultado))
                    {
                        throw new InfinitoExcepcion(frase);
                    }

                }
                catch (InfinitoExcepcion soloChuck)
                {
                    Console.WriteLine(soloChuck.Message);
                    excepcionInfinitaActivada = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Presione una tecla para continuar....");
                    Console.ReadKey();
                }
            } while (!excepcionInfinitaActivada);
        }
    }
}
