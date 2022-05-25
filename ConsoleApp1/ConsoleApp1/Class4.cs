using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TriangleStar
    {
        static void Main5()
        {
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



    }
}
