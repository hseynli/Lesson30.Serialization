using System.Xml.Linq;
using System.Xml.Serialization;

string xmlData = File.ReadAllText("books.xml");

XmlSerializer serializer = new XmlSerializer(typeof(Bookstore));
using (StringReader reader = new StringReader(xmlData))
{
    Bookstore bookstore = (Bookstore)serializer.Deserialize(reader);

    // Access the deserialized data
    foreach (var book in bookstore.Books)
    {
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine();
    }
}