
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_59_1_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametros por valor y referencia
            int num = 5;
            incrementarNumero(ref num);
            Console.WriteLine($"desde el metodo Main: {num}");
            
        }

        static void incrementarNumero(ref int numero)
        {
            numero = numero + 1;
            Console.WriteLine("Metodo: {0}",numero);
        }


    }
}
