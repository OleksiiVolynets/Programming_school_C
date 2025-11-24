﻿using System;
using System.Collections.Specialized;

namespace Project
{

    class Program
    {
        static void Main()
        {
            //OOП
            // Robot bot = new Robot("Botty", 150, new byte[] { 0, 0, 0 });
            // bot.Weight=5;
            // Console.WriteLine(bot.Weight);
            // Robot killer = new Robot("Killer", 200, new byte[] { 10, 0, 5 });
            // Robot robot = new Robot("Alex");

            ////Robot.count = 10;
            // Robot.Print();

            //get set
            // Robot bot1=new Robot();
            // bot1.Weight=5;
            // Console.WriteLine(bot1.Weight);
            // bot1.Width=50;
            // Console.WriteLine(bot1.Width);

            MyDate d = new MyDate(10, 2, 2024);

            Console.WriteLine("Поточна дата: " + d.GetDate());
            d.NextWeek();
            Console.WriteLine("Через тиждень: " + d.GetDate());
            d.PreviousWeek();
            d.PreviousWeek();
            Console.WriteLine("Два тижні назад: " + d.GetDate());
    }
}
}

