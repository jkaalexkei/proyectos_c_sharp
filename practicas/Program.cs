using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodoSinRetorno();
            Console.WriteLine(metodoRetornaDato());
            metodoconParametros(2, 3);
            Console.WriteLine(metodoconparametrosdos("Mundo"));

            Console.WriteLine("Ingrese los datos del auto, marca, ruedas, color, estado(true o false). En ese orden");
            string marca=Console.ReadLine().ToLower();
            int cantidadRuedas = Int32.Parse(Console.ReadLine());
            string color = Console.ReadLine().ToLower();
            bool encendido = Convert.ToBoolean(Console.ReadLine().ToLower());
            Auto Ford = new Auto(marca,cantidadRuedas,color);
            
            string est = Ford.encender(encendido).ToLower();
            if (est != "apagado")
            {
                Console.WriteLine($"auto marca:{Ford.marca} color:{Ford.color} esta en marcha");
            }
            else
            {
                Console.WriteLine($"auto marca:{Ford.marca} color:{Ford.color} esta apagado");
            }
        }

        static void metodoSinRetorno()
        {
            Console.WriteLine("Hola");
            
        }

        static int metodoRetornaDato()
        {
            int numero = 10;
            return numero;
        }

        static void metodoconParametros(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }

        static string metodoconparametrosdos(string mensaje)
        {
            string palabra = "Hola " + mensaje;
            return palabra;
        }

        class Auto
        {
            public string marca;
            public int cantidadRuedas;
            public string color;

            public Auto(string marca, int cantidadRuedas, string color)
            {
                this.marca = marca;
                this.cantidadRuedas = cantidadRuedas;
                this.color = color;
            }

            public string encender(bool estado) 
            {
                if (estado)
                {
                    return "Encendido";
                }
                else
                {
                    return "Apagado";
                }
                
            }

            public void marcha()
            {
                Console.WriteLine("Iniciando a rodar");
            }
        }
    }
}
