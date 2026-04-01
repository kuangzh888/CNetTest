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
            //RingDunceBell();
            test();
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


        /*
         * 
在某图形操作系统中，有 N
 个窗口，每个窗口都是一个两边与坐标轴分别平行的矩形区域。

窗口的边界上的点也属于该窗口。

窗口之间有层次的区别，在多于一个窗口重叠的区域里，只会显示位于顶层的窗口里的内容。

当你点击屏幕上一个点的时候，你就选择了处于被点击位置的最顶层窗口，并且这个窗口就会被移到所有窗口的最顶层，而剩余的窗口的层次顺序不变。

如果你点击的位置不属于任何窗口，则系统会忽略你这次点击。

现在我们希望你写一个程序模拟点击窗口的过程。
         */
        static void test()
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int windowCount = int.Parse(inputs[0]);
            int clickCount = int.Parse(inputs[1]);


            


            string[] windows = new string[windowCount];
            for (int i = 0; i < windowCount; i++)
            {
                windows[i] = Console.ReadLine();
            }

            string[] clicks = new string[clickCount];
            for (int i = 0; i < clickCount; i++)
            {
                clicks[i] = Console.ReadLine();
            }
            //Console.WriteLine(" ");
            //Console.WriteLine(input);
            //Console.WriteLine(string.Join("，", windows));
            //Console.WriteLine(string.Join("，", clicks));

            List<Window> windowList = new List<Window>();
            for (int i = 0;i < windows.Length; i++)
            {
                int[] temp = Array.ConvertAll(windows[i].Split(' '), int.Parse);
                Window window = new Window(x1: temp[0], y1: temp[1], x2: temp[2], y2: temp[3], i + 1);
                windowList.Add(window);
            }


            for (int i = 0; i < clicks.Length; i++) {
                int[] temp = Array.ConvertAll(clicks[i].Split(' '), int.Parse);
                bool find = false;

                //Console.WriteLine("windowList.Count" + windowList.Count);

                for (int j = windowList.Count - 1; j >= 0; j--)
                {
                    Window tWindow = windowList[j];


                    //Console.WriteLine(tWindow + " " + temp[0] + " " + temp[1] + " j=" + j);


                    if (tWindow.IsPointInWindow(temp[0], temp[1]))
                    {
                        windowList.RemoveAt(j);
                        windowList.Add(tWindow);

                        
                        Console.WriteLine(tWindow.id);
                        find = true;
                        break;
                    }
                }

                if (!find)
                {
                    Console.WriteLine("IGNORED");
                }

            }

        }
    }
}
