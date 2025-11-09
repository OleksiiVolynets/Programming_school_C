using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Collections.Generic;
namespace Project
{

    class Program
    {
        static void Main()
        {
            // foreach
            // short[,] nums = { 
            //     { 1, 2, 3 },
            //     { 4, 5, 6 }};
            // foreach (short el in nums)
            // {
            //     Console.WriteLine(el);
            // }

            //Колекції
            List<int> numbers = new List<int>() { 6, 9, 4, 6, 1 };
            numbers.Add(19);
            numbers.Remove(9);
            numbers.Sort();
            numbers.Reverse();
            numbers[0] = 7;
            foreach(int el in numbers)
            {
                Console.WriteLine(el);
            }
        }

    }
}
