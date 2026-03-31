using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class dajiangyou
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int count = 0;

            while (money > 0)
            {
                if (money - 50 >= 0)
                {
                    money -= 50;
                    count += 7;
                }
                else if (money - 30 >= 0)
                {
                    money -= 30;
                    count += 4;
                }
                else
                {
                    money -= 10;
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
