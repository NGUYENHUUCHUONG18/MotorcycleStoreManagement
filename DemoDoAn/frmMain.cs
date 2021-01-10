using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAn
{
    public partial class frmMain : Form
    {
        string username, password;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        private void Home_DangNhap_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel_nd.Controls.Clear();
            frmDangNhap frmChild = new frmDangNhap();
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void buttom_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangXuat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đăng xuất thành công!!", "Thông báo");
            this.Hide();
            Form OUT = new frmDangNhap();
            OUT.ShowDialog();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            //this.menu_NhanVien.Enabled = false;
            //this.menu_KhachHang.Enabled = false;
            //this.menu_SanPhan.Enabled = false;
            //this.menu_BaoCao.Enabled = false;
            // ->> làm menu báio cáo
            //this.menu_ThongKe.Enabled = false;
            // TẤT CẢ CÁC CHỨC NĂNG
            //Home_PhanQuyen.Enabled = false;
            //Home_TaiKhoan.Enabled = false;
            //Home_PhanQuyen.Enabled = false;
            //NhanVien_LuongNV.Enabled = false;
            //NhanVien_ThemNV.Enabled = false;
            //KhachHang_ThemKH.Enabled = false;
            //SanPham_QLXe.Enabled = false;
            //SanPham_BaoHanh.Enabled = false;
            //BaoCao_DSNV.Enabled = false;
            //BaoCao_DSTonKho.Enabled = false;
            //BaoCao_InHoaDon.Enabled = false;
            //------------- ẨN HẾT MENU ----------------//
            menu_TrangChu_con.Visible = true;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            // Quyền sau khi đăng nhập
            DataSet_.DataSetPhanQuyenTableAdapters.QueriesTableAdapter q = new DataSet_.DataSetPhanQuyenTableAdapters.QueriesTableAdapter();
            string phanquyen = q.QueryPhanQuyen(username).ToString();
            //MessageBox.Show(phanquyen);
            if (phanquyen == "Điều Hành")
            {
                this.menu_NhanVien.Enabled = true;
                this.menu_KhachHang.Enabled = true;
                this.menu_SanPhan.Enabled = true;
                this.menu_BaoCao.Enabled = true;

                //this.menu_ThongKe.Enabled = true;
                Home_PhanQuyen.Enabled = true;
                Home_TaiKhoan.Enabled = true;
                Home_PhanQuyen.Enabled = true;
                NhanVien_LuongNV.Enabled = true;
                NhanVien_ThemNV.Enabled = true;

                KhachHang_ThemKH.Enabled = true;
                SanPham_QLXe.Enabled = true;
                SanPham_BaoHanh.Enabled = true;
                BaoCao_DSNV.Enabled = true;
                BaoCao_DSTonKho.Enabled = true;
                BaoCao_InHoaDon.Enabled = true;
            }
            if (phanquyen == "Quản Lý")
            {
                this.menu_NhanVien.Enabled = true;
                this.menu_KhachHang.Enabled = true;
                this.menu_SanPhan.Enabled = true;
                this.menu_BaoCao.Enabled = true;
                //this.menu_ThongKe.Enabled = true;
                NhanVien_LuongNV.Enabled = true;
                NhanVien_ThemNV.Enabled = true;
                KhachHang_ThemKH.Enabled = true;
                SanPham_QLXe.Enabled = true;
                SanPham_BaoHanh.Enabled = true;
                BaoCao_DSNV.Enabled = true;
                BaoCao_DSTonKho.Enabled = true;
                BaoCao_InHoaDon.Enabled = true;
            }
            if (phanquyen == "Nhân Viên")
            {
                this.menu_NhanVien.Enabled = true;
                this.menu_KhachHang.Enabled = true;
                this.menu_SanPhan.Enabled = true;
                this.menu_BaoCao.Enabled = true;
                //SanPhan_QuanLyXe.Enabled = true;
                SanPham_BaoHanh.Enabled = true;
                BaoCao_DSNV.Enabled = true;
                BaoCao_DSTonKho.Enabled = true;
                BaoCao_InHoaDon.Enabled = true;
            }
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel_nd.Controls.Clear();
            //this.panel_nd.Controls.Add(logo);
        }

        private void menu_home_Click(object sender, EventArgs e)
        {
            //Ẩn các menu khác
            menu_SanPham_Con.Visible = false;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            //Hiện menu trang chủ
            menu_TrangChu_con.Visible = true;
        }

        private void menu_NhanVien_Click(object sender, EventArgs e)
        {
            menu_TrangChu_con.Visible = false;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            // Hiện menu nhân viên
            menu_NhanVien_con.Visible = true;
        }

        private void menu_employee_add_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmQLNhanVien frmChild = new frmQLNhanVien();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void Home_DoiMatKhau_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel_nd.Controls.Clear();
            frmDoiMatKhau frmChild = new frmDoiMatKhau(username, password);
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
            //MessageBox.Show(username + password);
        }


        private void menu_KhachHang_Click(object sender, EventArgs e)
        {

            menu_TrangChu_con.Visible = false;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            // Hiện menu khách hàng
            menu_KhachHang_con.Visible = true;
        }

        private void menu_SanPhan_Click(object sender, EventArgs e)
        {
            menu_TrangChu_con.Visible = false;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            // Hiện menu sản phẩm
            menu_SanPham_Con.Visible = true;
        }

        private void menu_BaoCao_Click(object sender, EventArgs e)
        {
            menu_TrangChu_con.Visible = false;
            menu_NhanVien_con.Visible = false;
            menu_KhachHang_con.Visible = false;
            menu_SanPham_Con.Visible = false;
            menu_BaoCao_con.Visible = false;
            // Hiện menu báo cáo
            menu_BaoCao_con.Visible = true;
        }

        private void menu_ThongKe_Click(object sender, EventArgs e)
        {
            // Màu
            menu_Home.ForeColor = Color.CornflowerBlue;
            menu_NhanVien.ForeColor = Color.CornflowerBlue;
            menu_KhachHang.ForeColor = Color.CornflowerBlue;
            menu_SanPhan.ForeColor = Color.CornflowerBlue;
            menu_BaoCao.ForeColor = Color.CornflowerBlue;
            //menu_ThongKe.ForeColor = Color.OrangeRed;
        }

       

        private void KhachHang_ThemKhachHang_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmKhachHang frmChild = new frmKhachHang();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void SanPhan_QuanLyXe_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmQLXe frmChild = new frmQLXe();
            frmChild.TopLevel = false;
            // Hiển thị form
            frmChild.Show();
        }

        private void qĐBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmQuyDinhBaoHanh frmChild = new frmQuyDinhBaoHanh();
            frmChild.TopLevel = false;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void qLBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmBaoHanh frmChild = new frmBaoHanh();
            frmChild.TopLevel = false;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void xuấtPhiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmPhieuBaoHanh frmChild = new frmPhieuBaoHanh(username);
            frmChild.TopLevel = false;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NhanVien_DSNhanVien_Click_1(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //this.panel_nd.Controls.Clear();
            frmBanHang frmChild = new frmBanHang();
            frmChild.TopLevel = false;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.panel_nd.Controls.Clear();
            frmQLTaiKhoan frmChild = new frmQLTaiKhoan();
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

           
        }

        private void Home_PhanQuyen_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmPhanQuyenSuDung frmChild = new frmPhanQuyenSuDung();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }


        private void Home_TaiKhoan_Click(object sender, EventArgs e)
        {
            //this.panel_nd.Controls.Clear();
            frmQLTaiKhoan frmChild = new frmQLTaiKhoan();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void BaoCao_DSTonKho_Click(object sender, EventArgs e)
        {

        }

        private void BaoCao_InHoaDon_Click(object sender, EventArgs e)
        {
            frmRP_InHD f = new frmRP_InHD();
            f.Show();
        }

        private void SanPham_QLXe_Click(object sender, EventArgs e)
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            //this.panel_nd.Controls.Clear();
            frmQLXe frmChild = new frmQLXe();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }


        private void SanPham_BanHang_Click(object sender, EventArgs e)
        {
            //this.panel_nd.Controls.Clear();
            frmBanHang frmChild = new frmBanHang();
            frmChild.TopLevel = true;
            // Gắn vào panel
            //this.panel_nd.Controls.Add(frmChild);
            // Hiển thị form
            frmChild.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

       
    }
}
