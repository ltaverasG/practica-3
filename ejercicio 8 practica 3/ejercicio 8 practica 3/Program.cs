using System;
/*Crear un programa que pida al usuario dos números enteros y diga "Uno de los
números es positivo", "Los dos números son positivos o bien "Ninguno de los
números es positivo", según corresponda.*/

namespace ejercicio_8_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {//VARIABLES
            int numero_1 = 0;
            int numero_2 = 0;
            //encabezado
            Console.WriteLine("INGRESE DOS NUMEROS ENTEROS");
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());
            //condiciones
            if (numero_1 > 0 )
           
            {
               

                if (numero_2 > 0)
                {
                    Console.WriteLine("LOS DOS NUMEROS SON POSITIVOS ");
                }
                else
                {
                    Console.WriteLine(" UNO DE LOS NUMEROS ES POSITIVO");
                }
               
            }
            else if (numero_1 < 0)
            {
                
                if ( numero_2 < 0)
                {
                    Console.WriteLine(" LOS DOS NUMEROS SON NEGATIVOS ");
                }
                else
                {
                    Console.WriteLine(" UNO DE LOS NUMEROS ES POSITIVO");
                }
            }
            
            Console.ReadKey();
        }
    }
}
