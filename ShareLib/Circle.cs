namespace ShapeLib
{
    public class Circle
    {

        public Point Center;
        public double Radius;

        // [ (x - a)^2 + (y - b)^2 < r^2 ]
        public Circle(Point center, double redius)
        {
            Center = center;
            Radius = redius;
        }


        public override string? ToString()
        {
            return $"center:{this.Center.ToString()} redius:{this.Radius}";
        }

        public bool IsPointInCircle(Point center)
        {
            return this.Center.GetDistance(center) <= this.Radius;
        }

        public double MonteCarloPi(int totalPoints = 100000000)
        {
            double count = 0;
            Random rand = new Random();
            for (int i = 0; i < totalPoints; i++)
            {
                double x = rand.NextDouble() * 2;
                double y = rand.NextDouble() * 2;
                // 判断点是否在圆内
                if (this.IsPointInCircle(new Point(x, y)))
                {
                    count++;
                }
            }
            return 4.0 * count / totalPoints;
        }
    }
}
