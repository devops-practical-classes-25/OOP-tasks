using System;
using System.Collections.Generic;

public class UserComparer : IComparer<User>
{
    /// <summary>
    /// Сравнивает двух пользователей по их именам в алфавитном порядке.
    /// </summary>
    /// <param name="x">Первый пользователь.</param>
    /// <param name="y">Второй пользователь.</param>
    /// <returns>
    /// Отрицательное значение, если x предшествует y в алфавитном порядке.
    /// Ноль, если имена одинаковы или один из пользователей null.
    /// Положительное значение, если x идет после y.
    /// </returns>
    public int Compare(User? x, User? y)
    {
        if (x == null || y == null) return 0;
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
}