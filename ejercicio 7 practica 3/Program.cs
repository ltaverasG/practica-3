using System;
/* Crear un programa que pida al usuario un número entero y diga si es múltiplo
de 4 o de 5.*/
namespace ejercicio_7_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int numero = 0;
            //encabezado
            Console.WriteLine("INGRESE UN NUMERO ENTERO:");
            //INGRESAMOS DATOS A LA VARIABLE
            numero = Convert.ToInt32(Console.ReadLine());
            //condiciones 
            if (numero % 4 == 0)
            {
                Console.WriteLine(numero + " es multiplo de 4.");
            }
            else if (numero % 5 == 0)
            {
                Console.WriteLine(numero + " es multiplo de 5.");
            }

        }
    }
}
