using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_62_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia un objeto de la clase persona y asignale valores a sus propiedades
            Persona persona = new Persona();

            persona.nombre = "alex";
            persona.edad = 20;

            Console.WriteLine(persona.nombre);
            Console.WriteLine(persona.edad);
        }
    }

    class Persona
    {
        public string nombre { get; set; }
        public int edad {  get; set; }
    }
}
