using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User("Alice", 25, 4.8),
            new User("Bob", 22, 4.8),
            new User("Charlie", 30, 4.5),
            new User("Dave", 22, 4.8),
            new User("Eve", 35, 4.9),
            new User("Frank", 30, 4.5)
        };

        Console.WriteLine("Sorting by Rating -> Age -> Name:");
        users.Sort();
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }

        Console.WriteLine("\nSorting by Name:");
        users.Sort(new UserComparer());
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}
