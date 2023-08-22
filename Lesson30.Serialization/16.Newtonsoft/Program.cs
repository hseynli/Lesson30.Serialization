using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // JSON string representing a Person
        string json = "{\"Name\":\"Bob\",\"Age\":35}";

        // Deserialize the JSON string to a Person object
        Person person = JsonConvert.DeserializeObject<Person>(json);

        Console.WriteLine("Deserialized Person:");
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
    }
}