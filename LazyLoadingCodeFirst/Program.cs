using LazyLoadingCodeFirst.Context;
using LazyLoadingCodeFirst.Models;
using System;

namespace LazyLoadingCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            //using(var context=new MyDbContext())
            //{
            //    var c = new Category() { Name = "Dedective" };
            //    var book = new Book() { Name = "The Big Sleep", Price = 125, Quantity = 34 };
            //    c.Books.Add(book);

            //    context.Categories.Add(c);
            //    context.Books.Add(book);
            //    context.SaveChanges();
            //}

            using (var context = new MyDbContext())
            {
                foreach (var category in context.Categories)
                {
                    Console.WriteLine($"Category Name:{category.Name}");
                    foreach (var book in category.Books)
                    {
                        Console.WriteLine($"Book Name:{book.Name}");
                        Console.WriteLine($"Book Quantity:{book.Quantity}");
                        Console.WriteLine($"Book Price:{book.Price}");
                    }
                    Console.WriteLine("---------------");
                }
            }

        }
    }
}
