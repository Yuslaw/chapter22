using System;
using System.Linq;

namespace question5
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

            var ans = students.OrderByDescending(x => x.FirstNmae).ThenByDescending(x => x.LastName);
           //using query
            // var query = from stu.FirstNmae descending, stu.LastName descending select stu;
            foreach(var item in ans)
            {
                 Console.WriteLine($"{item.FirstNmae} {item.LastName}");
            }


        }
    }
}
