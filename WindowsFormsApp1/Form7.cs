using MimeKit.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
            /* string url = Utils.siteUrl + "response.php";

              try
              {
                  var request = (HttpWebRequest)WebRequest.Create("response.php");
                  request.Method = "GET";
                  using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
               {
                      string responseString;
                      using (var stream = response.GetResponseStream())
                   {
                          using (var reader = new StreamReader(stream)) 
                  {
                              responseString = reader.ReadToEnd();
                              JObject O = JObject.Parse(responseString);
                              //JObject O = (string)JObject.Parse(responseString);
                              string Success = (string)O["Sucess"];
                              String Message = (string)O["Message"];
                              if (Success == "true")
                             {
                                  MessageBox.Show(Message);
                             }


                              MessageBox.Show(responseString);
                  }
                   }
               }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }*/

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
