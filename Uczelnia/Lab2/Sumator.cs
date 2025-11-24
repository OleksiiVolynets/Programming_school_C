using System;
using System.Collections.Specialized;

namespace Project
{

    class Sumator
    {
       private int[] Liczby;
    public Sumator(int[] values)
        {
            Liczby=values;
        }
       public void Suma()
        {
            int sum=0;
            foreach(int num in Liczby)
            {
                sum += num;
            }
            Console.WriteLine("Suma liczb: " + sum);
        }
        public void SumaPodziel2()
        {
            double sum=0;
            foreach(int num in Liczby)
            {
                sum += num;

            }
            sum=sum/2;
            Console.WriteLine("Suma liczb podzielona przez 2: " + sum);
        }
        public int IleLiczb()
        {
            return Liczby.Length;
        }
        public void WyswietlLiczby()
        {
            Console.Write("Liczby w tablicy: ");
            foreach(int num in Liczby)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public void Index(int low, int high)
        {
            
            Console.Write("Liczby od indeksu " + low + " do " + high + ": ");
            for(int i=low; i<=high; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
        }

    }
}