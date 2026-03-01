using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_45_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ordena un array de enteros de menor a mayor
            int[] enteros = { 8,7,6,5,4,3,2,1};
            Array.Sort(enteros);//ordenamos el array
            Console.WriteLine($"array ordenado: {string.Join(",",enteros)}");//aqui se imprime el arreglo ya ordenado

        }
    }
}
