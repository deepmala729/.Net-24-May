using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    
        class Voteage
        {
            public static void Main2()
            {
                int age;
                Console.Write("\n\n");


                Console.Write("Input the age of the candidate : ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    Console.Write(" not eligible to your vote.\n");

                }
                else if (age >= 60)
                {
                    Console.Write("senior citizen\n\n");
                }
                else
                {
                    Console.Write("eligible for vote\n\n");
                }

            }

        

    }
}
