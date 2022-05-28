using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    //public
    //protected
    //internal
    //private
    //protected internal


    //A class is a UDT that is composed of field data(member variables) and methods(member functions)
    //that act on this data

    /*<class> <name-of class>{}
     * 
     */
    

    class employee
    {
        public string Name;
        public int ID;
        public string Gender;
        public decimal salary;
    }

    class Class5
    {
        static void Main(string[] args)
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
