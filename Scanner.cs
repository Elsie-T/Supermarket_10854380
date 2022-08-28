using IronBarCode;
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
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BarcodePictureBox.Image = Image.FromFile(openFileDialog.FileName); 
                    BarcodePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(BarcodePictureBox.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

                    if (result != null)
                        resultTextBox.Text = result.ToString(); 
                }
            }
        }
    }
}
