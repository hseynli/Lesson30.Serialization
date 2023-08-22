using System;
using System.Text.Json;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a Person instance with nested Address
        var person = new Person
        {
            Name = "Alice",
            Age = 28,
            Address = new Address
            {
                Street = "123 Main St",
                City = "New York"
            }
        };

        // Serialize the Person instance to JSON
        string json = JsonSerializer.Serialize(person, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}