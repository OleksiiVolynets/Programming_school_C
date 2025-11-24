using System;
using System.Collections.Specialized;

namespace Project
{

    class Program
    {
        static void Main()
        {
            // zad1

            // before I changed int vlue to private

            // Licz num=new Licz();
            // num.value=10;
            // Licz num2=new Licz();
            // num2.value=20;
            // Licz num3=new Licz();
            // num3.value=30;
            // num.Dodaj(5);
            // num2.Odejmij(10);
            // num3.Dodaj(15);

            // after I changed int value to private and added constructor
            // Licz number=new Licz(10);
            // Licz number2=new Licz(20);
            // Licz number3=new Licz(30);
            // number.Dodaj(5);
            // number2.Odejmij(10);
            // number3.Dodaj(15);
            // number.Wyswietl();
            // zad2

            // Sumator sumator1=new Sumator();
            // sumator1.Liczby=new int[]{10,20,30,40,50};
            // sumator1.Suma();
            // sumator1.SumaPodziel2();

            // Sumator sumator2=new Sumator(new int[]{10,20,30,40,50});
            // sumator2.Suma();
            // sumator2.SumaPodziel2();
            // Console.WriteLine("Ilość liczb w tablicy: " + sumator2.IleLiczb());
            // sumator2.WyswietlLiczby();
            // sumator2.Index(1,3);

            MyDate d = new MyDate(10, 2, 2024);

            Console.WriteLine("Current date: " + d.GetDate());
            d.NextWeek();
            Console.WriteLine("In one week: " + d.GetDate());
            d.PreviousWeek();
            d.PreviousWeek();
            Console.WriteLine("Two weeks ago: " + d.GetDate());
        }
    }
}
