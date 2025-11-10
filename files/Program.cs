﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
namespace Project
{

    class Program
    {
        static void Main()
        {
            //Робота з рядками
            string str1 = "Hello, ";
            //str1 += "World!";
            str1 = String.Concat(str1, "World!");



            char[] symbols = { 'H', 'e', 'l', 'l', 'o' };

            Console.WriteLine(str1.Length);
            Console.WriteLine(str1[0]);
            Console.WriteLine(String.Compare(str1, "llo"));


            // practic
            string people = "Ivan, Petr, Maria, Olga";
            string[] names = people.Split(',');
            // foreach(string el in names)
            // {
            //     Console.WriteLine(el);
            // }
            people = String.Join(" | ", names);
            Console.WriteLine(people);
            Console.WriteLine(people.ToLower());
            Console.WriteLine(people.ToUpper());
            Console.WriteLine(people.Substring(10));

            //Робота з файлами
            // Console.WriteLine("Enter text ");
            // string text=Console.ReadLine();
            // using (FileStream stream=new FileStream("info.txt", FileMode.OpenOrCreate))
            // {
            //     byte[] array = System.Text.Encoding.Default.GetBytes(text);
            //     stream.Write(array);
            // }
            using (FileStream stream2 = File.OpenRead("info.txt"))
            {
                byte[] array2 = new byte[stream2.Length];
                stream2.Read(array2);

                string textFromFile = System.Text.Encoding.Default.GetString(array2);
                Console.WriteLine(textFromFile);
            }
        }
    }

}