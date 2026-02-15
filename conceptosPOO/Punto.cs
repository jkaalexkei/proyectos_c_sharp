using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptosPOO
{
    internal class Punto
    {
        private int x, y;
        public Punto(int x, int y) //constructor con parametros
        {
            this.x = x;//inicializacion de propiedades
            this.y = y;

            //Console.WriteLine($"x:{x}, y:{y}");
        }

        public Punto()//constructor por defecto
        {
            //Console.WriteLine("Constructor por defecto");
            this.x =0;
            this.y =0;
        }

        public double distanciaHasta(Punto destino)//recibe un parametro de tipo Objeto hace referencia al objeto origen,el para que recibe el metodo hace referencia al objeto destino
        {
            //con this hacemos referencia al objeto origen que no recibe parametros
            int xDif = this.x - destino.x;//destino hace referencia al objeto destino
            int yDif = this.y - destino.y;
            
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));//formula teorema de pitagoras 

            return distanciaPuntos;
        }

    }
}
