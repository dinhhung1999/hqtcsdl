using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiBUS;
using QuanLySieuThiEntity;
using System.Data;

namespace hoadon
{
    public partial class Form1 : Form
    {
        NhanvienBLL nvbll;
        public Form1()
        {
            InitializeComponent();
            nvbll = new NhanvienBLL();
        }
        public void showNV()
        {
            DataTable dt = nvbll.getAllNhanVien();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txt_Manv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Manv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_tennv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_quequan.Text))
            {
                MessageBox.Show("Bạn chưa nhập Quên quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_quequan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_phone.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_Luong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Bậc Lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_quequan.Focus();
                return false;
            }
            return true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Themnv_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txt_Manv.Text;
                nv.TenNV = txt_tennv.Text;
                nv.Quequan = txt_quequan.Text;
                nv.Sdt = txt_phone.Text;
                nv.Ngaysinh = txt_ngaysinh.Text;
                nv.BacLuong = txt_Luong.Text;
                nv.Maql = cb_Maql.Text;

                if (nvbll.Insert_nv(nv))
                {
                    showNV();
                    MessageBox.Show("Insert thanh cong", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txt_Manv.Text;
                nv.TenNV = txt_tennv.Text;
                nv.Quequan = txt_quequan.Text;
                nv.Sdt = txt_phone.Text;
                nv.Ngaysinh = txt_ngaysinh.Text;
                nv.BacLuong = txt_Luong.Text;
                nv.Maql = cb_Maql.Text;

                if (nvbll.Update_nv(nv))
                {
                    showNV();
                    MessageBox.Show("Update thanh cong", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txt_Manv.Text;
                nvbll.Delete_nv(nv);
                if (nvbll.Delete_nv(nv))
                {
                    showNV();
                    MessageBox.Show("Delete thanh cong", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showNV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txt_Manv.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_tennv.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txt_ngaysinh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txt_quequan.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txt_phone.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txt_Luong.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                cb_Maql.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();

            }
            else
            {
                MessageBox.Show("Loi", "Thong bao");
            }
        }

        private void btnql_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu dshd = new Trangchu();
            dshd.ShowDialog();
            this.Close();
        }
    }
}
