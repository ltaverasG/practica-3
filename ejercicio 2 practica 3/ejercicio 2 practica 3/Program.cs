using System;
//Crear un programa que pida al usuario dos números enteros y diga cuál es el
//mayor de ellos
namespace ejercicio_2_practica_3
{
    class Program
    {
        static void Main(string[] args)
        { // variables 
            int numero_1=0;
            int numero_2=0;
            Console.WriteLine("INGRESE DOS NUMEROS:");
            //ponemos los datos en la variable
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());
            //hacemos la condicion para la comparacion y que nos diga si es mayor.
            if (numero_1 > numero_2)
            {
                Console.WriteLine(numero_1 + "es mayor que" + numero_2);
            }
            else
            {
                Console.WriteLine(numero_2 + " es mayor que " + numero_1);
            }

        }
    }
}
