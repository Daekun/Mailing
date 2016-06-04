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

namespace 시험
{
    public partial class Upload : Form
    {
        struct Temp
        {
            String[] P;
            String[] Q;
        }
        public Upload()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ListAdd()
        {
            //C:/Users/SinSangHoon/Documents/GitHub/Mailing/시험/Image
            string fp = @"C:/Users/SinSangHoon/Documents/GitHub/Mailing/시험/Image";
            string[] jf = Directory.GetFiles(fp, "*.jpg");
            foreach (string file in jf)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }
        private void Upload_Load(object sender, EventArgs e)
        {
            ListAdd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cut Temp = new Cut();
            Temp.ShowDialog();
            listBox1.Items.Clear();
            ListAdd();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = listBox1.SelectedIndex.ToString();
            //MessageBox.Show(listBox1.SelectedIndex.ToString());
        }
    }
}
