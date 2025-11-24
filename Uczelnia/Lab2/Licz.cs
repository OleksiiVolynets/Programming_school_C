using System;
using System.Collections.Specialized;

namespace Project
{

    class Licz
    {
       private int value;

        public Licz(int val)
        {
            value=val;
        }
       public void Dodaj(int x)
       {
           value += x;
           Console.WriteLine("Dodano: " + x + ", nowa wartość: " + value);
       }
         public void Odejmij(int x)
         {
              value -= x;
              Console.WriteLine("Odjęto: " + x + ", nowa wartość: " + value);
         }
         public void Wyswietl()
         {
             Console.WriteLine("Aktualna wartość: " + value);
         }

    }
}
