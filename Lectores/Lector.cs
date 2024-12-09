using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia.Lectores {

	public abstract class Lector {

		protected readonly string direccion;
		public enum Tipo {STREAM, RECURSO}
		protected Tipo tipo;

		public Lector(string direccion, Tipo tipo) {
			this.direccion = direccion;
			this.tipo = tipo;
		}


		public bool ExistenDatos() {
			return File.Exists(direccion);
		}


		protected string LeerDesdeStream() {
			return File.ReadAllText(direccion);
		}

		
		protected void GuardarHaciaStream(string contenido) {
			File.WriteAllText(direccion, contenido);
		}


		protected string LeerDesdeRecursos(string direccion) {
			TextAsset recurso = (TextAsset) Resources.Load(direccion, typeof(TextAsset));
			return recurso.text;
		}


	}

}