using System;
using System.Collections.Generic;
using tp1;

namespace tp1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> Lista_de_hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return Lista_de_hijos;
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
	
		public int alturaRecursion() {
			int altura = 0;
			if (esHoja()) {
				Console.WriteLine("es hoja");
				return altura;
			}
			else
			{
				altura++;
				int altura_del_hijo=0;
				Console.WriteLine("tiene hijo");
				foreach (ArbolGeneral<T> recorrehijo in getHijos())
                {
					altura_del_hijo += recorrehijo.alturaRecursion();
					Console.WriteLine("recorrio al hijo " + recorrehijo.getDatoRaiz()+" tiene altura "+ altura_del_hijo);
					if (altura < altura_del_hijo)
                    {
						altura=altura_del_hijo;
                    }
                }
				
			}

			return altura+1;

		}
	
		
		public int nivel(T dato) {
			if (getDatoRaiz().Equals(dato))
			{
				return 0;
			}
			else
			{
				//-1 si no esta el dato
				int nivel = 1;
				List<ArbolGeneral<T>> hijos = getHijos();
				List<ArbolGeneral<T>> Siguiente_nivel_hijos;
				do
				{
					Siguiente_nivel_hijos = new List<ArbolGeneral<T>>();
					foreach (ArbolGeneral<T> Obtener_hijo in hijos)
					{
						if (Obtener_hijo.getDatoRaiz().Equals(dato)) { return nivel; }
						foreach (ArbolGeneral<T> hijo in Obtener_hijo.getHijos())
						{
							Siguiente_nivel_hijos.Add(hijo);
						}
					}
					hijos = Siguiente_nivel_hijos;
					nivel++;
				} while (Siguiente_nivel_hijos.Count > 0);
				//-1 si no esta el dato
				return -1;
			}
		}

		// Ejercicio 4 C  TP1
		public int ancho()
		{
			int ancho = 1;
			List<ArbolGeneral<T>> hijosdelArbol = Lista_de_hijos;
			List<ArbolGeneral<T>> Siguiente_nivel_hijos;
			do
			{
				if (ancho < hijosdelArbol.Count)
				{
					ancho = hijosdelArbol.Count;
				}
				Siguiente_nivel_hijos = new List<ArbolGeneral<T>>();
				foreach (ArbolGeneral<T> Obtener_hijo in hijosdelArbol)
				{
					foreach (ArbolGeneral<T> hijo in Obtener_hijo.getHijos())
					{
						Siguiente_nivel_hijos.Add(hijo);
					}
				}
				hijosdelArbol = Siguiente_nivel_hijos;

			} while (Siguiente_nivel_hijos.Count > 0);



			return ancho;
		}






	}
}


