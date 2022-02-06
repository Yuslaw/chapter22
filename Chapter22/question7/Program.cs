using System;
using System.Threading;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo t = new CultureInfo("en-US", false).TextInfo;
            
            string result = string.Join(" ", "this iS a Sample sentence".Split(' ').Select(word=> t.ToTitleCase(word)).ToArray());
            Console.WriteLine(result);
            
            
        }
    }
}
