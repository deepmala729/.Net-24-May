using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Secondnumber
    {
        static void Main8(string[] args)
        {
            int n, i, j = 0, largest, secondLargest;
            int[] arr1 = new int[50];

            Console.Write("\n\nFind the second highest element in an array :\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            largest = 0;

            for (i = 0; i < n; i++)
            {
                if (largest < arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }

            secondLargest = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    continue;

                }
                else
                {
                    if (secondLargest < arr1[i])
                    {
                        secondLargest = arr1[i];
                    }
                }
            }

            Console.Write("The Second  highest number in the array is :  {0} \n\n", secondLargest);

            Console.ReadKey();
        }


    }
}
