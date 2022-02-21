using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Owner user;
        BankAccount bankAcc;
        public Form2(Owner user, BankAccount bankAcc)
        {
            InitializeComponent();
            this.user = user;
            this.bankAcc = bankAcc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = user.fullname;
            label6.Text = user.nation;
            label7.Text = user.bankAccount.creationDate.ToString();
            label8.Text = $"{ user.bankAccount.cash.ToString()} USD";
        }
    }
}
