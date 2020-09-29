using System;

namespace ArbolBinario
{
	class PruebaAB
	{
		public static void Main_ArbolBinario(string[] args)
		{
			ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

			ArbolBinario<int> hijoIzquierdo=new ArbolBinario<int>(2);
			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));
			
			ArbolBinario<int> hijoDerecho=new ArbolBinario<int>(5);
			hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
			hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));
			
			arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
			arbolBinarioA.agregarHijoDerecho(hijoDerecho);

			arbolBinarioA.preorden();
			arbolBinarioA.inorden();
			arbolBinarioA.postorden();
			arbolBinarioA.recorridoPorNiveles();

			//Console.WriteLine("Es hoja "+ arbolBinarioA.esHoja() + " tiene en total hojas "+ arbolBinarioA.contarHojasRecursion());


			Console.Write("Presione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
		}
	}
}