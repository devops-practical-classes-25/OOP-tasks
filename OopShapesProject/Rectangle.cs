/// <summary>
/// Класс, представляющий прямоугольник.
/// </summary>
public class Rectangle : Shape
{
    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    public double Width { get; }

    /// <summary>
    /// Высота прямоугольника.
    /// </summary>
    public double Height { get; }

    /// <summary>
    /// Создает экземпляр прямоугольника с заданной шириной и высотой.
    /// </summary>
    /// <param name="width">Ширина прямоугольника. Должна быть положительным числом.</param>
    /// <param name="height">Высота прямоугольника. Должна быть положительным числом.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если ширина или высота меньше либо равны нулю.
    /// </exception>
    public Rectangle(double width, double height)
    {
        throw new NotImplementedException("Конструктор не реализован");
    }

    /// <summary>
    /// Вычисляет площадь прямоугольника.
    /// </summary>
    /// <returns>Площадь прямоугольника, вычисленная по формуле width * height.</returns>
    public override double GetArea()
    {
        throw new NotImplementedException("Метод GetArea не реализован");
    }

    /// <summary>
    /// Вычисляет периметр прямоугольника.
    /// </summary>
    /// <returns>Периметр прямоугольника, вычисленный по формуле 2 * (width + height).</returns>
    public override double GetPerimeter()
    {
        throw new NotImplementedException("Метод GetPerimeter не реализован");
    }
}