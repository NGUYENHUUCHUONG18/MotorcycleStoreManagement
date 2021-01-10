namespace DemoDoAn
{
    partial class frmQLTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboxPhanQuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboxMaNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataQLTK = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btDong = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTK)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1011, 58);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.txtMatKhau);
            this.expandablePanel1.Controls.Add(this.txtTaiKhoan);
            this.expandablePanel1.Controls.Add(this.cboxPhanQuyen);
            this.expandablePanel1.Controls.Add(this.cboxMaNV);
            this.expandablePanel1.Controls.Add(this.labelX5);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.labelX2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(12, 63);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1011, 161);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 5;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Title Bar";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(601, 103);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PreventEnterBeep = true;
            this.txtMatKhau.Size = new System.Drawing.Size(333, 26);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(601, 53);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PreventEnterBeep = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(333, 26);
            this.txtTaiKhoan.TabIndex = 11;
            // 
            // cboxPhanQuyen
            // 
            this.cboxPhanQuyen.DisplayMember = "Text";
            this.cboxPhanQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPhanQuyen.FormattingEnabled = true;
            this.cboxPhanQuyen.ItemHeight = 21;
            this.cboxPhanQuyen.Location = new System.Drawing.Point(139, 103);
            this.cboxPhanQuyen.Name = "cboxPhanQuyen";
            this.cboxPhanQuyen.Size = new System.Drawing.Size(347, 27);
            this.cboxPhanQuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxPhanQuyen.TabIndex = 10;
            // 
            // cboxMaNV
            // 
            this.cboxMaNV.DisplayMember = "Text";
            this.cboxMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMaNV.FormattingEnabled = true;
            this.cboxMaNV.ItemHeight = 21;
            this.cboxMaNV.Location = new System.Drawing.Point(139, 55);
            this.cboxMaNV.Name = "cboxMaNV";
            this.cboxMaNV.Size = new System.Drawing.Size(138, 27);
            this.cboxMaNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxMaNV.TabIndex = 8;
            this.cboxMaNV.SelectedIndexChanged += new System.EventHandler(this.cboxMaNV_SelectedIndexChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(504, 106);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Mật Khẩu";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(504, 59);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Tài Khoản";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(34, 102);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Phân Quyền";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(34, 59);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Nhân Viên";
            // 
            // dataQLTK
            // 
            this.dataQLTK.AllowUserToOrderColumns = true;
            this.dataQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.taikhoan,
            this.Matkhau,
            this.phanquyen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLTK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataQLTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataQLTK.Location = new System.Drawing.Point(12, 224);
            this.dataQLTK.Name = "dataQLTK";
            this.dataQLTK.Size = new System.Drawing.Size(1010, 205);
            this.dataQLTK.TabIndex = 9;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNV";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "TaiKhoan";
            this.taikhoan.HeaderText = "Tài Khoản";
            this.taikhoan.Name = "taikhoan";
            // 
            // Matkhau
            // 
            this.Matkhau.DataPropertyName = "MatKhau";
            this.Matkhau.HeaderText = "Mật Khẩu";
            this.Matkhau.Name = "Matkhau";
            // 
            // phanquyen
            // 
            this.phanquyen.DataPropertyName = "PhanQuyen";
            this.phanquyen.HeaderText = "Phân Quyền";
            this.phanquyen.Name = "phanquyen";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btSua);
            this.panelEx1.Controls.Add(this.btDong);
            this.panelEx1.Controls.Add(this.btXoa);
            this.panelEx1.Controls.Add(this.btThem);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(12, 428);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1010, 57);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 19;
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(435, 8);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 36);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.Symbol = "";
            this.btSua.TabIndex = 26;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btDong
            // 
            this.btDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(790, 7);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 37);
            this.btDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btDong.Symbol = "";
            this.btDong.TabIndex = 25;
            this.btDong.Text = "ĐÓNG";
            this.btDong.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(279, 8);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.Symbol = "";
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(120, 8);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(99, 37);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.Symbol = "";
            this.btThem.TabIndex = 23;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 490);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.dataQLTK);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.labelX1);
            this.Name = "frmQLTaiKhoan";
            this.Text = "frmQLTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTK)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxPhanQuyen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxMaNV;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQLTK;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btDong;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanquyen;
    }
}