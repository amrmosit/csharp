using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}

public class Program
{
    public static void Main()
    {
        // Deserializing JSON to a Person object
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.Write($"Name: {person.Name}, Age: {person.Age}");

        // Serializing a Person object to JSON
        Person newPerson = new Person { Name = "Jane Doe", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"\nSerialized JSON: {newJson}");
    }
}