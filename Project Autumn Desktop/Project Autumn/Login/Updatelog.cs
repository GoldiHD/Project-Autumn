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
    public partial class Updatelog : Form
    {
        public Updatelog()
        {
            InitializeComponent();
        }

        private void BuBack_Click(object sender, EventArgs e)
        {
            Form1 portal = new Form1();
            portal.Show();
            this.Close();
        }
    }
}
