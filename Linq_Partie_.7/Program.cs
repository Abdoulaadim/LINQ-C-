using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Partie_._7
{
    internal class Program
    {
        class Teacher
        {
            public string Name { get; set; }

        }
        class Student
        {
            public string Name { get; set; }

        }
        static void Main(string[] args)
        {
            Teacher[] teachers =
            {
                new Teacher() { Name = "Abdoulaadim"},
                new Teacher() { Name = "Ahmed"},
                new Teacher() { Name = "Yahya"},
                new Teacher() { Name = "Abdelaalim"},
                new Teacher() { Name = "Niimatallah"},
                new Teacher() { Name = "Hind"},
                new Teacher() { Name = "Kabira"}

            };

            Student[] students =
            {
                new Student() { Name ="Abdoulaadim"},
                new Student() { Name ="Yahya"},
                new Student() { Name ="Reda"},
                new Student() { Name ="Imane"},
                new Student() { Name ="Ghita"},
                new Student() { Name ="Ikram"},
                new Student() { Name ="Yassmine"}
            };

            //query Syntax

            var JoinList = from teacher in teachers
                           join student in students
                           on teacher.Name equals student.Name
                           select teacher;

            Console.WriteLine("---------------");
            foreach (var element in JoinList)
            {
                Console.WriteLine("Name = " + element.Name);
            }
            Console.ReadKey();
        }
    }
}
