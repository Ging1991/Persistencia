using System.Collections.Generic;

namespace Ging1991.Persistencia.Lectores {
		
	public class LectorListaCadenas : LectorGenerico<LectorListaCadenas.Dato> {

		public LectorListaCadenas(string direccion, Tipo tipo, string direccionInicializacion = "") : base(direccion, tipo, direccionInicializacion) {}


		public void Guardar(List<string> valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public List<string> valor;

		}

	}

}