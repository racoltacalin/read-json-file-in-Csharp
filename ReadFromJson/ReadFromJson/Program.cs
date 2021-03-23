using System;
using System.IO;

namespace ReadFromJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToJson = Path.Combine("myFile.json");
            JsonService.ReadJsonFile(pathToJson);
        }
    }
}
