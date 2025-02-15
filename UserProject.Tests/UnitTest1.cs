using System;
using Xunit;

namespace UserProject.Tests;
public class UnitTest1
{
    [Fact]
    public void Users_AreSorted_ByRating_Age_Name()
    {
        // Arrange
        var users = new List<User>
        {
            new User("Alice", 25, 4.8),
            new User("Bob", 22, 4.8),
            new User("Charlie", 30, 4.5),
            new User("Dave", 22, 4.8),
            new User("Eve", 35, 4.9),
            new User("Frank", 30, 4.5)
        };

        var expectedOrder = new List<User>
        {
            new User("Eve", 35, 4.9),
            new User("Bob", 22, 4.8),
            new User("Dave", 22, 4.8),
            new User("Alice", 25, 4.8),
            new User("Charlie", 30, 4.5),
            new User("Frank", 30, 4.5)
        };

        // Act
        users.Sort();

        // Assert
        Assert.Equal(expectedOrder, users);
    }

    [Fact]
    public void Users_AreSorted_ByName_WhenUsingComparer()
    {
        // Arrange
        var users = new List<User>
        {
            new User("Charlie", 30, 4.5),
            new User("Alice", 25, 4.8),
            new User("Eve", 35, 4.9),
            new User("Bob", 22, 4.8),
            new User("Frank", 30, 4.5),
            new User("Dave", 22, 4.8)
        };

        var expectedOrder = new List<User>
        {
            new User("Alice", 25, 4.8),
            new User("Bob", 22, 4.8),
            new User("Charlie", 30, 4.5),
            new User("Dave", 22, 4.8),
            new User("Eve", 35, 4.9),
            new User("Frank", 30, 4.5)
        };

        // Act
        users.Sort(new UserComparer());

        // Assert
        Assert.Equal(expectedOrder, users);
    }

    [Fact]
    public void Users_AreEqual_WhenRating_Age_NameAreEqual()
    {
        // Arrange
        var user1 = new User("Alice", 25, 4.8);
        var user2 = new User("Alice", 25, 4.8);

        // Act & Assert
        Assert.Equal(user1, user2);
    }

    
    [Fact]
    public void Users_AreSorted_ByName_WhenRating_AgeAreEqual()
    {
        // Arrange
        var users = new List<User>
        {
            new User("Charlie", 30, 4.5),
            new User("Alice", 30, 4.5),
            new User("Bob", 30, 4.5)
        };

        var expectedOrder = new List<User>
        {
            new User("Alice", 30, 4.5),
            new User("Bob", 30, 4.5),
            new User("Charlie", 30, 4.5)
        };

        // Act
        users.Sort();

        // Assert
        Assert.Equal(expectedOrder, users);
    }

    [Fact]
    public void Compare_ShouldReturnPositive_WhenFirstUserIsOlder()
    {
        // Arrange
        var user1 = new User("Alice", 30, 4.8);
        var user2 = new User("Bob", 25, 4.8);

        // Act
        var result = user1.CompareTo(user2);

        // Assert
        Assert.True(result > 0);
    }

    [Fact]
    public void Compare_ShouldReturnNegative_WhenFirstUserHasLowerRating()
    {
        // Arrange
        var user1 = new User("Alice", 25, 4.5);
        var user2 = new User("Alice", 30, 4.8);

        // Act
        var result = user1.CompareTo(user2);

        // Assert
        Assert.True(result > 0); 
    }

    [Fact]
    public void Compare_ShouldThrowArgumentNullException_WhenComparingWithNull()
    {
        // Arrange
        var user = new User("Alice", 25, 4.8);

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => user.CompareTo(null));
    }

    [Fact]
    public void Compare_ShouldReturnNegative_WhenFirstUserNameIsBeforeSecond()
    {
        // Arrange
        var user1 = new User("Alice", 25, 4.8);
        var user2 = new User("Bob", 30, 4.8);

        var comparer = new UserComparer();

        // Act
        var result = comparer.Compare(user1, user2);

        // Assert
        Assert.True(result < 0);
    }

    [Fact]
    public void Compare_ShouldReturnPositive_WhenFirstUserNameIsAfterSecond()
    {
        // Arrange
        var user1 = new User("Charlie", 25, 4.8);
        var user2 = new User("Alice", 30, 4.8);

        var comparer = new UserComparer();

        // Act
        var result = comparer.Compare(user1, user2);

        // Assert
        Assert.True(result > 0);
    }

    [Fact]
    public void Compare_ShouldReturnZero_WhenNamesAreEqual()
    {
        // Arrange
        var user1 = new User("Alice", 25, 4.8);
        var user2 = new User("Alice", 30, 4.8);

        var comparer = new UserComparer();

        // Act
        var result = comparer.Compare(user1, user2);

        // Assert
        Assert.True(result == 0);
    }

    [Fact]
    public void Compare_ShouldReturnNegative_WhenFirstUserNameIsBeforeSecond_WithDifferentCase()
    {
        // Arrange
        var user1 = new User("alice", 25, 4.8);
        var user2 = new User("Bob", 30, 4.8);

        var comparer = new UserComparer();

        // Act
        var result = comparer.Compare(user1, user2);

        // Assert
        Assert.True(result < 0);
    }

    [Fact]
    public void Compare_ShouldReturnPositive_WhenFirstUserNameIsAfterSecond_WithDifferentCase()
    {
        // Arrange
        var user1 = new User("Charlie", 25, 4.8);
        var user2 = new User("alice", 30, 4.8);

        var comparer = new UserComparer();

        // Act
        var result = comparer.Compare(user1, user2);

        // Assert
        Assert.True(result > 0);
    }
}