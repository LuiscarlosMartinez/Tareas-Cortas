using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TC04
    {
        //        static void Main(string[] args)
        //             {
        //                 bool flag = true;              //Esta bandera junto con el while son para que el usuario pueda hacer
        //                 while (flag)                   // mas de una verificación sin necesidad de volver a abrir el programa.
        //                 {
        //                     Console.WriteLine("\n Por favor ingrese una palabra para saber si es un palíndromo");
        //                     string revisar = Console.ReadLine();
        //        bool resultado = esPalindromo(revisar);                                                   //Se utiliza el método creado más abajo.
        //                     if (resultado)                                                              //Con el if, si el resultado que arroja el método es true, se imprime
        //                         Console.WriteLine("La palabra ingresada es un palíndromo \n");          //que es palídromo (Primera línea). Si es false, se imprime que NO es
        //                     else                                                                        //(Segunda línea).
        //                         Console.WriteLine("La palabra ingresada no es un palíndromo \n");
        //                     
        //              Console.WriteLine("Si desea evaluar otra palabra, ingrese Y. \n" +
//                         "De lo contrario, ingrese cualquier otra letra");
//                     if (Console.ReadLine().ToString().ToUpper() != "Y")
//                     {
//                         flag = false;
//                     }
//}


//        }

//        public static bool esPalindromo(string rev)                   //Este método recibe un string y retorna un booleano. El string recibido es
//{                                                                     //invertido en otro string, que luego se comparan. Si ambos son iguales, la
//    bool esPalin = false;                                             //palabra es palídromo y retorna true. De lo contrario, no lo es, entonces
//    string revInvertida = "";                                         //retorna false.
//    for (int i = rev.Count() - 1; i >= 0; i--)
//    {
//        revInvertida = revInvertida + rev[i];
//    }
//    if (rev == revInvertida)
//        esPalin = true;

//    return esPalin;
//}
    }
}
