using System;
using System.Globalization;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //Математичні дії
            // Console.WriteLine("Enter 1 number");
            // float a = float.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // float b = float.Parse(Console.ReadLine());
            // float result = a + b;
            // double res = result + 8f;
            // Console.WriteLine("The result is " + result);
            Console.WriteLine("The result is " + Math.PI);
            //Площа кола
            Console.WriteLine("Enter radius");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("The area of the circle is " + area);
        }
    }

}
