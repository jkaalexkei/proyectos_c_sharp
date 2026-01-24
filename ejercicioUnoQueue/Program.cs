using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio Queue 1: Cola de nombres
                Crea un programa con la colección Queue que cree un alista de nombres, lo agrege a la cola y los imprima en orden de llegada. Luego haz que el programa elimine el primer nombre de la cola e imprima nuevamente la lista con los nombres restantes.

                Reglas:

                Usa la declaración Queue<string> colaNombres = new Queue<string>(); para crear la cola

                utiliza un foreach para hacer la impresión de los nombres en orden de llegada y otro para la impresión después de la eliminación
             */

            int cantidad;
            string dato;
            Queue<string>  nombres = new Queue<string>();//aqui se indica el Queue almacenara datos estrictamente strings

            Console.WriteLine("cantidad de nombres a registrar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ingrese los nombres que se agregaran a la lista: ");
            for (int i=0; i < cantidad;i++)
            {
                Console.Write($"Nombre: ");
                dato = Console.ReadLine();
                nombres.Enqueue(dato);
            }
            Console.WriteLine($"Se registraron {nombres.Count} nombres");
            
            foreach (string item in nombres)
            {
                Console.WriteLine($"{item}");
            }
            nombres.Dequeue();
            Console.WriteLine($"Despues de retirar quedan {nombres.Count} nombres");
            foreach (string item in nombres)
            {
                Console.WriteLine($"{item}");
            }
            
            //Console.WriteLine("retiro de elemento: ");
            
            //string valor = (string)nombres.Dequeue();
            //Console.WriteLine("Se elimino el elemento {0}", valor);
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
            
            
            
        }
    }
}
