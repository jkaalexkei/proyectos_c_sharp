using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo Do While
            /*
             ejecuta al menos una vez el codigo dependiendo de la condicion
             do
             { 
                 condigo (este codigo se ejecuta al menos una vez)

             }(condicion);

             -> se evalua la condicion es verdad se repite el ciclo de lo contrario el programa continua con la ejecución, si la condicion es false el codigo se habra ejecutado al menos una vez.

             -> permite repetir el codigo sin necesidad de saber cuantas veces se requiera
            */

            //programa de carpiteria de ejemplo

            float pies, pulgadas, centimetros;

            string respuesta;
            //el codigo se ejecutara al menos una vez
            do
            {
                Console.WriteLine("Ingrese la cantidad de pies");
                pies = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de pulgadas");
                pulgadas = Convert.ToSingle(Console.ReadLine());


                centimetros = ((pies * 12) + pulgadas) * 2.54f;
                Console.WriteLine("Son {0} centimetros", centimetros);

                Console.WriteLine("desea hacer otra conversión?");
                respuesta = Console.ReadLine();

            }while(respuesta == "si");//si el responde que si, el programa se vuelve a ejecutar, caso contrario continua su ejecución

            if (respuesta == "no")
            {
                Console.WriteLine("Fin del programa");
                return;
            }


        }
    }
}
