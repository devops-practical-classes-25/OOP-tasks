using LibraryProject.Models;
using LibraryProject.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        List<IBookFormat> books = new List<IBookFormat>
        {
            new PhysicalBook("1984", "George Orwell", 1949, 3),
            new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode")
        };

        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }
}
