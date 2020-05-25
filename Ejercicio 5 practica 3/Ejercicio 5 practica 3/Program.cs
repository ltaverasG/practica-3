using System;
/*Crear un programa que multiplique dos números enteros de la siguiente forma:
pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
escribirá en pantalla &quot;El producto de 0 por cualquier número es 0&quot;. Si se ha
tecleado un número distinto de cero, se pedirá al usuario un segundo número y
se mostrará el producto de ambos.*/
namespace Ejercicio_5_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {// VARIABLES  
            int numero_1 = 0;
            int numero_2 = 0;
            

            Console.WriteLine("INGRESE UN NUMERO ENTERO:");

            // almacenamos datos en la primera variable
            numero_1 = Convert.ToInt32(Console.ReadLine());
            //condiciones 
            if (numero_1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0.");
            }
            else
            {
                Console.WriteLine("INGRESE UN NUMERO ENTERO");
                numero_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("EL PRODUCTO DE LOS NUMEROS ES:"+ (numero_1 * numero_2));

            }
        }
    }
}
