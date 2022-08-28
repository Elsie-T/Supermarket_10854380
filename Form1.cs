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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string Username = LogName.Text;
            string Password = LogPass.Text;

            try
            {
                string query = "select * from UserTb where UserName = '" + LogName.Text + "' AND UserPassword = '" + LogPass.Text + "' AND UserRole = '" + RoleBox.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0 && RoleBox.Text == "Admin")
                {
                    Username = LogName.Text;
                    Password = LogPass.Text;
                    Home log = new Home();
                    this.Hide();
                    log.Show();
                }

                else if (dataTable.Rows.Count > 0 && RoleBox.Text == "Attendant")
                {
                    Username = LogName.Text;
                    Password = LogPass.Text;
                    AttendantHome log = new AttendantHome();
                    this.Hide();
                    log.Show();
                }

                else
                {
                    MessageBox.Show("Invalid User");
                    LogName.Text = "";
                    LogPass.Text = "";
                }
            }

            catch
            {
                MessageBox.Show("Invalid User");
            }

            finally
            {
                Con.Close();
            }
       
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp F1 = new SignUp();
            this.Hide();
            F1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
