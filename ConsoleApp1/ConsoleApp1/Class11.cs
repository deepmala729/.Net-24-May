﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Uniqueelement
    {
        static void Main(string[] args)
        {

            int[] ar = new int[5] { 1, 2, 2, 3, 3 };
            int counter = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < i - 1; j++)
                {
                    //Increment the counter when the search value is duplicate
                    if (ar[i] == ar[j])
                    {
                        counter++;
                    }
                }

                for (int k = i + 1; k < ar.Length; k++)
                {
                    if (ar[i] == ar[k])
                    {
                        counter++;
                    }
                    if (ar[i] == ar[i + 1])
                    {
                        i++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine(ar[i]);
                }
            }
        }


    }
}

