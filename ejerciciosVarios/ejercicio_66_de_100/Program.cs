using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_66_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sobreescribir el metodo saludar en la clase estudiante, uso de polimorfismo
            Persona persona = new Persona();
            Estudiante estudiante = new Estudiante();
            persona.nombre = "Alex";
            estudiante.nombre = "Pedro";
            persona.saludar();
            estudiante.saludar();

        }
    }

    class Persona
    {
        public string nombre { get; set; }

        public virtual void saludar()
        {
            Console.WriteLine($"Hola {this.nombre} clase persona");
        }

    }

    class Estudiante : Persona
    {
        public int matricula { get; set; }  

        public override void saludar()
        {
            Console.WriteLine("el nombre es {1} La matricula es: {0}, desde la clase estudiante", this.matricula=1234,this.nombre);
        }
    }
}
