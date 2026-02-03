using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Continuacion
{
    internal class Program
    {
        /*ESTRUCTURA ENLAZADA*/
        public struct Direccion//declaramos esta estructura para enlazarla a la estructura de agenda
        {
            public String calle;
            public int numero;

            public Direccion(String pCalle, int pNumero)
            {
                calle = pCalle;
                numero = pNumero;
            }

            public override String ToString()
            {

                StringBuilder sbDireccion = new StringBuilder();
                sbDireccion.AppendFormat($"direccion: {calle}, numero: {numero}");
                return sbDireccion.ToString();
            }
        }
        public struct Agenda//declaracion de la estructur
        {
            //este conjunto de variables siempre se deben inicializar en cada sobrecarga declarada
            public String nombre;
            public String telefono;
            public int edad;
            public Direccion domicilio;
            //declaracion del metodo constructor
            public Agenda(String pNombre, String pTelefono, int pEdad, String pCalle, int pNumero)//metodo constructor
            {
                //inicializacion de variables
                nombre = pNombre;
                
                edad = pEdad;
                //telefono = pTelefono;
                if (pTelefono.Length == 8)//validamos longitud del telefono ingresado
                {
                    telefono = pTelefono;
                }
                else
                {
                    telefono = "telefono no valido";
                }

                domicilio = new Direccion(pCalle, pNumero);//creamos una instancia de la otra estructura en este caso Domicilio

            }

            
            //sobrecarga metodo agenda
            //en cada sobrecarga se deben inicializar todas las varibles, obligatorio
            public Agenda(String pNombre, int pEdad)
            {
                
                nombre = pNombre;
                edad = pEdad;
                telefono = "sin telefono";
                domicilio = new Direccion("sin direccion", 0);
            }
            public Agenda(String pNombre)
            {

                //aca tambien se puede programar para que el usuario ingrese los datos solicitados
                domicilio = new Direccion("sin direccion", 0);
                nombre = pNombre;
                Console.WriteLine("Ingrese la edad");
                edad = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el telf");
                telefono = Console.ReadLine();
                
                
            }
            public Agenda(int pEdad)
            {
                edad = pEdad;
                domicilio = new Direccion("sin direccion",0);
                //aca tambien se puede programar para que el usuario ingrese los datos solicitados
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                
                Console.WriteLine("Ingrese el telf");
                telefono = Console.ReadLine();
                
                
            }

            

            //sobreescribir metodo tostring()
            public override string ToString()//permite modificar el comportamiento del metodo en funcion de la necesidad del programa, no requiere parametro y devuelve un objeto del tipo string
            {

                StringBuilder sbcadena = new StringBuilder();//es una clase que provee .net permite crear cadenas de forma eficiente, se puede usar en lugar de concatenacion, permite agregar información especial, permite colocar lista de variables

                sbcadena.AppendFormat($"Nombre {nombre}, edad: {edad}, telefono: {telefono}"); //se usa para poder concatenar dentro de la misma clase del StringBuilder, se puede agregar una cadena de formato personalizada, se le puede dar formato especial a la cadena
                //esta sentencia permite darle formato a una cadena
                sbcadena.Append(domicilio.ToString());//aqui concatenamos la cadena de sbcadena y domicilio.
                return (sbcadena.ToString());//retorna la nueva subcadena
            }


        }
        static void Main(string[] args)
        {




            /*POO: */
            //INVOCAMOS EL METODO CONSTRUCTOR
            Agenda amigo = new Agenda("Alex","12345678",45, "sin direccion", 0);//creamos una instancia y le pasamos parametros
            Agenda amigo1 = new Agenda("Keidy","123",40, "sin direccion", 0);
            Agenda amigo2 = new Agenda("luis",35);
            Agenda amigo3 = new Agenda("Keidy");
            Agenda amigo4 = new Agenda(26);

            

            Console.WriteLine(amigo.ToString());//aqui mostramos la cadena en el formato indicado en el StringBuilder haciendo el llamado al objeto amigo y su metodo tostring
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());
            Console.WriteLine(amigo4.ToString());

            Console.ReadKey();
        }
    }
}

/*
 POO -> Programacion orientada a objetos

que es: es un paradigma de la programación, esto quiere decir que es una forma de resolver problemas a traves de clases y objetos.

Que es un objeto: es una unidad dentro del programa que tiene caracteristicas y puede realizar diferentes acciones

Las caracteristicas son las variables o atributos

las acciones que realiza un objeto son los metodos

que es una clase: las clases son los planos o moldes con los que se crean los objetos

instancia: Creación de un nuevo objeto.
---------------------------------------------------------
 El constructor, es un metodo que nos permitirá llevar a cabo la inicialización de los campos (estado inicial del objeto) y consta de algunas caracteristicas importantes:

se llamará igual que la clase o estructura a la que pertenece

el constructor se invoca automaticamente cuando llevamos a cabo la instanciacion de la variable de la estructura

no tiene tipo. No solo no regresa nada, no tiene tipo

debe ser public para que pueda ser llamado desde fuera


------------------------------------------------------------------
ejemplo de una clase

Class Silla{
    
    public Silla(){
        
        Patas = 4;
        Espaldar = 1;
        Cojines = 1;
        Altura = 1,5;
    }
    
}
------------------------------------------------------------------
metodo sobrecargado: es una técnica de programación y nos va a permitir tener varias versiones de esa funcion o metodo que estemos usando, el compilador usara la version a utilizar basandose en la cantidad de parametros y sus tipos. Esto nos va a permitir agrupar los metodos diferentes bajo un mismo nombre y concepto y esto nos facilitara la programacion.

el constructor se puede sobrecargar

la sobrecarga se debe realizar inmediantamente despues del metodo original
 
 */