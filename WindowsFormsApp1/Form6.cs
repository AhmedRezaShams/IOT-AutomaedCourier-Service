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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public string APhone { get; internal set; }
        public string BPhone { get; internal set; }
        public string Price { get; internal set; }
        public string Serial { get; internal set; }

        public Form6()
        {
            InitializeComponent();
            serialPort1.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m1 = "run";
            serialPort1.Write(m1);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox5.Text = APhone;
            textBox2.Text = BPhone;
            textBox7.Text = Price;
            textBox1.Text = Serial;
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
    }
}
