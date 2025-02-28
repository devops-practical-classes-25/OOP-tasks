namespace LibraryProject.Models;

public abstract class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    protected Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}