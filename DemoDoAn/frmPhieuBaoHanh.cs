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
    public partial class frmPhieuBaoHanh : Form
    {
        string username;
        public frmPhieuBaoHanh()
        {
            InitializeComponent();
        }
        public frmPhieuBaoHanh(string user)
        {
            InitializeComponent();
            username = user;
        }
        public void Load_Data()
        {
           
        }
        public string sinhMa()
        {
            DataSet_.DataSetMaPhieuBH_TableAdapters.QueriesTableAdapter q = new DataSet_.DataSetMaPhieuBH_TableAdapters.QueriesTableAdapter();
            string SoMaNV;
            SoMaNV = "000" + q.QueryMaPhieuBH().ToString();
            SoMaNV = SoMaNV.Substring(SoMaNV.Length - 4, 4);
            return "PBH" + SoMaNV;
        }
        //
        public void Load_cboxMaXe()
        {
            string dt = "select * from Xe";
            cboxMaXe.DisplayMember = "MaXe";
            cboxMaXe.DataSource = DatabaseService.getDataTable(dt);
        }
        //
        public void Load_cboxMaKH()
        {
            string dt = "select * from KhachHang";
            cboxMaKH.DisplayMember = "MaKH";
            cboxMaKH.DataSource = DatabaseService.getDataTable(dt);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string them = @"insert into PhieuBaoHanh values('" + txtMaPhieu.Text + "','" + cboxMaKH.Text + "','" + txtMaNv.Text + "','" + cboxMaXe.Text + "','" + dateMua.Text + "','" + dateLapPhieu.Text + "')";
            DatabaseService.executeQuery(them);
            //MessageBox.Show("Thêm thành công!");
            AutoClosingMessageBox.Show("Thêm thành công.", "Thông báo", 500);
            Load_Data();
        }

        private void frmPhieuBaoHanh_Load(object sender, EventArgs e)
        {
            Load_Data();
            //MessageBox.Show(username);
            this.Load_cboxMaXe();
            this.Load_cboxMaKH();
            cboxTenXe.Hide();
            cboxTenLoaiXe.Hide();
            cboxLoaiXe.Hide();
            cboxTenKH.Hide();
            cboxSoKhung.Hide();
            cboxSoMay.Hide();
            cboxTGBH.Hide();
            txtMaNv.Hide();
            this.dateMua.Value = DateTime.Now;
            DataSet_.DataSetPhanQuyenTableAdapters.QueriesTableAdapter q = new DataSet_.DataSetPhanQuyenTableAdapters.QueriesTableAdapter();
            string phanquyen = q.QueryMaNhanVien(username).ToString();
            txtMaNv.Text = phanquyen.ToString();
        }

        private void btnAddMa_Click(object sender, EventArgs e)
        {
            string MaNV;
            string sql = " select MaPhieuBH from PhieuBaoHanh";
            DataTable tb = DatabaseService.getDataTable(sql);
            int s = tb.Rows.Count;
            if (tb.Rows.Count < 1)
                MaNV = "PBH0001";
            else
                MaNV = sinhMa();
            txtMaPhieu.Text = MaNV;
        }

        private void cboxMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dt = "select * from Xe where MaXe='" + cboxMaXe.Text + "'";
            cboxTenXe.DisplayMember = "TenXe";
            cboxTenXe.DataSource = DatabaseService.getDataTable(dt);

            cboxSoKhung.DisplayMember = "SoKhung";
            cboxSoKhung.DataSource = DatabaseService.getDataTable(dt);
            txtSoKhung.Text = cboxSoKhung.Text;
            cboxSoMay.DisplayMember = "SoMay";
            cboxSoMay.DataSource = DatabaseService.getDataTable(dt);
            txtSoMay.Text = cboxSoMay.Text;

            //
            cboxTGBH.DisplayMember = "BaoHanh";
            cboxTGBH.DataSource = DatabaseService.getDataTable(dt);
            txtTGBH.Text = cboxTGBH.Text;
            //
            txtTenXe.Text = cboxTenXe.Text;
            //
            string dt_ = "select * from Xe where MaXe='" + cboxMaXe.Text + "'";
            cboxLoaiXe.DisplayMember = "MaLoaiXe";
            cboxLoaiXe.DataSource = DatabaseService.getDataTable(dt_);
            //
            string dt__ = "select * from LoaiXe where MaLoaiXe='" + cboxLoaiXe.Text + "'";
            cboxTenLoaiXe.DisplayMember = "TenLoaiXe";
            cboxTenLoaiXe.DataSource = DatabaseService.getDataTable(dt__);
            txtLoaiXe.Text = cboxTenLoaiXe.Text;


        }

        private void cboxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dt__ = "select * from KhachHang where MaKH='" + cboxMaKH.Text + "'";
            cboxTenKH.DisplayMember = "TenKH";
            cboxTenKH.DataSource = DatabaseService.getDataTable(dt__);
            txtTenKH.Text = cboxTenKH.Text;
        }

        private void cboxMaXe_TextChanged(object sender, EventArgs e)
        {
            string dt = "select * from Xe where MaXe='" + cboxMaXe.Text + "'";
            cboxTenXe.DisplayMember = "TenXe";
            cboxTenXe.DataSource = DatabaseService.getDataTable(dt);
            txtTenXe.Text = cboxTenXe.Text;
            //
            string dt_ = "select * from Xe where MaXe='" + cboxMaXe.Text + "'";
            cboxLoaiXe.DisplayMember = "MaLoaiXe";
            cboxLoaiXe.DataSource = DatabaseService.getDataTable(dt_);
            //
            string dt__ = "select * from LoaiXe where MaLoaiXe='" + cboxLoaiXe.Text + "'";
            cboxTenLoaiXe.DisplayMember = "TenLoaiXe";
            cboxTenLoaiXe.DataSource = DatabaseService.getDataTable(dt__);
            txtLoaiXe.Text = cboxTenLoaiXe.Text;
        }

        private void cboxMaKH_TextChanged(object sender, EventArgs e)
        {
            string dt__ = "select * from KhachHang where MaKH='" + cboxMaKH.Text + "'";
            cboxTenKH.DisplayMember = "TenKH";
            cboxTenKH.DataSource = DatabaseService.getDataTable(dt__);
            txtTenKH.Text = cboxTenKH.Text;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmQuyDinhBaoHanh f = new frmQuyDinhBaoHanh();
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoa = @"delete from PhieuBaoHanh where MaPhieuBH='" + txtMaPhieu.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Phiếu Bảo Hành: " + txtMaPhieu.Text + "\nCủa Khách Hàng: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    DatabaseService.executeQuery(xoa);
                    AutoClosingMessageBox.Show("Xóa thành công.", "Thông báo", 500);
                    Load_Data();
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

        private void dataPhieuBH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataPhieuBH.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells[0].Value.ToString();
                cboxMaKH.Text = row.Cells[1].Value.ToString();
                cboxMaXe.Text = row.Cells[3].Value.ToString();
                dateMua.Text = row.Cells[4].Value.ToString();
                dateLapPhieu.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string capnhat = @"update PhieuBaoHanh set MaKH='" + cboxMaKH.Text + "', MaXe='" + cboxMaXe.Text + "', NgayMua='" + dateMua.Text + "', NgayLapPhieu='" + dateLapPhieu.Text + "' where MaPhieuBH='" + txtMaPhieu.Text + "'";
            DatabaseService.executeQuery(capnhat);
            AutoClosingMessageBox.Show("Cập nhật thành công.", "Thông báo", 500);
            Load_Data();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string str = @"select * from PhieuBaoHanh where MaPhieuBH LIKE '%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(str);
            dataPhieuBH.DataSource = dt;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string str = @"select * from PhieuBaoHanh where MaPhieuBH LIKE'%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(str);
            dataPhieuBH.DataSource = dt;
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
