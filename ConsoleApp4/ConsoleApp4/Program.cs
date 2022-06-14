

using ConsoleApp4.Models;
using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Id");
            Console.WriteLine("Please enter your name");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            SampleDBContext db = new SampleDBContext();
            Tblsample tblsample = new Tblsample();
             tblsample.Id = id;
            tblsample.Text = name;
             db.Tblsamples.Add(tblsample);
             db.SaveChanges();

            //How we can show the values
            var data = db.Tblsamples;

            Console.WriteLine("Values from database ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }

            //How we can delete the value
            /*Console.WriteLine("Pleae enter id of your name which you want to delete");
            int DeleteItem = Convert.ToInt32(Console.ReadLine());
            var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
            db.Tblsamples.Remove(DeleteObject);
            db.SaveChanges();*/

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id + " | " + item.Text);
            //}

            //How we can Update the value

           /* Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Text = newName;
            db.Tblsamples.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
               Console.WriteLine(item.Id + " | " + item.Text);
            }*/



        }
    }
}