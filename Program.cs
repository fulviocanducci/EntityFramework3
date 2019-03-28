using System;
using System.Linq;
using Models;
namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                /*People p = new People 
                {
                    Name = "Fúlvio"
                };
                Book b = new Book 
                {
                    Title = "A Pantera Cor de Rosa"
                };

                db.People.Add(p);
                db.Book.Add(b);

                System.Console.WriteLine(db.SaveChanges());*/

                foreach(var p in db.People.ToList())
                {
                    System.Console.WriteLine("{0:000} {1} {2}", p.Id, p.Name, p.Active);
                }
                System.Console.WriteLine("------------------------");
                foreach(var p in db.Book.ToList())
                {
                    System.Console.WriteLine("{0:000} {1} {2}", p.Id, p.Title, p.Active);
                }
            }            
        }
    }
}
