using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260331
{
    internal class Window
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;


        public int id;


        public Window(int x1, int y1, int x2, int y2, int id)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.id = id;
        }

        public bool IsPointInWindow(int x, int y)
        {
            return x >= x1 && x <= x2 && y >= y1 && y <= y2;
        }

        public override string ToString()
        {
            return $"Window {id}: ({x1}, {y1}), ({x2}, {y2})";
        }
    }
}
