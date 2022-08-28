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
    public partial class InUsers : Form
    {
        public InUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Home F1 = new Home();
            this.Hide();
            F1.Show();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from UserTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataPanel.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            populate();
            //fillcombo();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTb.Text == "")
                {
                    MessageBox.Show("Select The User You Want To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from UserTb where UserName=" + NameTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into UserTb values (" + NameTb.Text + "','" + MailTb.Text + "','" + PassTb.Text + "','" + UserCb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = DataPanel.SelectedRows[0].Cells[1].Value.ToString();
            MailTb.Text = DataPanel.SelectedRows[0].Cells[2].Value.ToString();
            PassTb.Text = DataPanel.SelectedRows[0].Cells[3].Value.ToString();
            UserCb.Text = DataPanel.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if ( NameTb.Text == "" || MailTb.Text == "" || PassTb.Text == "" || UserCb.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "Update UserTb set UserName = '" + NameTb.Text + "', UserMail = '" + MailTb.Text + "', UserPassword = '" + PassTb.Text + "' UserRole = '" + UserCb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    Con.Close();
                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            NameTb.Text = " ";
            MailTb.Text = " ";
            PassTb.Text = " ";
            UserCb.Text = " ";
        }

        /*private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand ("select UserRole from UserTb", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UserRole", typeof(string));
            dt.Load(rdr);
            UserCb.ValueMember = "UserRole";
            uSERCb.DataSource = dt;
            Con.Close();
        }*/

        private void CategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
