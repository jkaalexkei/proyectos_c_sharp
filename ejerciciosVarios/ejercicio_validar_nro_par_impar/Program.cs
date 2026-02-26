using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_validar_nro_par_impar
{
    internal class Program
    {
        static void Main(string[] args) {

            //programa que valide si un numero impar, en caso que sea par se salga de la aplicacion

            int numero = 0;
            bool validacion = true;
            do
            {
                Console.WriteLine("Ingrese un numero para validar si par o impar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    validacion = false;
                }
                else
                {
                    Console.WriteLine("El numero es impar, intente otra vez");
                }


            } while (validacion);
            Console.WriteLine("conseguiste un numero par");


        }
    }
}
