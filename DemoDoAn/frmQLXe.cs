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
    public partial class frmQLXe : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        public frmQLXe()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QLXeMay-DB_SOFT;Integrated Security=True;");
        }
        public void Load_Data()
        {
            txtMaXe.DataBindings.Clear();
            txtMaXe.DataBindings.Add("Text", dataXe.DataSource, "MaXe");

            txtTenXe.DataBindings.Clear();
            txtTenXe.DataBindings.Add("Text", dataXe.DataSource, "TenXe");

            cboxLoaiXe.DataBindings.Clear();
            cboxLoaiXe.DataBindings.Add("Text", dataXe.DataSource, "TenLoaiXe");

            cboxNSX.DataBindings.Clear();
            cboxNSX.DataBindings.Add("Text", dataXe.DataSource, "TenNSX");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dataXe.DataSource, "GiaBan");

            dateNhap.DataBindings.Clear();
            dateNhap.DataBindings.Add("Text", dataXe.DataSource, "NgayNhap");

            BH.DataBindings.Clear();
            BH.DataBindings.Add("Text", dataXe.DataSource, "BaoHanh");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dataXe.DataSource, "SoLuong");

            txtSoKhung.DataBindings.Clear();
            txtSoKhung.DataBindings.Add("Text", dataXe.DataSource, "SoKhung");

            txtSoMay.DataBindings.Clear();
            txtSoMay.DataBindings.Add("Text", dataXe.DataSource, "SoMay");

            txtBoTriXL.DataBindings.Clear();
            txtBoTriXL.DataBindings.Add("Text", dataXe.DataSource, "BoTriXyLanh");

            txtDungTichXL.DataBindings.Clear();
            txtDungTichXL.DataBindings.Add("Text", dataXe.DataSource, "DungTichXyLanh");

            txtMau.DataBindings.Clear();
            txtMau.DataBindings.Add("Text", dataXe.DataSource, "Mau");

            txtKhoiDong.DataBindings.Clear();
            txtKhoiDong.DataBindings.Add("Text", dataXe.DataSource, "KhoiDong");

            txtBinhXang.DataBindings.Clear();
            txtBinhXang.DataBindings.Add("Text", dataXe.DataSource, "BinhXang");

            txtLoaiDC.DataBindings.Clear();
            txtLoaiDC.DataBindings.Add("Text", dataXe.DataSource, "LoaiDongCo");
        }
        private void LoaddataXe()
        {
            con.Open();
            string sql = "select * from Xe";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataXe.DataSource = dt;
            con.Close();
        }
        public void Load_cboxLoaiXe()
        {
            //con.Open();
            string sql = "select * from LoaiXe";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            da.Fill(dt);
            cboxLoaiXe.DataSource = dt;
            cboxLoaiXe.ValueMember = "MaLoaiXe";
            cboxLoaiXe.DisplayMember = "TenLoaiXe";      
            //con.Close();
        }
        //
        public void Load_cboxNSX()
        {
            //con.Open();
            string sql = "select * from NhaSanXuat";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            dt = new DataTable();
            da.Fill(dt);
            cboxNSX.DataSource = dt;
            cboxNSX.DisplayMember = "TenNSX";//Word là tên trường bạn muốn hiển thị trong combobox
            cboxNSX.ValueMember = "MaNSX";
            //con.Close();
            
        }
        

        private void frmXe_Load(object sender, EventArgs e)
        {
            LoaddataXe();
            Load_Data();
            
            Load_cboxLoaiXe();
            Load_cboxNSX();
            
        }

        private void addLoaiXe_Click(object sender, EventArgs e)
        {
            frmLoaiXe f = new frmLoaiXe();
            f.Show();
        }

        private void addNSX_Click(object sender, EventArgs e)
        {
            frmNSX f = new frmNSX();
            f.Show();
        }
        public void TinhSoLuong()
        {
            int sum = 0;
            for (int i = 0; i < dataXe.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataXe.Rows[i].Cells[8].Value);
            }
            txtTongSL.Text = sum.ToString();
        }
        private void DongNhap()
        {
            foreach (Control c in panel_Xe.Controls)
            {
                c.Enabled = false;
            }
        }
        private void MoNhap()
        {
            foreach (Control c in panel_Xe.Controls)
            {
                c.Enabled = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaXe.Text == "")
                {
                    MessageBox.Show("Vui lòng thêm Mã Xe!", "Thông Báo");
                    return;
                }
                if (txtTenXe.Text == "")
                {
                    MessageBox.Show("Vui lòng thêm Tên Xe!", "Thông Báo");
                    return;
                }
                    MoNhap();
                    con.Open();
                    string them = "insert into Xe values('" + txtMaXe.Text + "',N'" + txtTenXe.Text + "',N'" + cboxLoaiXe.Text + "','" + cboxNSX.Text + "','" + dateNhap.Value.ToString("yyyy/MM/dd") + "','" + txtGiaBan.Text + "','" + BH.ToString() + "','" + txtSoLuong.Text + "',N'" + txtSoKhung.Text + "',N'" + txtSoMay.Text + "',N'" + txtMau.Text + "',N'" + txtLoaiDC.Text + "',N'" + txtBoTriXL.Text + "',N'" + txtDungTichXL.Text + "',N'" + txtKhoiDong.Text + "',N'" + txtBinhXang.Text + "')";
                    cmd = new SqlCommand(them,con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thành công");
                    Load_Data();
                //}
            }
            catch (Exception) { }
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    string xoa = @"delete from Xe where MaXe='" + txtMaXe.Text + "'";
        //    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Xe: " + txtTenXe.Text + "\n Tại Kho: " + cboxKho.Text + "\n Mã Xe: " + txtMaXe.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dialog == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            DatabaseService.executeQuery(xoa);
        //            AutoClosingMessageBox.Show("Xóa thành công.", "Thông báo", 500);
        //            Load_Data();
        //            Load_cboxTenKho();
        //        }
        //        catch (Exception)
        //        {
        //        }
        //    }
        //    else if (dialog == DialogResult.No)
        //    {
        //        //
        //    }
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
       
        //        string capnhat = @"update Xe set TenXe=N'" + txtTenXe.Text + "', MaLoaiXe='" + cboxMaLoaiXe.Text + "', MaNSX='" + cboxMaNSX.Text + "', NgayNhap='" + dateNhap.Text + "', GiaBan='" + txtGiaBan.Text + "', MaKho=N'" + cboxMaKho.Text + "', BaoHanh='" + BH.Text + "', SoLuong='" + txtSoLuong.Text + "', SoKhung='" + txtSoKhung.Text + "', SoMay='" + txtSoMay.Text + "', Mau=N'" + txtMau.Text + "', LoaiDongCo=N'" + txtLoaiDC.Text + "', BoTriXyLanh=N'" + txtBoTriXL.Text + "', DungTichXyLanh=N'" + txtDungTichXL.Text + "', KhoiDong=N'" + txtKhoiDong.Text + "', BinhXang=N'" + txtBinhXang.Text + "' where MaXe='" + txtMaXe.Text + "'";
        //        DatabaseService.executeQuery(capnhat);
        //        Load_cboxTenKho();
        //        AutoClosingMessageBox.Show("Cập nhật thành công.", "Thông báo", 500);
        //        Load_Data();
        //    }
        //}

        private void txtDungTichXL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Load_cboxLoaiXe();
        }

        private void addMaxe_Click(object sender, EventArgs e)
        {
            string row = dataXe.Rows[dataXe.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(2); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            if (i > 10)
                txtMaXe.Text = "XE00" + i;
            else
                txtMaXe.Text = "XE000" + i;
            txtTenXe.Clear();
            BH.ResetText();
            cboxLoaiXe.ResetText();
            cboxNSX.ResetText();
            dateNhap.ResetText();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtSoKhung.Clear();
            txtSoMay.Clear();
            txtMau.Focus();
            txtLoaiDC.Clear();
            txtBoTriXL.Clear();
            txtDungTichXL.Clear();
            txtKhoiDong.Clear();
            txtBinhXang.Clear();
            txtTenXe.Focus();
        }

        private void frmQLXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
