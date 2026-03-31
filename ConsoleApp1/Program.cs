using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.Write("Please input text");

            //string name = Console.ReadLine();

            //Console.WriteLine($"Helle ");


            //int age = 90;
            //double p1 = 2.32;
            //decimal p2 = 3.33;
            //char c = 'A';
            //bool flag = true;

            //string msg = "hello";
            //Console.WriteLine(msg);

            //string name = "John";
            //int age = 32;
            //Console.WriteLine($"My name is {name} and I am {age} years old.");
            //string msg = $"name {name} age {age}";
            //Console.WriteLine(msg);

            //string num = "909";
            //int x = int.Parse(num);
            //Console.WriteLine(x + 1);

            //char c = '3';
            //int x = c - '1';
            //Console.WriteLine(x);



            //int source = 23;

            //while (source > 0)
            //{
            //    source--;
            //    Console.WriteLine(source);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            // 
            //int number = 153;
            //Console.WriteLine(number / 100);
            //Console.WriteLine(number / 10 % 10);
            //Console.WriteLine(number % 10);


            //Console.WriteLine(Math.Pow(5, 3));


            //for (int i = 100; i < 1000; i++)
            //{
            //    int a = i / 100;
            //    int b = i / 10 % 10;
            //    int c = i % 10;

            //    //int sum = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

            //    if (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3) == i)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            ///*
            // * 酱油 10 块钱一瓶，商家进行促销，每买 3 瓶送 1 瓶，或者每买 5 瓶送 2 瓶。
            //*/

            //// 20
            //int money = int.Parse(Console.ReadLine());

            //int count = 0;
            //while (money > 0)
            //{
            //    if (money >= 50)
            //    {
            //        money -= 50;
            //        count += 7;
            //    }
            //    else if (money >= 30)
            //    {
            //        money -= 30;
            //        count += 4;
            //    }
            //    else
            //    {
            //        money -= 10;
            //        count += 1;
            //    }
            //}

            //Console.WriteLine($"totalBottles:{count}");


            //int input = int.Parse(Console.ReadLine());

            //int j = 0;
            //int y = 0;
            //int b = 0;
            //int d = 0;

            //int i = 0;
            //while (i < input)
            //{
            //    if (i % 7 == 0 || i.ToString().Contains("7"))
            //    {
            //        if (i % 4 == 1)
            //        {
            //            j++;
            //        }
            //        if (i % 4 == 2)
            //        {
            //            y++;
            //        }
            //        if (i % 4 == 3)
            //        {
            //            b++;
            //        }
            //        if (i % 4 == 0)
            //        {
            //            d++;
            //        }
            //    }
            //    i++;
            //}

            //Console.WriteLine($"j:{j}, y:{y}, b:{b}, d:{d}");





            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            int count = 0;
            foreach (char item in charArray)
            {
                int i = (int)item - '0';
                Console.WriteLine(i);
                count += i;
            }

            Console.WriteLine(count);
        }

    }
}
