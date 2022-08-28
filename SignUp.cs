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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {

                Con.Open();
                string query = "Insert into UserTb values ('" + SignName.Text + "', '" + SignMail.Text + "', '" + SignPass.Text + "', '" + RoleBox.Text + "')";

                if(RoleBox.Text == "Admin")
                {
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully");
                    Con.Close();
                    Home log = new Home();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully");
                    Con.Close();
                    Home log = new Home();
                    this.Hide();
                    log.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
