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
    public partial class Form1 : Form
    {
        private MySQL Connection = new MySQL();
        public string User;
        public string Pass;
        public string[] version = (string[])null;
        public string[] Users = (string[])null;
        public string[] Password1 = (string[])null;
        public string[] Mode = (string[])null;
        public Form1()
        {
            Connection.SetIp();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {
            TBUsername.Text = User;
            TBPassword.Text = Pass;
            int num = Connection.
            Login();
        }

        private void Login()
        {
            //call on MySQL Lenght of table and conpent of table
            for(int i = 0; /*Lenght of tabel */i == 2; )
            {
                if(User == /**/)
                {

                }

                i++;
            }
        }

        private void LoadMain()
        {
            MainChat Portal = new MainChat(User);
            this.Hide();
            Portal.Show();
        }

        private void BuLogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BuUpdateLog_Click(object sender, EventArgs e)
        {

        }

        private void BuLoginOption_Click(object sender, EventArgs e)
        {

        }
    }
}
