using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_64_de_100
{
    class Persona
    {
        public string nombre {  get; set; }
        
        public Persona(string nombre)//constructor
        {
            this.nombre = nombre;
        }

        public void saludar()
        {
            Console.WriteLine("hola {0}",this.nombre);
        }
    }
}
