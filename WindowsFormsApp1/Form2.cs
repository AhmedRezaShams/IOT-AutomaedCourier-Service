using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string text;
        private int len = 0;
        public Form2()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";
            timer1.Start();
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

        private void label3_Click(object sender, EventArgs e)
        {
            string m1 = "kk";
            serialPort1.Write(m1);
            send fm4 = new send();
            fm4.Show();
            this.Close();
            if (serialPort1.IsOpen)
           {
                serialPort1.Close();
           }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
        
    }
}
