using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioStruct
{
    internal class Program
    {

        public struct Persona
        {
            public string nombre;
            public int edad;

            public Persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public override string ToString()
            {

                return String.Format($"Nombre: {this.nombre}, Edad: {this.edad}");
            }

            public void aumentarEdad(Persona perso, int newEdad)
            {
                perso.edad += newEdad;
            }
        }
        static void Main(string[] args)
        {
                string nombre = "alex";
                int edad = 20;
                Persona persona1 = new Persona(nombre,edad);

                persona1.aumentarEdad(persona1, 20);

                Console.WriteLine(persona1.ToString());


            
        }

        
    }
}
