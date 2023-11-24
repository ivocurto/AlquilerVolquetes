using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
namespace Clases
{
    public class JsonFileManager
    {

        public static T LoadFromJsonGeneric<T>(string filePath)
        {
            T item = default(T);  // Inicializa el objeto como valor predeterminado

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
            }
            return item;
        }

        public static void SaveToJsonGeneric<T>(string filePath, T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                File.WriteAllText(filePath, json);
                Console.WriteLine($"Datos guardados en el archivo JSON: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar datos en el archivo JSON: {ex.Message}");
                // También puedes lanzar la excepción para que sea manejada en niveles superiores si es necesario
                throw;
            }
        }
       
    }
       
    

}
