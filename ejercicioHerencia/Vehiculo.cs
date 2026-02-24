using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Vehiculo
    {

        public void arrancaMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }

        public void pararMotor(string sonidoAlparar)
        {
            Console.WriteLine($"parar el motor: {sonidoAlparar}");
        }
        public virtual void conducir()//convertimos el metodo virtual para permitir su modificación o adaptacion en las clases hijas
        {
            Console.WriteLine("conducir vehiculo");
        }
    }
}
