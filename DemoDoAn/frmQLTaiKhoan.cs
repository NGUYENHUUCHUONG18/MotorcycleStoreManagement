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

namespace DemoDoAn
{
    public partial class frmQLTaiKhoan : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        public frmQLTaiKhoan()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QL_CuaHangXeMay;Integrated Security=True;");
        }

        private void LoaddataPhanQuyen()
        {
            con.Open();
            string sql = "select * from DangNhap";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataQLTK.DataSource = dt;
            con.Close();
        }

        public void Load_Data()
        {
            cboxMaNV.DataBindings.Clear();
            cboxMaNV.DataBindings.Add("Text", dataQLTK.DataSource, "MaNV");

            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dataQLTK.DataSource, "TaiKhoan");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataQLTK.DataSource, "MatKhau");

            cboxPhanQuyen.DataBindings.Clear();
            cboxPhanQuyen.DataBindings.Add("Text", dataQLTK.DataSource, "PhanQuyen");
        }
        public void Load_cboxMaNhanVien()
        {
         string sql = "select * from NhanVien";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "NhanVien");
            cboxMaNV.DataSource = ds.Tables[0];
            cboxMaNV.ValueMember = "MaNV";
            cboxMaNV.DisplayMember = "MaNV";   
        }

        public void Load_cboxPhanQuyen()
        {
            string sql = "select * from DangNhap";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "DangNhap");
            cboxPhanQuyen.DataSource = ds.Tables[0];
            cboxPhanQuyen.ValueMember = "PhanQuyen";
            cboxPhanQuyen.DisplayMember = "PhanQuyen";
        }
       
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoaddataPhanQuyen();
            Load_Data();
            Load_cboxMaNhanVien();
            Load_cboxPhanQuyen();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
                con.Open();
                string them = @"insert into DangNhap values('" + cboxMaNV.Text + "','" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "',N'" + cboxPhanQuyen.Text + "')";
                cmd = new SqlCommand(them,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                con.Close();
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Không thể thêm!");
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa tài khoản của nhân viên : " + cboxMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string xoa = @"delete from DangNhap where MaNV='" + cboxMaNV.Text + "'";
                    cmd = new SqlCommand(xoa, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    Load_Data();
                    con.Close();
                }
                catch (Exception)
                {
                }
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            string capnhat = "update DangNhap set TaiKhoan='" + txtTaiKhoan.Text + "', MatKhau='" + txtMatKhau.Text + "' where MaNV='" + cboxMaNV.SelectedItem.ToString() + "'";
            cmd = new SqlCommand(capnhat, con);
            MessageBox.Show("Xóa thành công.", "Thông báo");
            Load_Data();
            con.Close();
        }

        private void cboxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cboxPhanQuyen.ResetText();
        }

    }
}
