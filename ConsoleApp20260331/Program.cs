using ShapeLib;
using System.Runtime.CompilerServices;

namespace ConsoleApp20260331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point point1 = new Point(1, 1);
            //Circle circle = new Circle(point1, 1);
            ////Console.WriteLine(point1);
            //Console.WriteLine(circle);
            //Random random = new Random();
            //const int NUM = 1000000;
            //double count = 0;
            //for (int i = 0; i < NUM; i++)
            //{
            //    double x = random.NextDouble() * 2;
            //    double y = random.NextDouble() * 2;

            //    Point tmp = new Point(x, y);

            //    if (circle.IsPointInCircle(tmp))
            //    {
            //        count++;
            //    }
            //}
            //double result = count * 4 / NUM;
            //Console.WriteLine(result);

            Point point1 = new Point(1, 1);
            Circle circle = new Circle(point1, 1);
            Console.WriteLine(circle);
            double distance = circle.MonteCarloPi();
            Console.WriteLine(distance);
        }
    }
}
