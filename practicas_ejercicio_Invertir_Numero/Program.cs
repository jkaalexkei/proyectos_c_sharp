using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas_ejercicio_Invertir_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Invertir un numero
            int numeroAconvertir, numeroConvertido, division, residuo, numAuxiliar;
            string dato;
            Console.WriteLine("Ingrese un numero de 2 cifras a invertir");
            dato = Console.ReadLine();
            Console.WriteLine("Uso de la forma 1 cuando el dato es de tipo string y bucle for");
            //FORMA 1
            int indice = dato.Length;
            for (int i = indice; i > 0; i--)
            {
                Console.Write(dato[i-1]);
            }
            Console.WriteLine();
            //FORMA 2
            Console.WriteLine("Uso de la forma 2 cuando el dato es de tipo int");
            numeroAconvertir = Convert.ToInt32(dato);
            division = numeroAconvertir / 10;
            residuo = numeroAconvertir % 10;

            numeroConvertido = (residuo * 10) + division;

            Console.WriteLine($"El numero convertido es: {numeroConvertido}");
            Console.WriteLine();
            //FORMA 3
            Console.WriteLine("Uso de la forma 2 cuando el dato es de tipo int y uso de bucle while");
            int invertido = 0;
            while (numeroAconvertir > 0)
            {
                residuo = numeroAconvertir % 10;
                invertido = invertido * 10 + residuo;
                numeroAconvertir = numeroAconvertir / 10;
            }
            Console.WriteLine("el numero invertido es: {0}",invertido);

            Console.ReadKey();



            
        }
    }
}
