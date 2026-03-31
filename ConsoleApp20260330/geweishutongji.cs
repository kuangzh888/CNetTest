using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp20260330
{
    internal class geweishutongji
    {
        static void Main(string[] args)
        {
            // 100311
            //string numText = Console.ReadLine();
            string numText = "100311";
            char[] nums = numText.ToCharArray();
            
            //List<int> temps = new List<int>();
            //List<int> results = new List<int>();

            int[] temps = new int[10];
            //int[] results = new int[10];

            foreach (char c in nums)
            {
                int n = c + '0';
                temps[n]++;
            }

            Console.WriteLine(string.Join("", temps));



            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int c = nums[i] - '0';
            //    bool find = temps.Contains(c);

            //    if (find)
            //    {
            //        int index = temps.IndexOf(c);
            //        index++;
            //        //results.Insert(index, c);
            //    }
            //    else
            //    {
            //        temps.Add(c);
            //        results.Add(1);
            //    }
            //}

            //for (int i = 0; i < temps.Count; i++)
            //{
            //    Console.WriteLine($"{temps[i]}:{results[i]}");
            //}

        }
    }
}
