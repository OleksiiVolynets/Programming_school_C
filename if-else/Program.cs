﻿using System;
using System.Globalization;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //Умовні коеструкції
            // Console.WriteLine("How old are you:");
            // double a = Convert.ToDouble(Console.ReadLine());
            // bool drink = true;
            // // &&-and ||-or !-not 
            // if (a < 18 && drink)
            // {

            //     Console.WriteLine("Go away, drink some milk");

            //     Console.WriteLine("You are teenager");
            // }
            // else
            // {
            //     Console.WriteLine("You are adult");
            // }

            Console.WriteLine("What's your name:");
            string role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.WriteLine("Username:");
            }
        }
    }

}
