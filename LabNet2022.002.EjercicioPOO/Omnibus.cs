using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._002.EjercicioPOO
{
    class Omnibus : TransportePublico
    {
		public string ImagenOmnibus = @"
 ____                                 
|    '------------------------------. 
|      COSTERA METROPOLITANA   ___ | \
| .---.  .---.  .---.  .---.  | | ||-|
| |   |  |   |  |\O |  |   |  | | || |
| |___|  |___|  |_|_|  |___|  | | ||_|
|==========================00=| | |==|
|     _                  _    | | |  |
[___/(O)|______________/(O)|__| j |__]";

		public int NumeroDeOmnibus { get; private set; }

		public Omnibus(int cantidadPasajeros, int numeroDeOmnibus) : base(cantidadPasajeros)
		{
			NumeroDeOmnibus = numeroDeOmnibus;
		}

		public override void Avanzar()
		{
			Console.WriteLine($"El Omnibus {NumeroDeOmnibus} arranca su recorrido llevando a {Pasajeros} pasajeros");
		}

		public override void Detenerse()
		{
			Console.WriteLine(ImagenOmnibus);
			Console.WriteLine("Un Omnibus se detiene a levantar pasajeros");
			Console.WriteLine("Presione una tecla para continuar....");
			Console.ReadKey(false);
		}
	}
}
