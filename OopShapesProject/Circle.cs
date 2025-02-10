public class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом");
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}