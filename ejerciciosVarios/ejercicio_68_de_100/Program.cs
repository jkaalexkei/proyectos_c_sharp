using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_68_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear una clase Cliente con un constructor que reciba nombre y edad, y que tenga un metodo MostrarDatos
            Clientes cliente = new Clientes("Alex",25);
            cliente.mostrarDatos();
        }
    }

    class Clientes
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Clientes(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void mostrarDatos()
        {
            Console.WriteLine($"Nombre: {this.Nombre} edad: {this.Edad}");
        }
    }
}
