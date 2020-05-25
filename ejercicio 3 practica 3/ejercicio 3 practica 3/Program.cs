using System;
/*Crear un programa que pida al usuario dos números enteros y diga si el primero
es múltiplo del segundo*/
namespace ejercicio_3_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numero_1 = 0;
            int numero_2 = 0;


            Console.WriteLine("INGRESE DOS NUMEROS ENTEROS:");
            //INGRESAR DATOS A LAS VARIABLES
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());
            //condiciones
            if (numero_1 % numero_2 == 0)
            {
                Console.WriteLine(numero_1 + " ES MULTIPLO DE " + numero_2);
            }
            else
            {
                Console.WriteLine(numero_1 + " NO ES MULTIPLO DE" + numero_2);
            }
        }
    }
}
