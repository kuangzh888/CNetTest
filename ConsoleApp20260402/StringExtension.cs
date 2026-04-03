using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp20260402
{
    static internal class StringExtension
    {
        public static int WordCount(this string info)
        {
            return info.Split(" ").Length;
        }
    }
}
