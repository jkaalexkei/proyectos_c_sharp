using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convierte una variable de tipo int a float y viceversa
            int entero = 10;
            float flotante = 15.5f;
            Console.WriteLine(entero.GetType());
            
            Console.WriteLine(flotante.GetType());

            float enteroConvertido = (float)entero;//convertimos entero a float
            Console.WriteLine(enteroConvertido.GetType());

            int flotanteConvertido = (int)flotante;//convertimos flotante a int
            Console.WriteLine(flotanteConvertido.GetType());






        }
    }
}
