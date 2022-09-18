using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest
{
    public class Punto2
    {
        public int Dividir(int dividendo, int divisor)
        {
            int resultado = 0;
            try
            {
                resultado = dividendo / divisor;
                Console.WriteLine($"El resultado de la operacion {dividendo}/{divisor} es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Solo Chuck Norris divide por cero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Excepcion generica controlada, Chuck Norris esta mirando que haces.....");
            }

            return resultado;
        }


        public void IniciarEjercicioDos()
        {
            bool esIntDividendo = false;
            bool esIntDivisor = false;

            int dividendo;
            int divisor;

            do
            {
                try
                {
                    BorrarConsola();
                    Console.WriteLine("* << Inciso 2 >> *");
                    Console.WriteLine("Ingrese dos numeros para realizar una division (Solo Enteros)");
                    Console.Write("Ingrese por favor un dividendo ==> ");
                    dividendo = Convert.ToInt32(Console.ReadLine());
                    esIntDividendo = true;

                    Console.Write("Ingrese por favor un divisor ==> ");
                    divisor = Convert.ToInt32(Console.ReadLine());
                    esIntDivisor = true;

                    if (esIntDividendo && esIntDivisor)
                    {
                        Dividir(dividendo, divisor);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Seguro ingresaste una letra o no ingresaste nada!");
                    Console.WriteLine("No me hagas decirle a Chuck Norris!");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Solo Chuck Norris puede hacer eso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Excepcion generica controlada, Chuck Norris esta mirando que haces.....");
                }
                finally
                {
                    Console.WriteLine("Presione una tecla para continuar....");
                    Console.ReadKey();
                }
            } while (!esIntDividendo || !esIntDivisor);
        }

        private void BorrarConsola() => Console.Clear();
    }
}
