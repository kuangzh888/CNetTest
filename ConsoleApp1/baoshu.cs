using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class baoshu
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int jia = 0;
            int yi = 0;
            int bing = 0;
            int ding = 0;

            int index = 1;

            while (index < n)
            {
                if (index % 7 == 0 || index.ToString().Contains("7"))
                {
                    // 甲
                    if (index % 4 == 1)
                    {
                        jia++;
                    }
                    // 乙
                    else if (index % 4 == 2)
                    {
                        yi++;
                    }
                    // 丙
                    else if (index % 4 == 3)
                    {
                        bing++;
                    }
                    // 丁
                    else if (index % 4 == 0)
                    {
                        ding++;
                    }
                    n++;
                }

                index++;
            }

            Console.WriteLine($"jia:{jia} yi:{yi} bing:{bing} ding:{ding}");
        }
    }
}
