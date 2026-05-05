using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generico_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona<String> objPersona = new Persona<String>("Alex");
            Console.WriteLine(objPersona.getNombre());
        }
    }
    class Persona<T>
    {
        private string _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                try
                {
                    if (value != "")
                    {
                        _Nombre = value;

                    }
                    else
                    {
                        throw new Exception("ERROR DATO VACIO");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR DE EXCEPCION: {0}", e.Message);
                }
            }
        }
        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string nombre) { 
            this.Nombre= nombre;
        }
    }
}
