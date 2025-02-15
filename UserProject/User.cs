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
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(EmptyNameMessage, nameof(name));

        if (age < 0)
            throw new ArgumentOutOfRangeException(nameof(age), NegativeAgeMessage);

        if (rating < 0 || rating > 10)
            throw new ArgumentOutOfRangeException(nameof(rating), InvalidRatingMessage);

        Name = name;
        Age = age;
        Rating = rating;
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
        if (other == null) 
            throw new ArgumentNullException(nameof(other), NullComparisonMessage);

        int ratingComparison = other.Rating.CompareTo(this.Rating);
        if (ratingComparison != 0) return ratingComparison;

        int ageComparison = this.Age.CompareTo(other.Age);
        if (ageComparison != 0) return ageComparison;

        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"{Name} (Age: {Age}, Rating: {Rating})";
    }
}