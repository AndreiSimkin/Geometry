using System;
using Geometry.Figures;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(26, 24, 10);
            Console.WriteLine("Площадь: " + triangle.GetArea());
            Console.WriteLine("Прямоугольный: " + (triangle.IsRight ? "Да" : "Нет"));
        }
    }
}
