using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_array_de_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato = 3;
            ArrayObjetos listaObjetos = new ArrayObjetos(dato);
            listaObjetos.agregarObjetos(new Persona("Alex", 40));
            listaObjetos.agregarObjetos(new Persona("kei", 40));
            //listaObjetos.agregarObjetos(new Persona("noraya", 40));
            listaObjetos.agregarObjetos(new Animal());

            for (int i = 0; i < dato;i++)
            {
                Console.WriteLine(listaObjetos.getObtenerObjetos(i));
            }

            foreach (var item in listaObjetos)
            {
                
            }

        }
    }

    class ArrayObjetos
    {
        private Object[] arrayObj;
        public int pos = 0;
        
        public ArrayObjetos(int cant) 
        {
            arrayObj = new Object[cant];
        }

        public void agregarObjetos(Object objeto)
        {
            arrayObj[pos] = objeto;
            pos++;
        }

        public Object getObtenerObjetos(int posicion)
        {
            return arrayObj[posicion];
        }
    }

    class Persona
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
           
        }
        //debemos sobreescribir el metodo tostring para que muestre los datos al momento de recorrer el objeto
        public override string ToString() //sino se sobreescribe este metodo, la salida por defecto sera el nombre de la clase
        {
            return $"Nombre: {nombre}, Edad: {edad}"; //retornamos la cadena que queremos mostrar
        }
    }

    class Animal
    {
        private string nombre;
        public string getNombreAnimal()
        {
            return this.nombre = "Tom";
        }
    }
            
}
