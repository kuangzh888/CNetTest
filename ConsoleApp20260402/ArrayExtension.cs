using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260402
{
    static internal class ArrayExtension
    {
        public static string ToStr(this string[] arr)
        {
            string result = string.Join(",", arr);
            return $"[{result}]";
        }
    }
}
