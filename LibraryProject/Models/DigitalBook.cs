using LibraryProject.Interfaces;

namespace LibraryProject.Models;

public class DigitalBook : Book, IBookFormat
{
    public string DownloadLink { get; }

    public DigitalBook(string title, string author, int year, string downloadLink)
        : base(title, author, year)
    {
        DownloadLink = downloadLink;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Digital Book: {Title} by {Author} ({Year}), Download: {DownloadLink}");
    }
}