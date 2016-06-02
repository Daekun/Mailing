namespace 시험
{
    partial class Member
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.idCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPw2 = new System.Windows.Forms.TextBox();
            this.txtPw1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.radPro = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.radioGirl = new System.Windows.Forms.RadioButton();
            this.txtSnum = new System.Windows.Forms.TextBox();
            this.txtDPM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpLevel.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "비밀번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "취  소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(226, 421);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(38, 23);
            this.btnJoin.TabIndex = 25;
            this.btnJoin.Text = "가입";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // idCheck
            // 
            this.idCheck.Location = new System.Drawing.Point(249, 20);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(53, 23);
            this.idCheck.TabIndex = 11;
            this.idCheck.Text = "check";
            this.idCheck.UseVisualStyleBackColor = true;
            this.idCheck.Click += new System.EventHandler(this.idCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "비번확인";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "비밀번호";
            // 
            // txtPw2
            // 
            this.txtPw2.Location = new System.Drawing.Point(80, 89);
            this.txtPw2.Name = "txtPw2";
            this.txtPw2.PasswordChar = '*';
            this.txtPw2.Size = new System.Drawing.Size(100, 21);
            this.txtPw2.TabIndex = 13;
            // 
            // txtPw1
            // 
            this.txtPw1.Location = new System.Drawing.Point(80, 53);
            this.txtPw1.Name = "txtPw1";
            this.txtPw1.PasswordChar = '*';
            this.txtPw1.Size = new System.Drawing.Size(100, 21);
            this.txtPw1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "아이디";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpLevel);
            this.groupBox1.Controls.Add(this.grpGender);
            this.groupBox1.Controls.Add(this.txtSnum);
            this.groupBox1.Controls.Add(this.txtDPM);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboEmail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBirth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnJoin);
            this.groupBox1.Controls.Add(this.idCheck);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPw2);
            this.groupBox1.Controls.Add(this.txtPw1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(8, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 457);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원 가입";
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.radPro);
            this.grpLevel.Controls.Add(this.radStudent);
            this.grpLevel.Location = new System.Drawing.Point(34, 187);
            this.grpLevel.Margin = new System.Windows.Forms.Padding(2);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Padding = new System.Windows.Forms.Padding(2);
            this.grpLevel.Size = new System.Drawing.Size(146, 39);
            this.grpLevel.TabIndex = 42;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "직위";
            // 
            // radPro
            // 
            this.radPro.AutoSize = true;
            this.radPro.Location = new System.Drawing.Point(84, 18);
            this.radPro.Margin = new System.Windows.Forms.Padding(2);
            this.radPro.Name = "radPro";
            this.radPro.Size = new System.Drawing.Size(47, 16);
            this.radPro.TabIndex = 17;
            this.radPro.TabStop = true;
            this.radPro.Text = "교수";
            this.radPro.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(23, 18);
            this.radStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(47, 16);
            this.radStudent.TabIndex = 16;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "학생";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radioMan);
            this.grpGender.Controls.Add(this.radioGirl);
            this.grpGender.Location = new System.Drawing.Point(34, 272);
            this.grpGender.Margin = new System.Windows.Forms.Padding(2);
            this.grpGender.Name = "grpGender";
            this.grpGender.Padding = new System.Windows.Forms.Padding(2);
            this.grpGender.Size = new System.Drawing.Size(146, 39);
            this.grpGender.TabIndex = 41;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "성별";
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Location = new System.Drawing.Point(23, 18);
            this.radioMan.Margin = new System.Windows.Forms.Padding(2);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(35, 16);
            this.radioMan.TabIndex = 19;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "남";
            this.radioMan.UseVisualStyleBackColor = true;
            // 
            // radioGirl
            // 
            this.radioGirl.AutoSize = true;
            this.radioGirl.Location = new System.Drawing.Point(96, 18);
            this.radioGirl.Margin = new System.Windows.Forms.Padding(2);
            this.radioGirl.Name = "radioGirl";
            this.radioGirl.Size = new System.Drawing.Size(35, 16);
            this.radioGirl.TabIndex = 20;
            this.radioGirl.TabStop = true;
            this.radioGirl.Text = "여";
            this.radioGirl.UseVisualStyleBackColor = true;
            // 
            // txtSnum
            // 
            this.txtSnum.Location = new System.Drawing.Point(80, 400);
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(100, 21);
            this.txtSnum.TabIndex = 24;
            // 
            // txtDPM
            // 
            this.txtDPM.Location = new System.Drawing.Point(80, 364);
            this.txtDPM.Name = "txtDPM";
            this.txtDPM.Size = new System.Drawing.Size(100, 21);
            this.txtDPM.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "학번";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "소속";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboEmail
            // 
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Items.AddRange(new object[] {
            "naver.com",
            "daum.net",
            "gmail.com"});
            this.comboEmail.Location = new System.Drawing.Point(208, 329);
            this.comboEmail.Margin = new System.Windows.Forms.Padding(2);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(100, 20);
            this.comboEmail.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "@";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "E-mail";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 329);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 241);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "이름";
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(80, 159);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 21);
            this.txtBirth.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "생년월일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "전화번호";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(80, 123);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(238, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "회원가입";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "ShortCut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Member";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button idCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPw2;
        private System.Windows.Forms.TextBox txtPw1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioGirl;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.RadioButton radPro;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.TextBox txtSnum;
        private System.Windows.Forms.TextBox txtDPM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.Button button3;
    }
}
