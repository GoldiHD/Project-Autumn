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
    public partial class CustomPM : Form
    {
        public CustomPM()
        {
            InitializeComponent();
        }

        private void CustomPM_Load(object sender, EventArgs e)
        {
            this.Text = "Goldi"; //given name from user who creats "aka the name of the table"
        }
    }
}
