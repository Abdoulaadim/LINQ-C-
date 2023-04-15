using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
           {
               "Red","BOOK","Car","Computer","Mobile","Program","Driver","Window","Key","Home"
           };
            

            //List<string> Result = new List<string>();
            //for (int i = 0; i < Names.Count; i++)
            //{
            //    if(Names[i].Length > 3)
            //    {
            //        Result.Add(Names[i]);
            //    }
            //}



            //Query Syntax
            //var Result = from item in Names where item.Length > 3 select item;

            // -- Non-Query Syntax 
            var Result  = Names.Where(itme => itme.Length > 3).ToList();


            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
