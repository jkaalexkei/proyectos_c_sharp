using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_63_de_100
{
    internal class Persona
    {
        public string nombre {  get; set; }
        public int edad {  get; set; }

        public void saludar()
        {
            Console.WriteLine($"Hola {this.nombre}");
        }
    }
}
