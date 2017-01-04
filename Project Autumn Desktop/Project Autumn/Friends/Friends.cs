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
    public partial class Friends : Form
    {
        private List<string> AllFriends = new List<string>();
        public Friends()
        {
            InitializeComponent();
        }

        private void BuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            LBFriends.Items.Clear();
            AllFriends = AddChangeRemoveFriend.LoadFriends();
            for (int i = 0; i < AllFriends.Count; i++)
            {
                LBFriends.Items.Add(AllFriends[i]);
            }
        }

        private void BuRemove_Click(object sender, EventArgs e)
        {
            LBFriends.Items.RemoveAt(LBFriends.SelectedIndex);
            AllFriends = LBFriends.Items.Cast<string>().ToList();
            AddChangeRemoveFriend.RemoveFriend(AllFriends);
        }
    }
}
