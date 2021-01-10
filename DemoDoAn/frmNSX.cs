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
    public partial class frmNSX : Form
    {

        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public frmNSX()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QLXeMay-DB_SOFT;Integrated Security=True;");
        }

        private void LoaddataNSX()
        {
            con.Open();
            string sql = "select * from NhaSanXuat";
            cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataNSX.DataSource = dt;
            con.Close();
        }
        public void Load_Data()
        {
            txtMaNSX.DataBindings.Clear();
            txtMaNSX.DataBindings.Add("Text", dataNSX.DataSource, "MaNSX");

            txtTenNSX.DataBindings.Clear();
            txtTenNSX.DataBindings.Add("Text", dataNSX.DataSource, "TenNSX");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataNSX.DataSource, "GhiChu");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string them = @"insert into NhaSanXuat values('" + txtMaNSX.Text + "',N'" + txtTenNSX.Text + "',N'" + txtGhiChu.Text + "')";
                cmd = new SqlCommand(them, con);
                MessageBox.Show("Thêm thành công!");
                con.Close();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa NSX: " + txtTenNSX.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string xoa = @"delete from NhaSanXuat where MaNSX='" + txtMaNSX.Text + "'";
                    cmd = new SqlCommand(xoa, con);
                    MessageBox.Show("Xóa thành công!");
                    con.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string capnhat = "update NhaSanXuat set TenNSX=N'" + txtTenNSX.Text + "', GhiChu=N'" + txtGhiChu.Text + "' where MaNSX='" + txtMaNSX.Text + "'";
                cmd = new SqlCommand(capnhat, con);
                MessageBox.Show("Cập nhật thành công!");
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmNSX_Add_Load(object sender, EventArgs e)
        {
            LoaddataNSX();
            this.Load_Data();
        }

        private void frmNSX_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void addMaNSX_Click(object sender, EventArgs e)
        {
            string row = dataNSX.Rows[dataNSX.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(4); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            txtMaNSX.Text = "NSX000" + i;
            txtTenNSX.Clear();
            txtGhiChu.Clear();
            txtTenNSX.Focus();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string TimKiemTS = @"select * from NhaSanXuat where MaNSX LIKE N'%" + txtTim.Text + "%' or TenNSX LIKE N'%" + txtTim.Text + "%'";
            DataTable dt = DatabaseService.getDataTable(TimKiemTS);
            dataNSX.DataSource = dt;
        }
    }
}
