using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_50_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ordena una lista de enteros de menor a mayor

            List<int> list = new List<int> { 9,5,2,1,8};
            Console.WriteLine("lista desordenada: {0}", string.Join(",", list));
            list.Sort();

            Console.WriteLine("lista ordenada: {0}",string.Join(",",list));
        }
    }
}
