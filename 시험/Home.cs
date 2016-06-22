using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시험
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sw_Upload = true;
            Upload Temp = new Upload();
            Temp.ShowDialog();
        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
          //Program.sw_Upload = true; 
            Mailing Temp = new Mailing();
            Temp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group Temp = new Group();
            Temp.ShowDialog();
        }
    }
}
