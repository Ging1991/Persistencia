namespace Ging1991.Persistencia.Lectores {
		
	public class LectorEntero : LectorGenerico<LectorEntero.Dato> {

		public LectorEntero(string direccion, Tipo tipo, string direccionInicializacion = "") : base(direccion, tipo, direccionInicializacion) {}


		public void Guardar(int valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public int valor;

		}


	}

}