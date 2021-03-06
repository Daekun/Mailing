﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 시험
{
    public partial class Mailing : Form
    {
        public Mailing()
        {
            InitializeComponent();
        }

      //  const string SMTP_SERVER = "smtp.naver.com"; // SMTP 서버 주소
      //  const int SMTP_PORT = 587; // SMTP 포트

        const string MAIL_ID = "sinegoist@gmail.com"; // 보내는 사람의 이메일
        const string MAIL_ID_NAME = "Egoist"; // 보내는사람 계정 ( 네이버 로그인 아이디 ) 
        const string MAIL_PW = "tjehdgnl13";  // 보내는사람 패스워드 ( 네이버 로그인 패스워드 )

    

        public static String connectionStr;
        public static MySqlConnection ConDB;

        private void Mailing_Load(object sender, EventArgs e)
        {
            txtBoxFrom.Text = Program.user_id;
        }

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
        
        private void btnMail_Click(object sender, EventArgs e)
        {
            //   DBConnection.DBconect();
            //   ConDB = DBConnection.ConDB;
            //   ConDB.Open();

            //   string sql = "SELECT *FROM 유저 WHERE 이메일 = 'qkrehddnjs05@naver.com'";

            
            //string txtTo = txtBoxTo.Text.ToString();
        //    var Comm = new MySqlCommand(sql, ConDB);
        //    var myRead = Comm.ExecuteReader();
            MailAddress mailFrom = new MailAddress(MAIL_ID, MAIL_ID_NAME, Encoding.UTF8); // 보내는사람의 정보를 생성
            MailAddress mailTo = new MailAddress("moondavil@naver.com"); // 받는사람의 정보를 생성

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // smtp 서버 정보를 생성

            MailMessage message = new MailMessage(mailFrom, mailTo);

            message.Subject = "시험 메일"; // 메일 제목 프로퍼티
            message.SubjectEncoding = Encoding.UTF8; // 제목 인코딩 형식
            message.Body = "시험 잘보세요"; // 메일의 몸체 메세지 프로퍼티
            message.BodyEncoding = Encoding.UTF8; // 메세지 인코딩 형식

            client.UseDefaultCredentials = false;

            client.EnableSsl = true; // SSL 사용 유무 (네이버는 SSL을 사용합니다.)
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential(MAIL_ID, MAIL_PW); // 보안인증 ( 로그인 )
            client.Send(message);  //메일 전송 
        }

        private void Test_Search_Button_Click(object sender, EventArgs e)
        {
            OpenMysql();
            string sql = "select 시험파일이름 from 시험 where 아이디= '" + Program.user_id + "'";
            var Comm = new MySqlCommand(sql, ConDB);
            var myRead = Comm.ExecuteReader();
            
            if (myRead.HasRows)
            {
                while (myRead.Read())
                {
                    string Data = myRead["시험파일이름"].ToString();
                    comboBox1.Items.Add(Data);
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("이 계정으로 등록한 시험이 존재 하지 않습니다.","확인", MessageBoxButtons.OK);
            }
            CloseMysql();
        }

        private void Group_Search_Button_Click(object sender, EventArgs e)
        {
            OpenMysql();
            string sql = "select 그룹명 from 그룹 where 감독명= '" + Program.user_id + "'";
            var Comm = new MySqlCommand(sql, ConDB);
            var myRead = Comm.ExecuteReader();

            if (myRead.HasRows)
            {
                while (myRead.Read())
                {
                    string Data = myRead["그룹명"].ToString();
                    comboBox2.Items.Add(Data);
                }
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("이 계정으로 생성한 그룹이 존재 하지 않습니다.", "확인", MessageBoxButtons.OK);
            }
            CloseMysql();
        }
    }
}