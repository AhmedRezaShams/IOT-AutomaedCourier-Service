using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using IronBarCode;
using System;
using System.Drawing;
using System.Linq;
using SixLabors.ImageSharp.Formats.Png;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public string APhone { get; internal set; }
        public string BPhone { get; internal set; }
        public string Price { get; internal set; }
        public string Serial { get; internal set; }
        public string Semail { get; internal set; }
        public string Remail { get; internal set; }

        public Form6()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* serialPort1.Open();
             string m1 = "run";
             serialPort1.Write(m1);
            */
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox5.Text = APhone;
            textBox2.Text = BPhone;
            textBox7.Text = Price;
            textBox1.Text = Serial;
            textBox4.Text = Semail;
            textBox6.Text = Remail;
            //button4_Click(null, EventArgs.Empty);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Sender Name", "ahmedrezashams4@gmail.com"));
            email.To.Add(new MailboxAddress("Receiver Name", textBox6.Text));
            email.To.Add(new MailboxAddress("Sender Name", textBox4.Text));

            email.Subject = "Automated Courier and Parcel";
            /* email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
             {
                 Text = "Hello all the way from the land of C#"
             };*/
            var builder = new BodyBuilder();
            builder.Attachments.Add("QrCode.png");
            email.Body = builder.ToMessageBody();
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("ahmedrezashams4@gmail.com", "haaseefhywxvopxa");

                smtp.Send(email);
                smtp.Disconnect(true);
               
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                GeneratedBarcode Qrcode = QRCodeWriter.CreateQrCode(textBox1.Text);
            Qrcode.SaveAsPng("QrCode.png");
            pictureBox1.Image = new Bitmap("QrCode.png");

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    private void PrintPage(object o, PrintPageEventArgs e)
    {
        System.Drawing.Image img = System.Drawing.Image.FromFile("QrCode.png");
        Point loc = new Point(100, 100);
        e.Graphics.DrawImage(img, loc);
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }

}
