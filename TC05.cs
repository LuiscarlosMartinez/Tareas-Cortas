using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TC05
    {        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Por favor escriba la primera versión a comparar");
        //    string VersionUno = Console.ReadLine();
        //    Console.WriteLine("Por favor escriba la segunda versión a comparar");
        //    string VersionDos = Console.ReadLine();
        //    int resultado = VersionMayor(VersionUno, VersionDos);                   //Después de ingresar ambas versiones, se comparan usando el método
        //    if (resultado == 1)                                                     // creado más abajo. Dependiendo del resultado se imprime la respuesta
        //        Console.WriteLine("La mayor versión es la segunda");                // usando un if para cada escenario.
        //    if (resultado == 0)
        //        Console.WriteLine("Ambas son la misma versión");
        //    if (resultado == -1)
        //        Console.WriteLine("La mayor versión es la primera");
        //    Console.ReadKey();
        //}

        //public static int VersionMayor(string VUno, string VDos)
        //{
        //    int result = 0;
        //    char delim = '.';
        //    string[] VersOne = VUno.Split(delim);                      //Primero se divide cada String en un arreglo de tipo String, usando el . como separador.
        //    string[] VersTwo = VDos.Split(delim);                     // Luego se pasa cada arreglo a una lista (Arreglo dinámico) para llenar con 0 los espacios
        //    List<string> ListaUno = new List<string>();              // en blanco en la lista con la versión menor. Esto se hace para que en el escenario en que 
        //    List<string> ListaDos = new List<string>();               // la versión mayor tenga más subversiones que la menor, y así el arreglo no salga de sus
        //                                                             // límites al comparar uno con otro. Se usa un foreach para llenar las listas, y luego
        //    foreach (var item in VersOne)                            // con la ayuda de un par de if se dejan las listas del mismo tamaño usando un for.
        //    {
        //        ListaUno.Add(item);
        //    }
        //    foreach (var item in VersTwo)
        //    {
        //        ListaDos.Add(item);
        //    }


        //    if (VersOne.Count() > VersTwo.Count())
        //    {
        //        {
        //            for (int i = VersTwo.Count() - 1; i < VersOne.Count(); i++)
        //                ListaDos.Add("0");
        //        }
        //    }
        //    if (VersTwo.Count() > VersOne.Count())
        //    {
        //        {
        //            for (int i = VersOne.Count() - 1; i < VersTwo.Count(); i++)
        //                ListaUno.Add("0");
        //        }
        //    }

        //    for (int i = 0; i < ListaUno.Count(); i++)                              //Se usa un for para comparar uno por uno los números de cada versión.
        //    {                                                                       //Cuando se encuentra un número mayor que el otro, automáticamente se 
        //        if (Convert.ToInt32(ListaUno[i]) > Convert.ToInt32(ListaDos[i]))    //le asigna el resultado final correspondiente al valor de retorno del método
        //        {                                                                   //y con un break se sale del for para conservar ese valor.
        //            result = -1;
        //            break;
        //        }
        //        if (Convert.ToInt32(ListaDos[i]) > Convert.ToInt32(ListaUno[i]))
        //        {
        //            result = 1;
        //            break;
        //        }
        //    }

        //    return result;
        //}
    }
}
