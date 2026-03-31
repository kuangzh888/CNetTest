using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260331
{
    internal class StringDemo
    {

        static void Main(string[] args)
        {
            //string msg = "hello world hello kitty";
            //string info = msg.Replace("hello", "nihao");
            //Console.WriteLine(info);
            //Console.WriteLine(msg.Contains("world"));
            //// 
            //int index = msg.IndexOf("world");
            //Console.WriteLine(index);

            //string subStr = msg.Substring(5);
            //Console.WriteLine(subStr);

            //char[] chars = msg.ToCharArray();


            //RevealPattern();
            RingDunceBell();
        }


        static void RevealPattern()
        {
            string daan = "hello";

            char[] daans = daan.ToCharArray();
            char[] results = new char[daan.Length];
            for (int i = 0; i < daan.Length; i++)
            {
                results[i] = '-';
            }

            int cishu = 5;


            while (true)
            {
                char input = Console.ReadLine().ToCharArray()[0];
                bool find = false;

                for (int i = 0; i < daans.Length; i++)
                {
                    if (daans[i] == input)
                    {
                        results[i] = daans[i];
                        find = true;
                    }
                }

                if (find)
                {
                    if (!results.Contains('-'))
                    {
                        Console.WriteLine("胜利");
                        break;
                    }
                    printResult(results);
                }
                else
                {
                    printResult(results);
                    if (cishu <= 4)
                    {
                        Console.Write($"答错了，剩余{cishu}次");
                        Console.Write("\n");

                        if (cishu == 0)
                        {
                            Console.WriteLine("失败了");
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("答错了");
                        Console.Write("\n");
                    }

                    cishu--;
                }
            }

            static void printResult(char[] results)
            {
                Console.Write("\n");
                foreach (char c in results)
                {
                    Console.Write(c);
                }
                Console.Write("\n");
            }
        }



        static void RingDunceBell()
        {
            int count = int.Parse(Console.ReadLine());
            string[] inputs = new string[count];
            for (int i = 0; i < count; i++)
            {
                inputs[i] = Console.ReadLine();
            }







            for (int i = 0; i < inputs.Length; i++)
            {
                string input = inputs[i];

                
                bool hasCong = false;

                string[] strings = input.Split(' ');


                for (int j = 0; j < strings.Length; j++)
                {
                    Console.WriteLine($"{strings[j]}");
                }

                Console.WriteLine($"1:{(input.Contains(',') && input.Contains("cong"))} 2:{(input.Contains('.') && input.Contains("cong"))}");
                if ((input.Contains(',') && input.Contains("cong")) &&
                    (input.Contains('.') && input.Contains("cong"))
                    )
                {
                    hasCong = true;
                }






                string temp = input.Substring(0, input.Length - 1);
                

                string[] stringArray = temp.Split(' ');

                //Console.WriteLine(strings.Last());
                string last = stringArray.Last();

                if (hasCong)
                {
                    for (int j = stringArray.Length - 1; j > stringArray.Length - 4; j--) {
                        Console.WriteLine($"{stringArray[j]}");
                    }

                } else
                {
                    Console.WriteLine("Skipped");
                }

            }



        }

       

    }
}
