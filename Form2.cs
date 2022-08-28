using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }


        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar.Value = start;
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
