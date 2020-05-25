using System;
/*Crear un programa que pida al usuario dos números enteros. Si el segundo no
es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
entre cero";.*/
namespace ejercicio_6_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int numero_1 = 0;
            int numero_2 = 0;
            //ENCABEZADO
            Console.WriteLine("INGRESE DOS NUMEROS ENTEROS");
            //INGRESAMOS LOS DATOS EN LAS VARIABLES
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());
            //condiciones 
            if (numero_2 == 0)
            {
                Console.WriteLine("ERROR, NO SE PUEDE DIVIDIR ENTRE CERO");
            }
            Console.WriteLine("El resultado de dividir " + numero_1 + " y " + numero_2 + " es:" + (numero_1 / numero_2 ));
        }
    }
}
