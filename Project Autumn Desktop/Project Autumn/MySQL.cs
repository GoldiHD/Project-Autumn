using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Project_Autumn
{
    class MySQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public string ConnectionError;

        public MySQL()
        {
            Initialize();
        }
        public void SetIp()
        {
            string textfilelocation = Application.StartupPath + "\\Assests\\Settings.txt";
            if (!File.Exists(textfilelocation))
            {
                using (StreamWriter Write = File.CreateText(textfilelocation))
                {

                }
            }
            using (StreamReader Reader = new StreamReader(textfilelocation))
            {
                server = Reader.ReadLine();
                database = Reader.ReadLine();
                uid = Reader.ReadLine();
                password = Reader.ReadLine();
                Reader.Close();
            }
        } //sets the default ip or custome ip
        public void Initialize()
        {
            SetIp();
            connection = new MySqlConnection("SERVER=" + this.server + ";DATABASE=" + this.database + ";UID=" + this.uid + ";PASSWORD=" + this.password + ";");
        }
        public bool OpenConnection()
        {
            Initialize();

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                int timeout = 1000;
                Ping ping = new Ping();
                PingReply ReplyGoogle = ping.Send("8.8.8.8", timeout);
                if (ReplyGoogle.Status == IPStatus.Success)
                {
                    PingReply ReplyServer = ping.Send("10.11.2.5", timeout);
                    if(ReplyServer.Status == IPStatus.Success)
                    {
                        ConnectionError = ex.Number.ToString();
                        MessageBox.Show("Some error happend. error code: "+ConnectionError);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Server seems to be down");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("You don't seem to have any connection");
                    return false;
                }
            }
        }//opens conncetion and check for connection and access to server, also reports any errors, under connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }   //closes connection
        public int CountUsers()
        {
            string cmdText = "SELECT Count(*) FROM users";
            int num1 = -1;
            if (!this.OpenConnection())
                return num1;
            int num2 = int.Parse(string.Concat(new MySqlCommand(cmdText, this.connection).ExecuteScalar()));
            this.CloseConnection();
            return num2;
        }// count how many user we have, used in login to do a for loop to check all accounts login
        public int CountVersion()
        {
            string cmdText = "SELECT Count(*) FROM version";
            int num1 = -1;
            if (!this.OpenConnection())
                return num1;
            int num2 = int.Parse(string.Concat(new MySqlCommand(cmdText, this.connection).ExecuteScalar()));
            this.CloseConnection();
            return num2;
        }//check which version we're on
        public void UpdateLocation(string Location, string Username)
        {
            string str = "UPDATE users SET location ='" + Location + "' WHERE username='" + Username + "'";
            if (!this.OpenConnection())
                return;
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = str;
            mySqlCommand.Connection = this.connection;
            mySqlCommand.ExecuteNonQuery();
            this.CloseConnection();
        }//Change what location other people see you in
        public void UpdateMode(string Mode, string Username)
        {
            string str = "UPDATE users SET mode ='" + Mode + "' WHERE username='" + Username + "'";
            if (!this.OpenConnection())
                return;
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = str;
            mySqlCommand.Connection = this.connection;
            mySqlCommand.ExecuteNonQuery();
            this.CloseConnection();
        } //Change your current mode (Online/Offline)
        public List<string>[] SelectVersion()
        {
            string cmdText = "SELECT * FROM version";
            List<string>[] stringListArray = new List<string>[2] { new List<string>(), new List<string>() };
            if (!this.OpenConnection())
                return stringListArray;
            MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, this.connection).ExecuteReader();
            while (mySqlDataReader.Read())
            {
                stringListArray[0].Add(string.Concat(mySqlDataReader["id"]));
                stringListArray[1].Add(string.Concat(mySqlDataReader["version"]));
            }
            mySqlDataReader.Close();
            this.CloseConnection();
            return stringListArray;
        }   // checks  version to make sure we're on the newst
        public List<string>[] SelectLogin()
        {
            string cmdText = "SELECT * FROM users";
            List<string>[] stringListArray = new List<string>[7] { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>()};
            if (!this.OpenConnection())
                return stringListArray;
            MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, this.connection).ExecuteReader();
            while (mySqlDataReader.Read())
            {
                stringListArray[0].Add(string.Concat(mySqlDataReader["Id"]));
                stringListArray[1].Add(string.Concat(mySqlDataReader["username"]));
                stringListArray[2].Add(string.Concat(mySqlDataReader["password"]));
                stringListArray[3].Add(string.Concat(mySqlDataReader["email"]));
                stringListArray[4].Add(string.Concat(mySqlDataReader["privileges"]));
                stringListArray[5].Add(string.Concat(mySqlDataReader["location"]));
                stringListArray[6].Add(string.Concat(mySqlDataReader["mode"]));
            }
            mySqlDataReader.Close();
            CloseConnection();
            return stringListArray;
        }    //checks all login so we can compare them

        public void SendIPToServer(string IP, string Username)
        {
            string str = "UPDATE users SET lastloginip ='" + IP + "' WHERE username ='" + Username + "'";
            if (!this.OpenConnection())
                return;
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = str;
            mySqlCommand.Connection = this.connection;
            mySqlCommand.ExecuteNonQuery();
            this.CloseConnection();
        }


        public void SendChatMainLobby(string User, string message)
        {
            string query = "INSERT INTO mainlobby (sentfrom, message) VALUES('" + User + "', '" + @message + "')";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }// Main lobby send message to server
        public void DeleteOverFlowMainLobby(string id)
        {
            string query = "DELETE FROM chat WHERE id='" + id + "'";
        }   //deletes overflow messages
        public int CountMainLobbyMessages()
        {
            string cmdText = "SELECT Count(*) FROM mainlobby";
            int num1 = -1;
            if (!this.OpenConnection())
                return num1;
            int num2 = int.Parse(string.Concat(new MySqlCommand(cmdText, this.connection).ExecuteScalar()));
            this.CloseConnection();
            return num2;
        }   // count all the messages in the lobby so if there is too many it will delete one when you send a message
        public List<string>[] ReceiveMessagesMainLobby()
        {
            string query = "SELECT * FROM mainlobby";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Id"] + "");
                    list[1].Add(dataReader["sentfrom"] + "");
                    list[2].Add(dataReader["message"] + "");
                    list[3].Add(dataReader["currenttime"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }   // Main lobby reading messages so it can display them
        public void SendLobby1(string User, string message)
        {
            string query = "INSERT INTO lobby1 (sentfrom, message) VALUES('" + User + "', '" + message + "')";
            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();

            }
        } // Lobby 1 sending a message to the server
        public List<string>[] ReceivedMessafesLobby1()
        {
            string query = "SELECT * FROM lobby1";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Id"] + "");
                    list[1].Add(dataReader["sentfrom"] + "");
                    list[2].Add(dataReader["message"] + "");
                    list[3].Add(dataReader["currenttime"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        } //Lobby 1 reading messages so it can display them
        public int CountLobby1Messages()
        {
            string cmdText = "SELECT Count(*) FROM lobby1";
            int num1 = -1;
            if (!this.OpenConnection())
                return num1;
            int num2 = int.Parse(string.Concat(new MySqlCommand(cmdText, this.connection).ExecuteScalar()));
            this.CloseConnection();
            return num2;
        }//Lobby1 Count all the messages to check for overflow
        public List<string>[] UsersLocationLobbies()
        {
            string cmdText = "SELECT * FROM users";
            List<string>[] stringListArray = new List<string>[1] { new List<string>() };
            if (!OpenConnection())
                return stringListArray;
            MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, connection).ExecuteReader();
            while(mySqlDataReader.Read())
            {
                stringListArray[0].Add(string.Concat(mySqlDataReader["Location"]));
            }
            mySqlDataReader.Close();
            CloseConnection();
            return stringListArray;
        }//used for lobby to check how many of them are in what Lobby
        public void DeleteOverFlowLobby1(string id)
        {
            string query = "DELETE FROM chat WHERE id='" + id + "'";
        }
        public void TestToCreatUserChats(string Username)//test
        {
            string query = "CREATE TABLE '" + Username + "'(Id int(30) auto_increment primary key, sentfrom varchar(64), message varchar(1024), currenttime datetime(64))";
            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void TestDeletingTableAgain(string TableName)
        {

        }

        /*
         * Plans to make so you create a new lobby/table when pming to people(currently in testing form)
         * Delete table after users have ended the pm 
         * Need some way to check if a user is deleted, then the table with the user is closed too, could do pings to each other
         * 
         * 
        */
    }

}

