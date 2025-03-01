using System;
using LibraryProject.Interfaces;

namespace LibraryProject.Models
{
    public class PhysicalBook : Book, IBookFormat
    {
        private const string NegativeCopiesError = "Количество копий не может быть отрицательным.";
        private const string EmptyTitleError = "Название книги не может быть пустым.";
        private const string EmptyAuthorError = "Автор книги не может быть пустым.";
        private const string InvalidYearError = "Год издания не может быть отрицательным.";

        public int CopiesAvailable { get; private set; }

        public PhysicalBook(string title, string author, int year, int copiesAvailable)
            : base(title, author, year)
        {
            Validate(title, author, year, copiesAvailable);
            CopiesAvailable = copiesAvailable;
        }

        private void Validate(string title, string author, int year, int copiesAvailable)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException(EmptyTitleError);

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException(EmptyAuthorError);

            if (year < 0)
                throw new ArgumentException(InvalidYearError);

            if (copiesAvailable < 0)
                throw new ArgumentException(NegativeCopiesError);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Physical Book: {Title} by {Author} ({Year}), Copies available: {CopiesAvailable}");
        }
    }
}