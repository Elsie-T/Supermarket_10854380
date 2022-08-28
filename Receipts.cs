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
    public partial class Receipts : Form
    {
        public Receipts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ektet\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CnameTb.Text = " ";
            AnameTb.Text = " ";
            ProdTb.Text = " ";
            PriceTb.Text = " ";
            QuanTb.Text = " ";
            DateTb.Text = " ";
            SigTb.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ReceiptsTb values ("+ CnameTb.Text +" ,' "+ AnameTb.Text +" ',' "+ ProdTb.Text +" ',' "+ PriceTb.Text +" ',' "+ QuanTb.Text +" ',' "+ DateTb.Text +" ',' "+ SigTb.Text +"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Receipt Saved!");
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AttendantHome F1 = new AttendantHome();
            this.Hide();
            F1.Show();
        }
    }
}
