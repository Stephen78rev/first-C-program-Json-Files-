
using System.Text.Json;

namespace first_C__program
{
    
    internal class ProcessJason
    {
        public static int Add(int a, int b)
        {
            //Console.WriteLine(a + b);
            int result = a + b;

            return result;
        }
        public static int firstNumber(int a)
        {
            a = a + 1;
            return a;
        }
        public static int secondNumber(int b)
        {
            b = b + 1;
            return b;
        }
    }

    public class JsonConfigManager
    {
        private readonly string _jsonPath;

        public JsonConfigManager(string jsonPath)
        {
            _jsonPath = jsonPath;
        }

        public JsonConfigList? Load()
        {
            
            if (!File.Exists(_jsonPath)) return null;
            string jsonString = File.ReadAllText(_jsonPath);
            return JsonSerializer.Deserialize<JsonConfigList>(jsonString);
        }

        public void AddPerson(JsonConfigList configList, JsonConfig newPerson)
        {
            configList.People.Add(newPerson);
            Save(configList);
        }

        public void Save(JsonConfigList configList)
        {
            string updatedJson = JsonSerializer.Serialize(configList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_jsonPath, updatedJson);
        }
    }
}
