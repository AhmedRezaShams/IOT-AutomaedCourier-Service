using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private string text;
        private int len = 0;
        public Form4()
        {
            InitializeComponent();
            serialPort1.Open();

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = Form3.quantity;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                comboBox1.Items.Add(Device.Name);
           
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 1;
                videoCaptureDevice = new VideoCaptureDevice();
            }
            text = label1.Text;
            label1.Text = "";
            timer1.Start();
            button1.PerformClick();
            
        }
        CancellationTokenSource cancellationToken;
        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "ok")
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                videoCaptureDevice.Start();
                cancellationToken = new CancellationTokenSource();
                var sourcetoken = cancellationToken.Token;
                onStartScan(sourcetoken);
                button1.Text = "Dừng lại!";
            }
            else
            {
                button1.Text = "ok";
                cancellationToken.Cancel();
                if (videoCaptureDevice != null)
                    if (videoCaptureDevice.IsRunning == true)
                        videoCaptureDevice.Stop();
            }
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        public void onStartScan(CancellationToken sourcetoken)
        {
            Task.Factory.StartNew(new Action(() =>
            {
                while (true)
                {
                    if (sourcetoken.IsCancellationRequested)
                    {
                        return;
                    }
                    Thread.Sleep(50);
                    BarcodeReader Reader = new BarcodeReader();

                    _ = pictureBox1.BeginInvoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            try
                            {
                                var results = Reader.DecodeMultiple((Bitmap)pictureBox1.Image);
                                if (results != null)
                                {
                                   


                                        if (richTextBox1.Text == richTextBox2.Text)
                                        {
                                            string m1 = "ok";
                                            serialPort1.Write(m1);
                                        //System.Windows.Forms.Application.Exit();
                                        // Form1 fm1 = new Form1();
                                        // fm1.Show();
                                        //this.Close();
                                        Application.Restart();
                                        Environment.Exit(0);
                                    }
                                       
                                    



                                        foreach (Result result in results)
                                    {
                                        richTextBox1.Text = result.ToString() /*+ $"- Type: {result.BarcodeFormat.ToString()}"*/;

                                        SystemSounds.Beep.Play();
                                        if (result.ResultPoints.Length > 0)
                                        {
                                            var offsetX = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Width - pictureBox1.Image.Width) / 2 :
                                               0;
                                            var offsetY = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Height - pictureBox1.Image.Height) / 2 :
                                               0;
                                            var rect = new Rectangle((int)result.ResultPoints[0].X + offsetX, (int)result.ResultPoints[0].Y + offsetY, 1, 1);
                                            foreach (var point in result.ResultPoints)
                                            {
                                                if (point.X + offsetX < rect.Left)
                                                    rect = new Rectangle((int)point.X + offsetX, rect.Y, rect.Width + rect.X - (int)point.X - offsetX, rect.Height);
                                                if (point.X + offsetX > rect.Right)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width + (int)point.X - (rect.X - offsetX), rect.Height);
                                                if (point.Y + offsetY < rect.Top)
                                                    rect = new Rectangle(rect.X, (int)point.Y + offsetY, rect.Width, rect.Height + rect.Y - (int)point.Y - offsetY);
                                                if (point.Y + offsetY > rect.Bottom)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height + (int)point.Y - (rect.Y - offsetY));
                                            }
                                            using (var g = pictureBox1.CreateGraphics())
                                            {
                                                using (Pen pen = new Pen(Color.Green, 5))
                                                {
                                                    g.DrawRectangle(pen, rect);

                                                    pen.Color = Color.Yellow;
                                                    pen.DashPattern = new float[] { 5, 5 };
                                                    g.DrawRectangle(pen, rect);
                                                }
                                                g.DrawString(result.ToString(), new Font("Tahoma", 16f), Brushes.Blue, new Point(rect.X - 60, rect.Y - 50));
                                            }
                                        }


                                    }

                                }
                            }
                            catch (Exception)
                            {
                            }
                        }

                    }));

                }
            }), sourcetoken);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                timer1.Stop();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
           
        }
    }
}
