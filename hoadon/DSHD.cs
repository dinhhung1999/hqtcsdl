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
using QuanLySieuThiDAL;
using QuanLySieuThiEntity;

namespace hoadon
{
    public partial class DSHD : Form
    {
        public DSHD()
        {
            InitializeComponent();
        }
        BUS_DSHD buscthd = new BUS_DSHD();
        EC_DSHD ds = new EC_DSHD();
        void KhoaDieuKien()
        {
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaMH.Enabled = false;
            txtNgayLap.Enabled = false;
            txtThanhTien.Enabled = false;
            txtSoLuong.Enabled = false;
            txtMaNV.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
        }
        void MoDieuKien()
        {
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = true;
            txtMaMH.Enabled = true;
            txtNgayLap.Enabled = false;
            txtThanhTien.Enabled = false;
            txtSoLuong.Enabled = true;
            txtMaNV.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
        }
        void HienThi(string where)
        {
            dskh.DataSource = buscthd.LayDSHD(where);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DSHD_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //KhoaDieuKien();
            try
            {
                txtMaHD.Text = dskh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaKH.Text = dskh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaMH.Text = dskh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgayLap.Text = dskh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSoLuong.Text = dskh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtThanhTien.Text = dskh.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMaNV.Text = dskh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ds.MaHD = txtMaHD.Text;
                    buscthd.Delete(ds);
                    KhoaDieuKien();
                    HienThi("");
                    MessageBox.Show("Đã xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể xóa");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoadon = new HoaDon();
            hoadon.ShowDialog();
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtSoLuong.Text == "" || txtMaNV.Text == "" || txtMaMH.Text =="")
            {
                MessageBox.Show("Xin mời nhập thông tin");
                return;
            }
            try
            {
                ds.MaKH = txtMaKH.Text;
                ds.MaHD = txtMaHD.Text;
                ds.MaMH = txtMaMH.Text;
                ds.MaNV = txtMaNV.Text;
                ds.NgayLap = txtNgayLap.Text;
                ds.SoLuongMua = txtSoLuong.Text;
                ds.ThanhTien = txtThanhTien.Text;
                buscthd.Update(ds);
                HienThi("");
                MessageBox.Show("Đã sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaDieuKien();
        }
    }
}
