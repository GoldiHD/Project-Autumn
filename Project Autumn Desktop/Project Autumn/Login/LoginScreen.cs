using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Autumn
{
    public partial class Form1 : Form
    {
        private string IP;
        public static string username;
        public static string UserPriv;
        private MySQL Connection = new MySQL();
        public string User;
        public string Pass;
        public string VersionNr = "Alpha 1.0-0001";
        private string[] version = (string[])null;
        private string[] Users = (string[])null;
        private string[] Password = (string[])null;
        private string[] email = (string[])null;
        private string[] Priv = (string[])null;

        public Form1()
        {
            starUpPing();
            List<string>[] stringListArray = new MySQL().SelectLogin();
            Users = stringListArray[1].ToArray();
            Password = stringListArray[2].ToArray();
            email = stringListArray[3].ToArray();
            Priv = stringListArray[4].ToArray();
            Connection.SetIp();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadMain()
        {
            username = User;
            Connection.UpdateLocation("Global", username);
            MainChat Portal = new MainChat();
            this.Hide();
            Portal.Show();
        }

        private void BuLogin_Click(object sender, EventArgs e)
        {
             User = TBUsername.Text;
             Pass = TBPassword.Text;
            TBUsername.Text = null;
            TBPassword.Text = null;
            int num = Connection.CountUsers();
            for (int i = 0; num > i; )
            {   
                if(User == Users[i] && BCrypt.CheckPassword(Pass, Password[i])) // maybe add lock account feature, trough admin panel unlock and lock/do timeouts
                {
                    Connection.SendChatMainLobby("SERVER", User + " Has logged in.");
                    IP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                    Connection.SendIPToServer(IP, User);
                    UserPriv = Priv[i];
                    LoadMain();
                }
               else if(User == email[i] && BCrypt.CheckPassword(Pass, Password[i]))
                {
                    //uses email for user name, change so it uses the username instead
                    LoadMain();
                }
                i++;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            AdminLogin portal = new AdminLogin();
            portal.Show();
            this.Hide();
        }

        private void BuUpdateLog_Click(object sender, EventArgs e)
        {
            Updatelog portal = new Updatelog();
            portal.Show();
            this.Hide();
        }

        private void BuLoginOption_Click(object sender, EventArgs e)
        {
            LoginOption portal = new LoginOption();
            portal.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            LaNewBuildVer.Visible = false;
            LaDownloadLink.Visible = false;
            TBUpdateLink.Visible = false;
            LaNewVer.Visible = false;
            int num = Connection.CountVersion();
            LaBuildNum.Text = VersionNr;
            version = mysql.SelectVersion()[1].ToArray();
            int index = num - 1;
            LaNewBuildVer.Text = version[index];
             if (version[index] == VersionNr)
            {
                TBUpdateLink.Visible = true;
                LaDownloadLink.Visible = true;
                LaNewVer.Visible = true;
                LaNewBuildVer.Visible = true;
            }
           
        }

        public void BGWLoginSession_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void PBLogo_Click(object sender, EventArgs e)
        {

        }

        private void starUpPing()
        {
            int timeout = 1000;
            Ping ping = new Ping();
            PingReply reply = ping.Send("10.11.2.5", timeout);
            if (reply.Status == IPStatus.Success)
            {
                
            }
            else
            {
                MessageBox.Show("Server is down");
                Application.Exit();
            }
        }
    }
}
