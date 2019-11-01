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

namespace hoadon
{
    public partial class KHACH : Form
    {
        public KHACH()
        {
            InitializeComponent();
        }
        BUS_KHACH bus = new BUS_KHACH();
        EC_KHACH ec = new EC_KHACH();
        bool themmoi;
        void KhoaDieuKien()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTaohoadon.Enabled = true;
            btnHuy.Enabled = false;
        }
        void MoDieuKien()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTaohoadon.Enabled = false;
            btnHuy.Enabled = true;
        }

        void SetNull()
        {
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
        }

        void HienThi(string where)
        {
            dskh.DataSource = bus.TaoBang(where);
        }
        private void KHACH_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            SetNull();
            themmoi = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text=="" || txtTenKH.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin");
                return;
            }
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        ec.MaKH = txtMaKH.Text;
                        ec.TenKH = txtTenKH.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        bus.Insert(ec);
                        MessageBox.Show("Đã thêm thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                else
                {

                    try
                    {
                        ec.MaKH = txtMaKH.Text;
                        ec.TenKH = txtTenKH.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        bus.Update(ec);
                        MessageBox.Show("Đã sửa thành công");

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKien();
                HienThi("");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            txtMaKH.Enabled = false;
            themmoi = false;
        }

        private void dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKien();
            try
            {
                txtMaKH.Text = dskh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dskh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dskh.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ec.MaKH = txtMaKH.Text;
                    bus.Delete(ec);
                    KhoaDieuKien();
                    HienThi("");
                    MessageBox.Show("Đã xóa thành công");
                    SetNull();
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể xóa");
                }
            }
        }

        private void btnTaohoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoadon = new HoaDon();
            hoadon.ShowDialog();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            SetNull();
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
