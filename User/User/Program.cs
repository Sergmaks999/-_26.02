using System;

public class User
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }

    public User(string lastName, string firstName, string middleName, int age)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Age = age;
    }

    public string GetFullName()
    {
        return $"{LastName} {FirstName} {MiddleName}";
    }

    public override string ToString()
    {
        return $"ФИО: {GetFullName()}, Возраст: {Age}";
    }

    public static void Main(string[] args)
    {
        User myUser = new User("Иванов", "Иван", "Иванович", 30);
        Console.WriteLine(myUser);
    }
}
