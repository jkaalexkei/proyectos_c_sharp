using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoEstructuras
{
    internal class Program
    {
        public struct Contacto
        {
            public string Nombre;
            public string Telefono;
            public string Email;

            public override string ToString()
            {
                StringBuilder sbFormatoResultado = new StringBuilder();

                sbFormatoResultado.AppendFormat($"Nombre: {Nombre}, Telefono: {Telefono}, Email: {Email}");

                return sbFormatoResultado.ToString();
            }
            
        }
        static void Main(string[] args)
        {
            /*
             Ejercicio de agenda de teléfono simple
            Crea una estructura llamada Contacto que contenga los siguientes campos:

            Nombre (cadena de texto)

            Telefono (cadena de texto)

            Email (cadena de texto)

            Luego, crea un arreglo de 3 contactos, solicita al usuario que ingrese la información para cada uno y finalmente muestra los datos ingresados en la consola.
             
             */
            int cantidad = 0;
            Console.WriteLine("Ingrese la cantidad de contactos a registrar: ");
            cantidad = Convert.ToInt32( Console.ReadLine() );
            Contacto[] agenda = new Contacto[cantidad];

            Console.WriteLine("Registre los datos: ");
            for (int i = 0; i < agenda.Length; i++)
            {
                Console.WriteLine("Ingrese los datos para el contacto {0}", (i + 1));
                Console.Write("Nombre: ");
                agenda[i].Nombre = Console.ReadLine();
                Console.Write("Telefono: ");
                agenda[i].Telefono = Console.ReadLine();
                Console.Write("Email: ");
                agenda[i].Email = Console.ReadLine();
            }
               
            Console.WriteLine("Lista de contactos: ");

            foreach (Contacto item in agenda)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var contacto in agenda)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}, Email: {contacto.Email}");
            }








        }
    }
}
