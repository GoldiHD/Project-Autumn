using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

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

        //Constructor
        public MySQL()
        {
            Initialize();
        }

        public void SetIp()
        {
            var Base = Directory.GetCurrentDirectory();
            string LinkToText = Base + @"\Assests\Settings.txt";
            if (!File.Exists(LinkToText))
            {
                using (StreamWriter Write = File.CreateText(LinkToText))
                {

                }

            }
            using (StreamReader Reader = new StreamReader(LinkToText))
            {
                server = Reader.ReadLine();
                Reader.Close();
            }
        }

        //Initialize values
        public void Initialize()
        {
            //10.11.4.156 Work
            //localhost local
            //192.168.1.83 home
            server = "0.0.0.0";
            database = "chat";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
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
                switch (ex.Number)
                {
                    case 0:
                        ConnectionError = "Offline";
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        break;
                }
                return false;
            }
        }
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
        }
        public int CountUsers()
        {
            string cmdText = "SELECT Count(*) FROM users";
            int num1 = -1;
            if (!this.OpenConnection())
                return num1;
            int num2 = int.Parse(string.Concat(new MySqlCommand(cmdText, this.connection).ExecuteScalar()));
            this.CloseConnection();
            return num2;
        }
    }
}
