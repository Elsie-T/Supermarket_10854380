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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataPanel.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            populate();
            //fillcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home F1 = new Home();
            this.Hide();
            F1.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTb values (" + IDtb.Text + ",'" + NameTb.Text + "','" + PriceTb.Text + "','" + QuantityTb.Text + "','" + CategoryCb.Text + "','" + DescriptionTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtb.Text = DataPanel.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = DataPanel.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = DataPanel.SelectedRows[0].Cells[2].Value.ToString();
            QuantityTb.Text = DataPanel.SelectedRows[0].Cells[3].Value.ToString();
            CategoryCb.Text = DataPanel.SelectedRows[0].Cells[4].Value.ToString();
            DescriptionTb.Text = DataPanel.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "")
                {
                    MessageBox.Show("Select The Product You Want To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTb where ProductID=" + IDtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "" || NameTb.Text == "" || PriceTb.Text == "" || QuantityTb.Text == "" || CategoryCb.Text == "" || DescriptionTb.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "Update ProductTb set ProductName = '" + NameTb.Text + "', Price = '" + PriceTb.Text + "', Quantity = '" + QuantityTb.Text + "', Category = '" + CategoryCb.Text + "', Description = '" + DescriptionTb.Text + "' where ProductID = " + IDtb.Text + ";";
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
            IDtb.Text = " ";
            NameTb.Text = " ";
            PriceTb.Text = " ";
            QuantityTb.Text = " ";
            CategoryCb.Text = " ";
            DescriptionTb.Text = " ";
        }

        /*private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTb", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            CategoryCb.ValueMember = "CatgoryName";
            CategoryCb.DataSource = dt;
            Con.Close();
        }*/

        private void CategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
