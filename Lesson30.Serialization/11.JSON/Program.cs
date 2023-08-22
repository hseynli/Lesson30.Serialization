using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // The SensitiveInfo property will be ignored during serialization
    [JsonIgnore]
    public string SensitiveInfo { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a Person object with sample data
        Person person = new Person
        {
            Name = "Alice",
            Age = 28,
            SensitiveInfo = "This should not appear in JSON"
        };

        // Serialize the Person object to JSON
        string jsonData = JsonSerializer.Serialize(person, new JsonSerializerOptions
        {
            WriteIndented = true // For pretty-printing JSON
        });

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonData);
    }
}