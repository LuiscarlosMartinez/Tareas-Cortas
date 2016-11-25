using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TC03
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
        //           "Si desea consultar la lista para saber si existe un elemento," +
        //           "presione cualquier otra tecla. \n");

        //        if (Console.ReadLine().ToString().ToUpper() != "Y")
        //        {
        //            flag = false;
        //        }
        //    }

        //    Console.WriteLine("Ingrese un elemento para saber si existe en la lista");  //Ahora el usuario ingresa el elemento a buscar en la lista
        //    string elem = Console.ReadLine();
        //    int rep = existe(Lista, elem);
        //    Console.WriteLine("El elemento se encuentra {0} veces en la lista.", rep); //Se llama el método creado más abajo.
        //    Console.ReadKey();
        //}

        //public static int existe(List<string> lista, string elemento)  //Este método recibe una lista y un elemento para buscarlo en esa lista
        //{
        //    int repeticiones = 0;
        //    for (int i = 0; i < lista.Count; i++)                     //Con un for se recorre la lista, comparando el elemento ingresado con el
        //    {                                                         // elemento que se encuentra en cada posición de la lista. Cuando encuentra
        //        if (lista[i] == elemento)                             // una coincidencia, el contador aumenta. Finalmente, se retorna el contador.
        //        {
        //            repeticiones++;
        //        }
        //    }
        //    return repeticiones;
        //}
    }
}
