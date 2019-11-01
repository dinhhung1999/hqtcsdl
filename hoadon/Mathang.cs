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

namespace hoadon
{
    public partial class Mathang : Form
    {
        string conn = @"Data Source=DESKTOP-GN3V8MM\\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=SSPI";
        SqlConnection connect;
        SqlCommand command = new SqlCommand();
        public Mathang()
        {
            connect = new SqlConnection(conn);
            InitializeComponent();
        }
        private void dodulieu()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from MATHANG", connect);
            adapter.Fill(tb);
            tb_mathang.DataSource = tb;
        }
        private void Mathang_Load(object sender, EventArgs e)
        {
            dodulieu();
            connect.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmathang();
        }
        private void themmathang()
        {


            try
            {
                command.Connection = connect;
                command.CommandText = "insert into MATHANG values ('" + txtmamh.Text + "', N'" + txttenmh.Text + "','" + txtsoluong.Text + "','" + txtgiamh.Text + "','" + txtnsx.Text + "', N'" + txtmagh.Text + "', N'" + txtmanv.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dodulieu();

            }
            catch (SqlException e)
            {
                MessageBox.Show("" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtbmagh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            suamathang();
        }

        private void suamathang()
        {


            try
            {
                command.Connection = connect;
                command.CommandText = "update MATHANG set TenMH = N'" + txttenmh.Text + "',SoLuong='" + txtsoluong.Text + "',GiaMH = '" + txtgiamh.Text + "',NSX = '" + txtnsx.Text + "',MaGH = N'" + txtmagh.Text + "',MaNV = N'" + txtmanv.Text + "' where MaMH =  '" + txtmamh.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dodulieu();

            }
            catch (SqlException e)
            {
                MessageBox.Show("" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

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
