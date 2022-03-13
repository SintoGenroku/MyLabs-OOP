using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public sealed class SingletonSerializator
    {
        private string _path = @"D:\2 course\2 sem\ООП\data.json";
        private static readonly Lazy<SingletonSerializator> Lazy = new Lazy<SingletonSerializator>(() => new SingletonSerializator());
        private SingletonSerializator() { }

        public static SingletonSerializator GetInstance() => Lazy.Value;

        public void ToJson(List<Owner> users)
        {
            var jstr = JsonConvert.SerializeObject(users);
            using (StreamWriter fstream = new StreamWriter(_path))
            {
                //var array = System.Text.Encoding.Default.GetBytes(jstr);
                fstream.Write(jstr);
            }
        }

        public async Task<List<Owner>> FromJson()
        {
            string users;
            using (var streamReader = new StreamReader(_path))
            {
                users = await streamReader.ReadToEndAsync();

            }
            
            return JsonConvert.DeserializeObject<List<Owner>>(users);
        }
      /*  private void DeserializeButton_Click(object sender, EventArgs e)
        {
            using var fs = new StreamReader(@"./data.json");
            var data = fs.ReadToEnd();
            var accounts = JsonConvert.DeserializeObject < List < Account»(data);
            Bank.Accounts = accounts;
            ResultTextBox.Text = "";
            foreach (var item in Bank.Accounts)
            {
                ResultTextBox.Text += item.ToString();
            }
        }*/
    }

}
