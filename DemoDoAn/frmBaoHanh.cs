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
    public partial class frmBaoHanh : Form
    {
        public frmBaoHanh()
        {
            InitializeComponent();
        }
        //Load dữ liệu
        public void Load_Data()
        {
            
        }
        public void Load_cboxMaPhieuBH()
        {
            string dt = "select * from PhieuBaoHanh";
            cbo_MaPBH.DisplayMember = "MaPhieuBH";
            cbo_MaPBH.DataSource = DatabaseService.getDataTable(dt);
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {

            this.Load_Data();
            Load_cboxMaPhieuBH();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string them = @"insert into BaoHanh values('" + cbo_MaPBH.Text + "','" + dateBH.Text + "',N'" + txt_ND.Text + "')";
            DatabaseService.executeQuery(them);
            AutoClosingMessageBox.Show("Thêm thành công.", "Thông báo", 500);
            Load_Data();
        }

        private void dataBaoHanh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataBaoHanh.Rows[e.RowIndex];
                cbo_MaPBH.Text = row.Cells[0].Value.ToString();
                dateBH.Text = row.Cells[1].Value.ToString();
                txt_ND.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception) { }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string TimKiemTS = @"select * from BaoHanh where MaPhieuBH LIKE N'%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(TimKiemTS);
            dataBaoHanh.DataSource = dt;
            
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string TimKiemTS = @"select * from BaoHanh where MaPhieuBH LIKE N'%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(TimKiemTS);
            dataBaoHanh.DataSource = dt;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string xoa = @"delete from BaoHanh where MaPhieuBH='" + cbo_MaPBH.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Phiếu Bảo Hành: " + cbo_MaPBH.Text + "\nNgày Bảo Hành: " + dateBH.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btSua_Click(object sender, EventArgs e)
        {
            string capnhat = @"update BaoHanh set NgayBH='" + dateBH.Text + "', NoiDungBH=N'" + txt_ND.Text + "' where MaPhieuBH='" + cbo_MaPBH.Text + "'";
            DatabaseService.executeQuery(capnhat);
            AutoClosingMessageBox.Show("Sửa thành công.", "Thông báo", 500);
            Load_Data();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
