using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("bookstore")]
public class Bookstore
{
    [XmlElement("book")]
    public List<Book> Books { get; set; }
}

public class Book
{ 
    [XmlElement("author")]
    public string Author { get; set; }
}