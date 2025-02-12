/// <summary>
/// Абстрактный класс, представляющий геометрическую фигуру.
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    public abstract double GetArea();

    /// <summary>
    /// Вычисляет периметр (длину границы) фигуры.
    /// </summary>
    /// <returns>Периметр фигуры.</returns>
    public abstract double GetPerimeter();
}
