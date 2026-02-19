using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caballo miCaballo = new Caballo("potroSalvaje");
            Console.WriteLine($"El nombre del caballo es: {miCaballo.getNombreMamifero()}");

            Humano nombrePersona = new Humano("Alex");
            Console.WriteLine($"El nombre del humano es: {nombrePersona.getNombreMamifero()}");
        }
    }
    //la clase object siempre va a estar por encima de una clase creada y sus metodos siempre se heredan a las clases inferiores de manera implicita
    class Mamiferos
    {
        private String nombreMamifero;
        public Mamiferos(String nombre) 
        { 
            nombreMamifero = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("cuido de mis crias");
        }

        public string getNombreMamifero()
        {
            return nombreMamifero;
        }
    }

    class Caballo : Mamiferos //sintaxis de la herencia
    {
        public Caballo(string nombre) : base(nombre)
        {

            
        }
        public void galopar()
        {
            Console.WriteLine("soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano (string nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("soy capaz de pensar");
        }
    }


}
