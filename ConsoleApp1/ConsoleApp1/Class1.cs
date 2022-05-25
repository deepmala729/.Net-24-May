using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Weekdays
    {
        static void Main3(string[] args)
        {

            Console.Write("enter some value");
            int choice;



            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Hi, I am a default case.");
                    break;

            }
            Console.ReadLine();



        }





    }
}
