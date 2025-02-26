using System.Collections.Generic;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Ging1991.Persistencia.Lectores {

	public class LectorImagenLazy {

		private readonly Dictionary<string, Sprite> mapaImagenes;
		private readonly Direccion direccionCarpeta;

		public LectorImagenLazy(Direccion direccionCarpeta) {
			mapaImagenes = new Dictionary<string, Sprite>();
			this.direccionCarpeta = direccionCarpeta;
		}

		public Sprite GetImagen (string nombre) {

			if (!mapaImagenes.ContainsKey(nombre)) {
				mapaImagenes.Add(
					nombre, LeerImagen(direccionCarpeta.Generar(nombre))
				);
			}

			return mapaImagenes[nombre];
		}

		public static Sprite LeerImagen(string direccion) {
			return (Sprite) Resources.Load(direccion, typeof(Sprite));
		}

	}

}