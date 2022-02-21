
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace lab2
{
    static class Serializator
    {
        public static void ToJson(List<Owner> users, string path)
        {
            var jstr = JsonConvert.SerializeObject(users);
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate)) 
            {
                var array = System.Text.Encoding.Default.GetBytes(jstr);
                fstream.Write(array, 0, array.Length);
            }
        }

        public static List<Owner> FromJson(string path)
        {
            string users;
            using (FileStream fstream = File.OpenRead(path))
            {
                var array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                users = System.Text.Encoding.Default.GetString(array);
            }
            
            return JsonConvert.DeserializeObject<List<Owner>>(users);


        }
    }
}
