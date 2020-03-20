using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tutorial2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        var list = new List<Student>
        {
            new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski"}
        };

        var jsonString = JsonSerializer.Serialize(list);
        File.WriteAllText("data.json", jsonString);
    }
}

[Serializable]
class Student
{

    public int IdStudent { get; set; }
    [XmlElement(ElementName = "InneNazwa")]
    public string FirstName { get; set; }
    [XmlAttribute(AttributeName = "InnaNazwa")]
    [JsonPropertyName("LastName")]
    public string LastName { get; set; }

}






