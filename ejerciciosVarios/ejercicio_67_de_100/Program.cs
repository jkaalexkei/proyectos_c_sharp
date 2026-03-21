
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_67_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usar propiedades con getters y setters en la clase persona
            Persona persona = new Persona();
            persona.Nombre = "Alex";
            persona.Edad = 20;
            Console.WriteLine(persona.saludar());
            
        }
    }

    class Persona
    {
        private string _nombre;//solo se pueden usar en la clase e indica que es privada
        private int _edad;
        public string Nombre {//propiedad encapsulada
            get { return _nombre; }

            set { _nombre = value; } 
        }
        public int Edad {
            get { return _edad; }
            set {//validamos la propiedad edad
                if (value >= 0)
                {
                    _edad = value;
                }
            }
        }

        public string saludar()
        {
            return $"Hola {this.Nombre} tienes {this.Edad} años";
        }



    }

    

 
}



