using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Square : Rhombus
    {
        public Square(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
            if (!IsSquare())
                throw new ArgumentException("Точки не образуют квадрат.");
        }

        private bool IsSquare()
        {
            double[] angles = CalculateAngles();
            return angles.All(angle => Math.Abs(angle - 90) < 0.001);
        }

        public override double CalculateArea()
        {
            double side = Distance(VERTICES[0], VERTICES[1]);
            return side * side;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
