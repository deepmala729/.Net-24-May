﻿using System;

namespace ConsoleApp3
{
    //abstract

    //abstract class cannot have an object.
    //abstarct class can be extendend by any derived class
    //it can have constructor and destructors
    //it cannot sipport multiple inheritance
    //it cannot be static
    abstract class Sample
    {
        public abstract void print();
    }

    class Sample2 : Sample
    {
        public override void print()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}