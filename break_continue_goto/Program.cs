using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace break_continue_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uso de break, continue, goto
            int numero = 20;
            
            for (int i = 1; i <= numero;i++)
            {
                Thread.Sleep(500);//genera un retardo en la ejecución del codigo
                Console.WriteLine(i);
                if (i == 12)
                {
                    Console.WriteLine("conseguiste el numero 12");
                    //continue;//permite dar continuidad a la ejecución del codigo en funcion de una condición
                    break;// rompe la ejecución del codigo en funcion de una condición dada.
                    //goto etiqueta; //permite salir del bucle y dirigir la ejecución del codigo hacia otra parte en el codigo donde se encuentre la etiqueta
                }
            }

            Console.WriteLine("Mensaje fuera del bucle");
        //etiqueta:
        //    Console.WriteLine("mensaje despues de la etiqueta");

        }
    }
}
