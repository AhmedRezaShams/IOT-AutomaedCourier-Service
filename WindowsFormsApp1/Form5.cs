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
           Form6 fm6 = new Form6();
            fm6.APhone = textBox5.Text;
            fm6.BPhone = textBox2.Text;
            fm6.Price = textBox7.Text;
            fm6.Serial = textBox9.Text;
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
            button3_Click(null, EventArgs.Empty);
            
            if (textBox7.TextLength > 0)
            {
                button4_Click(null, EventArgs.Empty);
            }
            
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

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

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
            string insert = "insert into sender(code) values('" + textBox9.Text + "') ";
            string insert1 = "INSERT INTO `receiver`( `code`) values('" + textBox9.Text + "') ";
            MySqlCommand cmd = new MySqlCommand(insert, con);
            MySqlCommand cmd1 = new MySqlCommand(insert1, con);
            int i = cmd.ExecuteNonQuery();
            int j = cmd1.ExecuteNonQuery();
            MessageBox.Show(i.ToString(),j.ToString());
            //hello
        }
    }
}
