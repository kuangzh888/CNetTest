using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260330
{
    internal class xianglinshudui
    {
        static void Main(string[] args)
        {
            /*
             * 6
               10 2 6 3 7 8
             */ 
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine($"num：{num}");
            Console.WriteLine(string.Join(" ", arr));
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 >= arr.Length)
                {
                    break;
                }
                if (arr[i] + 1 == arr[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine($"count = {count}");
        }
    }
}
