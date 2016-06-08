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
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(358, 57);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(163, 82);
            this.btnMail.TabIndex = 0;
            this.btnMail.Text = "메일보내기";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "보내는사람";
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(109, 9);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(243, 28);
            this.txtBoxTo.TabIndex = 2;
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Location = new System.Drawing.Point(109, 57);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(243, 28);
            this.txtBoxFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "받는 사람";
            // 
            // txtBoxPD
            // 
            this.txtBoxPD.Location = new System.Drawing.Point(109, 111);
            this.txtBoxPD.Name = "txtBoxPD";
            this.txtBoxPD.Size = new System.Drawing.Size(243, 28);
            this.txtBoxPD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "비밀번호";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(109, 165);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(412, 28);
            this.txtBoxTitle.TabIndex = 8;
            // 
            // txtBoxP
            // 
            this.txtBoxP.Location = new System.Drawing.Point(109, 211);
            this.txtBoxP.Multiline = true;
            this.txtBoxP.Name = "txtBoxP";
            this.txtBoxP.Size = new System.Drawing.Size(412, 189);
            this.txtBoxP.TabIndex = 9;
            // 
            // Mailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 410);
            this.Controls.Add(this.txtBoxP);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxPD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMail);
            this.Name = "Mailing";
            this.Text = "Mailing";
            this.Load += new System.EventHandler(this.Mailing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxP;
    }
}