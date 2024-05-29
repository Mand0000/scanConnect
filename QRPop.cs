using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanConnect
{
    public partial class QRPop : Form
    {
        bool isSave = false;
        private Registration regis = new Registration();
        public string name { get; set; }
        public QRPop()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                MessageBox.Show("Please Save This QrCode");
            } else
            {
                this.Hide();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = name + "'s QrCode";
            save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (save.ShowDialog() == DialogResult.OK)
            {
                qrPic.Image.Save(save.FileName);
                isSave = true;
            } 
        }
    }
}
