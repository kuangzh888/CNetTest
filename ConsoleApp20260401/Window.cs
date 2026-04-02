using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260401
{
    internal class Window
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public int number;

        public Window(int x1, int y1, int x2, int y2, int number)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.number = number;
        }

        public override string? ToString()
        {
                return $"Window {number}: ({x1}, {y1}), ({x2}, {y2})";
        }

        public bool IsPointInWindow(int x, int y)
        {
            return x >= this.x1 && y >= this.y1 && x <= x2 && y <= y2;
        }
    }
}
