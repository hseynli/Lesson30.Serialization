using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Person
{
    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("birth_year")]
    public int BirthYear { get; set; }
}

class Program
{
    static void Main()
    {
        // JSON string with custom property names
        string json = "{\"full_name\":\"Alice Smith\",\"birth_year\":1990}";

        // Deserialize the JSON string to a Person instance
        Person person = JsonSerializer.Deserialize<Person>(json);

        Console.WriteLine("Deserialized Person:");
        Console.WriteLine($"Full Name: {person.FullName}");
        Console.WriteLine($"Birth Year: {person.BirthYear}");
    }
}
