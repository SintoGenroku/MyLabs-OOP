using System;
using System.Windows.Forms;

namespace lab1
{
    public class ICalculate
    {
         public double Sinus(double buff)
        {
            MessageBox.Show($"I work lik sinus");
            return Math.Sin(buff);
        }
        public double Cosinus(double buff)
        {
            MessageBox.Show($"I work lik cos");
            return Math.Cos(buff);
        }
        public double Tangence(double buff)
        {
            MessageBox.Show($"I work lik tg");
            return Math.Tan(buff);
        }
        public double Catangence(double buff)
        {
            MessageBox.Show($"I work lik ctg");
            return 1.0/Math.Tan(buff);
        }
        public double SquareRoot(double buff) 
        {
            MessageBox.Show($"I work lik sqr root");
            return Math.Sqrt(buff);
        }
        public double CubeRoot(double buff) 
        {
            MessageBox.Show($"I work lik cube root");
            return Math.Pow(buff,1/3f);
        }
        public  double SecDegree(double buff) 
        {
            MessageBox.Show($"I work lik secdeg");
            return Math.Pow(buff,2);
        }
        public double ThirdDegree(double buff) 
        {
            MessageBox.Show($"I work lik tird deg");
            return Math.Pow(buff, 3);
        }

        public void SaveResult(){}
        public void DownloadResult(){}
    }
}
