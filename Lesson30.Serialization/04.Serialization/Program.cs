using System.Xml.Serialization;


Person person = new Person
{
    FirstName = "Jane",
    LastName = "Smith",
    Age = 25
};

XmlSerializer serializer = new XmlSerializer(typeof(Person));
using (TextWriter writer = new StreamWriter("person.xml"))
{
    serializer.Serialize(writer, person);
}

Console.WriteLine("XML Serialized to person.xml");
Console.ReadKey();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}