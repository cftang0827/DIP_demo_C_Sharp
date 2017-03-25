// 國立台灣大學資訊工程學系 數位影像處理課程 期末專題 微笑四方 美圖修修模組 第24組
// 組員: 湯智帆 R04945018
//       呂虹緯 R04945009
//       黃思翰 R04945008

// 使用軟體 Visual Studio 2012 C# with emguCV3 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.Net;
using System.Net.Mail;

namespace DIP_final
{
    
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private bool captureInProgress;
        private Image<Bgr,Byte> img;
        private Image<Bgr, Byte>imgBackUp;
        private Image<Bgr, Byte> src;
        private Image<Gray,Byte> mask;
        private Image<Gray,Byte> maskMatrix;
        private List<int> rect_x = new List<int>();
        private List<int> rect_y = new List<int>();
        
        // 初始化
        public Form1()
        {
            InitializeComponent();
            inpaintStart.Enabled = false;
            cloneLocate.Enabled = false;
            mail.Enabled = false;
        }

        // 開啟攝影機並且開始錄影
        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileName = new OpenFileDialog();
            if (fileName.ShowDialog() == DialogResult.OK || fileName.ShowDialog() == DialogResult.Yes)
            {
                try
                {
                    string name = fileName.FileName;
                    img = new Image<Bgr, Byte>(name).Resize(480, 640, Emgu.CV.CvEnum.Inter.Linear, true);
                    mask = new Image<Gray, Byte>(img.Width, img.Height);
                    mainImage2.Image = img.ToBitmap();
                    imgBackUp = img.Clone();
                    label1.Text = "Status: Read local image";

                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "laod image fail"); }

            }
        }

        // 錄影的Process
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (capture.IsOpened)
            {
                try
                {
                    img = capture.QueryFrame().ToImage<Bgr, Byte>();
                    mask = new Image<Gray,Byte>(img.Width, img.Height);
                    mainImage2.Image = img.ToBitmap();
                    imgBackUp = img.Clone();
                    label1.Text = "Status: Read image from camera";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + " capture frame fail"); }
            }
        }

        // 按下錄影按鈕的觸發事件
        private void camera_Click(object sender, EventArgs e)
        {
            try
            {
                capture = new VideoCapture();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "  camera fail"); }
            if (capture != null)
            {
                if (captureInProgress)
                {
                    camera.Text = "Start";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    camera.Text = "Say Cheese";
                    Application.Idle += ProcessFrame;
                }
                captureInProgress = !captureInProgress;
            }
        }

        // 偵測滑鼠移動路徑
        private void mainImage_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left && maskDraw.Enabled == false)
            {
                if (e.X > 0 && e.Y > 0 && e.Y < mainImage2.Height && e.X < mainImage2.Width)
                {
                    mask.Draw(new CircleF(new PointF(e.X, e.Y), 3), new Gray(255), 3);
                    imgBackUp.Draw(new CircleF(new PointF(e.X, e.Y), 3), new Bgr(Color.Red), 3);
                    mainImage2.Image = imgBackUp.ToBitmap();
                    label1.Text = "Status: Drawing mask";
                }
            }
            else if (e.Button == MouseButtons.Right && SeamlessStart.Enabled == false)
            {
                if (e.X > 0 && e.Y > 0 && e.Y < mainImage2.Height && e.X < mainImage2.Width)
                {
                    rect_x.Add(e.X);
                    rect_y.Add(e.Y);
                    imgBackUp.Draw(new CircleF(new PointF(e.X, e.Y), 3), new Bgr(Color.Yellow), 2);
                    mainImage2.Image = imgBackUp.ToBitmap();
                }

                cloneLocate.Enabled = true;
            }
        }

        // Inpaint按鈕
        private void inpaintStart_Click(object sender, EventArgs e)
        {
            maskDraw.Enabled = true;
            img = img.InPaint(mask, 10);
            mask = new Image<Gray, Byte>(img.Width, img.Height);
            imgBackUp = img.Clone();
            mainImage2.Image = img.ToBitmap();
            label1.Text = "Status: Inpainting";
        }

        // Equalization
        private void equalization_Click(object sender, EventArgs e)
        {
            maskDraw.Enabled = true;
            Image<Ycc, Byte> temp = new Image<Ycc, Byte>(img.Width, img.Height);
            CvInvoke.CvtColor(img, temp, ColorConversion.Rgb2YCrCb);
            Image<Gray, Byte>[] channels = temp.Split();

            channels[0]._EqualizeHist();
            VectorOfMat c = new VectorOfMat();
            c.Push(channels[0]);
            c.Push(channels[1]);
            c.Push(channels[2]);
            CvInvoke.Merge(c, temp);
            CvInvoke.CvtColor(temp, img, ColorConversion.YCrCb2Rgb);
            imgBackUp = img.Clone();
            mainImage2.Image = img.ToBitmap();
            label1.Text = "Status: Histogram equalization";
        }

        private void drawMask(object sender, EventArgs e)
        {
            maskDraw.Enabled = false;
            inpaintStart.Enabled = true;
            imgBackUp = img.Clone();
        }

        // Seamless click
        private void SeamlessStart_Click(object sender, EventArgs e)
        {

            SeamlessStart.Enabled = false;
            OpenFileDialog fileName = new OpenFileDialog();
            if (fileName.ShowDialog() == DialogResult.OK || fileName.ShowDialog() == DialogResult.Yes)
            {
                try
                {
                    string name = fileName.FileName;
                    src = new Image<Bgr, Byte>(name);
                    label1.Text = "Status: Read second image";
                    cloneImg.Image = src.Resize(cloneImg.Width, cloneImg.Height, Emgu.CV.CvEnum.Inter.Linear, false).ToBitmap();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "laod image fail"); }
            }


        
        }

        // 劃出Seamless的定位位置mask
        private void cloneLocate_Click(object sender, EventArgs e)
        {
            int rect_width = rect_x.Max() - rect_x.Min();
            int rect_height = rect_y.Max() - rect_y.Min();
            src = src.Resize(rect_width, rect_height, Emgu.CV.CvEnum.Inter.Linear, false);
            Image<Bgr, Byte> mask_seamless = new Image<Bgr, Byte>(src.Width, src.Height);   
            mask_seamless.SetValue(255);                                                    
            Point center = new Point(   (rect_x.Max() + rect_x.Min()) / 2, (rect_y.Max() + rect_y.Min())/2);  //設定要擺在原本圖的哪個位置
            CloningMethod method = CloningMethod.Mixed;                                     //還有其他方法可以用
            CvInvoke.SeamlessClone(src, img, mask_seamless, center, img, method);
            mainImage2.Image = img.ToBitmap();
            imgBackUp = img.Clone();
            label1.Text = "Status: Seamless cloning";
            rect_x.Clear();
            rect_y.Clear();
            SeamlessStart.Enabled = true;
        }

        // Gamma correction click
        private void gammaCorrect_Click(object sender, EventArgs e)
        {
            try
            {
                maskDraw.Enabled = true;
                double alpha =Convert.ToDouble(gammaNum.Value);
                
                img._GammaCorrect(alpha);
                imgBackUp = img.Clone();
                mainImage2.Image = img.ToBitmap();
                label1.Text = "Status: Gamma Correction";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " gamma frame fail"); }

        }

        // 發送email模組
        private void mail_Click(object sender, EventArgs e)
        {
            label1.Text = "寄信中";
            var fromAddress = new MailAddress("cftang0827@gmail.com", "微笑四方測試第24組, "+nameBox.Text+"來信囉!");
            var toAddress = new MailAddress(friendMailAddress.Text, "User");
            const string fromPassword = "kmchszfgaxhyfppq";
            const string subject = "感謝您使用微笑四方，您剛剛認識的朋友來信囉~";
            string body = "我是" +nameBox.Text+ "\n"+ greeting.Text + "\n\n\n我的名字是: " + nameBox.Text + " ,我的聯絡電子郵件是: " + ownMailAddress.Text + "\n\n希望我們能變成朋友~";
            

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            MailMessage message = new MailMessage(fromAddress, toAddress);
            Attachment attfile = new Attachment("test.jpg");
            message.Subject = subject;
            message.Body = body;
            message.Attachments.Add(attfile);
            
            {
                smtp.Send(message);
                showMail.Text = "已經完成寄信\n希望你們能夠變成朋友\n微笑四方24組\n感謝您的使用 :)~~";
                label1.Text = "寄信完成，掰掰";
            }
        }

        // 儲存影像用來寄信
        private void saveImage_Click(object sender, EventArgs e)
        {
            label1.Text = "存檔囉! 不能後悔囉!!!\n請填寫個人資訊";
            CvInvoke.Imwrite("test.jpg", img);
            mail.Enabled = true;
            loadImage.Enabled = false;
            camera.Enabled = false;
            SeamlessStart.Enabled = false;
            cloneLocate.Enabled = false;
            gammaCorrect.Enabled = false;
            equalization.Enabled = false;
            maskDraw.Enabled = false;
            inpaintStart.Enabled = false;

        }

        private void median_Click(object sender, EventArgs e)
        {
            try
            {
                img = img.SmoothMedian(Convert.ToInt16(medianNum.Value));
                mainImage2.Image = img.ToBitmap();
                imgBackUp = img.Clone();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " median frame fail"); }

        }

    }
}
