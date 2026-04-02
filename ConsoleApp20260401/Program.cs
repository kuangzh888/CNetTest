using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp20260401
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list[2] = 100;
            //list.RemoveAt(1);
            //list.Add(4);
            //Console.WriteLine(list[2]);
            //list.Sort();
            //list.Reverse();

            //// 不保存重复
            //HashSet<string> set = new HashSet<string>();
            ////intSet.Add(12);

            ////Console.WriteLine(guid);
            //for (int i = 0; i < 10000000; i++)
            //{
            //    Guid guid = Guid.NewGuid();
            //    set.Add(guid.ToString());
            //}
            //Console.WriteLine(set.Count);



            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict.Add("Alice", 20);
            //dict.Add("Bob", 25);
            //dict.Add("Charlie", 30);

            //dict["Alice"] = 101;
            //dict["Green"] = 13;

            //bool bob = dict.ContainsKey("Bob");
            //bool value = dict.ContainsValue(13);

            //Console.WriteLine($"Bob is in the dictionary: {bob}");
            //Console.WriteLine($"Value 13 is in the dictionary: {value}");

            //foreach (KeyValuePair<string, int> kvp in dict)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}

            test();
        }


        

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
            for (int i = 0; i < windows.Length; i++)
            {
                int[] temp = Array.ConvertAll(windows[i].Split(' '), int.Parse);
                Window window = new Window(x1: temp[0], y1: temp[1], x2: temp[2], y2: temp[3], i + 1);
                windowList.Add(window);
            }


            for (int i = 0; i < clicks.Length; i++)
            {
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
