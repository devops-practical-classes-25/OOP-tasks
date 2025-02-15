public class Circle : Shape
{
    private const string InvalidRadiusMessage = "Радиус должен быть положительным числом.";

    public double Radius { get; }

    /// <summary>
    /// Создает экземпляр окружности с заданным радиусом.
    /// </summary>
    /// <param name="radius">Радиус окружности. Должен быть положительным числом.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если радиус меньше или равен нулю.</exception>
    public Circle(double radius)
    {

    }

    /// <summary>
    /// Вычисляет площадь окружности.
    /// </summary>
    /// <returns>Площадь окружности, вычисленная по формуле π * r².</returns>


    /// <summary>
    /// Вычисляет длину окружности (периметр).
    /// </summary>
    /// <returns>Длина окружности, вычисленная по формуле 2 * π * r.</returns>

}