using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia.Direcciones {

	public abstract class Direccion {

		protected readonly string carpeta;
		protected readonly string archivo;

		public Direccion(string carpeta, string archivo) {
			this.carpeta = carpeta;
			this.archivo = archivo;
		}


		public abstract string Generar();


		public abstract string Generar(string archivo);


		public static string GetDireccionPlataforma() {
			return Application.platform == RuntimePlatform.Android ? Application.persistentDataPath : Application.dataPath;
		}


		public static void CrearCarpetaSiNoExiste(string direccionCarpeta) {
			if (!Directory.Exists(direccionCarpeta)) {
				Directory.CreateDirectory(direccionCarpeta);
				Debug.Log("Direccion: La carpeta se ha creado correctamente en " + direccionCarpeta);
			}
		}


		public static int CantidadDeArchivosEnCarpeta(string direccion) {
			if (Directory.Exists(direccion)) {
				string[] files = Directory.GetFiles(direccion, "*.json");
				return files.Length;
			}
			return 0;
		}


	}

}