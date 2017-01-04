using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Autumn
{
    public partial class Lobby1 : Form
    {
        private List<string> UsersInLobby = null;
        private List<string> UsersInLobbyLast = null;
        private string[] Id = (string[])null;
        private string[] Chat = (string[])null;
        private string[] Time = (string[])null;
        private string[] Users = (string[])null;
        private string[] location = (string[])null;
        private string User;
        private MySQL Connection = new MySQL();
        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);
        private string LastId = "1";
        private string sending;
        private bool FirstRun;
        private int AmountOfMessages;
        private int AmountOfMessages1;
        private int AmountOfMessages2;


        public Lobby1()
        {
            User = Form1.username;
            InitializeComponent();
        }

        private void BuLobby_Click(object sender, EventArgs e)
        {
            Connection.UpdateLocation("Global", Form1.username);
            MainChat Portal = new MainChat();
            Portal.Show();
            this.Close();
        }

        private void InLobbyChecker_Tick(object sender, EventArgs e) /// needs debugging ####### Priority
        {
            UsersInLobby = UserLocationChecker.UsersInLobby("Lobby 1");
            if (UsersInLobby == UsersInLobbyLast)
            {

            }
            else
            {
                LBUsersInLobby.Items.Clear();
                for (int i = 0; i <= (UsersInLobby.Count - 1); i++)
                {
                    LBUsersInLobby.Items.Add(UsersInLobby[i]);
                }
                UsersInLobbyLast = UsersInLobby;
            }
        }

        private void BuSend_Click(object sender, EventArgs e)
        {
            if (!(TBChat.Text == ""))
            {
                sending = TBChat.Text;
                Connection.SendLobby1(Form1.username, sending);
                TBChat.Text = null;
                if (AmountOfMessages > 30)
                {
                    Connection.DeleteOverFlowLobby1(Id[0]);
                }
            }
        }

        private void LaTitle_Click(object sender, EventArgs e)
        {

        }//Error

        private void UpdateTick_Tick(object sender, EventArgs e)
        {
            UpdateTick.Enabled = false;
            AmountOfMessages = Connection.CountLobby1Messages();
            AmountOfMessages1 = AmountOfMessages;
            AmountOfMessages2 = AmountOfMessages;
            if(AmountOfMessages1 != -1)
            {
                List<string>[] stringListArray = new MySQL().ReceivedMessafesLobby1();
                Id = stringListArray[0].ToArray();
                Users = stringListArray[1].ToArray();
                Chat = stringListArray[2].ToArray();
                Time = stringListArray[3].ToArray();
                AmountOfMessages1--;
                if (LastId != Id[AmountOfMessages1])
                {
                    RTBChatWindow.Text = null;
                    LastId = Id[AmountOfMessages1];

                    if(FirstRun)
                    {
                        FirstRun = false;
                        for (int i = 40; i >= 0;)
                        {
                            RTBChatWindow.Text = RTBChatWindow.Text + " [ "+ Time[AmountOfMessages1 - i] + " ] " + Users[AmountOfMessages1 - i] + ": " + Chat[AmountOfMessages1 - i] + Environment.NewLine;
                            i--;
                        }
                    }
                    else if (!FirstRun)
                    {
                        FlashWindow(Handle, false);
                        new SoundPlayer(Application.StartupPath + "\\Assests\\Sound.wav").Play();
                        FlashWindow(Handle, false);
                        if (AmountOfMessages1 > 41)
                        {
                            for (int i = 40; i >= 0;)
                            {
                                RTBChatWindow.Text = RTBChatWindow.Text + Users[AmountOfMessages1 - i] + ": " + Chat[AmountOfMessages1 - i] + Environment.NewLine;
                                i--;
                            }
                        }
                        else
                        {
                            for (int i = AmountOfMessages1; i >= 0;)
                            {
                                RTBChatWindow.Text = RTBChatWindow.Text + Users[AmountOfMessages1 - i] + ": " + Chat[AmountOfMessages1 - i] + Environment.NewLine;
                                i--;
                            }
                        }
                        RTBChatWindow.SelectionStart = RTBChatWindow.Text.Length;
                        RTBChatWindow.ScrollToCaret();
                    }
                }
                UpdateTick.Enabled = true;
            }

        }

        private void BuAddFriend_Click(object sender, EventArgs e)
        {
            if (!(LBUsersInLobby.SelectedIndex == -1))
            {
                AddChangeRemoveFriend.AddFriend(LBUsersInLobby.GetItemText(LBUsersInLobby.SelectedItem));
                MessageBox.Show("Friend: " + LBUsersInLobby.GetItemText(LBUsersInLobby.SelectedItem) + " has been added to your friend list");
            }
        }

        private void Lobby1_Load(object sender, EventArgs e)
        {
            LBUsersInLobby.Items.Clear();
            UsersInLobby = UserLocationChecker.UsersInLobby("Lobby 1");
            for (int i = 0; i <= (UsersInLobby.Count - 1); i++)
            {
                LBUsersInLobby.Items.Add(UsersInLobby[i]);
            }
            UsersInLobby = UsersInLobbyLast;
        }
    }
}
