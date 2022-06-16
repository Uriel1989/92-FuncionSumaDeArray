using System;

//Crea la suma de un array.

namespace _92_SumaDeArray
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int[] array = new int[3];

            array[0] = 3;
            array[1] = 3;
            array[2] = 3;


            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            Console.WriteLine("La suma de los valores introducidos en el array es: " + suma);
        }
    }
}
