// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using first_C__program;




string jsonPath = Path.Combine("Data", "jsconfig1.json");
string jsonString = File.ReadAllText(jsonPath);
var manager = new JsonConfigManager(jsonPath);
var configList = manager.Load();
if (configList == null)
{
    Console.WriteLine("Failed to deserialize JSON.");
    return;
}




foreach (var person in configList.People)
{
    Console.WriteLine($"Read from JSON: Id = {person.Id}, Name = {person.Name}, Salery = {person.Salery}");
}
//  Update the salery of the person with Id = 2
foreach (var person in configList.People)
{
    if (person.Id == 2)
    {
        person.Salery += 5000; // Increase salery by 5000 (!!!!!!write to file!!!!!!)
        Console.WriteLine($"Updated: Id = {person.Id}, Name = {person.Name}, Salery = {person.Salery}");
    }
}
foreach(var person in configList.People)
{
    Console.WriteLine($"Read from JSON: Id = {person.Id}, Name = {person.Name}, Salery = {person.Salery}");
}



foreach (var person in configList.People)
{
    Console.WriteLine($"Read from JSON: Id = {person.Id}, Name = {person.Name}, Salery = {person.Salery}");
}
// !!!!!Add a new person!!!!!
// Make sure People list is initialized (enables adding new persons if the list was null)
if (configList.People == null)
    configList.People = new List<JsonConfig>();
// Add a new person
var newPerson = new JsonConfig { Id = 4, Name = "Alice Johnson", Salery = 70000 };
manager.AddPerson(configList, newPerson);
// After making changes to configList
string updatedJson = JsonSerializer.Serialize(configList, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText(jsonPath, updatedJson);
manager.Save(configList);


foreach (var person in configList.People)
{
    Console.WriteLine($"Read from JSON: Id = {person.Id}, Name = {person.Name}, Salery = {person.Salery}");
}

Console.WriteLine("Press any key to continue...");


