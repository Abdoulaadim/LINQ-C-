using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 2, 8, 5};

            Console.WriteLine();
            Console.WriteLine("////////////////////count//////////////////////");
            var count = numbers.Count();
            Console.WriteLine(count);
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("////////////////////Sum//////////////////////");
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("////////////////////AVG//////////////////////");
            var AVG = numbers.Average();
            Console.WriteLine(AVG);
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
