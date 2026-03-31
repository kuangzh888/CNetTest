using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260330
{
    internal class MethodDemo
    {

        static double MyPow(double x, int y)
        {
            double result = 1;
            if (y != 0)
            {
                result = x;
                for (int i = 1; i < Math.Abs(y); i++)
                {
                    result *= x;
                }

                if (y < 0)
                {
                    result = 1 / (result);
                }
            }
            return result;
        }

        static int MyMax(params int[] arr)
        {

            return 0;
        }


        static void Main(string[] args)
        {
            //double x = 2;
            //int y = -3;
            //double result1 = MyPow(x, y);
            //double result2 = Math.Pow(x, y);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(MyMax(11, 13, 14));

            //Point point1 = new Point(1, 1);
            //Point point2 = new Point(10, 30);
            //Console.WriteLine(point1.GetDistance(point2));
            //Circle circle = new Circle(point1, 1);
            //Point point3 = new Point(0.5, 0.5);
            //Console.WriteLine($"{circle.IsPointInCircle(point3)}");

            //Random random = new Random();
            ////Console.WriteLine(random.Next(20));
            //Console.WriteLine(random.NextDouble() * 2);

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(random.NextDouble()*2);
            //}


            Point point1 = new Point(1, 1);
            Circle circle = new Circle(point1, 1);

            //Console.WriteLine(point1);
            Console.WriteLine(circle);


            double distance = circle.MonteCarloPi();
            Console.WriteLine(distance.ToString());
        }
    }
}
