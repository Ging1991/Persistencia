using UnityEngine;

namespace Ging1991.Persistencia.Lectores {
		
	public abstract class LectorGenerico<T> : Lector {

		private T dato;

		public LectorGenerico(string direccion, Tipo tipo, string inicializacion = "", string defecto = "") : base(direccion, tipo) {
			if (!ExistenDatos()) {
				if (inicializacion != "")
					InicializarDesdeRecursos(inicializacion);
				if (defecto != "")
					GuardarHaciaStream(defecto);
			}
		}


		public T Leer() {
			if (dato == null) {
				if (tipo == Tipo.STREAM) {
					dato = JsonUtility.FromJson<T>(LeerDesdeStream());
				}
				if (tipo == Tipo.RECURSO)
					dato = JsonUtility.FromJson<T>(LeerDesdeRecursos(direccion));
			}
			return dato;
		}


		public void Descartar() {
			dato = Leer();
		}


		public void Guardar(T dato) {
			if (tipo == Tipo.STREAM)
				GuardarHaciaStream(JsonUtility.ToJson(dato));
			else
				Debug.LogWarning("Un lector de recursos no puede guardar. Use un lector de Stream.");
		}


		public void InicializarDesdeRecursos(string direccion) {
			string datos = LeerDesdeRecursos(direccion);
			GuardarHaciaStream(datos);
		}


	}

}