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
    public partial class frmPhanQuyenSuDung : Form
    {
        public frmPhanQuyenSuDung()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string phanQuyen = "";
            if (radAdmin.Checked == true)
                phanQuyen = "Điều Hành";
            if (radQuanLy.Checked == true)
                phanQuyen = "Quản Lý";
            if (radNhanVien.Checked == true)
                phanQuyen = "Nhân Viên";
            string capnhat = @"update DangNhap set PhanQuyen=N'" + phanQuyen + "' where MaNV='" + txtMaNV.Text + "'";
            DatabaseService.executeQuery(capnhat);
            AutoClosingMessageBox.Show("Cập nhật thành công.", "Thông báo", 500);
            Load_Data();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataNguoiDung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataPhanQuyen.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTaiKhoan.Text = row.Cells[1].Value.ToString();
                txtMatKhau.Text = row.Cells[2].Value.ToString();
                //cboxPhanQuyen.Text = row.Cells[3].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Điều Hành")
                    radAdmin.Checked = true;
                if (row.Cells[3].Value.ToString() == "Quản Lý")
                    radQuanLy.Checked = true;
                if (row.Cells[3].Value.ToString() == "Nhân Viên")
                    radNhanVien.Checked = true;
            }
            catch (Exception) { }
        }
    }
}
