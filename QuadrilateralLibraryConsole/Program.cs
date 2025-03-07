using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrilateralLibrary;

namespace QuadrilateralLibraryConsole
{
    class Program
    {
        static void Main()
        {
            ConvexQuadrilateral[] shapes =
            {
            new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2)),
            new Rhombus(new Point(0, 0), new Point(2, 0), new Point(3, Math.Sqrt(3)), new Point(1, Math.Sqrt(3))),
            new Parallelogram(new Point(0, 0), new Point(4, 0), new Point(5, 3), new Point(1, 3))
        };

            foreach (var shape in shapes)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine($"Тип фигуры: {shape.GetType().Name}\n");

                Console.WriteLine("Координаты вершин:");
                foreach (var point in shape.VERTICES)
                    Console.WriteLine($"({point.X}, {point.Y})");

                Console.WriteLine("\nДлины сторон: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateSideLengths(), x => $"{x:F2}")));

                Console.WriteLine("Углы: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateAngles(), x => $"{x:F1}°")));

                Console.WriteLine("Диагонали: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateDiagonals(), x => $"{x:F2}")));

                Console.WriteLine($"Периметр: {shape.CalculatePerimeter():F2}");
                Console.WriteLine($"Площадь: {shape.CalculateArea():F2}\n");
            }

            var square1 = new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
            var square2 = new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
            var rhombus = new Rhombus(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Проверка метода Equals:");
            Console.WriteLine($"square1 == square2: {square1.Equals(square2)}");
            Console.WriteLine($"square1 == rhombus: {square1.Equals(rhombus)}");
            Console.ReadKey();
        }
    }
}
