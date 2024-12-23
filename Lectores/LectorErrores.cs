using System;
using System.Collections.Generic;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Ging1991.Persistencia.Lectores {

	public class LectorErrores {

		private readonly LectorInterno lectorInterno;
		private static LectorErrores instancia;

		public static LectorErrores GetInstancia() {
			if (instancia == null)
				instancia = new LectorErrores();
			return instancia;
		}


		private LectorErrores() {
			DireccionStream direccion = new DireccionStream("AUDITORIA", "ERRORES.json");
			lectorInterno = new LectorInterno(direccion.Generar());
			
			if (!lectorInterno.ExistenDatos())
				lectorInterno.Guardar(new DatoLista());
		}


		public void Guardar(string mensaje) {
			Debug.LogError(mensaje);

			Dato dato = new Dato();
			dato.mensaje = mensaje;
			dato.fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 

			DatoLista datoLista = lectorInterno.Leer();
			datoLista.lista.Add(dato);
			lectorInterno.Guardar(datoLista);
		}


		public List<Dato> Leer() {
			return lectorInterno.Leer().lista;
		}


		private class LectorInterno : LectorGenerico<DatoLista> {

			public LectorInterno(string direccion) : base(direccion, Tipo.STREAM) {}

		}

		
		[System.Serializable]
		public class DatoLista {

			public List<Dato> lista;

		}


		[System.Serializable]
		public class Dato {

			public string fecha;
			public string mensaje;

		}

	
	}

}