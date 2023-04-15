using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
           {
               "Red","BOOK","Car","Computer","Mobile","Program","Driver","Window","Key","Home","Remote","Cami"
           };

            //Non Query syntax   &&  lambda expression
            

            var Result =  Names.Where(item => item.Contains("C")).Take(2);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
