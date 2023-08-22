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
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 28, City = "New York" },
            new Person { Name = "Bob", Age = 35, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 42, City = "Chicago" }
        };

        // Specify the binary file path
        string filePath = "people.dat";

        // Open the binary file for writing
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            foreach (Person person in people)
            {
                // Write data to the binary file
                writer.Write(person.Name);
                writer.Write(person.Age);
                writer.Write(person.City);
            }
        }

        Console.WriteLine("Data written to people.dat");
    }
}