using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Person
{
    public string Name { get; set; }

    [JsonConverter(typeof(CustomDateConverter))]
    public DateTime BirthDate { get; set; }
}

public class CustomDateConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            if (DateTime.TryParse(reader.GetString(), out DateTime date))
            {
                return date;
            }
        }
        return DateTime.MinValue;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
    }
}

class Program
{
    static void Main()
    {
        string json = "{\"Name\":\"Alice\",\"BirthDate\":\"1990-05-15\"}";

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var person = JsonSerializer.Deserialize<Person>(json, options);

        Console.WriteLine("Deserialized Person:");
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Birth Date: {person.BirthDate:yyyy-MM-dd}");

        // Serialize back to JSON
        string serializedJson = JsonSerializer.Serialize(person, options);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(serializedJson);
    }
}
