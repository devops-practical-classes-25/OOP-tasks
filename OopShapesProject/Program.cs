using System;

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        
        Console.WriteLine($"Площадь круга (радиус = 5): {circle.GetArea()}");
        Console.WriteLine($"Периметр круга (радиус = 5): {circle.GetPerimeter()}");

        Console.WriteLine($"Площадь прямоугольника (4x6): {rectangle.GetArea()}");
        Console.WriteLine($"Периметр прямоугольника (4x6): {rectangle.GetPerimeter()}");
    }
}