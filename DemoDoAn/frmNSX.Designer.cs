namespace DemoDoAn
{
    partial class frmNSX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.txtTenNSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addMaNSX = new System.Windows.Forms.PictureBox();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.dataNSX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btDong = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMaNSX)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNSX)).BeginInit();
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
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1020, 39);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "QUẢN LÝ NHÀ SẢN XUẤT";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.txtTenNSX);
            this.expandablePanel1.Controls.Add(this.txtMaNSX);
            this.expandablePanel1.Controls.Add(this.addMaNSX);
            this.expandablePanel1.Controls.Add(this.txtGhiChu);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.labelX2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(3, 48);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 196);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 47;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Thông Tin";
            // 
            // txtTenNSX
            // 
            // 
            // 
            // 
            this.txtTenNSX.Border.Class = "TextBoxBorder";
            this.txtTenNSX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNSX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNSX.Location = new System.Drawing.Point(130, 118);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.PreventEnterBeep = true;
            this.txtTenNSX.Size = new System.Drawing.Size(197, 26);
            this.txtTenNSX.TabIndex = 42;
            // 
            // txtMaNSX
            // 
            // 
            // 
            // 
            this.txtMaNSX.Border.Class = "TextBoxBorder";
            this.txtMaNSX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNSX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNSX.Location = new System.Drawing.Point(130, 50);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.PreventEnterBeep = true;
            this.txtMaNSX.Size = new System.Drawing.Size(197, 26);
            this.txtMaNSX.TabIndex = 41;
            // 
            // addMaNSX
            // 
            this.addMaNSX.BackColor = System.Drawing.Color.Transparent;
            this.addMaNSX.Image = global::DemoDoAn.Properties.Resources.add;
            this.addMaNSX.Location = new System.Drawing.Point(333, 50);
            this.addMaNSX.Name = "addMaNSX";
            this.addMaNSX.Size = new System.Drawing.Size(35, 26);
            this.addMaNSX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addMaNSX.TabIndex = 40;
            this.addMaNSX.TabStop = false;
            this.addMaNSX.Click += new System.EventHandler(this.addMaNSX_Click);
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(618, 43);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(386, 119);
            this.txtGhiChu.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX4.Location = new System.Drawing.Point(531, 77);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(81, 33);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Ghi Chú";
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
            this.labelX3.Location = new System.Drawing.Point(33, 112);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(107, 33);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Tên NSX";
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
            this.labelX2.Location = new System.Drawing.Point(33, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(148, 33);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Mã NSX";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.dataNSX);
            this.expandablePanel2.Controls.Add(this.txtTim);
            this.expandablePanel2.Controls.Add(this.btnTim);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel2.HideControlsWhenCollapsed = true;
            this.expandablePanel2.Location = new System.Drawing.Point(3, 240);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(1020, 248);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 22;
            this.expandablePanel2.Text = "Tìm kiếm";
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Tìm Kiếm";
            // 
            // dataNSX
            // 
            this.dataNSX.AllowUserToOrderColumns = true;
            this.dataNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.Ghichu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNSX.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNSX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataNSX.Location = new System.Drawing.Point(0, 73);
            this.dataNSX.Name = "dataNSX";
            this.dataNSX.Size = new System.Drawing.Size(1021, 174);
            this.dataNSX.TabIndex = 11;
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
            this.txtTim.Location = new System.Drawing.Point(53, 35);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(309, 32);
            this.txtTim.TabIndex = 9;
            this.txtTim.Text = "Nhập mã, tên NSX cần tìm";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(386, 35);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 32);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.Symbol = "";
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.btSua);
            this.panelEx1.Controls.Add(this.btThem);
            this.panelEx1.Controls.Add(this.btDong);
            this.panelEx1.Controls.Add(this.btXoa);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(3, 484);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1020, 72);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 54;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(519, 19);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(94, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 27;
            this.buttonX1.Text = "In";
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(368, 19);
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
            this.btThem.Location = new System.Drawing.Point(53, 19);
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
            this.btDong.Location = new System.Drawing.Point(791, 19);
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
            this.btXoa.Location = new System.Drawing.Point(212, 19);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.Symbol = "";
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã nhà sản xuất";
            this.MaNSX.Name = "MaNSX";
            // 
            // TenNSX
            // 
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên nhà sản xuất";
            this.TenNSX.Name = "TenNSX";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "GhiChu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // frmNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 565);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel2);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.labelX1);
            this.Name = "frmNSX";
            this.Text = "frmNSX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNSX_FormClosing);
            this.Load += new System.EventHandler(this.frmNSX_Add_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMaNSX)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNSX)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataNSX;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btDong;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNSX;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNSX;
        private System.Windows.Forms.PictureBox addMaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}