using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class ConvexQuadrilateral
    {
        public Point[] VERTICES; //Координаты вершин четырёхугольника

        public ConvexQuadrilateral(Point a, Point b, Point c, Point d)
        {
            VERTICES = new Point[] { a, b, c, d };
        }

        public virtual double[] CalculateSideLengths()
            => throw new NotImplementedException("Метод должен быть переопределен в производном классе.");

        public virtual double[] CalculateAngles()
            => throw new NotImplementedException("Метод должен быть переопределен в производном классе.");

        public virtual double[] CalculateDiagonals()
            => throw new NotImplementedException("Метод должен быть переопределен в производном классе.");

        public virtual double CalculatePerimeter()
            => throw new NotImplementedException("Метод должен быть переопределен в производном классе.");

        public virtual double CalculateArea()
            => throw new NotImplementedException("Метод должен быть переопределен в производном классе.");

        protected static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        protected static double CalculateAngle(Point a, Point b, Point c)
        {
            double baX = a.X - b.X;
            double baY = a.Y - b.Y;
            double bcX = c.X - b.X;
            double bcY = c.Y - b.Y;

            double dotProduct = baX * bcX + baY * bcY;
            double baLength = Math.Sqrt(baX * baX + baY * baY);
            double bcLength = Math.Sqrt(bcX * bcX + bcY * bcY);

            double cosTheta = dotProduct / (baLength * bcLength);
            double angleRad = Math.Acos(cosTheta);
            return angleRad * (180.0 / Math.PI);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ConvexQuadrilateral other = (ConvexQuadrilateral)obj;
            for (int i = 0; i < 4; i++)
            {
                if (VERTICES[i].X != other.VERTICES[i].X ||
                    VERTICES[i].Y != other.VERTICES[i].Y)
                    return false;
            }
            return true;
        }
    }
}