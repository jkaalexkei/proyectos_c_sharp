
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


            Console.WriteLine("Ingrese un numero a invertir");
            int dato = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El numero invertido de {dato} es {invertirNumero(dato)}");

        }

        static void incrementarNumero(ref int numero)
        {
            numero = numero + 1;
            Console.WriteLine("Metodo: {0}",numero);



        }

        static int invertirNumero(int numero)
        {
            int invertido = 0;
            int residuo = 0;

            while (numero > 0)
            {
                residuo = numero % 10;
                invertido = invertido * 10 + residuo;
                numero = numero / 10;
            }

            return invertido;
        }


    }
}
