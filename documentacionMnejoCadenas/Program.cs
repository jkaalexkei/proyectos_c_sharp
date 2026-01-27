using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacionMnejoCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Forzar UTF-8 en la consola

            String miCadena = "Hola"; //cadena
            string cadena = "Hola Mundo"; //variable

            //******************************

            int valor = 20000;

            //metodo ToString()

            String variable = valor.ToString();//convertimos la variable valor a cadena


            //*************************************************

            DateTime tiempo = DateTime.Now; //se declara e instancia la variable tiempo como tipo de fecha y hora
            String formato;//este tipo declaracion hace que funcione como variable y como objeto de esa clase String

            formato = String.Format("la fecha es: {0:dddd d MMMM yyyy h:m:s tt}", DateTime.Now);//establecemos el formato de fecha
            Console.WriteLine(formato);


            //formato numerico

            /*
                #   digito
                .   punto decimal
                ,   separador de miles
                %   porcentaje
                EO  Notacion cientifica
                ;   separador de secciones
             
             */

            Console.WriteLine(String.Format("{0:$#,####0.00}", valor));//convertir la cantidad de la variable valor a un numero con separador de miles y decimales, devuelve el resultado en formato cadena
            //*******************************************************
            //concatenación:

            String nombreCompleto = String.Concat(miCadena, cadena);//concatenamos dos cadenas
            String mensaje = String.Format("Imprimir mensaje: {0}",nombreCompleto);//le damos formato a la nueva cadena y le agregamos el texto imprimir mensaje
            Console.WriteLine(mensaje);

            String mensaje1 = "Hola Mundo";
            String mensaje2 = "Estoy con C#";

            String unionMensajes = String.Concat(mensaje1, String.Concat(" ", mensaje2));// de esta forma tambien se puede concatenar
            Console.WriteLine(unionMensajes);

            string cadena1 = "Prueba de comparacion";
            string cadena2 = "Prueba de comparacion";

            int comparacion = String.Compare(cadena1,cadena2);//el metodo compare recibe dos cadenas puede ser como tipo de dato string o usando la clase String, esto retorna un entero, donde 0 indica que las cadenas son iguales de lo contrario las cadenas son diferentes

            if (comparacion == 0) {//aqui evaluamos si el valor retornado es 0 las cadenas son iguales
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }
            //**************************************************************
            //uso del metodo Contains();
            String cadena3 = "prueba de buscar cadena";
            bool midato = cadena3.Contains("buscar");//esta declaracion retorna un bool true o false en caso que exista o no la cadena a buscar
            Console.WriteLine(midato);
            if (midato)
            {
                Console.WriteLine("existe la cadena");
            }
            else
            {
                Console.WriteLine("no existe");
            }

            //**************************************************************************
            //uso de Substring(inicio,fin); recibe 2 enteros como parametros

            String cadena4 = "prueba de buscar cadena";
            string resultado = cadena4.Substring(0,6);
            Console.WriteLine($"el substring obtenido es:->  {resultado}");

            //---------------------------------------------------------
            //uso del metodo EndsWith() y StartWidth()
            Console.WriteLine("->uso del metodo EndsWith()");
            String cadena5 = "prueba de buscar cadena";
            bool resultado2 = cadena5.EndsWith("na");
            Console.WriteLine($"el resultado obtenido es:->  {resultado2}");
            if (resultado2) {
                Console.WriteLine("existe");

             }else{
                Console.WriteLine("no existe");
             }
            Console.WriteLine("->uso del metodo  StartWidth()");
            
            String cadena6 = "prueba de buscar cadenas";
            bool resultado3 = cadena6.StartsWith("p");
            Console.WriteLine($"el resultado obtenido es:->  {resultado3}");

            string validacion = (resultado3) ? "exise" : "no existe";//validamos usando el operador ternario si la cadena inicio o no con la subcadena buscada
            Console.WriteLine(validacion);
            //***************************************************

            //Uso del metodo CopyTo()
            Console.WriteLine("Uso del metodo CopyTo()");
            //declaramos un array de tipo char
            char[] destino = new char[30];
            //cadena a evaluar
            String saludo = "Estoy haciendo el curso de c#";
            //declaracion de instruccion que ejecutara la copia
            saludo.CopyTo(10,destino,0,12);
            //mostrar el resultado
            Console.WriteLine(destino);
            //------------------------------------------------------
            string cadenaPrueba = "Prueba de conocimiento de CopyTo";
            int tamagno = cadenaPrueba.Length;//se puede obtener el tamaño de la cadena a copiar y asi hacer mas dinamico el codigo al momento de copiar una cadena especifica.
            char[] destinoCopia = new char[tamagno];//inicializamos el array con la longitud de la cadena a copiar y asi garantizar que el array tenga el tamaño correcto

            cadenaPrueba.CopyTo(0,destinoCopia,0,6);
            //Descripción de los parametros del metodo CopyTo()
            /*
                primer parametro: 0 = indice del caracter de la cadenaPrueba donde iniciara la copia
                segundo parametro: destinoCopia = array donde se guardara la copia realizada
                tercer parametro: 0 = posicion del array donde iniciara a guardar
                cuarto parametro: 6 = cantidad de caracteres a copiar, en este caso se copiaran 6 iniciando desde la posicion 0 como lo indica en primer parametro de este ejemplo

             */

            Console.WriteLine(destinoCopia);//mostramos la copia.
            String nuevaCadena = new String(destinoCopia);//esta declaracion recibe el array y lo transforma a un String
            Console.WriteLine(nuevaCadena);
            //*****************************************************************
            // Uso de metodo Insert(indice donde se agregara la nueva cadena, cadena a agregar)
            string cadenaResultante = cadenaPrueba.Insert(10,"Hola Mundo ");//de esta forma insertamos una cadena en otra, este metodo retorna el valor que es la nueva cadena y se debe almacenar en una otra variable
            Console.WriteLine(cadenaResultante);

            //**************************************************************
            // Uso de metodo LastIndexOf()
            string cadenaEjemplo = "Prueba de conocimiento de CopyTo";

            int i = 0;

            i = cadenaEjemplo.LastIndexOf("Copy");

            Console.WriteLine(i);
            //------------------------------------------
            /*
             Justificación del texto:

                Los metodos PadLeft(cantidad de caracteres) y PadRigth(cantidad de caracteres)
             */
            string cadenaEjemplo1 = "Prueba";

            string res1 = cadenaEjemplo1.PadLeft(40);
            string res2 = cadenaEjemplo1.PadRight(20);
            Console.WriteLine("Usando PadLeft");            
            Console.WriteLine(res1);
            Console.WriteLine("Usando PadRight");
            Console.WriteLine(res2);
            //------------------------------------------
            //Eliminar caracteres de la cadena
            string cadenaEjemplo2 = "Prueba de eliminación";
            string r = cadenaEjemplo2.Remove(0,6);
            Console.WriteLine("Resultado de eliminación");
            Console.WriteLine(r);
            //------------------------------------------
            //Reemplazar una cadena
            string cadenaEjemplo3 = "Prueba de Reemplazar";
            Console.WriteLine("cadena antes de reemplazar");
            Console.WriteLine("->"+cadenaEjemplo3);
            string r3 = cadenaEjemplo3.Replace("Prueba","Ejemplo");
            Console.WriteLine("Resultado despues reemplazar");
            Console.WriteLine("->"+r3);
            

















            Console.ReadKey();







        }
    }
}

