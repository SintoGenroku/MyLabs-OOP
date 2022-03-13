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
    public partial class BuilderUpdate : Form
    {
        Owner User;
        Builder builder;
        Director director;

        public BuilderUpdate(Owner User)
        {
            InitializeComponent();
            this.User = User;
            builder = new ConcreteBuilder();
            director = new Director(builder);
        }


        private void Change_Click(object sender, EventArgs e)
        {
            director.Construct(User, CashReset.Checked, SmsReset.Checked, AppReset.Checked);
            User = builder.GetUser();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            label1.Text += $"\n{User.fullname}";
        }
    }
}
