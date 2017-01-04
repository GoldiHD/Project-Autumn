using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Autumn
{
    public partial class LoginOption : Form
    {
        public LoginOption()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuBack_Click(object sender, EventArgs e)
        {
            Form1 portal = new Form1();
            portal.Show();
            this.Close();
        }

        private void BuSaveSettings_Click(object sender, EventArgs e)
        {
            var Bare = Directory.GetCurrentDirectory();
            string TextLocation = Bare + @"\Assests\Settings.txt";
            if (!File.Exists(TextLocation))
            {
                using (StreamWriter Creates = File.CreateText(TextLocation))
                {

                }
                MessageBox.Show("No file was found, new has been created");
            }
            StreamWriter write = new StreamWriter(TextLocation);
            write.WriteLine(TBIPAddress.Text);
            write.Close();
        }
    }
}
