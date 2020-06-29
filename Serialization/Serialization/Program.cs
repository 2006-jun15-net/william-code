using Newtonsoft.Json;
using Serialization.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        async static Task Main(string[] args)
        {

           // List<PlayerStats> data = GetInitialData();

            // Serialization conversion
           // string json = ConvertToJson(data);

            string filePath = "../../../data.json";

            List<PlayerStats> data;
            try
            {
                string initialJson = await File.ReadAllTextAsync(filePath);
                data = GetInitialData();
            }
            catch (FileNotFoundException)
            {
                
            }

           // string json = ConvertToJson(data);
           // await WriteStringToFileAsync(filePath, json);
        }
        // 1. call async version
        // 2. await task (Future)
        // 3. mark with async (just after access modifier)
        // 4. if returns T, change it to type Task<T>
        private async static Task WriteStringToFileAsync(string filePath, string json)
        {
            await File.WriteAllTextAsync(filePath, json);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>serialized JSON</returns>
        public static string ConvertToJson(List<PlayerStats> data)
        {
            // in .NET Core, we use a program called NuGet
            // to resolve dependencies and download them from registries

            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private static List<PlayerStats> GetInitialData()
        {
            return new List<PlayerStats>
            {
                new PlayerStats
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 99,
                    PointsPerGame = 100,
                    ArcLocations = new Dictionary<int, double>
                    {

                    }
                },
                new PlayerStats()
            };
        }
    }
}
