using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Project_Autumn
{




    public partial class MainChat : Form
    {
        private Random rnd = new Random();
        private string[] Id = (string[])null;
        private string[] Chat = (string[])null;
        private string[] Time = (string[])null;
        private string[] Users = (string[])null;
        private string[] location = (string[])null;
        bool lobby1Free = true;
        bool lobby2Free = true;
        bool lobby3Free = true;
        bool lobby4Free = true;
        bool FirstRun = true;
        int randomNumber;
        int AmountOfmessages2;
        int AmountOfmessages1;
        int AmountOfMessages;
        string LastId = "1";
        string randomsText;
        private string Sending;
        private MySQL Connection = new MySQL();
        string User;
        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);


        public MainChat()
        {
            User = Form1.username;
            InitializeComponent();
        }

        private void BuSendMessage_Click(object sender, EventArgs e)
        {
            if (!(TBChat.Text == ""))
            {
                Sending = TBChat.Text;
                CheckForCommandsInSendingText();
            }

        }

        private void CheckForCommandsInSendingText()
        {
            if (Sending.Contains("!edif"))
            {
                Process.Start("http://www.steffench.dk/erdetikkefredag.php");
            }


            else if (Sending.Contains("!freestuff"))
            {
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }

            else if (Sending.Contains("!glory"))
            {
                Process.Start("https://www.reddit.com/r/AyyMD/");
            }

            else if (Sending.Contains("!roll"))
            {
                Sending = Sending.Replace("!roll", "");
                randomNumber = rnd.Next(0, 100);
                if (randomNumber == 0)
                {
                    randomsText = " lel mate just staph already -";
                }
                else if (randomNumber >= 1 && randomNumber < 25)
                {
                    randomsText = "  LOL y u so bad m9- ";
                }
                else if (randomNumber >= 25 && randomNumber < 90)
                {
                    randomsText = "  LOL Must be rigged as fuck- ";
                }
                else if (randomNumber >= 90 && randomNumber < 98)
                {
                    randomsText = " Lol M8 too Ez- ";
                }
                else if (randomNumber < 98)
                {
                    randomsText = " Git gut nerds- ";
                }
                Sending = "!roll " + randomNumber + randomsText + Sending;
            }
            else if (Sending.Contains("!commands"))
            {
                Connection.SendChatMainLobby("SERVER", " Current commands are: !d, !shotsfired, !why, !fightme, !commands, !edif, !moneh, !glory, !roll, !freestuff, !mymoneh, (if admin) !ban (username), !givemonhey (username)");
            }

            else if (Sending.Contains("!mymoneh"))
            {
                //get current money from server then send normal message from server
            }

            else if (Sending.Contains("!givemoneh"))
            {
                //update current money then uupdate the other users money
            }

            Sending = Sending.Replace("!saltes", "( ͡° ͜ʖ ͡°) ( ͡°﹏ ͡°) ( ͡°_ ͡°)");
            Sending = Sending.Replace("!d", "༼つ ◕_◕ ༽つ");
            Sending = Sending.Replace("!moneh", "[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅]");
            Sending = Sending.Replace("!shotsfired", "┌( ͝° ͜ʖ͡°)=ε/̵͇̿̿/’̿’̿ ̿ ");
            Sending = Sending.Replace("!why", "ლ( `Д’ ლ)");
            Sending = Sending.Replace("!fightme", "(ง’̀-‘́)ง");
            SendTextToServer();
            TBChat.Text = null;
        }

        private void SendTextToServer()
        {
            Connection.SendChatMainLobby(Form1.username, Sending);
            if (AmountOfMessages > 30)
            {
                Connection.DeleteOverFlowMainLobby(Id[0]);
            }
        }

        private void MainChat_Load(object sender, EventArgs e)
        {
            if (Form1.UserPriv == "1")
            {
                BuUsers.Visible = true;
            }
            else
            {
                BuUsers.Visible = false;
            }
        }

        private void BuLogout_Click(object sender, EventArgs e)
        {
            Connection.UpdateLocation("Logged Out", Form1.username);
            Connection.SendChatMainLobby("SERVER", Form1.username + " Has logged out.");
            Form1 Portal = new Form1();
            Portal.Show();
            Close();
        }

        private void BuJoinLobby1_Click(object sender, EventArgs e)
        {
            if (lobby1Free)
            {
                Connection.UpdateLocation("Lobby 1", Form1.username);
                Lobby1 Portal = new Lobby1();
                Portal.Show();
                Close();
            }
            else
            {
                MessageBox.Show("The lobby is full");
            }
        }

        private void BuJoinLobby2_Click(object sender, EventArgs e)
        {
            if (lobby2Free)
            {
                Connection.UpdateLocation("Lobby 2", Form1.username);
                Lobby2 Portal = new Lobby2();
                Portal.Show();
                Close();
            }
            else
            {
                MessageBox.Show("The lobby is full");
            }
        }

        private void BuJoinLobby3_Click(object sender, EventArgs e)
        {
            if (lobby3Free)
            {
                Connection.UpdateLocation("Lobby 3", Form1.username);
                Lobby3 Portal = new Lobby3();
                Portal.Show();
                Close();
            }
            else
            {
                MessageBox.Show("The lobby is full");
            }
        }

        private void BuJoinLobby4_Click(object sender, EventArgs e)
        {
            if (lobby4Free)
            {
                Connection.UpdateLocation("Lobby 4", Form1.username);
                Lobby4 Portal = new Lobby4();
                Portal.Show();
                Close();
            }
            else
            {
                MessageBox.Show("The lobby is full");
            }
        }

        private void UpdateTick_Tick(object sender, EventArgs e)
        {
            UpdateTick.Enabled = false;
            AmountOfMessages = Connection.CountMainLobbyMessages();
            AmountOfmessages1 = AmountOfMessages;
            AmountOfmessages2 = AmountOfMessages;
            AmountOfmessages1--;
            if (AmountOfmessages1 != -1)
            {
                List<string>[] stringListArray = new MySQL().ReceiveMessagesMainLobby();
                Id = stringListArray[0].ToArray();
                Users = stringListArray[1].ToArray();
                Chat = stringListArray[2].ToArray();
                Time = stringListArray[3].ToArray();

                if (LastId != Id[AmountOfmessages1])
                {
                    RTBChatWindow.Text = null;
                    LastId = Id[AmountOfmessages1];
                    if (FirstRun)
                    {
                        FirstRun = false;
                        for (int i = 40; i >= 0;)
                        {
                            Chat[AmountOfmessages1 - i] = Chat[AmountOfmessages1 - i].Replace("/", "//");
                            Chat[AmountOfmessages1 - i] = Chat[AmountOfmessages1 - i].Replace("'", "/'");
                            RTBChatWindow.Text = RTBChatWindow.Text + " [ " + Time[AmountOfmessages1 - i] + " ] " + Users[AmountOfmessages1 - i] + ": " + Chat[AmountOfmessages1 - i] + Environment.NewLine;
                            i--;
                        }
                    }
                    else if (!FirstRun)
                    {
                        FlashWindow(Handle, false);
                        new SoundPlayer(Application.StartupPath + "\\Assests\\Sound.wav").Play();
                        FlashWindow(Handle, false);
                        for (int i = 40; i >= 0;)
                        {
                            RTBChatWindow.Text = RTBChatWindow.Text + Users[AmountOfmessages1 - i] + ": " + Chat[AmountOfmessages1 - i] + Environment.NewLine;
                            i--;
                        }

                    }
                    RTBChatWindow.SelectionStart = RTBChatWindow.Text.Length;

                    RTBChatWindow.ScrollToCaret();
                }
            }
            UpdateTick.Enabled = true;
        }

        private void BuMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LobbyState_Tick(object sender, EventArgs e)
        {
            int UsersIn1 = UserLocationChecker.UsersHowManyInlobby(1);
            int UsersIn2 = UserLocationChecker.UsersHowManyInlobby(2);
            int UsersIn3 = UserLocationChecker.UsersHowManyInlobby(3);
            int UsersIn4 = UserLocationChecker.UsersHowManyInlobby(4);
            if (UsersIn1 > 5)
            {
                lobby1Free = false;
                TBLobby1Status.BackColor = Color.Red;
            }
            else if (UsersIn1 <= 5)
            {
                lobby1Free = true;
                TBLobby1Status.BackColor = Color.LimeGreen;
            }



            if (UsersIn2 > 5)
            {
                lobby2Free = false;
                TBLobby2Status.BackColor = Color.Red;
            }
            else if (UsersIn2 <= 5)
            {
                lobby2Free = true;
                TBLobby2Status.BackColor = Color.LimeGreen;
            }

            if (UsersIn3 > 5)
            {
                lobby3Free = false;
                TBLobby3Status.BackColor = Color.Red;
            }
            else if (UsersIn3 <= 5)
            {
                lobby3Free = true;
                TBLobby3Status.BackColor = Color.LimeGreen;
            }

            if (UsersIn4 > 5)
            {
                lobby4Free = false;
                TBLobby4Status.BackColor = Color.Red;
            }
            else if (UsersIn4 <= 5)
            {
                lobby4Free = true;
                TBLobby4Status.BackColor = Color.LimeGreen;
            }


        }

        private void RTBChatWindow_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void BuUsers_Click(object sender, EventArgs e)
        {
            Users portal = new Users();
            portal.Show();
        }

        private void BuFriends_Click(object sender, EventArgs e)
        {
            Friends Portal = new Friends();
            Portal.Show();
        }
    }
}
/*
 *###### Notes ######
 *  Still neeed to make all signs safe
 *  
 *
 *
 *
 *
 *
 * 
 */
