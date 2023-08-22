using System;
using System.IO;
using System.Xml.Serialization;

/*
     XML formatına serializasiya olunan klas aşağıdakı şərtlərə cavab verməlidir:
     - klas açıq olmalıdır (public)
     - serializasiya olunan bütün üzvlər açıq olmalıdır (public)
     - deafult konstruktor olmalıdır (parametersiz)
 */

namespace ClassSerializationXML
{
    public class ShoppingCatItem
    {
        public Int32 productId;
        public decimal price;
        public Int32 quantity;
        public decimal total;
    }

    class Program
    {
        static void Main()
        {
            var item = new ShoppingCatItem { productId = 22, price = 50000, quantity = 2 };
            item.total = item.quantity * item.price;

            // Məlumatları saxlamaq üçün fayl yaradırıq
            FileStream stream = new FileStream("SerializedClass.xml", FileMode.Create);

            // Serializasiya etmək üçün XmlSerializer klasının instance-nı yaradırıq
            XmlSerializer serializer = new XmlSerializer(typeof(ShoppingCatItem));

            // Məlumatları faylı saxlamaq üçün XmlSerializer obyektindən istifadə edirik
            serializer.Serialize(stream, item);

            // Faylı bağlayırıq
            stream.Close();
        }
    }
}
