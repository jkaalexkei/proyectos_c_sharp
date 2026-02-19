using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_instruccion_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hijo1 nombreHijo1 = new Hijo1("Alex");
            Console.WriteLine("El nombre del hijo 1 es: " + nombreHijo1.getNombre());
            
            Hijo2 nombreHijo2 = new Hijo2("Keidy");
            Console.WriteLine($"El nombre del hijo 2 es {nombreHijo2.getNombre()} y {nombreHijo2.Profesional()}");
        }
           
    }

    class Padre
    {
        private string nombre;

        public Padre(string nombre)
        {
            this.nombre = nombre;
        }

        public void saludar()
        {
            Console.WriteLine("estoy saludando");
        }

        public string getNombre()
        {
            return this.nombre;
        }

    }

    class Hijo1 : Padre 
    {
        public Hijo1(string nombreHijo1) : base(nombreHijo1)
        {
        }
        public void estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
    }

    class Hijo2 : Padre
    {
        public Hijo2(string nombreHijo2) : base(nombreHijo2)
        {
        }
        public string  Profesional()
        {
            return "Estoy en la universidad";
        }
    }
}
