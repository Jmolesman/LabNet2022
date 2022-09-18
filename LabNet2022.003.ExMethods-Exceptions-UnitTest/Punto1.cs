using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._003.ExMethods_Exceptions_UnitTest
{
    public class Punto1
    {
        public int Dividir(int numero)
        {
            int resultado = 0;
            bool excepcionActivada = false;

            try
            {
                resultado = numero / numero;
                Console.WriteLine($"El resultado de la operacion {numero}/{numero} es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                excepcionActivada = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                excepcionActivada = true;
            }
            finally
            {
                Console.Write("La operacion a finalizado ");
                Console.WriteLine(excepcionActivada ? "con errorres." : "exitosamente.");
            }
            return resultado;
        }

        public void IniciarEjercicioUno()
        {
            bool esInt = false;

            do
            {
                try
                {
                    BorrarConsola();
                    Console.WriteLine("* << Inciso 1 >> *");
                    Console.WriteLine("Ingrese un numero para realizar la division por si mismo (Solo Enteros)");
                    Console.Write("Ingrese por favor un numero ==> ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    esInt = true;

                    if (esInt)
                    {
                        Dividir(numero);
                    }
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
            } while (esInt == false);
        }

        private void BorrarConsola() => Console.Clear();

    }
}
