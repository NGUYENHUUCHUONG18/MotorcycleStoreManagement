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
    public partial class frmRP_InHD : Form
    {
        string MaHoaDon, MaKhachHang;
        public frmRP_InHD()
        {
            InitializeComponent();
        }

        private void frmRP_InHD_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public frmRP_InHD(string maKH, string maHD) 
        {
            InitializeComponent();
            MaHoaDon = maHD;
            MaKhachHang = maKH;
        }
        public void Load_cboxMaKH()
        {
            
        }
        public void Load_cboxMaHD()
        {
           
        }
    }
}
