public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Ширина и высота должны быть положительными числами");
        Width = width;
        Height = height;
    }
    public override double GetArea()
    {
        return Width * Height;
    }
    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}