using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class employee
    {
        public string Name;
        public int ID;
        public string Gender;
        public decimal salary;
    }

    class Class5
    {
        static void Main6(string[] args)
        {
            

            //<class-name> <object-name>=new <class-Name>()

            employee e = new employee();
            e.Name = "Deepmala";
            e.ID = 101;
            e.Gender= "female";
            e.salary = 25000;

            Console.WriteLine("Employee Details are");
            Console.WriteLine(e.Name);
            Console.WriteLine(e.ID);
            Console.WriteLine(e.Gender);
            Console.WriteLine(e.salary);
        }
    }
}
