using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = { "Abdoulaadim", "Hamid", "Laila", "Kabira" };
            string[] group2 = { "Hind", "Abdoulaadim", "Kabira", "Yassir" };


            //concat
            var concatGroup = group1.Concat(group2);

            foreach (var group in concatGroup)
            {
                Console.WriteLine(group);
            }

            Console.WriteLine("//////////////////////////////");
            Console.WriteLine();

            // Distinct 
            var concatGroup1 = group1.Concat(group2).Distinct();

            foreach (var group in concatGroup1)
            {
                Console.WriteLine(group);
            }

            Console.WriteLine("//////////////////////////////");
            Console.WriteLine();

            // Union 
            var concatGroup2 = group1.Union(group2);

            foreach (var group in concatGroup2)
            {
                Console.WriteLine(group);
            }

            Console.ReadKey();

            Console.ReadKey();



        }
    }
}
