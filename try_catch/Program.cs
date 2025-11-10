﻿using System;

namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //Try catch
            // try
            // {
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(num);
            // }
            // catch(FormatException)
            // {
            //     Console.WriteLine("You entered not a number");
            // }
            bool IsRunn = true;
            while (IsRunn)
            {
                try
                {
                    Console.WriteLine("Enter a number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    float rezult = 100 / num;
                    Console.WriteLine(rezult);
                    IsRunn = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered not a number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You can't divide by zero");
                }
                finally
                {
                    Console.WriteLine("End of iteration");
                }
            }    
        }
    }

}