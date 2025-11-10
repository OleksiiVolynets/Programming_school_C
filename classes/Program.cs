﻿using System;
using System.Collections.Specialized;

namespace Project
{

    class Program
    {
        static void Main()
        {
            //OOП
            Robot bot = new Robot();
            bot.setValues("Botty", 150, new byte[] { 0, 0, 0 });

            bot.printValues();

            Robot killer = new Robot();
            killer.setValues("Killer", 200, new byte[] { 10, 0, 5 });

            killer.printValues();
        }
    }
}


