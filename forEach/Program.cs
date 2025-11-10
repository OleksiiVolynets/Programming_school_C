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
            //function
            Print("Some");
            string words = "Some info";
            Print(words);

        }
        public static void Print(string word )
        {
            Console.WriteLine(word);
        }
    }
}
