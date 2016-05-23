using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Testing
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
            OpenMysql();
        }
        private Boolean PhoneNumber = false; // 전화번호 체크 
        private Boolean BirthNumber = false; // 생년원일 체크 
        private Boolean idChecked = false;    // id체크 
        private Boolean pwChecked = false;    // 패스워드 재확인 
        private Boolean pwLenChecked = false; // 패스워드 길이에 대해서 체크 
        private Boolean EmailChecked = false; // 이메일에 대해서 체크
        private Boolean NameChecked = false; // 이름에 대해서 체크 
        private Boolean SnumberChecked = false;
        private Boolean SexChecked = false;
        private Boolean LevelChecked = false;

        private Char SexTos;
        private Char LevelTos;

        RadioButton[] radSex = new RadioButton[2]; // 성별 저장 
        RadioButton[] radLevel = new RadioButton[3]; // 보안 레벨 
        // 보안 레벨에 따라서 교수탭을 열 것인지 학생탭을 열 것인지 판단 

        MySqlConnection ConDB;

        public const String _DOMAIN_SERVER = "127.0.0.1";
        public const String _USER_ID = "root";
        public const String _PASSWORD = "1234";
        public const String _DATABASE = "member";

        public String connectionStr;

        private bool CHK_NBR(String ch)
        {
            int i, sw2 = 1;
            for (i = 0; i < ch.Length; i++)
            {
                if (!(0x30 <= ch[i] && ch[i] <= 0x39)) sw2 = 0;
            }
            if (sw2 == 1) return true;
            else return false;
        }
        private bool CHK_ID(String ch)
        {
            int i, sw2 = 1;
            for (i = 0; i < ch.Length; i++)
            {
                if (!((0x61 <= ch[i] && ch[i] <= 0x7A) || (0x41 <= ch[i] && ch[i] <= 0x5A) || (0x30 <= ch[i] && ch[i] <= 0x39))) sw2 = 0;
            }
            if (sw2 == 1) return true;
            else return false;
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                OpenMysql();
                string sql = "select 아이디, 패스워드 from 유저 where 아이디= '" + textBox1.Text + "'";
                var Comm = new MySqlCommand(sql, ConDB);
                var myRead = Comm.ExecuteReader();
                if (myRead.HasRows)
                {
                    if (myRead.Read())
                    {
                        if (myRead["패스워드"].ToString() == textBox2.Text)
                        {
                            MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.sw_Login = true;
                            Program.user_id = myRead["아이디"].ToString();
                            CloseMysql();
                            Home Temp = new Home();
                            Temp.Show();
                            this.Close();
                        }
                        else
                            label3.Text = "암호가 일치하지 않습니다";
                    }
                }
                else
                {
                    label3.Text = "일치하는 계정이 없습니다";
                }
                myRead.Close();
                CloseMysql();
            }
            else
            {
                label3.Text = "아이디와 암호를 입력하세요";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                ClientSize = new System.Drawing.Size(333, 128);
                label3.Text = "회원 접속을 시도합니다.";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                ClientSize = new System.Drawing.Size(333, 128);
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                JoinTextClear();
                label3.Text = "회원 접속을 시도합니다.";
            }
            else
            {
                ClientSize = new System.Drawing.Size(333, 596);
                txtId.Focus();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                label3.Text = "회원 가입을 진행합니다";
            }
        }

        private void idCheck_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text.Length < 5)
            {
                OpenMysql();
                string sql = "select 아이디, 패스워드 from 유저 where 아이디= '" + txtId.Text + "'";
                var Comm = new MySqlCommand(sql, ConDB);
                var myRead = Comm.ExecuteReader();
                if (myRead.HasRows)
                {
                    CloseMysql();
                    idChecked = false;
                    label4.ForeColor = Color.Red;
                    label4.Text = "아이디 중복";
                }
                else
                {
                    CloseMysql();
                    idChecked = true;
                    label4.ForeColor = Color.Blue;
                    label4.Text = "OK 확인";
                }
            }
            else
            {
                if (!CHK_ID(txtId.Text))
                {
                    MessageBox.Show("정상적인 아이디를 입력해 주세요", "아이디 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                }
                else
                {
                    MessageBox.Show("아이디를 5자리 이상 입력해 주세요", "아이디 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                }
            }
        }

        private void pwCheck()
        {
            if (txtPw1.Text == txtPw2.Text)
            {
                pwChecked = true;
            }
            else
            {
                pwChecked = false;
            }
        } // 비밀번호와 확인 란에 대해 같은지 확인
        private void pwLenCheck()
        {
            if (txtPw1.Text.Length >= 6)
            {
                pwLenChecked = true;
            }
            else
            {
                pwLenChecked = false;
            }
        } // 비밀번호 자리수에 대해서 확인
        private void Number()
        {
            if (txtNum.Text.Length >= 11)
            {
                PhoneNumber = true;
            }
            else
                PhoneNumber = false;
            PhoneNumber = CHK_NBR(txtNum.Text);
        }  // 전화번호에 대해서 저장할 변수 
        private void Birth()
        {
            if (txtBirth.Text.Length >= 6)
            {
                BirthNumber = true;
            }
            else
                BirthNumber = false;
            BirthNumber = CHK_NBR(txtBirth.Text);
        }  // 생년월일에 대한 함수 
        
        private void Email()
        {
            if (txtEmail.Text.Length <= 15 && txtEmail.Text.Length >= 7 && comboEmail.Text!=null)
            {
                EmailChecked = true;
            }
            else
                EmailChecked = false;
        } // 이메일 길이에 대하여 제한 설정 
        private void name()
        {
            if (txtName.Text.Length <= 5)
            {
                NameChecked = true;
            }
            else
                NameChecked = false;
        }//이름이 5자리 이하인지에 대해서 확인
        private void Snumber()
        {
            if (txtSnum.Text.Length >= 9 && txtSnum.Text.Length <= 11)
                SnumberChecked = true;
            else SnumberChecked = false;
            SnumberChecked = CHK_NBR(txtSnum.Text);
        }// 학번의 자릿수에 대해서 확인
        private void Sex()
        {
            if (radioGirl.Checked)
                SexTos = 'F';
            else if (radioMan.Checked) SexTos = 'M';
            else SexChecked = true;
        } // 성별이 무엇인지 
        private void Level()
        {
            if (radStudent.Checked)
                LevelTos = 'S';
            else if (radPro.Checked) LevelTos = 'P';
            else LevelChecked = true;
        }  // 직위에 대해서 보안레벨 설정하는 버튼을 배열에 저장 
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (idChecked)   // 중복체크
            {
                pwCheck();  // 함수 불러오기 
                pwLenCheck();
                Number();
                Birth();
                name();
                Email();
                Snumber();
                Sex();
                Level();
                if (pwChecked)   // pw same check
                {
                    if (pwLenChecked) // pw length check
                    {
                        if (PhoneNumber)
                        {
                            if (BirthNumber)
                            {
                                if (NameChecked)
                                {
                                    if (EmailChecked)
                                    {
                                        if (SnumberChecked)
                                        {
                                            if (!SexChecked)
                                            {
                                                if (!LevelChecked)
                                                {
                                                    OpenMysql();
                                                    string sql = "insert into 유저(아이디, 패스워드, 전화번호, 생년월일, 이름, 이메일, 학번, 소속, 성별, 직위) values ('" + txtId.Text + "', '" + txtPw1.Text + "','" + txtNum.Text + "','" + txtBirth.Text + "','" + txtName.Text + "','" + txtEmail.Text + "@" + comboEmail.Text + "','" + txtSnum.Text + "','" + txtDPM.Text + "','" + SexTos + "','" + LevelTos + "')";
                                                    var Comm = new MySqlCommand(sql, ConDB);
                                                    int i = Comm.ExecuteNonQuery();

                                                    if (i == 1)
                                                    {
                                                        CloseMysql();
                                                        checkBox1.Checked = false;
                                                        textBox1.Focus();
                                                        MessageBox.Show("가입이 완료되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        JoinTextClear();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("직위를 확인해 주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    radStudent.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("성별을 확인해 주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                radioMan.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("9자리에서 11자리의 숫자인 학번을 입력해 주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtSnum.Clear();
                                            txtSnum.Focus();
                                        }
                                    }
                                    else {
                                        MessageBox.Show("정상적인 이메일을 입력해 주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtEmail.Clear();
                                        txtEmail.Focus();
                                    }
                                }
                                else {
                                    MessageBox.Show("5자리 이하의 이름을 입력해 주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtName.Clear();
                                    txtName.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("생년월일을 6자리로 입력해 주세요","확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtBirth.Clear();
                                txtBirth.Focus();
                            }
                        }else
                        {
                            MessageBox.Show("전화번호를 11자리로 입력해 주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNum.Clear();
                            txtNum.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("암호를 6자리 이상으로 설정해 주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPw1.Clear();
                        txtPw2.Clear();
                        txtPw1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("패스워드가 일치하지 않습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPw1.Focus();
                }
            }
            else
            {
                MessageBox.Show("ID 중복체크를 해주시기 바랍니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
            }
            Reset();
        }

        private void Reset()
        {
            SexChecked = false;
            LevelChecked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            JoinTextClear();
            textBox1.Focus();
        }

        private void JoinTextClear()
        {
            txtId.Clear();
            txtPw1.Clear();
            txtPw2.Clear();
            txtNum.Clear();
            txtName.Clear();
            txtBirth.Clear();
            txtEmail.Clear();
            txtDPM.Clear();
            txtSnum.Clear();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
