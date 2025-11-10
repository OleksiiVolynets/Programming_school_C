﻿using System;
using System.Collections.Specialized;

namespace Project
{

    class Program
    {
        static void Main()
        {
            //OOП
            Robot bot = new Robot("Botty", 150, new byte[] { 0, 0, 0 });

            Robot killer = new Robot("Killer", 200, new byte[] { 10, 0, 5 });
            Robot robot = new Robot("Alex");

            //Robot.count = 10;
            Robot.Print();
        }
    }
}


