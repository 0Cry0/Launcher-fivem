using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Germany_Life_vRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/4agNpFgNEf");
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://uc-library.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                Label1.Text = DateTime.Now.ToLongTimeString();
                Label2.Text = DateTime.Now.ToLongDateString();
            }
        }
    }
}
