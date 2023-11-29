using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clases
{
    public class JsonFileManager
    {
        public static async Task<T> LoadFromJsonGenericAsync<T>(string filePath)
        {
            T item = default(T);

            try
            {
                if (File.Exists(filePath))
                {
                    string json = await File.ReadAllTextAsync(filePath);
                    item = JsonConvert.DeserializeObject<T>(json);
                }
            }
            catch (Exception ex)
            {
                item = default(T);
            }
            return item;
        }

        public static async Task SaveToJsonGenericAsync<T>(string filePath, T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                await File.WriteAllTextAsync(filePath, json);
                Console.WriteLine($"Datos guardados en el archivo JSON: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar datos en el archivo JSON: {ex.Message}");
                throw;
            }
        }

        public static T LoadFromJsonGeneric<T>(string filePath)
        {
            T item = default(T);

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    item = JsonConvert.DeserializeObject<T>(json);
                }
            }
            catch (Exception ex)
            {
                //string json = JsonConvert.SerializeObject(default(T));
                //File.WriteAllText(filePath, json);
                Console.WriteLine($"Error al leer datos en el archivo JSON: {ex.Message}");

            }
            return item;
        }
    }
}
