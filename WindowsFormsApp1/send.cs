using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class send : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

        string server = "localhost";
        string uid = "root";

        string password = "";
        string port = "3307";
        string database = "courier";
        public send()
        {
            InitializeComponent();
        }

        private void send_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Sender First Name");
                textBox1.Focus();
                return;
            }
           else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please Enter Sender Last Name");
                textBox1.Focus();
                return;
            }
           else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter Sender Address");
                textBox1.Focus();
                return;
            }
           else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Sender Nid");
                textBox1.Focus();
                return;
            }
           else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please Enter Sender Mobile Number");
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please Enter Receivers First Name");
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Please Enter Receivers Last Name");
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please Enter Receivers Address");
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please Enter Receivers Mobile Number");
                textBox1.Focus();
                return;
            }
            else
            {
                string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                //string createable = "creat table test_table(id int,f_name varchar(50),l_name varchar(50))";
                string insert = "insert into sender(f_name,l_name,address,nid,phone,f_name1,l_name1,address1,phone1) values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "') ";
                MySqlCommand cmd = new MySqlCommand(insert, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString());
                if (i == 1)
                {
                    Form5 fm5 = new Form5();
                    fm5.SName = textBox1.Text;
                    fm5.SPhone = textBox5.Text;
                    fm5.SAddress = textBox3.Text;
                    fm5.RName = textBox9.Text;
                    fm5.RAddress = textBox7.Text;
                    fm5.RPhone = textBox6.Text;

                    fm5.Show();
                    this.Hide();
                }
            }
            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string show = "SELECT  `date` FROM `receiver` ORDER BY ID DESC";
            MySqlCommand cmd = new MySqlCommand(show, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               // textBox10.Text = reader.GetValue(0).ToString();
            }

            // SqlDataReader DR1 = Cmd.ExecuteReader();
            //if (DR1.Read())
            //{
            //textBox10.Text = DR1.GetValue(0).ToString();
            //}
            


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
