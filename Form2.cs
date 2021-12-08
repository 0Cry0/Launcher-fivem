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
using System.Data.OleDb;

namespace Germany_Life_vRP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form1 form = new Form1();
            metroProgressBar1.Increment(2);
            if (metroProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                form.Show();
                Hide();
                
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            {
                Label1.Text = DateTime.Now.ToLongTimeString();
                Label2.Text = DateTime.Now.ToLongDateString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();

        }
    }
}
