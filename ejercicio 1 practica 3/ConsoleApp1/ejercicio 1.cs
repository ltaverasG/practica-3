using System;
//Crear un programa que pida al usuario un número entero y diga si es par.
namespace practica
{
    class numero_Par
    {
        static void Main(string[] args)
        {
            int numero = 0 ;
            int divisor;
            int i = 0;
            Console.WriteLine("INGRESE UN NUMERO ENTERO:");
            i = Convert.ToInt32(Console.ReadLine());
            numero = i + numero;
            divisor = numero % 2;
            if (divisor == 0  )
            {
                Console.WriteLine("EL NUMERO QUE INGRESO ES PAR.");
            }


           
        }
    }
}
