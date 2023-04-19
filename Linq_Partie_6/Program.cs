using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_6
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
            Book[] books = { new Book()   { Id = 1 , Author ="Abdoulaadim" , Title = "C#" },
                             new Book()   { Id = 2 , Author ="Yahya" , Title = "Java" },
                             new Book()   { Id = 3 , Author ="jabrane" , Title = "Dotnet" },
                             new Book()   { Id = 4 , Author ="kabira" , Title = "android" },
                             new Book()   { Id = 5 , Author ="Morad" , Title = "ReactJS" },
                             new Book()   { Id = 6 , Author ="kabira" , Title = "Angular" },
                             new Book()   { Id = 7 , Author ="kabira" , Title = "VueJS" },
                             new Book()   { Id = 8 , Author ="ghita" , Title = "CSS" }
                            };

            // Query syntax

            var list = from item
                       in books
                       group item by item.Author;

            foreach (var item in list)
            {
                Console.WriteLine();
                Console.WriteLine("Author : " + item.Key);
                Console.WriteLine("___________________________//////////////////___________________________________________");
                foreach (var book in item)
                {
                    Console.WriteLine();
                    Console.WriteLine("Id= {0} \n Title = {1} \n Author= {2}", book.Id, book.Title, book.Author);
                    Console.WriteLine("................................................................................");
                }

            }
            Console.WriteLine();
            Console.WriteLine("_________________________Non query __________________________________________");
            Console.WriteLine();
            //Non query Syntax  / fluent syntax 


            var List = books.GroupBy(item => item.Author);

            foreach (var item in list)
            {
                Console.WriteLine();
                Console.WriteLine("Author : " + item.Key);
                Console.WriteLine("___________________________//////////////////___________________________________________");
                foreach (var book in item)
                {
                    Console.WriteLine();
                    Console.WriteLine("Id= {0} \n Title = {1} \n Author= {2}", book.Id, book.Title, book.Author);
                    Console.WriteLine("................................................................................");
                }

            }


            Console.ReadLine();
        }
    }
}

