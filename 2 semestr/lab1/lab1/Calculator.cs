using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public delegate double Operation(double buff);
    
    public class Calculator : ICalculate
    {
        public Operation operation;
        public string Path = @"D:\MyRepos\MyLabs-OOP\2 semestr\lab1";
        public double Awnser { get; set; }
        public string FromFile { 
            get 
            {
                return _fromfile; 
            }
            set 
            {
                FromFile = _fromfile; 
            }
        }
        private string _fromfile;

        public Calculator()
        {
            _fromfile = "0";
            Awnser = 0;
            operation = Sinus;
        }

        new public void SaveResult() 
        {
            using (FileStream fstream = new FileStream($@"{Path}\text.txt", FileMode.OpenOrCreate))
                {
                byte[] array = Encoding.Default.GetBytes(Awnser.ToString());
                fstream.Write(array, 0, array.Length);
            }
        
        }
        new public string DownloadResult()
        {
            using (FileStream fstream = File.OpenRead($@"{Path}\text.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                _fromfile = Encoding.Default.GetString(array);
                return _fromfile;
            }
        }

        public void OperationIdentify(string op) 
        {
            switch (op)
            {
                case "sin":
                    operation = Sinus;
                    break;
                case "cos":
                    operation = Cosinus;
                    break;
                case "tan":
                    operation = Tangence;
                    break;
                case "ctg":
                    operation = Catangence;
                    break;
                case "√":
                    operation = SquareRoot;
                    break;
                case "∛":
                    operation = CubeRoot;
                    break;
                case "^2":
                    operation = SecDegree;
                    break;
                case "^3":
                    operation = ThirdDegree;
                    break;
            }
        }
    }
}
