﻿﻿using System;
using System.Globalization;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //Switch case
            Console.WriteLine("Enter 1 number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            
        }
    }

}
