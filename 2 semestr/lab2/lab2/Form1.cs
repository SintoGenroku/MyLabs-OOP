using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace lab2
{
    public partial class Form1 : Form
    {
        private string _contribution;
        private string _interestRate;
        private BankAccount bankAcc;
        private Owner user;
        public List<Owner> UsersList { get; set; }
        private const string path = @"D:\2 course\2 sem\ООП\data.json";
       
        public Form1()
        {
            InitializeComponent();
            UsersList = new List<Owner>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {

                UserValidator validator = new UserValidator(FullName.Text, PassportInfo.Text, Citizenship.Text, _contribution, _interestRate);
                var results = new List<ValidationResult>();
                var context = new ValidationContext(validator);
            if (!Validator.TryValidateObject(validator, context, results, true))
            {
                    string err = "\tЧто-то пошло не так...\n\n";
                    foreach (var error in results)
                    {
                        err += error.ErrorMessage + "\n";
                    }
                    MessageBox.Show(err);
                }
            else
            {
                bankAcc = new BankAccount(AccCreationDate.Value, Int32.Parse(Cash.Text), _contribution, _interestRate);
                user = new Owner(bankAcc, BirthDate.Value, FullName.Text, PassportInfo.Text, Citizenship.Text, SMSCheckBox.Checked, NetBankingCheckBox.Checked);
                FormCleaner();
                OutputBox.Text += user.ShowInfo();
            }
                

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Cash.Text = CashTrackBar.Value.ToString(); 
        }

        private void ContributionChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if(button.Checked)
            {
                _contribution = button.Text;
            }    

        }

        private void InterestChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                _interestRate = button.Text;
            }
        }

        private void DownloadFromJson_Click(object sender, EventArgs e)
        {
           
            UsersList = Serializator.FromJson(path);
            foreach(var user in UsersList)
            {
                OutputBox.Text += user.ShowInfo();
            }
        }

        private void SaveToJson_Click(object sender, EventArgs e)
        {
            Serializator.ToJson(UsersList, path);
        }

        private void FormCleaner()
        {
            FullName.Text = "";
            PassportInfo.Text = "";
            Citizenship.Text = "";
            Cash.Text = "1000";
            CashTrackBar.Value = CashTrackBar.Minimum;
            SMSCheckBox.Checked = false;
            NetBankingCheckBox.Checked = false;

        }

        private void ClearOutputBox_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
        }


        private void ToolsAboutButton_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Show();
        }


    }
}
