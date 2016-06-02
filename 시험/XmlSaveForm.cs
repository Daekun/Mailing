using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace 시험
{
    public partial class XmlSaveForm : Form
    {
        public XmlSaveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Problem info = new Problem();
      
                info.Data1 = txtData1.Text;
                info.Data2 = txtData2.Text;
                info.Data3 = txtData3.Text;
                SaveXml.SaveData(info, "data.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
