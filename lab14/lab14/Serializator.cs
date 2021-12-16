using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;

namespace lab14
{
    static class Serializator
    {

        public static void ToJson(Circle obj) 
        {
            string json = JsonSerializer.Serialize(obj);
        }
    }
}
