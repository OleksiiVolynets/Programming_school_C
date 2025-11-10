﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Collections.Generic;
namespace Project
{

    class Program
    {
        static void Main()
        {
            // function("some");
            // string words = "New some";
            // function(words);
            // int result = sum(6, 9);
            // Console.WriteLine(result);
            int[] numbers = { 1, 2, 3, 4, 5 };
            int res = elements(numbers);
            Console.WriteLine(res);
        }
        // public static void function(string word)
        // {
        //     Console.WriteLine(word);
        // }
        // public static int sum(int a,int b)
        // {

        //     int sum = a + b;
        //     return sum;
        // }
       
        public static int elements(int[] list)
        {
            int sum = 0;
            foreach (int el in list)
            {
                sum += el;
            }
            return sum;
        }
        
    }
}
