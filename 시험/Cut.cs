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
        OpenFileDialog ofd = new OpenFileDialog();
        Byte[] ByteCode;


        public Cut()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowFileDialog1();
        }
        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }
        public class DialogState
        {

            public DialogResult result;
            public FileDialog dialog;
 

            public void ThreadProcShowDialog()
            {
                result = dialog.ShowDialog();
            }
        }

        private void ShowFileDialog1()
        {
            //파일오픈창 생성 및 설정
            ofd.InitializeLifetimeService();
            ofd.Title = "파일 오픈";
            ofd.FileName = "test";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = STAShowDialog(ofd);

            if (dr == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                ByteCode = imageToByteArray(Image.FromFile(ofd.FileName));
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private Point? _Previous = null;
        private Point? _EndPoint = null;
        private Pen _Pen = new Pen(Color.Black,3);
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Rectangle ee = new Rectangle(10, 10, 30, 30);
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point coordinates = e.Location;
            _Previous = new Point(coordinates.X, coordinates.Y);
            //pictureBox1_MouseMove(sender, e);
        }
        private void Drawing_Rectangle()
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                int ratio_width = Image.FromFile(ofd.FileName).Size.Width/pictureBox1.Size.Width;
                int ratio_height = Image.FromFile(ofd.FileName).Size.Height/pictureBox1.Size.Height;
                int width = _EndPoint.Value.X-_Previous.Value.X;
                int height = _EndPoint.Value.Y - _Previous.Value.Y;
                g.DrawRectangle(_Pen, _Previous.Value.X*ratio_width, _Previous.Value.Y*ratio_height, width*ratio_width , height*ratio_height);
            }
            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Previous != null)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                    }
                    pictureBox1.Image = bmp;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawRectangle(_Pen, _Previous.Value.X, _Previous.Value.Y, e.Location.X, e.Location.Y);
                }
                pictureBox1.Invalidate();
                Point coordinates = e.Location;
                _Previous = new Point(coordinates.X, coordinates.Y);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _EndPoint = new Point(e.Location.X, e.Location.Y);
            Drawing_Rectangle();
             _Previous = null;
            _EndPoint = null;
        }
    }
}
