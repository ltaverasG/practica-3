using System;
/*Crear un programa que pida al usuario tres números reales y muestre cuál es el
mayor de los tres.*/

namespace Ejercicio_9_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE TRES NUMEROS:");
            // VARIABLES 
            int numero_1 = 0;
            int numero_2 = 0;
            int numero_3 = 0;
            // INTRODUCIMOS DATOS A LAS VARIABLES 
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());
            numero_3 = Convert.ToInt32(Console.ReadLine());
            //condiciones 
            if (numero_1 > numero_2)
            {
                if (numero_1 > numero_3)
                {
                    Console.WriteLine("el " + numero_1  + " es el mayor de los tres");
                }
            }

            else if (numero_2 > numero_1)
            {
                if (numero_2 > numero_3)
                {
                    Console.WriteLine("el " + numero_2  +  " es el mayor de los tres");
                }
            }

            if (numero_3 > numero_1)
                {
                    if (numero_3 > numero_2)
                    {
                        Console.WriteLine("el " + numero_3 + " es el mayor de los tres");
                    }
                }
            
            Console.ReadKey();// no es necesario.
        }
    }
}
