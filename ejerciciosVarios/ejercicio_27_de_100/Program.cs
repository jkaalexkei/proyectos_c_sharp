using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_27_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe un programa que use switch para determinar el dia la semana basado en un numero
             */

            Console.WriteLine("Ingrese el numero de dia a validar de 1 a 7 donde 1 es lunes y 7 es domingo");

            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes");
                    break;
                case 2:
                    Console.WriteLine("el dia es martes");
                    break;
                case 3:
                    Console.WriteLine("el dia es miercoles");
                    break;
                case 4:
                    Console.WriteLine("el dia es jueves");
                    break;
                case 5:
                    Console.WriteLine("el dia es viernes");
                    break;
                case 6:
                    Console.WriteLine("el dia es sabado");
                    break;
                case 7:
                    Console.WriteLine("el dia es domingo");
                    break;
                default:
                    Console.WriteLine("La opcion no esta contemplada");
                    break;
               

            }
        }
    }
}
