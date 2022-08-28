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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home F1 = new Home();
            this.Hide();
            F1.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTb values (" + IDtb.Text + ",'" + NameTb.Text + "','" + DescriptionTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataPanel.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtb.Text = DataPanel.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = DataPanel.SelectedRows[0].Cells[1].Value.ToString();
            DescriptionTb.Text = DataPanel.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "")
                {
                    MessageBox.Show("Select The Category You Want To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTb where CategoryID=" + IDtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
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
            IDtb.Text = " ";
            NameTb.Text = " ";
            DescriptionTb.Text = " ";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "" || NameTb.Text == "" || DescriptionTb.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTb set CategoryName = '" + NameTb.Text + "',CategoryDes = '" + DescriptionTb.Text + "' where CategoryID = " + IDtb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully");
                    Con.Close();
                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
