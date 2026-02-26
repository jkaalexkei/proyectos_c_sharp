using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_20_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usa el formato de cadenas para mostrar una fecha en formato (DD/MM/YYYY)
            DateTime miFecha = DateTime.Now;

            Console.WriteLine("fecha corta {0}",miFecha.ToString("dd/MM/yyyy"));//cambiamos el formato de la fecha
        }
    }
}
