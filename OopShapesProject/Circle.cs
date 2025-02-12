public class Circle : Shape
{
    public double Radius { get; }

    /// <summary>
    /// Создает экземпляр окружности с заданным радиусом.
    /// </summary>
    /// <param name="radius">Радиус окружности. Должен быть положительным числом.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если радиус меньше или равен нулю.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом");
        Radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь окружности.
    /// </summary>
    /// <returns>Площадь окружности, вычисленная по формуле π * r².</returns>
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    /// <summary>
    /// Вычисляет длину окружности (периметр).
    /// </summary>
    /// <returns>Длина окружности, вычисленная по формуле 2 * π * r.</returns>
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}