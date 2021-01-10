namespace DemoDoAn
{
    partial class frmLoaiXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLoaiXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLoaiXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addMaLoai = new System.Windows.Forms.PictureBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.dataQLLoaiXe = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btTim = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btDong = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMaLoai)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLLoaiXe)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1065, 57);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "LOẠI XE";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.txtGhiChu);
            this.expandablePanel1.Controls.Add(this.labelX7);
            this.expandablePanel1.Controls.Add(this.txtTenLoaiXe);
            this.expandablePanel1.Controls.Add(this.txtMaLoaiXe);
            this.expandablePanel1.Controls.Add(this.addMaLoai);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.labelX2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(12, 65);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1064, 166);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 2;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Thông Tin";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(627, 31);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(276, 113);
            this.txtGhiChu.TabIndex = 46;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX7.Location = new System.Drawing.Point(546, 68);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 24);
            this.labelX7.TabIndex = 45;
            this.labelX7.Text = "Ghi chú";
            // 
            // txtTenLoaiXe
            // 
            // 
            // 
            // 
            this.txtTenLoaiXe.Border.Class = "TextBoxBorder";
            this.txtTenLoaiXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiXe.Location = new System.Drawing.Point(124, 94);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.PreventEnterBeep = true;
            this.txtTenLoaiXe.Size = new System.Drawing.Size(197, 26);
            this.txtTenLoaiXe.TabIndex = 44;
            // 
            // txtMaLoaiXe
            // 
            // 
            // 
            // 
            this.txtMaLoaiXe.Border.Class = "TextBoxBorder";
            this.txtMaLoaiXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLoaiXe.Location = new System.Drawing.Point(124, 48);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.PreventEnterBeep = true;
            this.txtMaLoaiXe.Size = new System.Drawing.Size(197, 26);
            this.txtMaLoaiXe.TabIndex = 43;
            // 
            // addMaLoai
            // 
            this.addMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.addMaLoai.Image = global::DemoDoAn.Properties.Resources.add;
            this.addMaLoai.Location = new System.Drawing.Point(326, 46);
            this.addMaLoai.Name = "addMaLoai";
            this.addMaLoai.Size = new System.Drawing.Size(35, 28);
            this.addMaLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addMaLoai.TabIndex = 42;
            this.addMaLoai.TabStop = false;
            this.addMaLoai.Click += new System.EventHandler(this.addMaLoai_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX3.Location = new System.Drawing.Point(42, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 24);
            this.labelX3.TabIndex = 41;
            this.labelX3.Text = "Tên loại xe";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX2.Location = new System.Drawing.Point(42, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 24);
            this.labelX2.TabIndex = 40;
            this.labelX2.Text = "Mã loại xe";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.dataQLLoaiXe);
            this.expandablePanel2.Controls.Add(this.txtTim);
            this.expandablePanel2.Controls.Add(this.btTim);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel2.HideControlsWhenCollapsed = true;
            this.expandablePanel2.Location = new System.Drawing.Point(12, 228);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(1065, 215);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 7;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Tìm Kiếm";
            // 
            // dataQLLoaiXe
            // 
            this.dataQLLoaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQLLoaiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.Ghichu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLLoaiXe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataQLLoaiXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataQLLoaiXe.Location = new System.Drawing.Point(0, 78);
            this.dataQLLoaiXe.Name = "dataQLLoaiXe";
            this.dataQLLoaiXe.Size = new System.Drawing.Size(1064, 136);
            this.dataQLLoaiXe.TabIndex = 49;
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTim.Location = new System.Drawing.Point(62, 35);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(309, 32);
            this.txtTim.TabIndex = 48;
            this.txtTim.Text = "Nhập mã, tên loại xe cần tìm";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btTim
            // 
            this.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(395, 35);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(104, 32);
            this.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTim.Symbol = "";
            this.btTim.TabIndex = 47;
            this.btTim.Text = "Tìm";
            this.btTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btSua);
            this.panelEx1.Controls.Add(this.btThem);
            this.panelEx1.Controls.Add(this.btDong);
            this.panelEx1.Controls.Add(this.btXoa);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(12, 444);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1065, 67);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 54;
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(439, 15);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 36);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.Symbol = "";
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(124, 15);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(99, 37);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.Symbol = "";
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btDong
            // 
            this.btDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(794, 14);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 37);
            this.btDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btDong.Symbol = "";
            this.btDong.TabIndex = 15;
            this.btDong.Text = "ĐÓNG";
            this.btDong.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(283, 15);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.Symbol = "";
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoaiXe";
            this.MaLoai.HeaderText = "Mã loại xe";
            this.MaLoai.Name = "MaLoai";
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoaiXe";
            this.TenLoai.HeaderText = "Tên loại xe";
            this.TenLoai.Name = "TenLoai";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "GhiChu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // frmLoaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 518);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel2);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.labelX1);
            this.Name = "frmLoaiXe";
            this.Text = "frmLoaiXe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiXe_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiXe_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMaLoai)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLLoaiXe)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btDong;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiXe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiXe;
        private System.Windows.Forms.PictureBox addMaLoai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQLLoaiXe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}