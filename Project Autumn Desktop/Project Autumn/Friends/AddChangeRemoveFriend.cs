using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_Autumn
{
    class AddChangeRemoveFriend
    {

        public static void AddFriend(string NewFriend)
        {
            var Route = Directory.GetCurrentDirectory();
            string LocationOfText = Route + @"\Assests\Friends.txt";
            if (!(File.Exists(LocationOfText)))
            {
                StreamWriter Creates = File.CreateText(LocationOfText);
            }
            else
            {
                StreamWriter write = new StreamWriter(LocationOfText);
                write.WriteLine(NewFriend);
                write.Close();
            }
        }

        public static void RemoveFriend(List<string> Friend)
        {
            var Route = Directory.GetCurrentDirectory();
            string LocationOfText = Route + @"\Assests\Friends.txt";
            StreamWriter write = new StreamWriter(LocationOfText);
            for (int i = 0; i < Friend.Count; i++)
            {
                write.WriteLine(Friend[i]);
            }
            write.Close();
        }
        public static List<string> LoadFriends()
        {
            List<string> AllFriends = new List<string>();
            var Route = Directory.GetCurrentDirectory();
            string LocationOfText = Route + @"\Assests\Friends.txt";
            using (StreamReader Reader = new StreamReader(LocationOfText))
            {
                while (!(Reader.EndOfStream))
                {
                    AllFriends.Add(Reader.ReadLine());
                }
                Reader.Close();
            }
            return AllFriends;
        }
    }
}
