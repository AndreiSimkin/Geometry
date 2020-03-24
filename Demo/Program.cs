using System;
using Geometry.Figures;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник со сторонами 10, 24, 26: ");
            Triangle triangle1 = new Triangle(10, 24, 26);
            Console.WriteLine("Площадь: " + triangle1.GetArea());
            //Output: 120
            Console.WriteLine("Прямоугольный: " + (triangle1.IsRight ? "Да" : "Нет"));
            //Output: Да

            Console.WriteLine("\nТреугольник со сторонами 11, 9, 13: ");
            Triangle triangle2 = new Triangle(11, 9, 13);
            Console.WriteLine("Площадь: " + triangle2.GetArea());
            //Output: 48,80766
            Console.WriteLine("Прямоугольный: " + (triangle2.IsRight ? "Да" : "Нет"));
            //Output: Нет

            Console.WriteLine("\nКруг с радиусом 15: ");
            Circle circle1 = new Circle(15);
            Console.WriteLine("Площадь: " + circle1.GetArea());
            //Output: 706,85834
        }
    }
}
