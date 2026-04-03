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


//namespace ConsoleApp20260402
//{
//    static internal class StringExtension
//    {
//        public static int WordCount(this string info)
//        {
//            return info.Split(" ").Length;
//        }
//    }
//}
