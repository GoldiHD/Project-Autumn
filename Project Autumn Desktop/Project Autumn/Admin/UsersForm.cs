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
    public partial class Users : Form
    {
        private string[] UsersArray = (string[])null;
        private int UserChoosen;
        private MySQL Connection = new MySQL();
        private int UsersLength;
        public Users()
        {
            InitializeComponent();
        }

        private void LBUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserChoosen = LBUsers.SelectedIndex;
            //openform where everything is moduler so you can make it for everyone
        }

        private void BuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            List<string>[] stringListArray = Connection.SelectLogin();
            UsersArray = stringListArray[1].ToArray();
            UsersLength = UsersArray.Length - 1;
            for(int i = 0; i >= UsersLength; i++)
            {
                LBUsers.Text = LBUsers.Text + UsersArray[i] + Environment.NewLine;
            }
        }

        private void TrackBTimeout_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBTimeout_ValueChanged(object sender, EventArgs e)
        {
            TBTrackBCurrentValue.Text = Convert.ToString(TrackBTimeout.Value);
        }

        private void BuBanUser_Click(object sender, EventArgs e)
        {
            //ban AKA Delete User
        }

        private void BuLockAccount_Click(object sender, EventArgs e)
        {
            //lock account, until un locked
        }

        private void BuTimeoutUser_Click(object sender, EventArgs e)
        {
            //do timeout based on trackbar
        }
    }
}

//make alt login in profile on mysql for admin with diffrent privileges
