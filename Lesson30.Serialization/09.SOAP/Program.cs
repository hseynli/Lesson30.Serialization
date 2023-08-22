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
        // Specify the JSON file path
        string filePath = "people.json";

        // Read the JSON data from the file
        string jsonData = File.ReadAllText(filePath);

        // Deserialize the JSON data into a list of Person objects
        List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonData);

        // Display the deserialized data
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }
    }
}