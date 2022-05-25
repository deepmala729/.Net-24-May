using System;

namespace ConsoleApp2
{
    class Factorial
    {
      
             static void Main1(string[] args)
            {
                int i, fact = 1, number;
                Console.Write("Enter any Number: ");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);
            }
        
    }
}
