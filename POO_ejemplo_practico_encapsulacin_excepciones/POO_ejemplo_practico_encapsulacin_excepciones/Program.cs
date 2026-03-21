using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejemplo_practico_encapsulacin_excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int edadN = -5;
                var persona = new Persona("Carlos", edadN, "carlos@mail.com", "Calle 123", "555-1234");
                Console.WriteLine(persona);

                persona.Edad = 19; // Esto lanza excepción
                Console.WriteLine(persona);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
