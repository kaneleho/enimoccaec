using System;
using System.Xml;

public class Example
{
    public static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("example.xml");
        Console.WriteLine(doc.OuterXml);
    }
}
