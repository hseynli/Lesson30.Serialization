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
        // Create a Person instance
        var person = new Person
        {
            Name = "Alice",
            Age = 28
        };

        // Serialize the Person instance to JSON
        string json = JsonConvert.SerializeObject(person, Formatting.Indented);

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}