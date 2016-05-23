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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Testing
{
    public partial class XmlSaveTextForm : Form
    {
        public XmlSaveTextForm()
        {
            InitializeComponent();
        }
        public static String connectionStr;
        public static MySqlConnection ConDB;

        private void button1_Click(object sender, EventArgs e)
        {
            connectionStr = "Server=stories2.iptime.org;Uid=daekun1;Pwd=daekun1;Database=project_test;Charset=utf8; ";
            ConDB = new MySqlConnection(connectionStr);

            try
            {
                Problem info = new Problem();

                info.Data = txtData.Text;
                info.Code = txtCode.Text;

                MessageBox.Show("저장성공");
                //     info.Picture = txtData3.Text;
                SaveXml.SaveData(info, "data1.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
       /*     SqlDataAdapter adp = new SqlDataAdapter("select * from tableName", "문제");
            DataSet ds = new DataSet("MyDB");
            adp.Fill(ds, "문제");

            // Write Data into XML
            ds.WriteXml("data1.xml");

            // Load(Read) XML data
     
           
           // dt.Rows.Add("val1", "val2"); // Adding row*/

        private void XmlSaveForm_Load(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Problem));
            FileStream read = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Problem info = (Problem)xs.Deserialize(read);
            txtData.Text = info.Data;
            txtCode.Text = info.Code;
        //    PictureBox. = info.Data3;
        }
    }
}
