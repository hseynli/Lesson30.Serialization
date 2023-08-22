using System.Xml.Serialization;

List<Person> people = new List<Person>
        {
            new Person { FirstName = "Alice", LastName = "Johnson", Age = 28 },
            new Person { FirstName = "Bob", LastName = "Smith", Age = 35 },
            new Person { FirstName = "Charlie", LastName = "Brown", Age = 42 }
        };

PersonList personList = new PersonList { Persons = people };

XmlSerializer serializer = new XmlSerializer(typeof(PersonList));
using (TextWriter writer = new StreamWriter("people.xml"))
{
    serializer.Serialize(writer, personList);
}

Console.WriteLine("List of Persons Serialized to people.xml");

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

[Serializable]
public class PersonList
{
    public List<Person> Persons { get; set; }
}