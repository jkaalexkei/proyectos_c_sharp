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

            Padre soyPadre = new Padre("keidy");
            soyPadre.saludar();
            Padre soyHijo = new Hijo1("alex");
            soyHijo.saludar();

            Padre nuevoPadre = new Padre("");
            
            
            
        }
           
    }

    class Padre
    {
        private string nombre;

        public Padre(string nombre)
        {
            this.nombre = nombre;
        }

        public  virtual void saludar()
        {
            Console.WriteLine("Soy padre y estoy saludando");
        }

        public string getNombre()
        {
            return this.nombre;
        }

        protected void Mensaje()
        {
            Console.WriteLine("Hola Mundo");
        }

    }

    class Hijo1 : Padre 
    {
        public Hijo1(string nombreHijo1) : base(nombreHijo1)
        {
        }

        public override void saludar()
        {
            Console.WriteLine($"Soy hijo y estoy saludando ");
        }
        public void estudiar()
        {
            Console.WriteLine("Estoy estudiando");
            Mensaje();
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
