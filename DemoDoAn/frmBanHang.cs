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
    public partial class frmBanHang : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        string username;
        string MaHoaDon, MaKhachHang;
        public frmBanHang()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QLXeMay-DB_SOFT;Integrated Security=True;");
        }

        private void LoaddataBanHang()
        {
            con.Open();
            string sql = "select * from HoaDon";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataQuanLyBanHang.DataSource = dt;
            con.Close();
        }
        
        //Load data
        public void Load_Data()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "MaHD");

            cboxMaNV.DataBindings.Clear();
            cboxMaNV.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "MaNV");

            cboxMaKH.DataBindings.Clear();
            cboxMaKH.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "MaKH");

            dateBan.DataBindings.Clear();
            dateBan.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "NgayBan");

            cboxMaXe.DataBindings.Clear();
            cboxMaXe.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "MaXe");

            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "SoLuong");

            txtTiGia.DataBindings.Clear();
            txtTiGia.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "TiGia");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "ThanhTien");

            txtThue.DataBindings.Clear();
            txtThue.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "ThueGTGT");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataQuanLyBanHang.DataSource, "TongTien");
        }
        // --> Load Nhân Viên
        public void Load_cboxMaNhanVien()
        {
            string sql = "select * from NhanVien";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds,"NhanVien");
            cboxMaNV.DataSource = ds.Tables[0];
            cboxMaNV.ValueMember = "MaNV";
            cboxMaNV.DisplayMember = "MaNV";
        }
        // -- Load Khách Hàng
        public void Load_cboxMaKhachHang()
        {
            string sql = "select * from KhachHang";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "KhachHang");
            cboxMaKH.DataSource = ds.Tables[0];
            cboxMaKH.ValueMember = "MaKH";
            cboxMaKH.DisplayMember = "MaKH";
        }
        // Load --> Xe
        public void Load_cboxMaXe()
        {
            string sql = "select * from Xe";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Xe");
            cboxMaXe.DataSource = ds.Tables[0];
            cboxMaXe.ValueMember = "MaXe";
            cboxMaXe.DisplayMember = "MaXe";
        }
        public void Load_cboxMau()
        {
            string sql = "select * from Xe";
            da = new SqlDataAdapter(sql, con);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, con là connection đến cơ sở dữ liệu
            dt = new DataTable();
            da.Fill(dt);
            cboxMau.DataSource = dt;
            cboxMau.ValueMember = "Mau";
            cboxMau.DisplayMember = "Mau";
        }    

        private void addMaHD_Click(object sender, EventArgs e)
        {
            string row = dataQuanLyBanHang.Rows[dataQuanLyBanHang.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(2); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            if (i > 10)
                txtMaHD.Text = "HD00" + i;
            else
                txtMaHD.Text = "HD000" + i;
            //cboxMaKho.ResetText();
            cboxMaNV.ResetText();
            cboxMaKH.ResetText();
            dateBan.ResetText();
            cboxMaXe.ResetText();
            txtTenKH.Clear();
            txtTenNV.Clear();
            txtTenXe.Clear();
            txtSoKhung.Clear();
            txtSoMay.Clear();
            cboxMau.ResetText();
            txtSL.Clear();
            txtGiaBan.Clear();
            txtTiGia.Clear();
            txtThanhTien.Clear();
            txtThue.Clear();
            txtTongTien.Clear();
        }

        private void txtTigia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46);
        }

        public void ThanhTien()
        {
            if (txtSL.Text == "") 
                MessageBox.Show("Vui lòng nhập số lượng xe cần bán.");
            if (txtTiGia.Text == "")
                MessageBox.Show("Vui lòng nhập tỉ giá.");
            else
            {
                int SoLuong, GiaBan;
                float TiGia, ThanhTien;

                SoLuong = int.Parse(txtSL.Text);
                GiaBan = int.Parse(txtGiaBan.Text);
                TiGia = float.Parse(txtTiGia.Text);
                ThanhTien = SoLuong * TiGia * GiaBan;
                txtThanhTien.Text = ThanhTien.ToString("0");
            }
        }
        public void TongTien()
        {
            if (txtThue.Text == "")
                MessageBox.Show("Vui lòng nhập thuế VAT.");
            else
            {
                int ThueGTGT;
                float ThanhTien, TongTien;
                ThanhTien = float.Parse(txtThanhTien.Text);
                ThueGTGT = int.Parse(txtThue.Text);
                TongTien = ThanhTien + ((ThanhTien / 100) * ThueGTGT);
                txtTongTien.Text = TongTien.ToString("0");
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoaddataBanHang();
            Load_Data();
            //Load_cboxGiaBan();
            Load_cboxMaKhachHang();
            //Load_cboxMaKhoHang();
            Load_cboxMaNhanVien();
            Load_cboxMau();
            Load_cboxMaXe();
            //Load_cboxSoKhung();
            //Load_cboxSoMay();
        }      
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataQuanLyBanHang.Rows.Count - 1; i++)
            {
                if (dataQuanLyBanHang.Rows[i].Cells["Ma"].Value.ToString() == txtMaHD.Text)
                {
                    MessageBox.Show("Đã có Mã Hóa Đơn này rồi.\nVui lòng kiểm tra lại!");
                    return;
                }
            }
            //string LoaiKH = "";
            //if (rdo_Le.Checked == true)
            //    LoaiKH = "Khách Lẻ";
            //if (rdo_Si.Checked == true)
            //    LoaiKH = "Khách Sỉ";
            string them = "insert into HoaDon values('" + txtMaHD.Text + "','"+cboxMaNV.Text+"','" + cboxMaKH.Text + "','" + dateBan.Text + "','" + cboxMaXe.Text + "','" + txtSL.Text + "','" + txtTiGia.Text + "','" + txtThanhTien.Text + "','" + txtThue.Text + "','" + txtTongTien.Text + "')";
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng thêm Mã Hóa Đơn.", "Thông báo");
                return;
            }
            if (txtThanhTien.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng thực hiện tính tiền trước khi lưu trữ.");
                return;
            }
            else
            {
                DatabaseService.executeQuery(them);
                AutoClosingMessageBox.Show("Lưu thành công.", "Thông báo", 500);
                Load_Data();
            }
        }

        private void cbo_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select TenKH from KhachHang where MaKH='" + cboxMaKH.SelectedValue.ToString() + "'";
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtTenKH.Text = dr["TenKH"].ToString(); ;
            }
            dr.Close();

            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_maxe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string str = @"select * from HoaDon where MaHD LIKE '%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(str);
            dataQuanLyBanHang.DataSource = dt;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string str = @"select * from HoaDon where MaHD LIKE '%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(str);
            dataQuanLyBanHang.DataSource = dt;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (cboxMaKH.Text == "" || txtMaHD.Text == "")
            {
                AutoClosingMessageBox.Show("Vui lòng chọn 1 hóa đơn trước khi in", "Thông báo", 1000);
                return;
            }
            else
            {
                MaKhachHang = cboxMaKH.Text;
                MaHoaDon = txtMaHD.Text;
                frmRP_InHD n = new frmRP_InHD(MaKhachHang, MaHoaDon);
                n.Show();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            ThanhTien();
            TongTien();
        }

        private void cboKhoHang_Click(object sender, EventArgs e)
        {
            //Load_cboxMaKhoHang();
        }

        private void txtTenKho_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select TenNV from NhanVien where MaNV='" + cboxMaNV.SelectedValue.ToString() + "'";
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtTenNV.Text = dr["TenNV"].ToString();;
            }
            dr.Close();
            
            con.Close();
            
        }

        private void cboxMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Xe where MaXe='" + cboxMaXe.SelectedValue.ToString() + "'";
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtTenXe.Text = dr["TenXe"].ToString();
                txtSoKhung.Text=dr["SoKhung"].ToString();
                txtSoMay.Text=dr["SoMay"].ToString();
                txtGiaBan.Text=dr["GiaBan"].ToString();
            }
            dr.Close();
            con.Close();
        }
        
    }
}
