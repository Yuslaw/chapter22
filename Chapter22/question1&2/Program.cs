using System;
using System.Text;

namespace Chapter22
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ext = new StringBuilder("Code as like a PRO");
            StringBuilder outcome = ext.Substring(10, ext.Length-10);
            Console.WriteLine(outcome.ToString());
            
        }
    }
}
