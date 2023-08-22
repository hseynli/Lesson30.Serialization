using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of Person objects
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 28, City = "New York" },
            new Person { Name = "Bob", Age = 35, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 42, City = "Chicago" }
        };

        // Serialize the list of Person objects to a JSON file
        SerializeToJsonFile(people, "data.json");
        Console.WriteLine("Data serialized to data.json");
    }

    static void SerializeToJsonFile<T>(T data, string filePath)
    {
        // Serialize the data to JSON format
        string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true // For pretty-printing JSON
        });

        // Write the JSON data to the file
        File.WriteAllText(filePath, jsonData);
    }
}