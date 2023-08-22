using System;
using System.IO;
using System.Xml.Serialization;

namespace ClassSerializationXML
{
    [XmlRoot("CarItem")]
    public class ShoppingCatItem
    {
        [XmlAttribute]
        public Int32 productId;
        public decimal price;
        public Int32 quantity;
        [XmlIgnore]
        public decimal total;

        public ShoppingCatItem()
        {
        }
    }

    class Program
    {
        static void Main()
        {
            ShoppingCatItem item = new ShoppingCatItem();
            item.productId = 22;
            item.price = 50000;
            item.quantity = 2;
            item.total = item.quantity * item.price;

            FileStream stream = new FileStream("SerializedClass.xml", FileMode.Create);

            XmlSerializer serializer = new XmlSerializer(typeof(ShoppingCatItem));

            serializer.Serialize(stream, item);

            stream.Close();
        }
    }
}
