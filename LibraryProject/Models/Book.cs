namespace LibraryProject.Models;

public abstract class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    /// <summary>
    /// Создает экземпляр книги с указанным заголовком, автором и годом издания.
    /// </summary>
    /// <param name="title">Заголовок книги.</param>
    /// <param name="author">Автор книги.</param>
    /// <param name="year">Год издания книги.</param>
    protected Book(string title, string author, int year)
    {
        throw new NotImplementedException("Конструктор не реализован");
    }
}