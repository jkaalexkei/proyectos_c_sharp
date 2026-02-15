using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacionPOO_2
{
    class Cubo//las clases deben iniciar con letra mayuscula
    {
        //delcarar datos o atributos
        public int lado;//tipo de acceso  tipo de dato  nombreVariable
        public int area;
        public int volumen;

        public void CalcularArea()//metodo de la clase
        {
            area = (lado * lado) * 6;
        }

        //metodo para calcular el volumen

        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }


    }

    class Prisma
    {
        //declarar datos
        private int ancho, alto, espesor, area, volumen;

        //definimos propiedades
        public int Ancho//definimos este metodo para validar el valor que tiene almacenado la propiedad ancho
        {
            get//obtiene el valor
            {
                return ancho;//devuelve el valor de la propiedad ancho
            }

            set //permite modificar el valor
            {
                if (value <=0)//si el valor es menor o igual a cero asigna 1 a la propiedad ancho
                {
                    ancho = 1;
                }
                else //de lo contrario
                {
                    ancho = value; // asigna el valor a la propiedad ancho
                }
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar la clase cubo
            Cubo miCubo = new Cubo();//objeto1
            Cubo tuCubo = new Cubo();//objeto2
            //asignamos el valor del lado
            miCubo.lado = 7;
            tuCubo.lado = 9;
            miCubo.area = 8;

            //LLamamos metodos
            miCubo.CalcularArea();
            miCubo.CalcularVolumen();
            tuCubo.CalcularArea();
            tuCubo.CalcularVolumen();

            //mostrar datos:
            Console.WriteLine($"Area: {miCubo.area} ,Volumen: {miCubo.volumen}");
            Console.WriteLine($"Area: {tuCubo.area} ,Volumen: {tuCubo.volumen}");
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

el codigo es reutilizable
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
---------------------------------------------------------------------
clases: Modelo para la creación de objetos
Instanciacion: objeto creado a partir de una clase tambien conocido como instancia de la clase
objeto: es una unidad dentro del programa que tiene caracteristicas y puede realizar diferentes acciones
metodos o funciones: comportamiento de los objetos.
datos: son la información con la que trabajará la clase. La clase solamente debe tener los datos que necesita para poder llevar a cabo su trabajo
---------------------------------------------------------------
como declarar la clase y los datos: La declaracion de la clase es un proceso sencillo. Las clases se declaran dentro de un namespace y cualquiera que tenga acceso a ese namespace puede crear objetos de la clase. No olvidemos que la clase es como el plano y los objetos son realmente los que usamos para llevar a cabo el trabajo.

class nombre{
    
    //datos

    //metodos

}
no se pueden tener dos clases con el mismo nombre
---------------------------------------------------------------
Los datos pueden tener los siguiente tipos de acceos: public, private, protected
public: cualquier elemento del exterior puede acceder al datos
private: solo los metodos definidos dentro de la clase lo pueden acceder
local: solo es accesible desde donde es declarado
protected: solo puede usarse dentro de la clase y en clases que heredan de otras clases
------------------------------------------------------
metodo relacionado con la lectura es get
metodo relacionado con la escritura es set
-------------------------------------------------------





 */