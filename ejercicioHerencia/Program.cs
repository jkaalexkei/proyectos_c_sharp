using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avion");
            Avion miAvion = new Avion();
            miAvion.arrancaMotor("rummmmmmmmmmmm"); 
            miAvion.despegar();
            miAvion.conducir();//en este metodo se aplica polimorfismo, es un metodo heredado que se comporta como metodo de la clase hija
            miAvion.aterrizar();
            miAvion.pararMotor("plofffff");

            Console.WriteLine("");
            Console.WriteLine("Probando el coche");
            Coche miCoche = new Coche();
            miCoche.arrancaMotor("rammmmmmm");
            miCoche.acelerar();
            miCoche.conducir();//en este metodo se aplica polimorfismo
            miCoche.frenar();
            miCoche.pararMotor("tummm");

            Vehiculo miVehiculo = miAvion;

            miVehiculo.conducir();//esto es polimorfismo en tiempo de ejecucion
        }
    }
}
