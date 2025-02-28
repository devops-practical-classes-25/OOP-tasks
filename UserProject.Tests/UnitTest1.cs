using System;
using NUnit.Framework;

namespace UserProject.Tests;
public class UnitTest1
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void User_Implements_IComparable()
        {
            var user = new User("Alice", 25, 4.8);

            Assert.IsInstanceOf<IComparable<User>>(user);
        }

        [Test]
        public void User_ThrowsArgumentException_ForEmptyName()
        {
            var ex = Assert.Throws<ArgumentException>(() => new User("", 25, 4.8));
            Assert.That(ex.Message, Does.Contain("Имя пользователя не может быть пустым"));
        }

        [Test]
        public void User_ThrowsArgumentOutOfRangeException_ForNegativeAge()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new User("Alice", -1, 4.8));
            Assert.That(ex.Message, Does.Contain("Возраст не может быть отрицательным"));
        }

        [Test]
        public void User_ThrowsArgumentOutOfRangeException_ForInvalidRating()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new User("Alice", 25, 11));
            Assert.That(ex.Message, Does.Contain("Рейтинг должен быть в диапазоне"));
        }

        [Test]
        public void CompareTo_ThrowsArgumentNullException_WhenComparingWithNull()
        {
            var user = new User("Alice", 25, 4.8);

            var ex = Assert.Throws<ArgumentNullException>(() => user.CompareTo(null));
            Assert.That(ex.Message, Does.Contain("Нельзя сравнивать с null"));
        }

        [Test]
        public void CompareTo_SortsUsers_ByRating_Age_Name()
        {
            var users = new List<User>
            {
                new User("Alice", 25, 4.8),
                new User("Bob", 22, 4.8),
                new User("Charlie", 30, 4.5),
                new User("Eve", 35, 4.9),
                new User("Dave", 22, 4.8)
            };

            var expectedOrder = new List<User>
            {
                new User("Eve", 35, 4.9),
                new User("Bob", 22, 4.8),
                new User("Dave", 22, 4.8),
                new User("Alice", 25, 4.8),
                new User("Charlie", 30, 4.5)
            };

            users.Sort();

            CollectionAssert.AreEqual(
                expectedOrder, users, 
                Comparer<User>.Create((x, y) => x.CompareTo(y))
            );
        }
    }

    [TestFixture]
    public class UserComparerTests
    {
        [Test]
        public void UserComparer_Implements_IComparer()
        {
            var comparer = new UserComparer();

            Assert.IsInstanceOf<IComparer<User>>(comparer);
        }

        [Test]
        public void Compare_SortsUsersByName_IgnoreCase()
        {
            var users = new List<User>
            {
                new User("Charlie", 30, 4.5),
                new User("alice", 25, 4.8),
                new User("Bob", 22, 4.8)
            };

            var expectedOrder = new List<User>
            {
                new User("alice", 25, 4.8),
                new User("Bob", 22, 4.8),
                new User("Charlie", 30, 4.5)
            };

            var comparer = new UserComparer();

            users.Sort(comparer);
            CollectionAssert.AreEqual(
                expectedOrder, users,
                Comparer<User>.Create((x, y) => comparer.Compare(x, y))
            );
        }

        [Test]
        public void Compare_ReturnsZero_WhenComparingNullUsers()
        {
            var comparer = new UserComparer();

            var result = comparer.Compare(null, null);

            Assert.AreEqual(0, result);
        }
    }
}