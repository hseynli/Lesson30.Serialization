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
        List<Person> people = new List<Person>();

        // Specify the binary file path
        string filePath = "people.dat";

        // Open the binary file for reading
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                // Read data from the binary file and create a Person object
                string name = reader.ReadString();
                int age = reader.ReadInt32();
                string city = reader.ReadString();

                Person person = new Person
                {
                    Name = name,
                    Age = age,
                    City = city
                };

                // Add the Person object to the list
                people.Add(person);
            }
        }

        // Display the list of people
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }
    }
}