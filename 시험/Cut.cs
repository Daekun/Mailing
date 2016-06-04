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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace 시험
{
    public partial class Cut : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
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
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
        private Pen _Pen = new Pen(Color.Red,3);
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
        Rectangle rect;
        private static Image CutPicture(Image imagen, Rectangle recuadro)
        {
            Bitmap bitmap = new Bitmap(imagen);
            Bitmap cropedBitmap = bitmap.Clone(recuadro, bitmap.PixelFormat);

            return (Image)(cropedBitmap);
        }
        private void Drawing_Rectangle()
        {
            if (ofd.FileName != "")
            {
                Generic();
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox2.Refresh();
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    float ratio_width = (float)Image.FromFile(ofd.FileName).Size.Width / (float)pictureBox1.Size.Width;
                    float ratio_height = (float)Image.FromFile(ofd.FileName).Size.Height / (float)pictureBox1.Size.Height;
                    float width = _EndPoint.X - _Previous.X;
                    float height = _EndPoint.Y - _Previous.Y;
                    rect.X = (int)((float)_Previous.X * ratio_width);
                    rect.Y = (int)((float)_Previous.Y * ratio_height);
                    rect.Width = (int)(width * ratio_width);
                    rect.Height = (int)(height * ratio_height);
                    pictureBox2.Image = CutPicture(pictureBox1.Image, rect);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    g.DrawRectangle(_Pen, rect);
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _EndPoint = new Point(e.Location.X, e.Location.Y);
            Drawing_Rectangle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog1();
        }

        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void SaveFileDialog1()
        {
            Bitmap bmp1 = new Bitmap(pictureBox2.Image);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            pictureBox2.Image.Save("C:/Users/SinSangHoon/Documents/GitHub/Mailing/시험/Image/Image.jpg", jpgEncoder,myEncoderParameters);
            this.Close();
        }
    }
}
