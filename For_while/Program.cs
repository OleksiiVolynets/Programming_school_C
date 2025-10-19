using System;
using System.Globalization;
using System.Reflection.Metadata;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //For and while
            //  for (byte i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("For Loop Iteration: " + i);
            // }
            // int i = 1;
            // while (i<10)
            // {
            //     Console.WriteLine("While Loop Iteration: " + i);
            //     i++;
            // }
            // bool condition = true;
            // while (condition)
            // {
            //     Console.WriteLine("Type 'exit' to terminate the loop:");
            //     string user = Console.ReadLine();
            //     if (user == "exit")
            //     {
            //         condition = false;
            //     }
            // }
            // int i = 0;
            // do
            // {
            //     Console.WriteLine("Do-While Loop Iteration: " + i);
            //     i++;
            // } while (i > 10);
            for(int i = 5; i < 15; i++)
            {
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine("For Loop Iteration: " + i);
            }
        }
    }

}