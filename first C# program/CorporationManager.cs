
using System.Collections.Generic;
using System.Text.Json;

namespace first_C__program
{   


    public class CorporationManager
    {
        private readonly string _jsonPath;
        //private readonly string _jsonPath = @"C:\Users\sdsmy\source\repos\first C# program\first C# program\Data\jsconfig1.json";
                                           


        public CorporationManager(string jsonPath)
        {
            _jsonPath = jsonPath;
        }

        public Corporation? Load()
        {
            
            if (!File.Exists(_jsonPath)) return null;
            string jsonString = File.ReadAllText(_jsonPath);
            return JsonSerializer.Deserialize<Corporation>(jsonString);
        }

        public void Save(Corporation configList)
        {
            string updatedJson = JsonSerializer.Serialize(configList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_jsonPath, updatedJson);
        }
        public static void PrintList(Corporation configList)
        {
            foreach (var person in configList.People)
            {
                Console.WriteLine($"Read from JSON: Id = {person.Id}, Name = {person.Name}, Salary = {person.Salary}");
            }
        }
    }
}
