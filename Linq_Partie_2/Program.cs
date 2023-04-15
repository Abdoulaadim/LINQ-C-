using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
           {
               "Red","BOOK","Car","Computer","Mobile","Program","Driver","Window","Key","Home","Remote"
           };

            //Query Syntax

            var result  =  from item in Names where item.StartsWith("C") && item.Length==3 select item;

            foreach (var items in result)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
