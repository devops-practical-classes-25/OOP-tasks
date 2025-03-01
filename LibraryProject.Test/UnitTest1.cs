using NUnit.Framework;
using LibraryProject.Models;
using LibraryProject.Interfaces;
using System;

namespace LibraryProject.Test
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void PhysicalBook_ShouldImplementIBookFormat()
        {
            var book = new PhysicalBook("1984", "George Orwell", 1949, 3);
            Assert.IsInstanceOf<IBookFormat>(book);
        }

        [Test]
        public void DigitalBook_ShouldImplementIBookFormat()
        {
            var book = new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode");
            Assert.IsInstanceOf<IBookFormat>(book);
        }

        [Test]
        public void PhysicalBook_DisplayInfo_ShouldNotThrowException()
        {
            var book = new PhysicalBook("1984", "George Orwell", 1949, 3);
            Assert.DoesNotThrow(() => book.DisplayInfo());
        }

        [Test]
        public void DigitalBook_DisplayInfo_ShouldNotThrowException()
        {
            var book = new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode");
            Assert.DoesNotThrow(() => book.DisplayInfo());
        }

        [Test]
        public void PhysicalBook_ShouldSetAllPropertiesCorrectly()
        {
            var book = new PhysicalBook("1984", "George Orwell", 1949, 3);

            Assert.AreEqual("1984", book.Title);
            Assert.AreEqual("George Orwell", book.Author);
            Assert.AreEqual(1949, book.Year);
            Assert.AreEqual(3, book.CopiesAvailable);
        }

        [Test]
        public void DigitalBook_ShouldSetAllPropertiesCorrectly()
        {
            var book = new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode");

            Assert.AreEqual("Clean Code", book.Title);
            Assert.AreEqual("Robert C. Martin", book.Author);
            Assert.AreEqual(2008, book.Year);
            Assert.AreEqual("http://example.com/cleancode", book.DownloadLink);
        }

        [Test]
        public void PhysicalBook_ShouldThrowException_WhenTitleIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => new PhysicalBook("", "George Orwell", 1949, 3));
            Assert.AreEqual("Название книги не может быть пустым.", ex.Message);
        }

        [Test]
        public void PhysicalBook_ShouldThrowException_WhenAuthorIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => new PhysicalBook("1984", "", 1949, 3));
            Assert.AreEqual("Автор книги не может быть пустым.", ex.Message);
        }

        [Test]
        public void PhysicalBook_ShouldThrowException_WhenYearIsNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => new PhysicalBook("1984", "George Orwell", -1949, 3));
            Assert.AreEqual("Год издания не может быть отрицательным.", ex.Message);
        }

        [Test]
        public void PhysicalBook_ShouldThrowException_WhenCopiesAreNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => new PhysicalBook("1984", "George Orwell", 1949, -3));
            Assert.AreEqual("Количество копий не может быть отрицательным.", ex.Message);
        }

        [Test]
        public void DigitalBook_ShouldThrowException_WhenTitleIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => new DigitalBook("", "Robert C. Martin", 2008, "http://example.com/cleancode"));
            Assert.AreEqual("Название книги не может быть пустым.", ex.Message);
        }

        [Test]
        public void DigitalBook_ShouldThrowException_WhenAuthorIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => new DigitalBook("Clean Code", "", 2008, "http://example.com/cleancode"));
            Assert.AreEqual("Автор книги не может быть пустым.", ex.Message);
        }

        [Test]
        public void DigitalBook_ShouldThrowException_WhenYearIsNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => new DigitalBook("Clean Code", "Robert C. Martin", -2008, "http://example.com/cleancode"));
            Assert.AreEqual("Год издания не может быть отрицательным.", ex.Message);
        }

        [Test]
        public void DigitalBook_ShouldThrowException_WhenDownloadLinkIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => new DigitalBook("Clean Code", "Robert C. Martin", 2008, ""));
            Assert.AreEqual("Ссылка на скачивание не может быть пустой.", ex.Message);
        }

         // OCP: Проверка возможности добавлять новые форматы книг без изменения существующего кода
        public class AudioBook : Book, IBookFormat
        {
            public int DurationInMinutes { get; }

            public AudioBook(string title, string author, int year, int durationInMinutes)
                : base(title, author, year)
            {
                if (durationInMinutes <= 0)
                    throw new ArgumentException("Длительность аудиокниги должна быть положительной.");

                DurationInMinutes = durationInMinutes;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Audio Book: {Title} by {Author} ({Year}), Duration: {DurationInMinutes} minutes");
            }
        }

        [Test]
        public void AudioBook_ShouldImplementIBookFormat()
        {
            var audioBook = new AudioBook("Atomic Habits", "James Clear", 2018, 320);
            Assert.IsInstanceOf<IBookFormat>(audioBook);
        }

        [Test]
        public void AudioBook_ShouldThrowException_WhenDurationIsNegative()
        {
            var ex = Assert.Throws<ArgumentException>(() => new AudioBook("Atomic Habits", "James Clear", 2018, -320));
            Assert.AreEqual("Длительность аудиокниги должна быть положительной.", ex.Message);
        }

        [Test]
        public void AudioBook_DisplayInfo_ShouldNotThrowException()
        {
            var audioBook = new AudioBook("Atomic Habits", "James Clear", 2018, 320);
            Assert.DoesNotThrow(() => audioBook.DisplayInfo());
        }

        // LSP: Проверка подстановки — использование производных классов вместо базового класса Book
        [Test]
        public void AllBooks_ShouldWorkWithIBookFormat()
        {
            var books = new List<IBookFormat>
            {
                new PhysicalBook("1984", "George Orwell", 1949, 3),
                new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode"),
                new AudioBook("Atomic Habits", "James Clear", 2018, 320)
            };

            // Ожидается, что все объекты вызывают DisplayInfo без ошибок
            foreach (var book in books)
            {
                Assert.DoesNotThrow(() => book.DisplayInfo());
            }
        }

        [Test]
        public void AllBooks_ShouldHaveCorrectTypeAndInheritFromBook()
        {
            var books = new List<Book>
            {
                new PhysicalBook("1984", "George Orwell", 1949, 3),
                new DigitalBook("Clean Code", "Robert C. Martin", 2008, "http://example.com/cleancode"),
                new AudioBook("Atomic Habits", "James Clear", 2018, 320)
            };

            // Проверка, что все книги — потомки Book
            foreach (var book in books)
            {
                Assert.IsInstanceOf<Book>(book);
            }
        }
    }
}