namespace DemoDoAn
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel_KH = new DevComponents.DotNetBar.ExpandablePanel();
            this.addMaKH = new System.Windows.Forms.PictureBox();
            this.dateNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboxGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.nam = new DevComponents.Editors.ComboItem();
            this.nu = new DevComponents.Editors.ComboItem();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCMND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.dataQLKH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MANNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btTim = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btDong = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.panel_KH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKH)).BeginInit();
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
            this.labelX1.Location = new System.Drawing.Point(12, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1011, 55);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "THÊM KHÁCH HÀNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel_KH
            // 
            this.panel_KH.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_KH.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_KH.Controls.Add(this.addMaKH);
            this.panel_KH.Controls.Add(this.dateNgaySinh);
            this.panel_KH.Controls.Add(this.cboxGioiTinh);
            this.panel_KH.Controls.Add(this.txtGhiChu);
            this.panel_KH.Controls.Add(this.txtCMND);
            this.panel_KH.Controls.Add(this.txtSDT);
            this.panel_KH.Controls.Add(this.txtTenKH);
            this.panel_KH.Controls.Add(this.txtDiaChi);
            this.panel_KH.Controls.Add(this.txtMaKH);
            this.panel_KH.Controls.Add(this.labelX9);
            this.panel_KH.Controls.Add(this.labelX8);
            this.panel_KH.Controls.Add(this.labelX7);
            this.panel_KH.Controls.Add(this.labelX6);
            this.panel_KH.Controls.Add(this.labelX5);
            this.panel_KH.Controls.Add(this.labelX4);
            this.panel_KH.Controls.Add(this.labelX3);
            this.panel_KH.Controls.Add(this.labelX2);
            this.panel_KH.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_KH.HideControlsWhenCollapsed = true;
            this.panel_KH.Location = new System.Drawing.Point(12, 62);
            this.panel_KH.Name = "panel_KH";
            this.panel_KH.Size = new System.Drawing.Size(1010, 248);
            this.panel_KH.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_KH.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_KH.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_KH.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_KH.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_KH.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_KH.Style.GradientAngle = 90;
            this.panel_KH.TabIndex = 4;
            this.panel_KH.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_KH.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_KH.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_KH.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panel_KH.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_KH.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_KH.TitleStyle.GradientAngle = 90;
            this.panel_KH.TitleText = "Thông Tin";
            // 
            // addMaKH
            // 
            this.addMaKH.BackColor = System.Drawing.Color.Transparent;
            this.addMaKH.Image = global::DemoDoAn.Properties.Resources.add;
            this.addMaKH.Location = new System.Drawing.Point(419, 39);
            this.addMaKH.Name = "addMaKH";
            this.addMaKH.Size = new System.Drawing.Size(35, 27);
            this.addMaKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addMaKH.TabIndex = 41;
            this.addMaKH.TabStop = false;
            this.addMaKH.Click += new System.EventHandler(this.btnAddMaKH_Click);
            // 
            // dateNgaySinh
            // 
            // 
            // 
            // 
            this.dateNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateNgaySinh.ButtonDropDown.Visible = true;
            this.dateNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.IsPopupCalendarOpen = false;
            this.dateNgaySinh.Location = new System.Drawing.Point(224, 158);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dateNgaySinh.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(230, 26);
            this.dateNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateNgaySinh.TabIndex = 39;
            // 
            // cboxGioiTinh
            // 
            this.cboxGioiTinh.DisplayMember = "Text";
            this.cboxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGioiTinh.FormattingEnabled = true;
            this.cboxGioiTinh.ItemHeight = 21;
            this.cboxGioiTinh.Items.AddRange(new object[] {
            this.nam,
            this.nu});
            this.cboxGioiTinh.Location = new System.Drawing.Point(224, 119);
            this.cboxGioiTinh.Name = "cboxGioiTinh";
            this.cboxGioiTinh.Size = new System.Drawing.Size(230, 27);
            this.cboxGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxGioiTinh.TabIndex = 31;
            // 
            // nam
            // 
            this.nam.Text = "Nam";
            // 
            // nu
            // 
            this.nu.Text = "Nữ";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(641, 128);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(230, 99);
            this.txtGhiChu.TabIndex = 30;
            // 
            // txtCMND
            // 
            // 
            // 
            // 
            this.txtCMND.Border.Class = "TextBoxBorder";
            this.txtCMND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCMND.Location = new System.Drawing.Point(641, 80);
            this.txtCMND.MaxLength = 9;
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PreventEnterBeep = true;
            this.txtCMND.Size = new System.Drawing.Size(230, 28);
            this.txtCMND.TabIndex = 29;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress_1);
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Location = new System.Drawing.Point(224, 199);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PreventEnterBeep = true;
            this.txtSDT.Size = new System.Drawing.Size(230, 28);
            this.txtSDT.TabIndex = 28;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress_1);
            // 
            // txtTenKH
            // 
            // 
            // 
            // 
            this.txtTenKH.Border.Class = "TextBoxBorder";
            this.txtTenKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKH.Location = new System.Drawing.Point(224, 76);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PreventEnterBeep = true;
            this.txtTenKH.Size = new System.Drawing.Size(230, 28);
            this.txtTenKH.TabIndex = 27;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(641, 38);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PreventEnterBeep = true;
            this.txtDiaChi.Size = new System.Drawing.Size(230, 28);
            this.txtDiaChi.TabIndex = 26;
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.Border.Class = "TextBoxBorder";
            this.txtMaKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKH.Location = new System.Drawing.Point(224, 38);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PreventEnterBeep = true;
            this.txtMaKH.Size = new System.Drawing.Size(190, 28);
            this.txtMaKH.TabIndex = 25;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX9.Location = new System.Drawing.Point(578, 124);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(100, 32);
            this.labelX9.TabIndex = 11;
            this.labelX9.Text = "Ghi chú";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX8.Location = new System.Drawing.Point(578, 76);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(100, 32);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "CMND";
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
            this.labelX7.Location = new System.Drawing.Point(578, 38);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(100, 32);
            this.labelX7.TabIndex = 9;
            this.labelX7.Text = "Địa chỉ";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX6.Location = new System.Drawing.Point(146, 195);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(100, 32);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Điện thoại";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelX5.Location = new System.Drawing.Point(146, 152);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 32);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Ngày sinh";
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
            this.labelX4.Location = new System.Drawing.Point(146, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 32);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Giới tính";
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
            this.labelX3.Location = new System.Drawing.Point(146, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 32);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Tên KH";
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
            this.labelX2.Location = new System.Drawing.Point(146, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 32);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Mã KH";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.dataQLKH);
            this.expandablePanel2.Controls.Add(this.txtTim);
            this.expandablePanel2.Controls.Add(this.btTim);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel2.HideControlsWhenCollapsed = true;
            this.expandablePanel2.Location = new System.Drawing.Point(12, 307);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(1010, 243);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 8;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Tìm Kiếm";
            // 
            // dataQLKH
            // 
            this.dataQLKH.AllowUserToOrderColumns = true;
            this.dataQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANNV,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataQLKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataQLKH.Location = new System.Drawing.Point(0, 70);
            this.dataQLKH.Name = "dataQLKH";
            this.dataQLKH.Size = new System.Drawing.Size(1010, 212);
            this.dataQLKH.TabIndex = 25;
            // 
            // MANNV
            // 
            this.MANNV.DataPropertyName = "MaKH";
            this.MANNV.HeaderText = "Mã khách hàng";
            this.MANNV.Name = "MANNV";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenKH";
            this.Column1.HeaderText = "Tên khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GioiTinh";
            this.Column2.HeaderText = "Giới Tính";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "SDT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CMND";
            this.Column7.HeaderText = "CMND";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GhiChu";
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.Name = "Column6";
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTim.Location = new System.Drawing.Point(69, 32);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(309, 32);
            this.txtTim.TabIndex = 24;
            this.txtTim.Text = "Nhập mã, tên khách hàng cần tìm";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btTim
            // 
            this.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTim.Location = new System.Drawing.Point(402, 32);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(104, 32);
            this.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTim.Symbol = "";
            this.btTim.TabIndex = 23;
            this.btTim.Text = "Tìm";
            this.btTim.Click += new System.EventHandler(this.txtTim_Click);
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
            this.panelEx1.Location = new System.Drawing.Point(12, 548);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1010, 57);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 15;
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
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
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
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 631);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel2);
            this.Controls.Add(this.panel_KH);
            this.Controls.Add(this.labelX1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panel_KH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKH)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandablePanel panel_KH;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btTim;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMND;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateNgaySinh;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btDong;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private System.Windows.Forms.PictureBox addMaKH;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQLKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.Editors.ComboItem nam;
        private DevComponents.Editors.ComboItem nu;
    }
}