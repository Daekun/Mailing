using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 시험
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }
        
        public static String connectionStr;
        public static MySqlConnection ConDB;
        private void OpenMysql()
        {
            DBConnection.DBconect();
            ConDB = DBConnection.ConDB;
            ConDB.Open();
        }

        private void CloseMysql()
        {
            ConDB.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenMysql();
            string sql = "select 아이디,이름,소속,학번,전화번호 from 유저 where 아이디= '" + User_Search_Box.Text + "'";
            var Comm = new MySqlCommand(sql, ConDB);
            var myRead = Comm.ExecuteReader();

            if (myRead.HasRows)
            {
                while (myRead.Read())
                {
                    ListViewItem Temp = new ListViewItem(myRead["이름"].ToString());
                    Temp.SubItems.Add(myRead["아이디"].ToString());
                    Temp.SubItems.Add(myRead["학번"].ToString());
                    Temp.SubItems.Add(myRead["소속"].ToString());
                    Temp.SubItems.Add(myRead["전화번호"].ToString());
                    listView1.Items.Add(Temp);
                }
            }
            else
            {
                MessageBox.Show("이 아이디를 사용하는 사람이 없습니다..", "확인", MessageBoxButtons.OK);
            }
            CloseMysql();
        }

        string User="";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenMysql();
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                User = User + ",'" + listView2.Items[i].SubItems[1].Text + "'";
            }
                string sql = "insert into 그룹(그룹명,감독명,학생) values ('"+ Group_Name_Box.Text + "','" + Program.user_id + "'" + User + ")";
                var Comm = new MySqlCommand(sql, ConDB);
                var myRead = Comm.ExecuteReader();

            MessageBox.Show("그룹이 생성되었습니다.","확인",MessageBoxButtons.OK);
            CloseMysql();
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem Temp_1 = new ListViewItem(listView1.Items[listView1.TabIndex - 2].SubItems[0].Text);
            for (int i=1;i<5;i++) {
                Temp_1.SubItems.Add(listView1.Items[listView1.TabIndex-2].SubItems[i]);
            }
            listView2.Items.Add(Temp_1);
        }
    }
}
