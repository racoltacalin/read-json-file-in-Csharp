using Newtonsoft.Json;
using System;
using System.IO;

namespace ReadFromJson
{
    public class JsonService
    {
        public static void ReadJsonFile(string jsonFileIn)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileIn));

            foreach (var item in jsonFile)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
