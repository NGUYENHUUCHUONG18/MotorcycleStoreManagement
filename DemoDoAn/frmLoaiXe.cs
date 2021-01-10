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
    public partial class frmLoaiXe : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public frmLoaiXe()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QLXeMay-DB_SOFT;Integrated Security=True;");
        }
        //Load dữ liệu
        public void Load_Data()
        {
            txtMaLoaiXe.DataBindings.Clear();
            txtMaLoaiXe.DataBindings.Add("Text", dataQLLoaiXe.DataSource, "MaLoaiXe");

            txtTenLoaiXe.DataBindings.Clear();
            txtTenLoaiXe.DataBindings.Add("Text", dataQLLoaiXe.DataSource, "TenLoaiXe");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataQLLoaiXe.DataSource, "GhiChu");
        }

        private void LoaddataLoaiXe()
        {
            con.Open();
            string sql = "select * from LoaiXe";
            cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataQLLoaiXe.DataSource = dt;
            con.Close();
        }
        
        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            LoaddataLoaiXe();
            this.Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string them = "insert into LoaiXe values('" + txtMaLoaiXe.Text + "',N'" + txtTenLoaiXe.Text + "',N'" + txtGhiChu.Text + "')";
                cmd = new SqlCommand(them, con);
                con.Close();
                Load_Data();
                MessageBox.Show("Thêm thành công!");
            }
            catch(Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Loại Xe: " + txtTenLoaiXe.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string xoa = "delete from LoaiXe where MaLoaiXe='" + txtMaLoaiXe.Text + "'";
                    cmd = new SqlCommand(xoa,con);
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    Load_Data();
                    con.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            string capnhat = @"update LoaiXe set TenLoaiXe=N'" + txtTenLoaiXe.Text + "', GhiChu=N'" + txtGhiChu.Text + "' where MaLoaiXe='" + txtMaLoaiXe.Text + "'";
            cmd = new SqlCommand(capnhat, con);
            MessageBox.Show("Xóa thành công.", "Thông báo");
            Load_Data();
            con.Close();
        }

        private void btnAddMa_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMaLoai_Click(object sender, EventArgs e)
        {
            string row = dataQLLoaiXe.Rows[dataQLLoaiXe.Rows.Count - 2].Cells[0].Value.ToString().Trim(); // lấy dòng cuối cùng cột 0;
            row = row.Substring(4); // căt từ vị trí thứ 2
            int i = (int.Parse(row) + 1);
            txtMaLoaiXe.Text = "LOAI000" + i;
            txtTenLoaiXe.Clear();
            txtGhiChu.Clear();
            txtTenLoaiXe.Focus();
        }

        private void frmLoaiXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
