namespace 시험
{
    partial class XmlSaveForm
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
            this.components = new System.ComponentModel.Container();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(98, 57);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(142, 28);
            this.txtData1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(98, 115);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(142, 28);
            this.txtData2.TabIndex = 2;
            // 
            // txtData3
            // 
            this.txtData3.Location = new System.Drawing.Point(98, 169);
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(142, 28);
            this.txtData3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XmlSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData3);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Name = "XmlSaveForm";
            this.Text = "XmlSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.Button button1;
    }
}