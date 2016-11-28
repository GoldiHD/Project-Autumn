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
    public partial class MainChat : Form
    {
        string User;
        public MainChat(string Users)
        {
            User = Users;
            InitializeComponent();
        }

        private void BuSendMessage_Click(object sender, EventArgs e)
        {
            string hello;//temp
            hello = RTBChatWindow.Text;
            //send tb content to server
        }

        private void MainChat_Load(object sender, EventArgs e)
        {

        }

        private void BuLogout_Click(object sender, EventArgs e)
        {
            Form1 Portal = new Form1();
            Portal.Show();
            this.Hide();
        }

        private void BuJoinLobby1_Click(object sender, EventArgs e)
        {
            Lobby1 Portal = new Lobby1();
            Portal.Show();
            this.Hide();
        }

        private void BuJoinLobby2_Click(object sender, EventArgs e)
        {
            Lobby2 Portal = new Lobby2();
            Portal.Show();
            this.Hide();
        }

        private void BuJoinLobby3_Click(object sender, EventArgs e)
        {
            Lobby3 Portal = new Lobby3();
            Portal.Show();
            this.Hide();
        }

        private void BuJoinLobby4_Click(object sender, EventArgs e)
        {
            Lobby4 Portal = new Lobby4();
            Portal.Show();
            this.Hide();
        }
    }
}
