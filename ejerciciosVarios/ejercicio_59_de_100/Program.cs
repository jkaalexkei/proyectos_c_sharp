using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_59_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             escribe una funcion que use parametros de referencia
             */
            //se refiere a asignarle una referencia a un valor ya existente y se va a cambiar la información dentro del flujo del programa
            //en la referencia las variables ya deben tener un valor asignado
            int x = 10;
            int y = 20;
            Console.WriteLine($"x={x}, y={y}");
            

            //llamamos a la funcion que otorga la referencia de valores
            refNumeros(ref x, ref y);
            //aqui se immprimen en tiempo de ejecucion los valores cambiados debido a la referencia que se aplica en la funcion refNumeros
            Console.WriteLine($"x={x}, y={y}");

            /*
             Salida en consola

            x=10, y=20
            x=20, y=10
             
             
             
             */

        }

        static void refNumeros(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b = temp; 
        }
    }
}
