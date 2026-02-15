using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            //TODO:
            Punto origen = new Punto();
            Punto destino = new Punto(150,90);

            double distancia = origen.distanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es: {distancia}");
        }
    }
}
