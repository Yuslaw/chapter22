using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace question6
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 21};

           //query method
           var output = from num in list where(num%3==0)&& (num%7==0) select num;
            foreach(var item in output)
            {
                 Console.WriteLine(item);
            }

            // lambda
            // var out = list.Where(x=> (x%3==0)&& (x%7==0));
            
        }
    }
}
