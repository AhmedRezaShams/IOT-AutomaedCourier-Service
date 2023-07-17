using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class Form5 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        string server = "localhost";
        string uid = "root";

        string password = "";
        string port = "3307";
        string database = "courier";

        public string SName { get; set; }
        public string SAddress { get; set; }
        public string SPhone { get; set; }
        public string RName { get; set; }
        public string RAddress { get; set; }
        public string RPhone { get; set; }
        public string Smail { get; set; }
        public string Rmail { get; set; }

        public Form5()
        {
            InitializeComponent();
            serialPort1.Open();

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            textBox6.Text = SName;
            textBox5.Text = SAddress;
            textBox4.Text = SPhone;
            textBox3.Text = RName;
            textBox2.Text = RAddress;
            textBox1.Text = RPhone;
            textBox10.Text = Smail;
            textBox11.Text = Rmail;
            Random ran = new Random();
            int randomno = ran.Next(0, 1000000);
            textBox9.Text = randomno.ToString();


        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            button4_Click(null, EventArgs.Empty);
            Form6 fm6 = new Form6();
            fm6.APhone = textBox5.Text;
            fm6.BPhone = textBox2.Text;
            fm6.Price = textBox7.Text;
            fm6.Serial = textBox9.Text;
            fm6.Semail = textBox10.Text;
            fm6.Remail = textBox11.Text;
            fm6.Show();
           this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {



                button4_Click(null, EventArgs.Empty);
                button3_Click(null, EventArgs.Empty);
                string m1 = "ok";
                serialPort1.Write(m1);
                string s = serialPort1.ReadLine();
                double a = Convert.ToDouble(s);
                textBox8.Text = s;
                //textBox8.Refresh();
                double i = 0.05;
                double j = 0.10;
                button2.Visible = false;
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && a <= i)
                {
                    textBox7.Text = "10";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && a >= j)
                {
                    textBox7.Text = "20";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && a <= i)
                {
                    textBox7.Text = "20";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && a >= j)
                {
                    textBox7.Text = "40";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2 && a <= i)
                {
                    textBox7.Text = "30";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2 && a >= j)
                {
                    textBox7.Text = "60";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 && a <= i)
                {
                    textBox7.Text = "40";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 && a >= j)
                {
                    textBox7.Text = "80";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4 && a <= i)
                {
                    textBox7.Text = "50";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4 && a >= j)
                {
                    textBox7.Text = "100";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5 && a <= i)
                {
                    textBox7.Text = "60";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5 && a >= j)
                {
                    textBox7.Text = "120";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6 && a <= i)
                {
                    textBox7.Text = "70";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6 && a >= j)
                {
                    textBox7.Text = "140";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 7 && a <= i)
                {
                    textBox7.Text = "80";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 7 && a >= j)
                {
                    textBox7.Text = "160";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 8 && a <= i)
                {
                    textBox7.Text = "90";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 8 && a >= j)
                {
                    textBox7.Text = "180";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 9 && a <= i)
                {
                    textBox7.Text = "100";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 9 && a >= j)
                {
                    textBox7.Text = "200";
                }

                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                {
                    textBox7.Text = "5";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    textBox7.Text = "10";
                }

                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    textBox7.Text = "15";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
                {
                    textBox7.Text = "20";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
                {
                    textBox7.Text = "25";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
                {

                    textBox7.Text = "30";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
                {
                    textBox7.Text = "35";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 7)
                {
                    textBox7.Text = "40";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 8)
                {
                    textBox7.Text = "45";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 9)
                {

                    textBox7.Text = "50";
                }
            }
            else
            {
                MessageBox.Show("Please Select Description and Quantity");
            }

            /*if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }*/

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            
        }

        private async void button3_Click(object sender, EventArgs e)
        {

            label7.Visible = true;
            await Task.Delay(5000);
            label7.Visible = false;
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            //string createable = "creat table test_table(id int,f_name varchar(50),l_name varchar(50))";
            string show = "SELECT  `id` FROM `sender` ORDER BY ID DESC LIMIT 1";
            MySqlCommand cmd2 = new MySqlCommand(show, con);
            
            MySqlDataReader reader = cmd2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox12.Text = reader.GetString(0);
                    
                }
                reader.Close();
            }
            string textboxValue = textBox12.Text;
            string insert = "UPDATE `sender` SET `code`='" + textBox9.Text + "' WHERE `id`= '" + textboxValue + "' ";
            //string insert1 = "INSERT INTO `receiver`( `code`) values('" + textBox9.Text + "') ";
            MySqlCommand cmd = new MySqlCommand(insert, con);
            //MySqlCommand cmd1 = new MySqlCommand(insert1, con);
            int i = cmd.ExecuteNonQuery();
            // int j = cmd1.ExecuteNonQuery();
            // MessageBox.Show(i.ToString());
            //hello
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
