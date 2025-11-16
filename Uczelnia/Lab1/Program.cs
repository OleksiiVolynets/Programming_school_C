using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace Project
{
    
    class Program
    {
        static void Main()
        {
            //zad 1
            // Console.WriteLine("Enter a for quadratic equation");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter b for quadratic equation");
            // double b = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter c for quadratic equation");
            // double c = Convert.ToDouble(Console.ReadLine());
            // double delta = Math.Pow(b, 2) - 4 * a * c;
            
            // if (delta < 0   )
            // {
            //     Console.WriteLine("The equation has no real roots.");
            // }
            // else if (delta == 0)
            // {
            //     double x = -b / (2 * a);
            //     Console.WriteLine("The equation has one real root: x = " + x);
            // }
            // else
            // {
            //     double sqdelta = Math.Sqrt(delta);
            //     double x1 = (-b - sqdelta) / (2 * a);
            //     double x2 = (-b + sqdelta) / (2 * a);
            //     Console.WriteLine("Roots of the equation are: x1 = " + x1 + " and x2 = " + x2);
            // }
            //zad 2
            // bool isRunning = true;
            // while (isRunning){
            // Console.WriteLine("Enter 1 number");
            // double f = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter 2 number");
            // double h = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Now: What do you want to do?");
            // Console.WriteLine("Enter 1 for Addition");
            // Console.WriteLine("Enter 2 for Subtraction");
            // Console.WriteLine("Enter 3 for Multiplication");
            // Console.WriteLine("Enter 4 for Division");
            // Console.WriteLine("Enter 5 to raise the first number to the power of the second number");
            // Console.WriteLine("Enter 6 to calculate trigonometric functions");
            // Console.WriteLine("Enter 7 to stop calculator");
            
            // int choice = Convert.ToInt32(Console.ReadLine());
            //     switch (choice)
            //     {
            //         case 1:
            //             Console.WriteLine("Result: " + (f + h));
            //             break;
            //         case 2:
            //             Console.WriteLine("Result: " + (f - h));
            //             break;
            //         case 3:
            //             Console.WriteLine("Result: " + (f * h));
            //             break;
            //         case 4:
            //             if (h != 0)
            //             {
            //                 Console.WriteLine("Result: " + (f / h));
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Error: Division by zero is not allowed.");
            //             }
            //             break;
            //         case 5:
            //             Console.WriteLine("Result: " + Math.Pow(f, h));
            //             break;
            //         case 6:
            //             Console.WriteLine("Enter function (sin, cos, tan):");
            //             string func = Console.ReadLine();
            //             Console.WriteLine("Enter angle in degrees:");
            //             double angle = Convert.ToDouble(Console.ReadLine());
            //             switch (func)
            //             {
            //                 case "sin":
            //                     Console.WriteLine("Result: " + Math.Sin(angle * (Math.PI / 180)));
            //                     break;
            //                 case "cos":
            //                     Console.WriteLine("Result: " + Math.Cos(angle * (Math.PI / 180)));
            //                     break;
            //                 case "tan":
            //                     Console.WriteLine("Result: " + Math.Tan(angle * (Math.PI / 180)));
            //                     break;
            //                 default:
            //                     Console.WriteLine("Invalid function choice.");
            //                     break;
            //             }
            //             break;
            //         case 7:
            //             isRunning = false;
            //             break;
            //         default:
            //             Console.WriteLine("Invalid choice.");
            //             break;
            //     }
            // }

            //zad 3

            // int[] nums=new int[10];
            // for (int i=0;i<10;i++)
            // {
            //     Console.WriteLine("Enter"+i+"number:");
            //     int l=Convert.ToInt32(Console.ReadLine());
            //     nums[i]=l;

            // }
            // int option;
            // do{ 
            //     Console.WriteLine("What do you want to dispaly?");
            //     Console.WriteLine("1-Numbers in normal order");
            //     Console.WriteLine("2-Numbers in reverse order");
            //     Console.WriteLine("3-Numbers with even index");
            //     Console.WriteLine("4-Numbers with odd index");
            //     Console.WriteLine("5-Exit");
            //     option=Convert.ToInt32(Console.ReadLine());
            // if(option==1)
            // {    
            // foreach (int num in nums)
            // {
                
            //         Console.WriteLine("Numbers in normal order: " + num);
            //     } } 
            // else if(option==2)  {
            // for(int i=9;i>=0;i--)
            // {
            //     Console.WriteLine("Numbers in reverse order: " + nums[i]);
            // }}
            // else if(option==3)  {
            // for(int i=0;i<10;i+=2)
            // {
            //     Console.WriteLine("Numbers with even index: " + nums[i]);
            // }}
            // else if(option==4)  {
            // for(int i=1;i<10;i+=2)
            // {
            //     Console.WriteLine("Numbers with odd index: " + nums[i]);
            // }   }}
            // while(option!=5);

            //zad 4

            // int[] array={34, 12, 5, 67, 23, 89, 2, 45, 78, 11};
            // int sum=0;
            // int product=1;
            // int max=array[0];
            // int min=array[0];
            // foreach(int num in array)
            // {
            //     sum+=num;
            //     product*=num;
            //     if(num>max)
            //     {
            //         max=num;
            //     }
            //     if(num<min)
            //     {
            //         min=num;
            // }}
            // int average=sum/array.Length;
            // Console.WriteLine("Sum "+sum);
            // Console.WriteLine("Product "+product);
            // Console.WriteLine("Max "+max);
            // Console.WriteLine("Min "+min);
            // Console.WriteLine("Average "+average);
            //zad5

            // int[] arr2= {2,6,9,15,19};
            // for(int i=0;i<21;i++)
            // {
            //     if(arr2.Contains(i))
            //     {
            //       continue;  
            //     }
            //     Console.WriteLine(i);
            // }

            //zad6
            // while(true)
            // {
            //     Console.WriteLine("Enter an integer number");
            //     int number=Convert.ToInt32(Console.ReadLine());
            //     if (number < 0)
            //     {
            //         Console.WriteLine("Negative number entered. Exiting the program.");
            //         break;
            //     }
            // }

            //zad7
            int n=Convert.ToInt32(Console.ReadLine());
            int[] nums=new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter"+i+"number:");
                int l=Convert.ToInt32(Console.ReadLine());
                nums[i]=l;

            }
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if(nums[j]>nums[j+1])
                    {
                        int temp=nums[j];
                        nums[j]=nums[j+1];
                        nums[j+1]=temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach(int num in nums)
            {
                Console.Write(num+" ");
            }
            
        

    
    }}

}
