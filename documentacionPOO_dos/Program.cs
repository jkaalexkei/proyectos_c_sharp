using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Math;//importación de una clase estatica

namespace documentacionPOO_dos
{
    internal class Program
    {
        static void Main(string[] args)
        {

         //crear una instancia de la clase Circulo, un Objeto
             Circulo miCirculo = new Circulo(); //creacion de objeto de tipo circulo. variable/objeto de tipo circulo, instanciacion de la clase
             
             Circulo miCirculoDos;
             miCirculoDos = new Circulo(); //Instanciacion, ejemplarizacion, ejemplar de clase

             double resultado = miCirculo.calculoArea(5);
            
            Console.WriteLine(resultado);
            //*****************************************************************

            ConversorEuroDolar obj = new ConversorEuroDolar();

            Console.WriteLine(obj.convierte(50));

            //************************************************

            Coche carro1 = new Coche();//con la palabra new llamamos al constructor, instanciar la clase, estado inicial a un objeto


            Console.WriteLine("datos coche 1");
            Console.WriteLine(carro1.getinfoCoche());
            //carro1.setEstablecerValor(true, "cuero");//setter
            Console.WriteLine(carro1.getEstablecerValor());//getter


            Coche carro2 = new Coche(23.5, 45.3);
            Console.WriteLine("datos coche 2");
            Console.WriteLine(carro2.getinfoCoche());

            //**************************************************************

            Prueba otraPrueba = new Prueba();

            Prueba segundaPrueba = new Prueba("Alex");

            otraPrueba.llamada();
            segundaPrueba.llamada();
            Prueba terceraPrueba = new Prueba();
            Console.WriteLine($"Numero de objetos creados de tipo Prueba son: {Prueba.ContadorObjetos()}");


            //declaracion de una variable anonima
            var claseAnonima = new 
            { 
                nombre = "alex",
                edad=40
            };
            
           

            var otraClaseAnonima = new
            {
                nombre = "pedro",
                edad = 34
            };

            Console.WriteLine(claseAnonima.nombre);

            claseAnonima = otraClaseAnonima;

            Console.WriteLine(claseAnonima.nombre);




        }

        static int miFuncion()
        {
            return 10;
        }
    }

    class Circulo //creacion de una clase
    {
        //formula para calcular area = pi * radio al cuadrado

        //atributos o propiedades de clase
        private const double pi = 3.1416;  //constante de clase
       

        //metodos de clase
        public  double calculoArea(int radio)  //metodo para calcular el area circula
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
    }

    class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
            


            
            

        }

        public Coche(double largoCoche, double anchoCoche)//sobre carga de constructor
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }



        public string getinfoCoche()
        {
            return $"ruedas: {ruedas}, largo: {largo}, ancho: {ancho}";
        }

        public void setEstablecerValor(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        public String getEstablecerValor()
        {
            return $"Climatizador: {climatizador}, tapiceria: {tapiceria}";
        }
        

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

/*
 
 getters y  setters : 

metodo setter permite establecer valores a las propiedades de clase, no tiene instrucción return, no devuelve información solo permite asignarle valor a las propiedades

los metodos setter siempre van acompañados de su correspondiente getter

uso de this: se usa para diferenciar cuando se hace referencia a un campo de clase o ha un parametro


dividir (split) las clases largas
 
con el uso de la palabra reservada partial podemos segmentar una clase en varias partes si esta clase es muy extensa






 */
