using System;

public class User : IComparable<User>
{
    private const string EmptyNameMessage = "Имя пользователя не может быть пустым или null.";
    private const string NegativeAgeMessage = "Возраст не может быть отрицательным.";
    private const string InvalidRatingMessage = "Рейтинг должен быть в диапазоне от 0 до 5.";
    private const string NullComparisonMessage = "Нельзя сравнивать с null.";

    public string Name { get; }
    public int Age { get; }
    public double Rating { get; }

    /// <summary>
    /// Создает новый экземпляр пользователя с заданными именем, возрастом и рейтингом.
    /// </summary>
    /// <param name="name">Имя пользователя. Не может быть пустым или null.</param>
    /// <param name="age">Возраст пользователя. Не может быть отрицательным.</param>
    /// <param name="rating">Рейтинг пользователя в диапазоне от 0 до 10.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если имя пустое или null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Выбрасывается, если возраст отрицательный или рейтинг выходит за границы 0–5.
    /// </exception>
    public User(string name, int age, double rating)
    {
        throw new NotImplementedException("Конструктор не реализован.");
    }


    /// <summary>
    /// Сравнивает текущего пользователя с другим пользователем по рейтингу, возрасту и имени.
    /// </summary>
    /// <param name="other">Другой пользователь для сравнения.</param>
    /// <returns>
    /// Отрицательное значение, если текущий пользователь должен быть перед другим.
    /// Ноль, если пользователи равны по всем параметрам.
    /// Положительное значение, если текущий пользователь должен быть после другого.
    /// </returns>
    /// <exception cref="ArgumentNullException">Выбрасывается, если переданный пользователь равен null.</exception>
    public int CompareTo(User? other)
    {
        throw new NotImplementedException("Метод CompareTo не реализован.");
    }

    public override string ToString()
    {
        throw new NotImplementedException("Метод ToString не реализован.");
    }
}