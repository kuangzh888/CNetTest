using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ArrayDemo
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]);

            int[] arr2 = new int[10];
            Array.Fill(arr2, 10);
            foreach (int val in arr2)
            {
                Console.Write(val + " ");
            }

        }
    }
}
