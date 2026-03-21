using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_69_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear clase Vehiculo y clase Hija Auto, con metodo MostrarTipo sobreescrito
            Vehiculo auto = new Vehiculo();
            auto.MostrarTipo();

            Vehiculo carro = new Auto();// aqui se aplica polimorfismo
            carro.MostrarTipo();
        }

    }

    class Vehiculo
    {
        public int Ruedas { get; set; }
        public string Tapiceria { get; set; }
        
        public Vehiculo()
        {
            this.Ruedas = 4;
            this.Tapiceria = "cuero";
        }
        public virtual void MostrarTipo()
        {
            Console.WriteLine($"El Vehiculo tiene, ruebas: {Ruedas} tapiceria: {Tapiceria}");
        }
    }

    class Auto : Vehiculo
    {
        public Auto()
        {
            this.Ruedas = 4;
            this.Tapiceria = "Tela";
        }
        public override void MostrarTipo()
        {
            Console.WriteLine($"El auto tiene, ruedas: {this.Ruedas} tapiceria: {this.Tapiceria}");
        }
    }
}
