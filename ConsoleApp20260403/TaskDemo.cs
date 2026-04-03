using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260403
{
    internal class TaskDemo
    {


        static async Task Main(string[] args)
        {

            PrintTask();

            int a = 1;
            PrintTask();
            Console.WriteLine(a);
            PrintTask();


            PrintTask();
            int result = await Task.Run(() =>
            {
                PrintTask();
                int result = 0;
                for (int i = 0; i < 100; i++)
                {
                    result += 1;
                }
                return result;
            });


            PrintTask();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hello world!");
            }
        }


        static void PrintTask(string info = "")
        {
            Console.WriteLine(info + "线程id:" + Thread.CurrentThread.ManagedThreadId);
        }

    }
}
