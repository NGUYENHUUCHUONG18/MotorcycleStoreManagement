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
    public partial class frmDoiMatKhau : Form
    {
        string username, password;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            string update = "update DangNhap set MatKhau='" + txtMatKhauMoi.Text + "' where(TaiKhoan=N'" + txtTK.Text + "' and MatKhau='" + txtMK.Text + "')";
            string ten = txtTK.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMatKhauMoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtNhapLai.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if ((txtMatKhauMoi.Text == txtNhapLai.Text) && txtMK.Text == password)
                            {
                                
                                //DatabaseService.executeQuery(update);
                                //AutoClosingMessageBox.Show("Bạn đã thay đổi mật khẩu thành công.", "Thông báo", 500);
                                //this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTK.Text = username;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
