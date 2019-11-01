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
    public partial class f_GianHang : Form
    {
        public f_GianHang()
        {
            InitializeComponent();
        }
        BUS_GianHang bus = new BUS_GianHang();
        EC_GianHang ec = new EC_GianHang();
        bool themmoi;
        void KhoaDieuKhien()
        {
            txtbmagh.Enabled = false;
            txtbtengh.Enabled = false;
            txtbvitri.Enabled = false;
            txtbmanv.Enabled = false;

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtbmagh.Enabled = true;
            txtbtengh.Enabled = true;
            txtbvitri.Enabled = true;
            txtbmanv.Enabled = true;

            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
        }

        void SetNull()
        {
            txtbmagh.Text = "";
            txtbtengh.Text = "";
            txtbvitri.Text = "";
            txtbmanv.Text = "";
        }
        void HienThi(string where)
        {
            msds.DataSource = bus.LayDuLieu(where);
        }

        private void f_GianHang_Load(object sender, EventArgs e)
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtbmagh.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaGH = txtbmagh.Text;
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtbmagh.Text == "" || txtbtengh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                return;
            }

            if (themmoi == true)
            {
                try
                {
                    ec.MaGH = txtbmagh.Text;
                    ec.TenGH = txtbtengh.Text;
                    ec.ViTri = txtbvitri.Text;
                    ec.MaNV = txtbmanv.Text;
                    //ec. = "true";
                    HienThi("");
                    bus.ThemDuLieu(ec);
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
                    ec.MaGH = txtbmagh.Text;
                    ec.TenGH = txtbtengh.Text;
                    ec.ViTri = txtbvitri.Text;
                    ec.MaNV = txtbmanv.Text;
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

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbmagh.Text = msds.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbtengh.Text = msds.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbvitri.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbmanv.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
