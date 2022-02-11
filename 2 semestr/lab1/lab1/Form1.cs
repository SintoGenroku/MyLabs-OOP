using System;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string _buffer;
        private double _awnser;
        private bool _toSave;
        private bool _isOperationChoosed;
        private int _doubleclick;
        public Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
            _toSave = false;
            _isOperationChoosed = false;
            _buffer = "0";
            _doubleclick = 1;
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
                    _buffer = numberButton.Text;

                }
                else
                {
                    textBox1.Text += numberButton.Text;
                    _buffer += numberButton.Text;
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
            _buffer = "0";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "-";
                _buffer = "-";
            }
            else if (textBox1.Text[0] == '-')
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
                _buffer = _buffer.Remove(0, 1);
            }
            else 
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");
                _buffer = _buffer.Insert(0, "-");
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            calc.OperationIdentify(operation.Text);
            _isOperationChoosed = true;
            
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (_isOperationChoosed)
            {
                _awnser = calc.operation(double.Parse(_buffer));
                _awnser = Math.Round(_awnser, 4);
                textBox1.Text = _awnser.ToString();
                calc.Awnser = _awnser;
                if (_toSave)
                {
                    calc.SaveResult();
                }
                _buffer = "0";
                _toSave = false;
            }
            else
            {
                calc.NothingChoosed();

            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _toSave = true; 
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.DownloadResult();
        }

        private void PreOperation_Click(object sender, EventArgs e)
        { 
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text.Insert(0, button.Text);
        }
        private void PostOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text.Insert(_buffer.Length, button.Text);
        }

        private void Button1_DoubleClick(object sender, EventArgs e)
        {
            _doubleclick = ~ _doubleclick;
            if(_doubleclick == 1)
            {
                MessageBox.Show("DDDDouble cliccckk");
            }
            
        }
    }
}
