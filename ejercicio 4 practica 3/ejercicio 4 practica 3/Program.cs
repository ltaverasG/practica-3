using System;
/*Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
se lo avisará al usuario y pedirá un segundo número, para decir a continuación
si este segundo número también es múltiplo de 10.*/
namespace ejercicio_4_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES    
            int numero_1 = 0;
            int numero_2 = 0;
            
            //MANDATO PARA USUARIO 
            Console.WriteLine("INGRESE UN NUMERO ENTERO:");
            // ingresamos los valores en las variables.
            numero_1 = Convert.ToInt32(Console.ReadLine());
            
            // condiciones 
            if (numero_1 % 10 == 0)
            {
                Console.WriteLine("El numero:" + numero_1 + " es multiplo de 10.");
                // hacemos que pida el otro numero si es multiplo
                Console.WriteLine("INGRESE UN NUMERO ENTERO:");
                numero_2 = Convert.ToInt32(Console.ReadLine());
                if (numero_2 % 10 == 0)
                {
                    Console.WriteLine("El numero:" + numero_2 + " es multiplo de 10.");
                }
                else
                {
                    Console.WriteLine("El numero: " + numero_1 + " no es multiplo de 10.");
                }


            }

            else
            {
                Console.WriteLine("El numero: " + numero_1 + " no es multiplo de 10.");
            }


          
        }
    }
}
