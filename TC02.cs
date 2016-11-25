using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TC02
    {
        //static void Main(string[] args)
        //{

        //    List<string> Lista = new List<string>();      // Se crea la lista a evaluar.
        //    Boolean flag = true;                         // Esta bandera la uso para la validacion.
        //    while (flag)                                 // Esta validación es para que el usuario pueda ingresar todos los elementos que quiera.
        //    {
        //        Console.WriteLine("\nPor favor ingresar un elemento a la lista.\n");
        //        Lista.Add(Console.ReadLine());
        //        Console.WriteLine("\nSi desea ingresar otro, presione Y \n" +
        //           "Si desea imprimir la lista completa al derecho y al reves," +
        //           "presione cualquier otra tecla. \n");

        //        if (Console.ReadLine().ToString().ToUpper() != "Y")
        //        {
        //            flag = false;
        //        }
        //    }
        //    voltearLista(Lista);                        //Se llama el método voltearLista, que se creó más abajo.
        //    Console.ReadKey();
        //}

        //public static void voltearLista(List<string> lista)     //Con este método se recibe una lista con el fin de imprimirla al derecho y al revés.
        //{
        //    int index = 0;
        //    Console.WriteLine("Lista al derecho \n");
        //    foreach (var item in lista)                        //Con este foreach se recorre la lista al derecho y se van imprimiendo sus elementos.
        //    {
        //        Console.WriteLine("{0}", lista[index]);
        //        index++;
        //    }

        //    Console.WriteLine("\nLista al reves \n");          //Haciendo uso del contador del foreach anterior, se recorre la lista en sentido inverso mientras
        //    foreach (var item in lista)                       // se van imprimiendo sus elementos.
        //    {
        //        Console.WriteLine("{0}", lista[index - 1]);
        //        index--;
        //    }
        //}
    }
}
