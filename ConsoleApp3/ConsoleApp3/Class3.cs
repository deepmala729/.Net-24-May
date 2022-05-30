using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class Calculatora
    {
        public int Number1, Number2;

        public Calculatora(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public void Print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }

        public static Calculatora operator * (Calculatora c1, Calculatora c2)
        {
            Calculatora c3 = new Calculatora(0, 0);
            c3.Number1 = c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;
            return c3;
        }
    }
    class Class3
    {
        public static void Main4()
        {
            Calculatora calculatora1 = new Calculatora(15, 20);
            Calculatora calculatora2 = new Calculatora(20, 20);
            Calculatora calculatora3 = new Calculatora(0, 0);
            calculatora3 = calculatora1 * calculatora2;
            calculatora3.Print();
        }
    }
}
