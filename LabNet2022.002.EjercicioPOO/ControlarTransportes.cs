using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._002.EjercicioPOO
{
    class ControlarTransportes
    {
        public int CantidadOmnibus { get; set; }
        public int CantidadTaxis { get; set; }
        public int CantidadTransporte { get => CantidadTaxis + CantidadOmnibus; }

        public int OpcionSeleccionada { get; private set; }

        private string _tituloSistema = @"
=    BIENVENIDO AL SISTEMA DE TRANSPORTE AUBASA    =";

        private string _subtituloEstadoTransporte = @"
=           ESTADO ACTUAL DEL TRANSPORTE           =";

        private string _estadoTransporte = @"
=     CANTIDAD ACTUAL DE TAXIS CIRCULANDO   CANTIDADTAXI/5    =
=     CANTIDAD ACTUAL DE OMNIBUS CIRCULANDO CANTIDADOMNIBUS/5    =";

        private string _subtituloOpcionDeTransporte = @"
=        SELECCIONE UNA OPCION DE TRANSPORTE       =";

        private string _viajeEnTaxi = @"
=               VIAJE EN TAXI                      =";

        private string _viajeEnOmnibus = @"
=               VIAJE EN OMNIBUS                   =";

        private string _delimitador = @"		
====================================================";

        List<TransportePublico> listaTransportePublico = new List<TransportePublico>();

        private void Menu()
        {
            Console.Write(_delimitador);
            Console.Write(_tituloSistema);
            Console.Write(_delimitador);
            Console.Write(_subtituloEstadoTransporte);
            Console.Write(_delimitador);
            Console.Write(_estadoTransporte.Replace("CANTIDADTAXI", CantidadTaxis.ToString()).Replace("CANTIDADOMNIBUS", CantidadOmnibus.ToString()));
            Console.Write(_delimitador);
            Console.Write(_subtituloOpcionDeTransporte);
            Console.Write(_delimitador);
            if (OpcionSeleccionada == 0)
            {
                CambiarColorOpcionSeleccionada();
            }
            else
            {
                CambiarColorOpcionNoSeleccionada();
            }
            Console.Write(_viajeEnTaxi);
            if (OpcionSeleccionada == 1)
            {
                CambiarColorOpcionSeleccionada();
            }
            else
            {
                CambiarColorOpcionNoSeleccionada();
            }
            Console.Write(_viajeEnOmnibus);
            CambiarColorOpcionNoSeleccionada();
            Console.WriteLine(_delimitador);
 
        }

        private void CambiarColorOpcionSeleccionada()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private void CambiarColorOpcionNoSeleccionada()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void MostrarMenu()
        {
            OpcionSeleccionada = 0;
            ConsoleKeyInfo teclaPresionada;

            Menu();

            do
            {
                Console.CursorVisible = false;

                teclaPresionada = Console.ReadKey(true);

                if (teclaPresionada.Key == ConsoleKey.UpArrow)
                {
                    if (OpcionSeleccionada == 0)
                    {
                        OpcionSeleccionada = 1;
                        BorrarConsola();
                        Menu();
                    }
                    else
                    {
                        OpcionSeleccionada = 0;
                        BorrarConsola();
                        Menu();
                    }

                }

                if (teclaPresionada.Key == ConsoleKey.DownArrow)
                {
                    if (OpcionSeleccionada == 1)
                    {
                        OpcionSeleccionada = 0;
                        BorrarConsola();
                        Menu();
                    }
                    else
                    {
                        OpcionSeleccionada = 1;
                        BorrarConsola();
                        Menu();
                    }
                }
            } while (teclaPresionada.Key != ConsoleKey.Enter);

            Console.CursorVisible = true;
        }

        public void Iniciar()
        {
            while (CantidadTransporte != 10)
            {
                MostrarMenu();
                string opcion = OpcionSeleccionada == 0 ? "T" : "O";

                switch (opcion)
                {
                    case "O":
                        if (CantidadOmnibus == 5)
                        {
                            Console.WriteLine("Todos los Omnibus disponibles estan ocupados");
                            Console.WriteLine("Seleccione otro metodo de transporte");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey(false);
                            BorrarConsola();
                        }
                        else
                        {
                            CantidadOmnibus += 1;
                            CargarTransporte(opcion);
                        }
                        break;
                    case "T":
                        if (CantidadTaxis == 5)
                        {
                            Console.WriteLine("Todos los Taxis disponibles estan ocupados");
                            Console.WriteLine("Seleccione otro metodo de transporte");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey(false);
                            BorrarConsola();
                        }
                        else
                        {
                            CantidadTaxis += 1;
                            CargarTransporte(opcion);
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, seleccione una opcion correcta");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey(false);
                        break;
                }
                BorrarConsola();
            }

            Console.WriteLine("Todo el transporte disponible se encuentra ocupado");
            Console.WriteLine("Detallando estado del transporte");

            foreach (TransportePublico transporte in listaTransportePublico)
            {
                transporte.Avanzar();
            }
            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadLine();
        }
        private void BorrarConsola()
        {
            Console.Clear();
        }

        public void CargarTransporte(string opcion)
        {
            BorrarConsola();
            int cantidadPasajeros = IngresarPasajeros(opcion);
		
		    switch (opcion)
		    {
			    case "O":
				    Omnibus nvoOmnibus = GenerarOmnibus(cantidadPasajeros);
                    nvoOmnibus.Detenerse();
				    listaTransportePublico.Add(nvoOmnibus);
				break;
			    case "T":
				    Taxi nvoTaxi = GenerarTaxi(cantidadPasajeros);
                    nvoTaxi.Detenerse();
				    listaTransportePublico.Add(nvoTaxi);
				    break;
		    }
        }

        private int IngresarPasajeros (String opcion)
        {
            int pasajeros;

            do
            {
                Console.Write("La capacidad actual del transporte seleccionado es de ");
                Console.WriteLine(opcion == "O" ? "(1-70)" : "(1-3)");
                Console.Write("Ingrese cantidad de pasajeros: ");
                int.TryParse(Console.ReadLine(), out pasajeros);

                if (opcion == "O" && (pasajeros > 0 && pasajeros <= 70))
                {
                    return pasajeros;
                }
                else if (opcion == "T" && (pasajeros > 0 && pasajeros <= 3))
                {
                    return pasajeros;
                }
                else
                {
                    Console.WriteLine("La cantidad ingresada para el transporte seleccionado es incorrecta");
                    Console.WriteLine("Por favor vuelva a ingresar la cantidad de pasajeros");
                    Console.WriteLine("Presione una tecla para continuar....");
                    Console.ReadKey(false);
                    BorrarConsola();
                    pasajeros = 0;
                }
            } while (pasajeros == 0);
            return 0;
        }

        private Omnibus GenerarOmnibus(int cantidadPasajeros)
        {
            return new Omnibus(cantidadPasajeros, CantidadOmnibus);
        }

        private Taxi GenerarTaxi(int cantidadPasajeros)
        {
            return new Taxi(cantidadPasajeros , CantidadTaxis);
        }
    }
}
