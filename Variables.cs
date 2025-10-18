using System;

namespace Project
{
    
    class Variables
    {
        static void Main()
        {
            //Variaables
            int number = 10;
            number = 9;
            //Console.WriteLine("Result " + number);
            //Data types
            uint numb1 = 10;//тільки додатні
            byte num2 = 255;// від 0 до 255
            short num3 = 32560;
            //Числа з крапкою
            double num6 = 45.8f;
            Console.WriteLine(num6);
            // Інші типи
            string name = "Alex";
            char sym = '#';// один символ
            bool isHappy = false;
            //Міні програма
            int user1, user2;
            user1 = Convert.ToInt32(Console.ReadLine());
            user2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: user1 " + user1 + "user2 " + user2);

        }
    }

}