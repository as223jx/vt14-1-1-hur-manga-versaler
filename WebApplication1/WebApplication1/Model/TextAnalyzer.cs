using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    static public class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}