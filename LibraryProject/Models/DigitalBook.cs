using LibraryProject.Interfaces;

namespace LibraryProject.Models
{
    public class DigitalBook : Book, IBookFormat
    {
        private const string EmptyDownloadLinkError = "Ссылка на скачивание не может быть пустой.";
        private const string EmptyTitleError = "Название книги не может быть пустым.";
        private const string EmptyAuthorError = "Автор книги не может быть пустым.";
        private const string InvalidYearError = "Год издания не может быть отрицательным.";

        public string DownloadLink { get; }

        public DigitalBook(string title, string author, int year, string downloadLink)
            : base(title, author, year)
        {
            Validate(title, author, year, downloadLink);
            DownloadLink = downloadLink;
        }

        private void Validate(string title, string author, int year, string downloadLink)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException(EmptyTitleError);

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException(EmptyAuthorError);

            if (year < 0)
                throw new ArgumentException(InvalidYearError);

            if (string.IsNullOrWhiteSpace(downloadLink))
                throw new ArgumentException(EmptyDownloadLinkError);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Digital Book: {Title} by {Author} ({Year}), Download: {DownloadLink}");
        }
    }
}