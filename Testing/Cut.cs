using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Cut : Form
    {
        Byte[] ByteCode;

        public Cut()
        {
            InitializeComponent();
            this.pictureBox1.Cursor = Cursors.Cross;
            this.DoubleBuffered = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowFileDialog1();
        }

        private void ShowFileDialog1()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈";
            ofd.FileName = "test";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                ByteCode = imageToByteArray(Image.FromFile(ofd.FileName));
            }
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    loadedImage = ci.Load(dialog);
                    // 픽처박스에 이미지 띄움 
                    pictureBox1.Image = loadedImage;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Image File");
                }
            }
        }*/

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
