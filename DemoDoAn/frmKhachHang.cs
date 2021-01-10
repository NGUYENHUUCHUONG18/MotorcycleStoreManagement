using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoDoAn
{
    public partial class frmKhachHang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public frmKhachHang()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QL_CuaHangXeMay;Integrated Security=True;");
        }
        
        public void Load_Data()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dataQLKH.DataSource, "MaKH");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dataQLKH.DataSource, "TenKH");

            cboxGioiTinh.DataBindings.Clear();
            cboxGioiTinh.DataBindings.Add("Text", dataQLKH.DataSource, "GioiTinh");

            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", dataQLKH.DataSource, "NgaySinh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataQLKH.DataSource, "SDT");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataQLKH.DataSource, "DiaChi");

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dataQLKH.DataSource, "CMND");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataQLKH.DataSource, "GhiChu");
        }
       
       
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoaddataKH();
            this.Load_Data();
        }

        private void DongNhap()
        {
            foreach (Control c in panel_KH.Controls)
            {
                c.Enabled = false;
            }
        }
        private void MoNhap()
        {
            foreach (Control c in panel_KH.Controls)
            {
                c.Enabled = true;
            }
        }
//-----------------Lấy dữ liệu từ database load lên datagridview----------------------------
        private void LoaddataKH()
        {
            con.Open();
            string sql = "select * from KhachHang";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataQLKH.DataSource = dt;
            con.Close();
        }
//--------------------Thêm khách hàng--------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MoNhap();
                con.Open();
                string them = "insert into KhachHang values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + cboxGioiTinh.Text + "','" + dateNgaySinh.Value.ToString("yyyy/MM/dd") + "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "','" + txtCMND.Text + "','" + txtGhiChu.Text + "')";
                cmd = new SqlCommand(them,con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoaddataKH();
                MessageBox.Show("Thêm thành công","Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại","Thông báo");
            }
        }
//------------------------Tạo mã khách hàng--------------------------
        private void btnAddMaKH_Click(object sender, EventArgs e)
        {
            string row = dataQLKH.Rows[dataQLKH.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(2); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            txtMaKH.Text = "KH00" + i;         
            txtTenKH.Clear();
            txtSDT.Clear();
            cboxGioiTinh.ResetText();
            dateNgaySinh.ResetText();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtGhiChu.Clear();
            txtTenKH.Focus();
        }

        private void DongConnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void MoConnect()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
//-------------Xóa khách hàng---------------------------------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MoNhap();
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Khách Hàng: " + txtTenKH.Text + "\n Mã NV: " + txtMaKH.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    MoConnect();
                    cmd.Connection = con;
                    string xoa = "delete from KhachHang where MaKH='" + txtMaKH.Text + "'";
                    cmd = new SqlCommand(xoa, con);
                    cmd.ExecuteNonQuery();
                    DongConnect();
                    LoaddataKH();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoNhap();
            try
            {
                MoConnect();
                string capnhat = "update KhachHang set TenKH=N'" + txtTenKH.Text + "', GioiTinh=N'" + cboxGioiTinh.Text + "', NgaySinh='" + dateNgaySinh.Value.ToString("yyyy/MM/dd") + "', SDT='" + txtSDT.Text + "', DiaChi=N'" + txtDiaChi.Text + "', CMND='" + txtCMND.Text + "', GhiChu=N'" + txtGhiChu.Text + "' where MaKH='" + txtMaKH.Text + "'";
                MessageBox.Show(capnhat);
                cmd = new SqlCommand(capnhat, con);
                cmd.ExecuteNonQuery();
                //LoaddataNV();
                DongConnect();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //string TimKiemTS = @"select * from KhachHang where MaKH LIKE N'%" + txtTim.Text + "%' or TenKH LIKE N'%" + txtTim.Text + "%'";
            //DataTable dt = DatabaseService.getDataTable(TimKiemTS);
            //dataQLKH.DataSource = dt;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
