using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private double _number;
        private string _buffer;
        private double _awnser;
        private bool _toSave;
        public Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
            _toSave = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void NumberButtons_Click(object sender, EventArgs e)
        {
            try
            {
                Button numberButton = (Button)sender;

                if (textBox1.Text == "0")
                {
                    textBox1.Text = numberButton.Text;
                }
                else
                {
                    textBox1.Text += numberButton.Text;
                }

            }
            catch (СustomExceptions ex)
            { 
                MessageBox.Show($"Error: {ex.Message}"); 
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {   
            if(textBox1.Text[0] == '-')
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = operation.Text;
            }
            else
            {
                double.TryParse(textBox1.Text, out _number);
                MessageBox.Show($"saved number: {_number}");
                textBox1.Text += operation.Text;
                MessageBox.Show($"{Math.Pow(_number, 2)}");
            }
            calc.OperationIdentify(operation.Text);
            
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            _awnser = calc.operation(_number); 
            textBox1.Text = _awnser.ToString();
            calc.Awnser = _awnser;
            if (_toSave)
            {
                calc.SaveResult();
            }
            _toSave = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _toSave = true; 
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.DownloadResult();
        }
    }
}
