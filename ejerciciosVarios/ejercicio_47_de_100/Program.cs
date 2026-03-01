using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_47_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recorre una lista de enteros y muesta sus valores

            List<int> listNumeros = new List<int>();
            for (int i = 1; i <= listNumeros.Count;i++)
            {
                Console.Write($"se agrego el nro {i} \n");
                listNumeros.Add(i);

            }
            Console.WriteLine($"se agregaron {listNumeros.Count} elementos a la lista");

            Console.WriteLine("Mostramos los numeros registrados en la lista");
            foreach (int item in listNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
