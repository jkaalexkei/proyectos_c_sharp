using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_46_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar una lista de enteros y asignale valores

            List<int> list = new List<int>();//declaramos la lista, son de tipo dinamico y pueden crecer segun la necesidad
         
            Console.WriteLine("cantidad de valores a registrar: ");
            int valores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los datos: ");
            for (int i = 0; i < valores; i++)
            {
                Console.Write($"dato {i+1}: ");
                int dato = Convert.ToInt32(Console.ReadLine());
                list.Add(dato);//agregamos elementos a la lista
            }
            Console.WriteLine("Valores Registrados: ");
            foreach (int item in list)//recorremos los valores de la lista
            {
                Console.WriteLine(item);
            }



        }
    }
}
