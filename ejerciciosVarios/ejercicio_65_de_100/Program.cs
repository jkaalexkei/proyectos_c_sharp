using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_65_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear una clase estudiante que herede de persona y añade una propiedad matricula
             Estudiante estudiante = new Estudiante();

            estudiante.nombre = "Alex";
            estudiante.matricula = 1;

            Console.WriteLine(estudiante.nombre);
            Console.WriteLine(estudiante.matricula);
        }
    }
}
