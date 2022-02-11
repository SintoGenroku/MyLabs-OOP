using System;
using System.Windows.Forms;

namespace lab1
{
    public class ICalculate
    {
         public double Sinus(double buff)
        {
            double rad = buff * (Math.PI / 180.0);

            return Math.Sin(rad);
            
        }
        public double Cosinus(double buff)
        {
            double rad = buff * (Math.PI / 180.0);
            return Math.Cos(rad);
        }
        public double Tangence(double buff)
        {
            double rad = buff * (Math.PI / 180.0);
            return Math.Tan(rad);
        }
        public double Catangence(double buff)
        {
            double rad = buff * (Math.PI / 180.0);
            return 1.0/Math.Tan(rad);
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
            return Math.Pow(buff,2);
        }
        public double ThirdDegree(double buff) 
        {
            return Math.Pow(buff, 3);
        }

        public void NothingChoosed() 
        {
            MessageBox.Show("Выберите операцию");
        }
        public void SaveResult(){}
        public void DownloadResult(){}
    }
}
