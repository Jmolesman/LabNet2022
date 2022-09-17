using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._002.EjercicioPOO
{
    class Taxi : TransportePublico
    {
		public string ImagenTaxi = @"
               [\
          .----' `-----.
         //^^^^;;^^^^^^`\
  ______//_____||_____()_\________
 /826   :      :  ____           `\
|>  ____;      ; |TAXI|    ____  _<)
{___/    \_________________/    \___}
    \ '' /                 \ '' /
     '--'                   '--'";

		public int NumeroDeTaxi { get; private set; }
		public Taxi(int cantidadPasajeros, int numeroDeTaxi) : base(cantidadPasajeros)
		{
			NumeroDeTaxi = numeroDeTaxi;
		}

		public override void Avanzar()
		{
			Console.WriteLine($"El Taxi {NumeroDeTaxi} arranca su recorrido llevando a {Pasajeros} pasajeros");
		}

		public override void Detenerse()
		{
			Console.WriteLine(ImagenTaxi);
			Console.WriteLine("Un Taxi se detiene a levantar pasajeros");
			Console.WriteLine("Presione una tecla para continuar....");
			Console.ReadKey(false);
		}
	}
}
