using LibraryProject.Interfaces;

namespace LibraryProject.Models;

public class PhysicalBook : Book, IBookFormat
{
    public int CopiesAvailable { get; private set; }

    public PhysicalBook(string title, string author, int year, int copiesAvailable)
        : base(title, author, year)
    {
        CopiesAvailable = copiesAvailable;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Physical Book: {Title} by {Author} ({Year}), Copies available: {CopiesAvailable}");
    }
}