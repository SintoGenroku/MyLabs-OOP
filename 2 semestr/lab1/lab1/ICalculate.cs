using System;
using System.Windows.Forms;

namespace lab1
{
    public class ICalculate
    {
         public double Sinus(double buff)
        {
            return Math.Sin(buff);
        }
        public double Cosinus(double buff)
        {
            return Math.Cos(buff);
        }
        public double Tangence(double buff)
        {
            return Math.Tan(buff);
        }
        public double Catangence(double buff)
        {
            return 1.0/Math.Tan(buff);
        }
        public double SquareRoot(double buff) 
        {
            return Math.Sqrt(buff);
        }
        public double CubeRoot(double buff) 
        {
            return Math.Pow(buff,1/3f);
        }
        public  double SecDegree(double buff) 
        {
            MessageBox.Show($"{Math.Pow(buff, 2)}");
            return Math.Pow(buff,2);
        }
        public double ThirdDegree(double buff) 
        {
            return Math.Pow(buff, 3);
        }

        public void SaveResult(){}
        public void DownloadResult(){}
    }
}
