using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_61_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear un clase llamada persona con propiedades nombre y edad

            Persona p = new Persona();

            p.nombre = "alex";
            Console.WriteLine(p.nombre);
        }
    }
}

class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
       
    
}
