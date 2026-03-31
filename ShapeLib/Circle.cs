namespace ShapeLib
{
    public class Circle
    {

        Point Center;
        double Radius;

        // [ (x - a)^2 + (y - b)^2 < r^2 ]
        Circle(Point center, double redius)
        {
            Center = center;
            Radius = redius;
        }


        public override string? ToString()
        {
            return $"center:{this.Center.ToString()} redius:{this.Radius}";
        }

        bool IsPointInCircle(Point center)
        {
            return this.Center.GetDistance(center) <= this.Radius;
        }

        public double MonteCarloPi(int totalPoints = 100000000)
        {
            int insideCircle = 0;
            Random rand = new Random();
            for (int i = 0; i < totalPoints; i++)
            {
                // 在以 Center 为圆心，Radius 为半径的正方形内随机投点
                double x = Center._x + (rand.NextDouble() * 2 - 1) * Radius;
                double y = Center._y + (rand.NextDouble() * 2 - 1) * Radius;
                // 判断点是否在圆内
                if ((x - Center._x) * (x - Center._x) +
                    (y - Center._y) * (y - Center._y) <= Radius * Radius)
                {
                    insideCircle++;
                }
            }
            return 4.0 * insideCircle / totalPoints;
        }
    }
}
