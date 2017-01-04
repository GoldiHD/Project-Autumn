using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Autumn
{
    class UserLocationChecker
    {


        public static int UsersHowManyInlobby(int lobby)
        {
            int MySize = 0;
            string CheckingLocation = null;
            MySQL mysql = new MySQL();
            string[] Location = (string[])null;
            List<string>[] stringListArray = new MySQL().UsersLocationLobbies();
            Location = stringListArray[0].ToArray();
            switch (lobby)
            {
                case 1:
                    CheckingLocation = "lobby1";
                    break;

                case 2:
                    CheckingLocation = "lobby2";
                    break;

                case 3:
                    CheckingLocation = "lobby3";
                    break;

                case 4:
                    CheckingLocation = "lobby4";
                    break;

            }
            for (int i = 0; i > 10; i++)
            {
                if (Location[i] == CheckingLocation)
                {
                    MySize++; // he he, my size
                }
            }
            return MySize;
        }
        public static List<string> UsersInLobby(string CurrentLocation)
        {
            MySQL mysql = new MySQL();
            string[] Location = (string[])null;
            string[] Users = (string[])null;
            List<string> SendingInfo = new List<string>();
            List<string>[] stringListArray = new MySQL().UsersLocationLobbies();
            List<string>[] stringListarray2 = new MySQL().SelectLogin();
            Location = stringListArray[0].ToArray();
            Users = stringListarray2[1].ToArray();
            for (int i = 0; i <= (Location.Length -1); i++)
            {
                if (Location[i] == CurrentLocation)
                {
                    SendingInfo.Add(Users[i]);
                }
            }
            return SendingInfo;
        }
    }
}
