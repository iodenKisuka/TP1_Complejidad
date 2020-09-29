using System;

namespace ArbolBinario
{
	public class ArbolBinario<T>
	{
		
		private NodoBinario<T> raiz;

		public ArbolBinario(T dato) {
			this.raiz = new NodoBinario<T>(dato);
		}
	
		private ArbolBinario(NodoBinario<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoBinario<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return new ArbolBinario<T>(this.raiz.getHijoIzquierdo());
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return new ArbolBinario<T>(this.raiz.getHijoDerecho());
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.raiz.setHijoIzquierdo(hijo.getRaiz());
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.raiz.setHijoDerecho(hijo.getRaiz());
		}
	
		public void eliminarHijoIzquierdo() {
			this.raiz.setHijoIzquierdo(null);
		}
	
		public void eliminarHijoDerecho() {
			this.raiz.setHijoDerecho(null);
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijoIzquierdo().esVacio() && this.getHijoDerecho().esVacio();
		}
		
		public void inorden() {
		}
		
		public void preorden() {
		}
		
		public void postorden() {
		}
		
		public void recorridoPorNiveles() {
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}

		//tarea 
		public int contarHojasRecursion()
		{
			//Console.WriteLine("inicio recursion");
			int hoja = 0;
			//aca deberia estar el caso es vacio
			if(esVacio())
            {
				Console.WriteLine("Esta vacio");
				return hoja;
            } //No es un arbol vacio
            else
            {
				// Es hoja
				if (esHoja())
                {
					hoja++;
					//Console.WriteLine(hoja);
					

                }
                else
                {
                    if (raiz.getHijoIzquierdo()!=null)
                    {
						hoja+=getHijoIzquierdo().contarHojasRecursion();

					}
					//Es un if para que pueda volver a entrar
					if (raiz.getHijoIzquierdo() != null)
					{
						hoja+=getHijoDerecho().contarHojasRecursion();
					}
				}

            }


			return hoja;
		}

		public int contarHojasInteractivo()
		{

			Console.WriteLine("inicio recursion");
			int hoja = 0;
			//aca deberia estar el caso es vacio
			if (esVacio())
			{
				Console.WriteLine("Esta vacio");
				return hoja;
			} //No es un arbol vacio
			else
			{
				// Es hoja
				if (esHoja())
				{
					hoja++;
					Console.WriteLine(hoja);


				}
				else
				{
					if (raiz.getHijoIzquierdo() != null)
					{
						hoja += getHijoIzquierdo().contarHojasRecursion();

					}
					//Es un if para que pueda volver a entrar
					if (raiz.getHijoIzquierdo() != null)
					{
						hoja = getHijoDerecho().contarHojasRecursion();
					}
				}

			}


			return hoja;








		}




	}
}
