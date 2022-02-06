using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public static class Question1
    {
        public static StringBuilder Substring(this StringBuilder ext, int index, int length)
        {
            StringBuilder dj = new StringBuilder();
            string outcome = ext.ToString();
            outcome = outcome.Substring(index, length);

            return dj.Append(outcome);
        }
        
    }
}