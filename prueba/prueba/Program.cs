using System;

class Prueba
{
    static void Main()
    {
        Console.WriteLine("do while");
        int z = 10;
        do
        {
            Console.WriteLine("Hola {0}", z);
            z++;
        } while (z < 10);
        Console.WriteLine("while");
        while (z < 10)
        {
            Console.WriteLine("Hola");
            z++;
        }
        Console.WriteLine("Fin");

    }
}