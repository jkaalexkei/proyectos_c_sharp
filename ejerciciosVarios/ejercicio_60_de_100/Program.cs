using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_60_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //escribir una funcion que use parametros de tipo genericos
            mostrarInfo(10);
            mostrarInfo("Hola");
            mostrarInfo(true);

            //tipo de dato generico intuye el tipo de dato del parametro o variable declarada como generico
        }

        static void mostrarInfo<T>(T dato)//declaracion que indica que recibe un tipo de dato generico
        {
            Console.WriteLine($"El tipo es: { typeof(T).Name  }");//typeof(T).Name => devuelve el tipo de dato del parametro generico
        }
    }
}
