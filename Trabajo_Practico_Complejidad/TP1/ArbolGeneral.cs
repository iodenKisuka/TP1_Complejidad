using System;
using System.Collections.Generic;
using tp1;

namespace tp1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura() {
			int alturaM = 0;
			if (esHoja()) { return alturaM; }
			else
			{




			}


		}
	
		
		public int nivel(T dato) {
			return 0;
		}

		// Ejercicio 4 C  TP1
		public int ancho()
		{
			int ancho = 1;
			List<ArbolGeneral<T>> hijosdelArbol = hijos;
			List<ArbolGeneral<T>> Siguiente_nivel_hijos;
			do
			{
				if (ancho < hijos.Count)
				{
					ancho = hijos.Count;
				}
				Siguiente_nivel_hijos = new List<ArbolGeneral<T>>();
				foreach (ArbolGeneral<T> Obtener_hijo in hijos)
				{
					foreach (ArbolGeneral<T> hijo in Obtener_hijo.getHijos())
					{
						Siguiente_nivel_hijos.Add(hijo);
					}
				}
				hijos = Siguiente_nivel_hijos;

			} while (Siguiente_nivel_hijos.Count > 0);



			return ancho;
		}






	}
}


