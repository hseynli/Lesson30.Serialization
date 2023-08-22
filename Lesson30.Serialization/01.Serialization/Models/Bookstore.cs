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
    [XmlElement("title")]
    public string Title { get; set; }

    [XmlElement("author")]
    public string Author { get; set; }

    [XmlElement("genre")]
    public string Genre { get; set; }

    [XmlElement("price")]
    public decimal Price { get; set; }
}