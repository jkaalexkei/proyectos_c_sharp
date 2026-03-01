using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_48_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             sumar todos los elementos de una lista
             */

            List<int> listNumeros = new List<int> { 10,30};

            int suma = 0;
            Console.WriteLine("Los elementos de la lista es: ");
            foreach (int item in listNumeros)
            {
                Console.WriteLine(item);
                suma += item;
            }
            Console.WriteLine($"se sumaron {listNumeros.Count} elementos");
            Console.WriteLine($"la suma total es: {suma}");
        }
    }
}
