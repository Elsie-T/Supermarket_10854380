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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillChart()
        {
            DataSet ds = new DataSet();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Price, Quantity from ProductTb", Con);
            adapter.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Quantity"].XValueMember = "Price";
            chart1.Series["Quantity"].YValueMembers = "Quantity";
            chart1.Titles.Add("Product Chart");
            Con.Close();
        }

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

        private void Stock_Load(object sender, EventArgs e)
        {
            fillChart();
            populate();
        }

        private void DataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home F1 = new Home();
            this.Hide();
            F1.Show();
        }
    }
}
