using System.Collections.Generic;

namespace Ging1991.Persistencia.Lectores {
		
	public class LectorListaEnteros : LectorGenerico<LectorListaEnteros.Dato> {
		
		public LectorListaEnteros(string direccion, Tipo tipo, string inicializacion = "") : base(direccion, tipo, inicializacion) {}
		
		
		public  void Guardar(List<int> valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public List<int> valor;

		}


	}

}