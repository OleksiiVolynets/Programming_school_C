﻿using System;
using System.Collections.Specialized;
using System.Collections.Generic;
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

            // MyDate d = new MyDate(10, 2, 2024);

            // Console.WriteLine("Поточна дата: " + d.GetDate());
            // d.NextWeek();
            // Console.WriteLine("Через тиждень: " + d.GetDate());
            // d.PreviousWeek();
            // d.PreviousWeek();
            // Console.WriteLine("Два тижні назад: " + d.GetDate());


            //Наслідування класів
            // Robot bot1=new Robot("Bot1");
            // Killer killer =new Killer("KillerX",250,new byte[]{5,10,15},100);
            // Killer killer1=null;
            // killer.Laser();



            //Масиви об'єктів
            //1 спосіб
            // Robot[] robots=new Robot[]
            // {
            //  bot1,killer,new Robot()
            // };

            //2 спосіб
            // List<Robot> robots=new List<Robot>();
            // robots.Add(bot1);
            // robots.Add(killer);
            // robots.Add(new Robot("Alex"));

            // foreach(Robot r in robots)
            // {
            //     if(r.Name=="KillerX")
            //     {
            //         killer1=r as Killer;
            //         killer1.Laser();
            //     }
            //     Console.WriteLine(r is Killer);
            // }

            //віртуальні методи
            Killer killer2=new Killer("KillerX",250,new byte[]{0,3,5},100);
            killer2.printValues();


    }
}
}

