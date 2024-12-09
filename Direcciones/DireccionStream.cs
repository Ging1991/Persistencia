
using UnityEngine;

namespace Ging1991.Persistencia.Direcciones {

	public class DireccionStream : Direccion {

		private readonly string CARPETA_STREAM = "\\TEMPORAL\\";

		public DireccionStream(string carpeta, string archivo = "") : base(carpeta, archivo) {
			CrearCarpetaSiNoExiste(Generar(""));
		}


		public override string Generar() {
			if (archivo == "")
				Debug.LogWarning("No hay un archivo cargado, use Generar(string archivo) en su lugar.");
			return $"{GetDireccionPlataforma()}{CARPETA_STREAM}\\{carpeta}\\{archivo}";
		}


		public override string Generar(string archivo) {
			return $"{GetDireccionPlataforma()}{CARPETA_STREAM}\\{carpeta}\\{archivo}";
		}


	}

}