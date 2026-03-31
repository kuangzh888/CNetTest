using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260330
{
    internal class Point
    {
        // 不加修饰符的成员默认为 private
        public double _x;
        public double _y;


        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string? ToString()
        {
            return $"({this._x}, {this._y})";
        }

        public double GetDistance(Point other)
        {
            return Math.Sqrt(Math.Pow(this._x - other._x, 2) + Math.Pow(this._y - other._y, 2));
        }


    }
}
