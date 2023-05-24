// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");


var pathToXmlFile = @"C:\Users\jomar\source\repos\BSIMPORT\BSIMPORT\Data\stock_export_full_for_jomardyan.xml";

offer result = new offer();
XmlSerializer serializer = new XmlSerializer(typeof(offer));

using (FileStream fileStream = new FileStream(pathToXmlFile, FileMode.Open))
{
    result = (offer)serializer.Deserialize(fileStream);
	foreach (var pr in result.products.product)
	{
        Console.WriteLine(pr.id);
    }
}

