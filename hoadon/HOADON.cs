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
using System.Data.SqlClient;
using System.Timers;
namespace hoadon
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        BUS_HOADON bushd = new BUS_HOADON();
        BUS_CTIETHD buscthd = new BUS_CTIETHD();
        BUS_KHACH busk = new BUS_KHACH();
        int dong = 0;
        EC_CTIETHD CTHD = new EC_CTIETHD();
        EC_HOADON HD = new EC_HOADON();
        bool themmoi;
        string nowaday = DateTime.Now.ToString();
        void KhoaDieuKien()
        {
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            txtNgayLap.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnKhach.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
        }
        void MoDieuKien()
        {
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            txtNgayLap.Enabled = false;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnKhach.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
        }

        void SetNull()
        {
            txtMaHD.Text = "";
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            txtNgayLap.Text = nowaday;
            txtMaKH.DataSource = busk.TaoBang("");
            txtMaKH.ValueMember = "MaKH";
            txtMaKH.DisplayMember = "MaKH";
            colMaMH.DataSource = buscthd.LayTTHANG("Where SoLuong > 0");
            colMaMH.ValueMember = "MaMH";
            colMaMH.DisplayMember = "TenMH";
            txtMaNV.Text = "NV01";
            KhoaDieuKien();
        }
        private void dshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dshd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dt = new DataTable();
            if (dshd.Rows[dong].Cells[1].Value != "0" && dshd.Rows[dong].Cells[2].Value != "0")
            {
                try
                {
                    dshd.Rows[dong].Cells[3].Value = (double.Parse(dshd.Rows[dong].Cells[1].Value.ToString()) * double.Parse(dshd.Rows[dong].Cells[2].Value.ToString())).ToString();
                }
                catch
                {
                }
            }
            try
            {
                dt = buscthd.LayTTHANG("Where MaMH ='" + dshd.Rows[dong].Cells[0].Value.ToString() + "'");
                dshd.Rows[dong].Cells[2].Value = double.Parse(dt.Rows[0]["GiaMH"].ToString()).ToString();

            }
            catch
            {
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin");
                return;
            }
            else
            {           
                try
                {
                HD.MaNV = "NV01";
                HD.MaHD = txtMaHD.Text;
                HD.MaKH = txtMaKH.Text;
                HD.NgayBan = "10/30/2019";
                bushd.Insert(HD); 
                }
                catch
                {
                    MessageBox.Show("Tạo hóa đơn thất bại");
                    return;
                }
                try
                {
                    for (int i = 0; i < dshd.Rows.Count - 1; i++)
                    {
                        CTHD.MaHD = txtMaHD.Text;
                        CTHD.MaMH = dshd.Rows[i].Cells[0].Value.ToString();
                        CTHD.SoLuongMua = dshd.Rows[i].Cells[1].Value.ToString();
                        buscthd.Insert(CTHD);
                    }
                    MessageBox.Show("Tạo hóa đơn thành công");
                }
                catch
                {
                    MessageBox.Show("Tạo hóa đơn thất bại");
                }
                SetNull();
                KhoaDieuKien();
                themmoi = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKien();
            SetNull();
        }
        private void dshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            SetNull();
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            this.Hide();
            KHACH khach = new KHACH();
            khach.ShowDialog();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSHD dshd = new DSHD();
            dshd.ShowDialog();
            this.Close();
        }
    }
}
