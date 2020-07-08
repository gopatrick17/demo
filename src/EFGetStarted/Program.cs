using System;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();
                
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                

                Console.WriteLine("Enter a new blog: ");
                var test = Console.ReadLine();
                db.Add(new Blog { Url = $"{test}" });

                db.SaveChanges();
            }
        }
    }
}