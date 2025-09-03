// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using first_C__program;




string jsonPath = Path.Combine("Data", "jsconfig1.json");

var manager = new CorporationManager(jsonPath);
var configList = manager.Load();
if (configList == null)
{
    Console.WriteLine("Failed to deserialize JSON.");
    return;
}

CorporationManager.PrintList(configList);    // print file content

// Make changes to configList (add/update people)
var newPerson = new Person { Id = 4, Name = "Alice Johnson", Salary = 70000 };
configList.People.Add(newPerson);

// Update salary example
var personToUpdate = configList.People.Find(p => p.Id == 2);
if (personToUpdate != null)
    personToUpdate.Salary += 5000;

// Save changes to file
manager.Save(configList);

var manager2 = new CorporationManager(jsonPath);
var configList2 = manager2.Load();
if (configList2 == null)
{
    Console.WriteLine("Failed to deserialize JSON.");
    return;
}

CorporationManager.PrintList(configList2);    // print file content




