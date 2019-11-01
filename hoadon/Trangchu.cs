using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoadon
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KHACH dshd = new KHACH();
            dshd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dshd = new Form1();
            dshd.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_MatHang dshd = new f_MatHang();
            dshd.ShowDialog();
            this.Close();
        }

        private void gianhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_GianHang dshd = new f_GianHang();
            dshd.ShowDialog();
            this.Close();
        }
    }
}
