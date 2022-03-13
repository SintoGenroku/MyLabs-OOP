using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    using S = SingletonSerializator;
    public partial class Form1 : Form
    {
        private string _contribution;
        private string _interestRate;
        private BankAccount bankAcc;
        private Owner user;
        public List<Owner> UsersList { get; set; }
        public List<Owner> SortedUsersList { get; set; }
       

        public Form1()
        {
            InitializeComponent();
            SortedUsersList = new List<Owner>();
            UsersList = new List<Owner>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
                UsersList.Add(user);
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

        private async void DownloadFromJson_Click(object sender, EventArgs e)
        {
            var FileWriter = S.GetInstance();
            UsersList = await FileWriter.FromJson();
            foreach(var user in UsersList)
            {
                OutputBox.Text += user.ShowInfo();
            }
        }

        private void SaveToJson_Click(object sender, EventArgs e)
        {
            var FileWriter = S.GetInstance();
            FileWriter.ToJson(UsersList);
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

        private void FullNameSearch(object sender, EventArgs e)
        {
           
            if(UsersList.Count == 0)
            {
                OutputBox.Text = "Список пользователей пуст!";
            }
            else
            {
                OutputBox.Text = "";
                var searchlist = UsersList.Where(x => x.fullname.Contains(FullnameToSearch.Text)); 
                if(searchlist.Count() > 0)
                {
                    SortedUsersList.Clear();
                    foreach (var user in UsersList)
                    { 
                        OutputBox.Text += user.ShowInfo();
                        SortedUsersList.Add(user);
                    }
                }
                else
                {
                    OutputBox.Text = "Совпадений  по ФИО нет:(";
                }
                
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ContributionToSerachChanged(object sender, EventArgs e)
        {
            var searchlist = UsersList.Where(x => x.bankAccount.ContributionType == ContributionType.Text);
            if (searchlist.Count() > 0)
            {
                SortedUsersList.Clear();
                OutputBox.Text = "";
                foreach (var user in searchlist)
                {
                    OutputBox.Text += user.ShowInfo();
                    SortedUsersList.Add(user);
                }
            }
            else
            {
                OutputBox.Text = "Совпадений по типу вклада нет:(";
            }
        }

        private void CashSearchChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CashSize.Text))
            {
                var searchlist = UsersList.Where(x => x.bankAccount.Cash - 1000 < Int32.Parse(CashSize.Text) & Int32.Parse(CashSize.Text) < x.bankAccount.Cash + 1000);
                if (searchlist.Count() > 0)
                {
                    SortedUsersList.Clear();
                    OutputBox.Text = "";
                    foreach (var user in searchlist)
                    {
                        OutputBox.Text += user.ShowInfo();
                        SortedUsersList.Add(user);
                    }
                }
                else
                {
                    OutputBox.Text = "Совпадений по балансу нет:(";
                }
            }
        }
    
        private void SaveSorted(object sender, EventArgs e)
        {
            var FileWriter = S.GetInstance();
            FileWriter.ToJson(SortedUsersList);
        }

        private void SortByDate(object sender, EventArgs e)
        {
            var searchlist = UsersList.OrderBy(x => x.bankAccount.creationDate);
            if (searchlist.Count() > 0)
            {
                SortedUsersList.Clear();
                OutputBox.Text = "";
                foreach (var user in searchlist)
                {
                    OutputBox.Text += user.ShowInfo();
                    SortedUsersList.Add(user);
                }
            }
            else
            {
                MessageBox.Show("список пользователей пуст!");
            }
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            if (UsersList.Any())
            {
                var Clone = UsersList.Last().DeepCopy();
                Clone.fullname += "V 2.0";
                MessageBox.Show(Clone.ShowInfo());
            }
            else
            {
                MessageBox.Show("Нету заригестрированных пользователей");
            }
            
        }

        private void BuilderUpdate_Click(object sender, EventArgs e)
        {
            if (UsersList.Count != 0) 
            {
                BuilderUpdate form = new BuilderUpdate(UsersList.Last());
                form.ShowDialog();
                form.FormClosed += ShowListUpdate;
            }
            else
            {
                MessageBox.Show("Нету зарегестрированных пользователей!");
            }
            
        }

        private void ShowListUpdate(object sender, FormClosedEventArgs e)
        {
            OutputBox.Text = "";
            foreach (var user in UsersList)
            {
                OutputBox.Text += user.ShowInfo();
            }
        }
    }
}
