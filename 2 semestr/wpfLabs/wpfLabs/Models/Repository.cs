using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
