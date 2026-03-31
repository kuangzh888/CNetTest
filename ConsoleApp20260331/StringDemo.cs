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


        // 5
        // xun zhang zhai ju lao diao chong, xiao yue dang lian gua yu gong.
        // tian sheng wo cai bi you yong, qian jin san jin huan fu lai.
        // xue zhui rou zhi leng wei rong, an xiao chen jing shu wei long.
        // zuo ye xing chen zuo ye feng, hua lou xi pan gui tang dong.
        // ren xian gui hua luo, ye jing chun shan kong. 
        static void RingDunceBell()
        {
            int count = int.Parse(Console.ReadLine());
            string[] inputs = new string[count];
            for (int i = 0; i < count; i++)
            {
                inputs[i] = Console.ReadLine();
            }
            Console.WriteLine("输入完成，正在处理数据...\n");
            for (int i = 0; i < inputs.Length; i++)
            {
                string input = inputs[i];
                bool hasCong1 = false;
                bool hasCong2 = false;
                string[] strings = input.Split(' ');
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[j].Contains(',') && strings[j].Contains("ong"))
                    {
                        hasCong1 = true;
                    }
                    if (strings[j].Contains('.') && strings[j].Contains("ong"))
                    {
                        hasCong2 = true;
                    }
                }
                if (hasCong1 && hasCong2)
                {
                    for (int j = strings.Length - 1; j > strings.Length - 4; j--)
                    {
                        // Console.Write($"{strings[j]} ");
                        if (j == strings.Length - 1)
                        {
                            strings[j] = "zhong.";
                        } else if (j == strings.Length - 2)
                        {
                            strings[j] = "ben";
                        } else if (j == strings.Length - 3)
                        {
                            strings[j] = "qiao";
                        }
                    }
                    Console.WriteLine(string.Join(" ", strings));
                } else
                {
                    Console.WriteLine("Skipped");
                }
            }
        }
    }
}
