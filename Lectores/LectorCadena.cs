namespace Ging1991.Persistencia.Lectores {
		
	public class LectorCadena : LectorGenerico<LectorCadena.Dato> {

		public LectorCadena(string direccion, Tipo tipo, string direccionInicializacion = "") : base(direccion, tipo, direccionInicializacion) {}


		public void Guardar(string valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public string valor;

		}
		

	}

}