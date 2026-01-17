using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace promedioNotasconFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres;
            int cant;
            Console.WriteLine("Ingrese cantidad nombres a registrar: ");
            cant = Convert.ToInt32(Console.ReadLine());
            nombres = new string[cant];
            capturarDatos(nombres);
            mostrarDatos(nombres);

        }

        static string capturarDatos(string[] nombres)
        {
            Console.WriteLine("Ingrese los nombres: ");
            for (int i = 0; i < nombres.Length;i++)
            {
                nombres[i] = Console.ReadLine();
            }
            return nombres[0];
        }

        static void mostrarDatos(string[] nombres)
        {
            Console.WriteLine("Los nombres registrados fueron: ");
            for (int j = 0; j < nombres.Length;j++)
            {
                Console.WriteLine($"{nombres[j]}");
            }
        }



    }
}
