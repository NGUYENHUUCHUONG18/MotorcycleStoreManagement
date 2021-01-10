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
    public partial class frmQLNhanVien: Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public frmQLNhanVien()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QLXeMay-DB_SOFT;Integrated Security=True;");
        }
        //Load dữ liệu
        public void Load_Data()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataQLNV.DataSource, "MaNV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dataQLNV.DataSource, "TenNV");

            cboxGioiTinh.DataBindings.Clear();
            cboxGioiTinh.DataBindings.Add("Text", dataQLNV.DataSource, "GioiTinh");

            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", dataQLNV.DataSource, "NgaySinh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataQLNV.DataSource, "SDT");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataQLNV.DataSource, "DiaChi");

            cboxChucVu.DataBindings.Clear();
            cboxChucVu.DataBindings.Add("Text", dataQLNV.DataSource, "ChucVu");

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dataQLNV.DataSource, "CMND");

            dateNgayLam.DataBindings.Clear();
            dateNgayLam.DataBindings.Add("Text", dataQLNV.DataSource, "NgayVaoLam");
        }

        private void DongNhap()
        {
            foreach (Control c in panel_TTNV.Controls)
            {
                c.Enabled = false;
            }
        }
        private void MoNhap()
        {
            foreach (Control c in panel_TTNV.Controls)
            {
                c.Enabled = true;
            }
        }

        private void LoaddataNV()
        {
            con.Open();
            string sql = "select * from NhanVien";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataQLNV.DataSource = dt;
            con.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoaddataNV();
            this.Load_Data();
        }

        private void btnAddMaNV_Click(object sender, EventArgs e)
        {
            string row = dataQLNV.Rows[dataQLNV.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(2); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            //MessageBox.Show(i.ToString());
            txtMaNV.Text = "NV00" + i;
            txtTenNV.Clear();
            txtSDT.Clear();
            cboxGioiTinh.ResetText();
            dateNgaySinh.ResetText();
            cboxChucVu.ResetText();
            dateNgayLam.ResetText();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtTenNV.Focus();
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

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }

       

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            frmRP_DSNV f = new frmRP_DSNV();
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MoNhap();
                con.Open();
                cmd.Connection = con;
                string them = @"insert into NhanVien values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboxGioiTinh.Text + "','" + dateNgaySinh.Value.ToString("yyyy/MM/dd") + "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'" + cboxChucVu.Text + "','" + txtCMND.Text + "','" + dateNgayLam.Value.ToString("yyyy/MM/dd") + "')";
                cmd.CommandText = them;
                cmd.ExecuteNonQuery();
                LoaddataNV();
                con.Close();
                
                MessageBox.Show("Thành công");
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MoNhap();
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Nhân Viên: " + txtTenNV.Text + "\n Mã NV: " + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    MoConnect();
                    cmd.Connection = con;
                    string xoa = @"delete from NhanVien where MaNV='" + txtMaNV.Text + "'";
                    cmd = new SqlCommand(xoa, con);
                    cmd.ExecuteNonQuery();                
                    DongConnect();
                    LoaddataNV();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception)
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
            btnXacNhan.Visible = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //try
            //{
                //cmd.Connection = con;
                MoConnect();
                string capnhat = "update NhanVien set TenNV=N'" + txtTenNV.Text + "', GioiTinh=N'" + cboxGioiTinh.Text + "', NgaySinh='" + dateNgaySinh.Value.ToString("yyyy/MM/dd") + "', SDT='" + txtSDT.Text + "', DiaChi=N'" + txtDiaChi.Text + "', ChucVu=N'" + cboxChucVu.Text + "', CMND='" + txtCMND.Text + "', NgayVaoLam='" + dateNgayLam.Value.ToString("yyyy/MM/dd") + "' where MaNV='" + txtMaNV.Text + "'";
                MessageBox.Show(capnhat);
                cmd = new SqlCommand(capnhat, con);
                cmd.ExecuteNonQuery();
                //LoaddataNV();
                DongConnect();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            //}
            //catch
            //{
            //    MessageBox.Show("Cập nhật thất bại", "Thông báo");
            //}
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoaddataNV();
            Load_Data();
        }

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmQLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
       
    }
}
