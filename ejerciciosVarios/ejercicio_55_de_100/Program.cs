using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_55_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe una funcion que use parametros nombrados

            datosPersonales(edad:42,nombre:"alex");//sintaxis de un parametro nombrado, sirven para una mejor lectura del codigo 
            //sintaxis: nombrefuncion(nombredelparametro: valordelparametro);
        }

        public static void datosPersonales(string nombre, int edad) {

            Console.WriteLine($"Datos: {edad} - nombre: {nombre}");
        }
    }
}
