using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abdoulaadim", "Youssef", "Rachid", "Kabira", "Hind", "Yassine", "Laila" };

            //var firstElement = names.First();
            var firstElement = names.First(a => a.StartsWith("H"));
            //var firstElement = names.FirstOrDefault(a => a.StartsWith("T")); // return null

            Console.WriteLine("////////////////firstElement///////////////////");
            Console.WriteLine();
            Console.WriteLine(firstElement);
            Console.WriteLine();


            var lastElement = names.Last();
            //var lastElement = names.Last(a => a.StartsWith("Y"));
            //var lastElement = names.LastOrDefault(a => a.StartsWith("T"));


            Console.WriteLine("////////////////LastElement///////////////////");
            Console.WriteLine();
            Console.WriteLine(lastElement);
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
