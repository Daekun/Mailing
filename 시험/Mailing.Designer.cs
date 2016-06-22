namespace 시험
{
    partial class Mailing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Test_Search_Button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Group_Search_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(257, 10);
            this.btnMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(70, 21);
            this.btnMail.TabIndex = 0;
            this.btnMail.Text = "메일 보내기";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "보내는 사람";
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Location = new System.Drawing.Point(76, 10);
            this.txtBoxFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(171, 21);
            this.txtBoxFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "받는 사람";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // Test_Search_Button
            // 
            this.Test_Search_Button.Location = new System.Drawing.Point(257, 36);
            this.Test_Search_Button.Name = "Test_Search_Button";
            this.Test_Search_Button.Size = new System.Drawing.Size(70, 20);
            this.Test_Search_Button.TabIndex = 6;
            this.Test_Search_Button.Text = "시험 검색";
            this.Test_Search_Button.UseVisualStyleBackColor = true;
            this.Test_Search_Button.Click += new System.EventHandler(this.Test_Search_Button_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 20);
            this.comboBox2.TabIndex = 7;
            // 
            // Group_Search_Button
            // 
            this.Group_Search_Button.Location = new System.Drawing.Point(257, 62);
            this.Group_Search_Button.Name = "Group_Search_Button";
            this.Group_Search_Button.Size = new System.Drawing.Size(69, 19);
            this.Group_Search_Button.TabIndex = 8;
            this.Group_Search_Button.Text = "그룹 검색";
            this.Group_Search_Button.UseVisualStyleBackColor = true;
            this.Group_Search_Button.Click += new System.EventHandler(this.Group_Search_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "받는 그룹";
            // 
            // Mailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 89);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Group_Search_Button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Test_Search_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mailing";
            this.Text = "Mailing";
            this.Load += new System.EventHandler(this.Mailing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Test_Search_Button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Group_Search_Button;
        private System.Windows.Forms.Label label3;
    }
}