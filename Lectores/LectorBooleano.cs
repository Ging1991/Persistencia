namespace Ging1991.Persistencia.Lectores {
		
	public class LectorBooleano : LectorGenerico<LectorBooleano.Dato> {

		public LectorBooleano(string direccion, Tipo tipo, string direccionInicializacion = "") : base(direccion, tipo, direccionInicializacion) {}


		public void Guardar(bool valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public bool valor;

		}


	}

}