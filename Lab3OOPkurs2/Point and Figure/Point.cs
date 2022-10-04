using System;
using System.Collections.Generic;
using System.Text;

namespace Point_and_Figure
{
    internal class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _name;
        public int X => _x;
        public int Y => _y;
        public string Name => _name;

        public Point(int x, int y, string name)
        {
            this._x = x;
            this._y = y;
            this._name = name;
        }
    }
}
