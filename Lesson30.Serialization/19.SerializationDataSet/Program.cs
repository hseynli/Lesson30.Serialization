using System.IO;
using System.Xml.Serialization;
using System.Data;

namespace SerializationDataSet
{
    class Program
    {
        public static void SerializeDataSet(string fileName)
        {
            // DataSet yaradırıq; cədvəl, daha sonra sütun və 10 sətir əlavə edirik.
            DataSet dataSet = new DataSet("myDataSet");
            DataTable table = new DataTable("table1");
            DataColumn column = new DataColumn("thing");

            table.Columns.Add(column);
            dataSet.Tables.Add(table);

            DataRow row;

            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row[0] = "Thing " + i;
                table.Rows.Add(row);
            }

            dataSet.WriteXml(fileName);
            dataSet.WriteXmlSchema(Path.ChangeExtension(fileName, "xsd"));
        }

        static void Main()
        {
            SerializeDataSet("SerializedDataSet.xml");
        }
    }
}
