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
    public partial class AttendantHome : Form
    {
        public AttendantHome()
        {
            InitializeComponent();
        }

        int timeStart = 1;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void AttendantHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Sales Log = new Sales();
            this.Hide();
            Log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Receipts Log = new Receipts();
            this.Hide();
            Log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Scanner Log = new Scanner();
            this.Hide();
            Log.Show();

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeStart > 0)
            {
                timeStart = timeStart + 1;
                TimerLabel.Text = timeStart + "  Seconds";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
