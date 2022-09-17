using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022._002.EjercicioPOO
{
    public abstract class TransportePublico
    {
		private int _pasajeros;

		public int Pasajeros { get => _pasajeros; }

		public TransportePublico(int cantidadPasajeros) => _pasajeros = cantidadPasajeros;

		public abstract void Avanzar();
		public abstract void Detenerse();
	}
}
