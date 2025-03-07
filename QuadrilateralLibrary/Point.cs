using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) //Это конструктор с координатами вершин четырёхугольника
        {
            X = x;
            Y = y;
        }
    }
}
