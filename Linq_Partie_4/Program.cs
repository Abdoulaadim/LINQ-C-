using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_4
{
    internal class Program
    {
        class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }

            public string Author { get; set; }
        }
        static void Main(string[] args)
        {
                Book[] books = { new Book()   { Id = 6 , Author ="Abdoulaadim" , Title = "C#" },
                                 new Book()   { Id = 7 , Author ="Yahya" , Title = "Java" },
                                 new Book()   { Id = 4 , Author ="jabrane" , Title = "Dotnet" }
                               };

                // Query syntax

                var list  = from item
                            in books 
                            orderby item.Id descending
                            select item;

            foreach (Book item in list)
            {
                Console.WriteLine("Id= {0} , Title = {1}, Author= {2}", item.Id, item.Title, item.Author);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________Non query __________________________________________");
            Console.WriteLine();
            //Non query Syntax  / fluent syntax 


            var items  = books.OrderByDescending(item => item.Id);


            foreach (Book item in items)
            {
                Console.WriteLine("Id= {0} , Title = {1}, Author= {2}", item.Id, item.Title, item.Author);
            }



            Console.ReadLine();
        }
    }
}
