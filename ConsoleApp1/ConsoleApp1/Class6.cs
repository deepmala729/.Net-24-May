using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Leftarrowstar
    {
        static void Main7(string[] args)
        {
            for (int row = 5; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int row = 1; row <= 5; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

}

