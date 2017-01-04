using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Autumn
{
    public partial class AdminLogin : Form
    {
        private MySQL Connection = new MySQL();
        private string[] Users = (string[])null;
        private string[] Password = (string[])null;
        private string[] privileges = (string[])null;
        public string User;
        public string Pass;

        public AdminLogin()
        {
            List<string>[] stringListArray = new MySQL().SelectLogin();
            Users = stringListArray[1].ToArray();
            Password = stringListArray[2].ToArray();
            privileges = stringListArray[4].ToArray();
            InitializeComponent();
        }

        private void BuLogin_Click(object sender, EventArgs e)
        {
            int num = Connection.CountUsers();
            num--;
            for (int i = 0; num >= i;)
            {
                User = TBUsername.Text;
                Pass = TBPassword.Text;
                if (User == Users[i] && BCrypt.CheckPassword(Pass, Password[i]) && privileges[i] == "1")
                {
                    Loadpanel();
                }
                i++;
            }

        }

        private void Loadpanel()
        {
            AdminPanel Portal = new AdminPanel();
            Portal.Show();
            this.Close();
        }

        private void BuBack_Click(object sender, EventArgs e)
        {
            Form1 Portal = new Form1();
            Portal.Show();
            this.Hide();
        }
    }
}
