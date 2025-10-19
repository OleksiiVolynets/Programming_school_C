using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //Arrays
            // int[] numbres = new int[7];
            // numbres[0] = 9;
            // numbres[1] = 91;
            // numbres[2] = 37;
            // numbres[3] = 82;
            // numbres[4] = 12;
            // numbres[5] = 65;

            // numbres[4] += 9;
            // Console.WriteLine(numbres[4]);

            // string[] names = { "Ana", "Juan", "Pedro", "Maria" };
            // names[0] = "Alex";
            // Console.WriteLine(names[0]);

            // for (int i = 0; i < names.Length; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }

            // sum of elements
            int[] numbers = new int[10];
            int suma = 0;
            Random random= new Random();
            for (byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10);
                Console.WriteLine(numbers[i]);
                suma += numbers[i];


            }
            Console.WriteLine("Suma parcial: " + suma);
            //багатовимірні масиви
            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'a';
            symbols[0, 1] = 'b';
            symbols[0, 2] = 'c';
            symbols[1, 0] = 'd';
            symbols[1, 1] = 'e';
            symbols[1, 2] = 'f';
        }
    }

}