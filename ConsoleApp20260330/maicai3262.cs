using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp20260330
{
    internal class maicai3262
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            Console.WriteLine($"num：{length}");
            Console.WriteLine(string.Join(" ", arr));

            /*
             * 8
                4 1 3 1 6 5 17 9
             */

            int[] results = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int currentI = arr[i];
                if (i == 0)
                {
                    results[i] = ((currentI - 1) + currentI) / 2;
                }
                else if (arr.Length == i + 1)
                {
                    results[i] = ((currentI + 1) + currentI) / 2;
                }
                else
                {
                    results[i] = ((currentI - 1) + currentI + (currentI + 1)) / 3;
                }

            }


            Console.WriteLine("results=" + string.Join(" ", results));


        }
    }
}
