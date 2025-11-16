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
            //for each
            // short[,] numbers ={ {10, 12, 31} , {44, 56, 78} };
            // foreach (short number in numbers)
            // {
            //     Console.WriteLine(number);
            List<int> nums=new List<int>{12, 73,23,45,67};
            nums.Add(99);
            nums.Add(100);
            nums.Add(101);
            nums.Remove(23);
            nums.Sort();
            nums.Reverse();
            foreach(int n in nums)
            {
            Console.WriteLine(n);
            }

        }
        //колекції
        

        
    }}

