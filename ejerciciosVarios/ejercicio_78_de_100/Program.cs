using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_78_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un constructor que lance una excepcion y manejala
            try
            {
                Persona persona = new Persona(20,"alex");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR DE EXCEPCION: {0}",ex.Message);
            }
            
        }
    }
    class Persona
    {
        public int edad;
        public string nombre;
        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;

            if (this.edad < 0 || this.edad > 120 || string.IsNullOrEmpty(this.nombre))
            {
                throw new ArgumentException("Datos edad o nombre Invalidos");
            }
            else
            {
                Console.WriteLine("Datos Validos");
            }

            this.nombre = nombre;
        }
    }
}
