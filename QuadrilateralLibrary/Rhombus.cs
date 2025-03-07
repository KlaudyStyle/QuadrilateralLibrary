using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
            if (!IsRhombus())
                throw new ArgumentException("Точки не образуют ромб!");
        }

        private bool IsRhombus()
        {
            const double epsilon = 0.001;
            double[] sides = CalculateSideLengths();

            return Math.Abs(sides[0] - sides[1]) < epsilon &&
                   Math.Abs(sides[1] - sides[2]) < epsilon &&
                   Math.Abs(sides[2] - sides[3]) < epsilon;
        }

        public override double CalculateArea()
        {
            double[] diagonals = CalculateDiagonals();
            return (diagonals[0] * diagonals[1]) / 2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}