/*
Cadenas:

Si necesitamos guardar cualquier información de tipo alfanumerica las podemos utilizar. Tambien son utilizadas para guardar nombres, direcciones, otros.

para poder utilizar cadenas necesitamos hacer uso de la clase String., que nos da todo lo necesario para poder trabajar con ellas

en su interior la cadena se guarda como una coleccion y cada caracter es un elemento

permiten procesar y almacenar información escrita

declaracion:

String miCadena = "Hola Mundo";

String dato = "";

diferencia entre declarar una variable y una Cadena

la variable se declara con la palabra reserva string en minusculas ejemplo string variable = "hola";

la cadena se declara con la palabra reservada String con la S en mayuscula, lo cual hace referencia a la clase. ejemplo: String cadena = "Hola Mundo";
-----------------------------------------

* el metodo ToString();

este metodo es usado para convertir el tipo de dato a su representación en una cadena y es muy util cuando necesitamos desplegar esa información para que el usuario la pueda leer.

el metodo siempre regresara una cadena, que puede ser formateada para nuestras necesidades.

* convertir y formatear fechas a cadenas

    Para utilizar la fecha y la hora, lo haremos mediante una clase conocida como DateTime. Si deseamos tener un Objeto de este tipo y que tenga la hora actual de lamaquina en el momento en que se instanció podemos hacerlo de la siguiente manera:

        ejemplo:
                    DateTime miTiempo = DateTime.Now;

-------------------------------------------------------------------
* darles formato a valores númericos:
    
    #   digito
    .   punto decimal
    ,   separador de miles
    %   porcentaje
    EO  Notacion cientifica
    ;   separador de secciones
--------------------------------------------------------------------
* concatenar cadenas:

    si deseamos llevar a cabo la concatenación por medio del operador + podemos hacer de la siguiente manera:

        String nombre = "Alex";
        String Apellido = "Lopez";

        String nombreCompleto = "";
        nombreCompleto = nombre + " " + apellido;


------------------------------------------------------------
* comparacion de cadenas: método Compare(cadena1,cadena2):

este metodo es estático, por lo que podemos hacer uso de éste sin necesidad de declarar un objeto de tipo String.

necesidad de dos parámetros(cadena1,cadena2), que son las cadenas a comparar.

el metodo regresara o retornara un valor entero

resultado       significado

= 0             cadena1 = cadena 2 son iguales

< 0             cadena1 < cadena2

> 0             cadena1 > cadena2
---------------------------------------------------------------------
* Encontrar una subcadena:

el metodo que usaremos se llama Contains() y debe ser invocado por la cadena a la que se le realizara la busqueda.

el metodo Contains() solo necesita un parametro. Este parametro es la subcadena a buscar. Esta puede ser dada explicitamente o por medio de una variable de tipo String que la contenga

el metodo regresa un bool. Si la subcadena se encontro, el valor regresado es true y si no se encontro el valor regresado es false.

este metodo distingue entre mayusculas y minusculas

----------------------------------------------------------------------
* Obtener una subcadena:

usando el metodo Substring() --> sustraer informacion(subcadena) de un string

Necesita dos parametros, que son valores de tipo entero:
    el primero indica el indice adentro de la cadena original donde inicia la subcadena que nos interesa obtener y el segundo es la cantidad de caracteres que tiene la subcadena.

    el metodo regresa una cadena que contiene a la subcadena que hemos obtenido.
---------------------------------------------------------------------

Determinar si una cadena finaliza en una subcadena:

usamos el metodo EndsWith();

necesita un parametro, que sera la subcadena que deseamos verificar en la terminacion de la cadena principal

la funcion regresa un valor de tipo bool, si es true la cadena termina en la subcadena en caso contrario el valor regresado es de false

-----------------------------------------------------------------------
* copiar una parte de la cadena

usamos el metodo CopyTo(indice de la cadena donde iniciara a copiar,arraydestino donde se almacenaran,indice array donde se copiaran,cantidad de caracteres a copiar)
Se necesitan 4 parametros
1.- el primer parametro es el indice dentro de la cadena principal desde donde se empesara a copiar

2.- el segundo parametro es la cadena de tipo char donde se colocara la cadena a extraer - array donde se guardara

3.- el tercer parametro es el indice del arreglo a partir de donde se empezaran a colocar los caracteres de la cadena copiada.

4.- el cuarto parametro indica la cantidad de caracteres a copiar

el metodo no retorna nigun valor

---------------------------------------------------------------------------------------
Insertar una cadena:

usamos el metodo Insert(). Este método coloca la cadena dentro de la cadena principal.

Este tambien necesitara dos parametros. El primero indicara el indice dentro de la cadena principal donde se va a insertar la nueva cadena. Este valor debe ser de tipo entero y nunca podemos pasarle un valor negativo. El segundo parámetro es la cadena que deseamos insertar, que puede ser colocada explicitamente o mediante una variable de tipo String.

el metodo Insert() regresa un valor de tipo String. Este valor regresado sería la instancia de la nueva cadena que ya contiene la inserción

------------------------------------------------------------------------------------

Encontrar la posición de una subcadena:

Usando el metodo LastIndexOf("cadena a buscar"):

Regresa el indice de la ultima posición encontrada

Si la cadena principal tiene dos repeticiones de esa cadena, nos da el indice de la segunda repetición

Necesita un parametro y es la subcadena a encontrar

el metodo regresa un valor de tipo entero que contiene el indice de la ultima ocurrencia de la subcadena

Retorna -1 si la cadena no existe
---------------------------------------------------------------------------------------------------
Justificación del texto:

Los metodos PadLeft(cantidad de caracteres) y PadRigth(cantidad de caracteres), justifican la cadena

Requiere de un parametro que es la cantidad de caracteres de la cadena final. Este es un valor entero y representa los caracteres originales mas los espacios en blanco

Regresa la cadena final justificada

-----------------------------------------------------------------------------------
Eliminar caracteres de la cadena:

el metodo Remove(indice donde iniciara a eliminar,cant de caracteres a eliminar) permite borrar cierta cantidad de carcateres

Necesita dos parametros, ambos de valores enteros. El primer parámetro se usa para indicar el indice a partir del cual se empezarán a eliminar los caracteres de la cadena, y en el segundo parametro colocamos la cantidad de caracteres a eliminar.

El metodo regresa una cadena, que es la cadena resultante de la eliminación.

----------------------------------------------------------------------------------
Reemplazar una subcadena:

Usamos el metodo Replace("cadena anterior","cadena nueva");

Existen dos versiones del metodo Replace(), una de ellas funciona con caracteres y la que aprenderemos hace uso de cadenas

permitir reemplazar una palabra en particular contenida dentro de la cadena por otra palabra

necesita dos parametros, el primero es la cadena que simboliza la palabra que deseamos reemplazar, el segundo es la cadena con la que reemplazaremos.

el metodo regresa una cadena, que es la resultante con los reemplazos ya llevados a cabo
----------------------------------------------------------------------------------------
Itercambiar mayusculas y minusculas

para convertir la cadena a minusculas se debe usar el metodo ToLower();

Para convertir la cadena a mayusculas se debe usar el metodo ToUpper()

Estos Metodos no necesitan ningun parametro. La fuente de información para la conversion es la misma cadena que lo invoca

los metodos regresan un valor, el valor que se devuelve será la cadena convertida totalmente a letras minusculas

----------------------------------------------------------
Podar la cadena: Cuado una cadena tiene exceso de espacios hacemos uso del metodo Trim()

no necesita ningun parametro, trabaja sobre la cadena que lo invoca

regresa una cadena nueva, que es la cadena original sin los espacios extras

es importante tener en cuenta que la cadena original no se modifica, por esta razon se recibe una cadena completamente nueva

tambien se pueden usar TrimStar() para eliminar los espacios al inicio de la cadena, y TrimEnd() para eliminar los espacios al final








 
 
 
 
 */
