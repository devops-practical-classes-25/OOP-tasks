/// <summary>
/// Класс, представляющий прямоугольник.
/// </summary>
public class Rectangle : Shape
{
    private const string InvalidSizeMessage = "Ширина и высота должны быть положительными числами.";

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

    }

    /// <summary>
    /// Вычисляет площадь прямоугольника.
    /// </summary>
    /// <returns>Площадь прямоугольника, вычисленная по формуле width * height.</returns>

    /// <summary>
    /// Вычисляет периметр прямоугольника.
    /// </summary>
    /// <returns>Периметр прямоугольника, вычисленный по формуле 2 * (width + height).</returns>
}