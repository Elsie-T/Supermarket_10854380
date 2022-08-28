using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Supermarket
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Product log = new Product();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Category log = new Category();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            InUsers log = new InUsers();
            this.Hide();
            log.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Stock log = new Stock();
            this.Hide();
            log.Show();
        }
    }
}
