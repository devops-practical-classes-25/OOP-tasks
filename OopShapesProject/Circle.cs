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
        throw new NotImplementedException("Конструктор не реализован");
    }

    /// <summary>
    /// Вычисляет площадь окружности.
    /// </summary>
    /// <returns>Площадь окружности, вычисленная по формуле π * r².</returns>
    public override double GetArea()
    {
        throw new NotImplementedException("Метод GetArea не реализован");
    }

    /// <summary>
    /// Вычисляет длину окружности (периметр).
    /// </summary>
    /// <returns>Длина окружности, вычисленная по формуле 2 * π * r.</returns>
    public override double GetPerimeter()
    {
        throw new NotImplementedException("Метод GetPerimeter не реализован");
    }
}