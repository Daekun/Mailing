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
using Input = System.Windows.Input;
using Drawing = System.Drawing;

namespace 시험
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
            ofd.FileName = "Image";
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

        private Point _Previous;
        private Point _EndPoint;
        private Pen _Pen = new Pen(Color.Red,5);
        private void Generic() {
            int Temp;
            if (_Previous.X > _EndPoint.X)
            {
                Temp = _EndPoint.X;
                _EndPoint.X = _Previous.X;
                _Previous.X = Temp;
            }
            if (_Previous.Y > _EndPoint.Y)
            {
                Temp = _EndPoint.Y;
                _EndPoint.Y = _Previous.Y;
                _Previous.Y = Temp;
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
            Generic();
            pictureBox1.Image = Image.FromFile(ofd.FileName);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                float ratio_width = (float)Image.FromFile(ofd.FileName).Size.Width/(float)pictureBox1.Size.Width;
                float ratio_height = (float)Image.FromFile(ofd.FileName).Size.Height/(float)pictureBox1.Size.Height;
                float width = _EndPoint.X-_Previous.X;
                float height = _EndPoint.Y - _Previous.Y;
                g.DrawRectangle(_Pen, _Previous.X * ratio_width, _Previous.Y * ratio_height, width * ratio_width, height * ratio_height);
            }
            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _EndPoint = new Point(e.Location.X, e.Location.Y);
            Drawing_Rectangle();
        }
    }
}
