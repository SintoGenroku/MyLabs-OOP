using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace wpfLabs
{
    public static class Repository
    {
        static string _path = @"../../../data.json";


        public static ObservableCollection<Product> LoadProducts()
        {
            var products = new ObservableCollection<Product>();
            string data;
            using (var fstream = new StreamReader(_path))
            {
                data = fstream.ReadToEnd();

            }
            return JsonConvert.DeserializeObject<ObservableCollection<Product>>(data);
        }

    }
}
