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
        public static List<T> LoadFromJson<T>(string filePath)
        {
            List<T> items = new List<T>();

            try
            {
                
                
                string json = File.ReadAllText(filePath);
                items = JsonConvert.DeserializeObject<List<T>>(json);
                
            }
            catch (Exception ex)
            {
                string json = JsonConvert.SerializeObject(items);
                File.WriteAllText(filePath, json);
            }

            return items;
        }

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
                string json = JsonConvert.SerializeObject(default(T));
                File.WriteAllText(filePath, json);
            }

            return item;
        }

        public static void SaveToJson<T>(string filePath, List<T> items)
        {
            try
            {
                string json = JsonConvert.SerializeObject(items);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Manejar la excepción o registrarla según tus necesidades.
            }
        }
        public static void SaveToJsonGeneric<T>(string filePath, T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Manejar la excepción o registrarla según tus necesidades.
            }
        }
    }

}
