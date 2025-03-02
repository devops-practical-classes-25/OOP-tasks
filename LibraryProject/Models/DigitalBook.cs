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

        /// <summary>
        /// Создает экземпляр цифровой книги с заданными параметрами.
        /// </summary>
        /// <param name="title">Название книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="year">Год издания книги.</param>
        /// <param name="downloadLink">Ссылка на скачивание книги.</param>
        public DigitalBook(string title, string author, int year, string downloadLink)
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
        /// <param name="downloadLink">Ссылка на скачивание книги.</param>
        private void Validate(string title, string author, int year, string downloadLink)
        {
            throw new NotImplementedException("Метод Validate не реализован");
        }

        /// <summary>
        /// Отображает информацию о книге.
        /// </summary>
        public void DisplayInfo()
        {
            throw new NotImplementedException("Метод DisplayInfo не реализован");
        }
    }
}