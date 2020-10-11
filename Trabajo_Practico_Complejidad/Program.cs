using ArbolBinario;
using System;
using tp1;

namespace Trabajo_Practico_Complejidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PruebaAB.Main_ArbolBinario();

            ArbolGeneral<int> arbolRaiz = new ArbolGeneral<int>(0);
            ArbolGeneral<int> arbol1 = new ArbolGeneral<int>(1);
            ArbolGeneral<int> arbol2 = new ArbolGeneral<int>(2);
            ArbolGeneral<int> arbol3 = new ArbolGeneral<int>(3);
            ArbolGeneral<int> arbol4 = new ArbolGeneral<int>(4);
            ArbolGeneral<int> arbol5 = new ArbolGeneral<int>(5);
            ArbolGeneral<int> arbol6 = new ArbolGeneral<int>(6);
            ArbolGeneral<int> arbol7 = new ArbolGeneral<int>(7);

            arbol1.agregarHijo(arbol4);

            arbol6.agregarHijo(arbol7);

            arbol2.agregarHijo(arbol5);
            arbol2.agregarHijo(arbol6);

            arbolRaiz.agregarHijo(arbol1);
            arbolRaiz.agregarHijo(arbol2);
            arbolRaiz.agregarHijo(arbol3);


            Console.WriteLine("Altura : " + arbolRaiz.alturaRecursion());


        }
    }
}
