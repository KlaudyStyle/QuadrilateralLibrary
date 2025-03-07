using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Parallelogram : ConvexQuadrilateral
    {
        public Parallelogram(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
            if (!IsParallelogram())
                throw new ArgumentException("Точки не образуют параллелограмм.");
        }

        private bool IsParallelogram()
        {
            return Distance(VERTICES[0], VERTICES[1]) == Distance(VERTICES[2], VERTICES[3]) &&
                   Distance(VERTICES[1], VERTICES[2]) == Distance(VERTICES[3], VERTICES[0]);
        }

        public override double[] CalculateSideLengths()
        {
            return new double[]
            {
            Distance(VERTICES[0], VERTICES[1]),
            Distance(VERTICES[1], VERTICES[2]),
            Distance(VERTICES[2], VERTICES[3]),
            Distance(VERTICES[3], VERTICES[0])
            };
        }

        public override double[] CalculateAngles()
        {
            double angle1 = CalculateAngle(VERTICES[0], VERTICES[1], VERTICES[2]);
            double angle2 = 180 - angle1;
            return new double[] { angle1, angle2, angle1, angle2 };
        }

        public override double[] CalculateDiagonals()
        {
            return new double[]
            {
            Distance(VERTICES[0], VERTICES[2]),
            Distance(VERTICES[1], VERTICES[3])
            };
        }

        public override double CalculatePerimeter()
        {
            double ab = Distance(VERTICES[0], VERTICES[1]);
            double bc = Distance(VERTICES[1], VERTICES[2]);
            return 2 * (ab + bc);
        }

        public override double CalculateArea()
        {
            double baseLength = Distance(VERTICES[0], VERTICES[1]);
            double height = Math.Abs(VERTICES[3].Y - VERTICES[0].Y);
            return baseLength * height;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
