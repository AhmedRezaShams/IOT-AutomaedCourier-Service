using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Client.Result;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.CodeDom;
using System.Data.OleDb;
using Org.BouncyCastle.Utilities.Collections;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string port = "3307";
        string database = "courier";
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
           // serialPort1.Open();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private object richtextBox1;
        private object richtextBox2;    


        private void Form3_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
            Start.PerformClick();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           pictureBox.Image= (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void Form3_FormClosing (object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning) 
                captureDevice.Stop();
        }
        public static string quantity;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    richTextBox1.Text = result.ToString();
                    if (richTextBox1.Text != null)
                    {
                        button1.PerformClick();
                        string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
                        MySqlConnection con = new MySqlConnection(constring);
                        con.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("select code from receiver where code like '%" + richTextBox1.Text + "%'", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        //string ad = richTextBox1.Text;

                        if (dt.Rows.Count > 0)
                        {
                            quantity = richTextBox1.Text;
                            string results = dt.Rows[0][0].ToString();
                            if (results == richTextBox1.Text)
                            {
                               
                                button3.PerformClick();

                                Form4 fm4 = new Form4();
                                fm4.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Product Found");
                            Form2 fm2 = new Form2();
                            fm2.Show();
                            this.Close();
                        }
                    }


                        //serialPort1.Write(richTextBox1.Text);
                        timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*if (richTextBox1.Text != null)
            {
                button1.PerformClick();
                string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select code from receiver where code like '%" + richTextBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                //string ad = richTextBox1.Text;
                if (dt.Rows.Count > 0)
                {

                    string result = dt.ToString();
                    if (result == richTextBox1.Text)
                    {
                        Form4 fm4 = new Form4();
                        fm4.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("No Product Found");
                }                //dataGridView1.DataSource = dt;
                //dataGridView1.Visible = true;
                //con.Close();
            }


            /*string constring = "server =" + server + ";uid = " + uid + ";password = " + password + ";port = " + port + ";database =" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            dt = new DataTable();
            string sql = "Select * from receiver ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (richtextBox1 == dr.GetString(5)) // 0 is 1st column
            {
                //Do as your wish
                // MessageBox.Show("Please enter Address");
                Form4 fm4 = new Form4();
                fm4.Show();
                this.Hide();
            }*/



        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
    }
    
}
