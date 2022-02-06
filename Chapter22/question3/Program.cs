using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new []
            {
                new {FirstNmae = "Ola", LastName = "Olu", Age = 27},
                new {FirstNmae = "Ade", LastName = "Sam", Age = 17},
                new {FirstNmae = "Tobi", LastName = "mola", Age = 20},
                new {FirstNmae = "Sola", LastName = "demola", Age = 19},
                new {FirstNmae = "Dami", LastName = "solape", Age = 21},
               
              
            };
            var ct = from student in students where student.FirstNmae.CompareTo(student.LastName)<0 select student;
            foreach(var item in ct)
            {
                Console.WriteLine($"{item.FirstNmae} {item.LastName}");
            } 
        }
    }
}
