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
using System.Data;
using System.Data.SqlClient;
namespace hoadon
{
    public partial class f_MatHang : Form
    {
        public f_MatHang()
        {
            InitializeComponent();
        }

        BUS_MATHANG bus = new BUS_MATHANG();
        EC_MatHang ec = new EC_MatHang();
        bool themmoi;
        void KhoaDieuKhien()
        {
            txtbmamh.Enabled = false;
            txtbtenmh.Enabled = false;
            txtbsoluong.Enabled = false;
            txtbgiamh.Enabled = false;
            txtbmagh.Enabled = false;
            txtbnsx.Enabled = false;
            txtbmanv.Enabled = false;



            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtbmamh.Enabled = true;
            txtbtenmh.Enabled = true;
            txtbsoluong.Enabled = true;
            txtbgiamh.Enabled = true;
            txtbmagh.Enabled = true;
            txtbnsx.Enabled = true;
            txtbmanv.Enabled = true;

            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
        }

        void SetNull()
        {
            txtbmamh.Text = "";
            txtbtenmh.Text = "";
            txtbsoluong.Text = "";
            txtbgiamh.Text = "";
            txtbmagh.Text = "";
            txtbnsx.Text = "";
            txtbmanv.Text = "";

        }
        void HienThi(string where)
        {
            msds.DataSource = bus.TaoBang(where);
        }
        private void f_MatHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaMH1 = txtbmamh.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtbmamh.Enabled = false;
            themmoi = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtbmamh.Text == "" || txtbtenmh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                return;
            }

            if (themmoi == true)
            {
                try
                {
                    ec.MaMH1 = txtbmamh.Text;
                    ec.TenMH1 = txtbtenmh.Text;
                    ec.SoLuong1 = txtbsoluong.Text;
                    ec.GiaMH1 = txtbgiamh.Text;
                    ec.NSX1 = txtbnsx.Text;
                    ec.MaGH1 = txtbmagh.Text;
                    ec.MaNV1 = txtbmanv.Text;

                    //ec.TinhTrang = "true";
                    bus.ThemDuLieu(ec);
                    HienThi("");

                    MessageBox.Show("Đã thêm mới thành công!");

                }
                catch
                {
                    MessageBox.Show("Không lưu được!");
                    return;
                }
            }
            else
            {
                try
                {
                    ec.MaMH1 = txtbmamh.Text;
                    ec.TenMH1 = txtbtenmh.Text;
                    ec.SoLuong1 = txtbsoluong.Text;
                    ec.GiaMH1 = txtbgiamh.Text;
                    ec.NSX1 = txtbnsx.Text;
                    ec.MaGH1 = txtbmagh.Text;
                    ec.MaNV1 = txtbmanv.Text;
                    //ec.TinhTrang = "true";
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Đã sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không lưu được!");
                    return;
                }
            }
            SetNull();
            KhoaDieuKhien();
            HienThi("");
        }

        private void btnql_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu dshd = new Trangchu();
            dshd.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbmamh.Text = msds.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbtenmh.Text = msds.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbsoluong.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbgiamh.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbnsx.Text = msds.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbmagh.Text = msds.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtbmanv.Text = msds.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
