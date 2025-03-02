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

        /// <summary>
        /// Создает экземпляр физической книги с заданными параметрами.
        /// </summary>
        /// <param name="title">Название книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="year">Год издания книги.</param>
        /// <param name="copiesAvailable">Количество доступных копий книги.</param>
        public PhysicalBook(string title, string author, int year, int copiesAvailable)
            : base(title, author, year)
        {
            throw new NotImplementedException("Конструктор не реализован");
        }

        /// <summary>
        /// Проверяет корректность данных книги.
        /// </summary>
        /// <param name="title">Название книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="year">Год издания книги.</param>
        /// <param name="copiesAvailable">Количество доступных копий книги.</param>
        private void Validate(string title, string author, int year, int copiesAvailable)
        {
            throw new NotImplementedException("Метод Validate не реализован");
        }

        /// <summary>
        /// Отображает информацию о книге.
        public void DisplayInfo()
        {
            throw new NotImplementedException("Метод DisplayInfo не реализован");
        }
    }
}