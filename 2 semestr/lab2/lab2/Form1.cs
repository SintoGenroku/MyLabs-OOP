using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private string _contribution;
        private string _interestRate;
        private bool _contributionChanged;
        private bool _interestRateChanged;
        private BankAccount bankAcc;
        private Owner user;
        private List<string> CIScountries = new List<string> { "РБ", "рб", "РФ","рф","УКР","укр",};
        public List<Owner> UsersList { get; set; }
        private const string path = @"D:\2 course\2 sem\ООП\data.json";
       
        public Form1()
        {
            InitializeComponent();
            _contributionChanged = false;
            _interestRateChanged = false;
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
            if (!CIScitizen())
            {
                MessageBox.Show("Банк работает только с гражданами Беларуси, России и Украины");
            }
            else if(_contributionChanged & _interestRateChanged)
            {

                bankAcc = new BankAccount(AccCreationDate.Value, Int32.Parse(Cash.Text), _contribution, _interestRate);
                user = new Owner(bankAcc, BirthDate.Value, FullName.Text, PassportInfo.Text, Citizenship.Text, SMSCheckBox.Checked, NetBankingCheckBox.Checked);
                Form2 userInfo = new Form2(user, bankAcc);
                UsersList.Add(user);
                FormCleaner();
                userInfo.Show();
                OutputBox.Text += user.ShowInfo();
            }
            else
            {
                MessageBox.Show("Выберите тип вклада");
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
                _contributionChanged = true;
            }
            

        }

        private void InterestChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                _interestRate = button.Text;
                _interestRateChanged = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            _contributionChanged = false;
            _interestRateChanged = false;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearOutputBox_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
        }

        private bool CIScitizen()
        {

            return CIScountries.Contains(Citizenship.Text);
        }
    }
}
