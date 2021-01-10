namespace DemoDoAn
{
    partial class frmPhieuBaoHanh
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
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.cboxSoMay = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboxSoKhung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboxTenKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboxTenXe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dateLapPhieu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateMua = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtTenKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboxMaKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addMaPhieu = new System.Windows.Forms.PictureBox();
            this.txtSoKhung = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTGBH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoMay = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLoaiXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboxTenLoaiXe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboxTGBH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboxMaXe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.dataPhieuBH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaPBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btTim = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bt_Quydinh = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btDong = new DevComponents.DotNetBar.ButtonX();
            this.cboxLoaiXe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateLapPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMaPhieu)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuBH)).BeginInit();
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
            this.labelX1.Location = new System.Drawing.Point(12, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1145, 47);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "THÔNG TIN PHIẾU BẢO HÀNH";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.cboxLoaiXe);
            this.expandablePanel1.Controls.Add(this.cboxSoMay);
            this.expandablePanel1.Controls.Add(this.cboxSoKhung);
            this.expandablePanel1.Controls.Add(this.cboxTenKH);
            this.expandablePanel1.Controls.Add(this.cboxTenXe);
            this.expandablePanel1.Controls.Add(this.dateLapPhieu);
            this.expandablePanel1.Controls.Add(this.dateMua);
            this.expandablePanel1.Controls.Add(this.txtTenKH);
            this.expandablePanel1.Controls.Add(this.cboxMaKH);
            this.expandablePanel1.Controls.Add(this.txtMaPhieu);
            this.expandablePanel1.Controls.Add(this.addMaPhieu);
            this.expandablePanel1.Controls.Add(this.txtSoKhung);
            this.expandablePanel1.Controls.Add(this.txtTGBH);
            this.expandablePanel1.Controls.Add(this.txtSoMay);
            this.expandablePanel1.Controls.Add(this.txtMaNv);
            this.expandablePanel1.Controls.Add(this.txtLoaiXe);
            this.expandablePanel1.Controls.Add(this.txtTenXe);
            this.expandablePanel1.Controls.Add(this.cboxTenLoaiXe);
            this.expandablePanel1.Controls.Add(this.cboxTGBH);
            this.expandablePanel1.Controls.Add(this.labelX12);
            this.expandablePanel1.Controls.Add(this.labelX11);
            this.expandablePanel1.Controls.Add(this.labelX10);
            this.expandablePanel1.Controls.Add(this.labelX9);
            this.expandablePanel1.Controls.Add(this.labelX8);
            this.expandablePanel1.Controls.Add(this.labelX7);
            this.expandablePanel1.Controls.Add(this.labelX6);
            this.expandablePanel1.Controls.Add(this.labelX5);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.cboxMaXe);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(12, 47);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1145, 263);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 21;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Thông Tin";
            // 
            // cboxSoMay
            // 
            this.cboxSoMay.DisplayMember = "Text";
            this.cboxSoMay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSoMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSoMay.FormattingEnabled = true;
            this.cboxSoMay.ItemHeight = 21;
            this.cboxSoMay.Location = new System.Drawing.Point(972, 72);
            this.cboxSoMay.Name = "cboxSoMay";
            this.cboxSoMay.Size = new System.Drawing.Size(129, 27);
            this.cboxSoMay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxSoMay.TabIndex = 48;
            // 
            // cboxSoKhung
            // 
            this.cboxSoKhung.DisplayMember = "Text";
            this.cboxSoKhung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSoKhung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSoKhung.FormattingEnabled = true;
            this.cboxSoKhung.ItemHeight = 21;
            this.cboxSoKhung.Location = new System.Drawing.Point(813, 72);
            this.cboxSoKhung.Name = "cboxSoKhung";
            this.cboxSoKhung.Size = new System.Drawing.Size(129, 27);
            this.cboxSoKhung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxSoKhung.TabIndex = 47;
            // 
            // cboxTenKH
            // 
            this.cboxTenKH.DisplayMember = "Text";
            this.cboxTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenKH.FormattingEnabled = true;
            this.cboxTenKH.ItemHeight = 21;
            this.cboxTenKH.Location = new System.Drawing.Point(654, 72);
            this.cboxTenKH.Name = "cboxTenKH";
            this.cboxTenKH.Size = new System.Drawing.Size(129, 27);
            this.cboxTenKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxTenKH.TabIndex = 46;
            // 
            // cboxTenXe
            // 
            this.cboxTenXe.DisplayMember = "Text";
            this.cboxTenXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxTenXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenXe.FormattingEnabled = true;
            this.cboxTenXe.ItemHeight = 21;
            this.cboxTenXe.Location = new System.Drawing.Point(496, 72);
            this.cboxTenXe.Name = "cboxTenXe";
            this.cboxTenXe.Size = new System.Drawing.Size(129, 27);
            this.cboxTenXe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxTenXe.TabIndex = 45;
            // 
            // dateLapPhieu
            // 
            // 
            // 
            // 
            this.dateLapPhieu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateLapPhieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateLapPhieu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateLapPhieu.ButtonDropDown.Visible = true;
            this.dateLapPhieu.IsPopupCalendarOpen = false;
            this.dateLapPhieu.Location = new System.Drawing.Point(938, 216);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateLapPhieu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateLapPhieu.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateLapPhieu.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateLapPhieu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateLapPhieu.MonthCalendar.DisplayMonth = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dateLapPhieu.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateLapPhieu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateLapPhieu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateLapPhieu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateLapPhieu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateLapPhieu.MonthCalendar.TodayButtonVisible = true;
            this.dateLapPhieu.Name = "dateLapPhieu";
            this.dateLapPhieu.Size = new System.Drawing.Size(200, 26);
            this.dateLapPhieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateLapPhieu.TabIndex = 44;
            // 
            // dateMua
            // 
            // 
            // 
            // 
            this.dateMua.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateMua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateMua.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateMua.ButtonDropDown.Visible = true;
            this.dateMua.IsPopupCalendarOpen = false;
            this.dateMua.Location = new System.Drawing.Point(520, 177);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateMua.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateMua.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateMua.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateMua.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateMua.MonthCalendar.DisplayMonth = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dateMua.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateMua.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateMua.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateMua.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateMua.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateMua.MonthCalendar.TodayButtonVisible = true;
            this.dateMua.Name = "dateMua";
            this.dateMua.Size = new System.Drawing.Size(274, 26);
            this.dateMua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateMua.TabIndex = 43;
            // 
            // txtTenKH
            // 
            // 
            // 
            // 
            this.txtTenKH.Border.Class = "TextBoxBorder";
            this.txtTenKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(631, 144);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PreventEnterBeep = true;
            this.txtTenKH.Size = new System.Drawing.Size(163, 26);
            this.txtTenKH.TabIndex = 42;
            // 
            // cboxMaKH
            // 
            this.cboxMaKH.DisplayMember = "Text";
            this.cboxMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMaKH.FormattingEnabled = true;
            this.cboxMaKH.ItemHeight = 21;
            this.cboxMaKH.Location = new System.Drawing.Point(520, 144);
            this.cboxMaKH.Name = "cboxMaKH";
            this.cboxMaKH.Size = new System.Drawing.Size(105, 27);
            this.cboxMaKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxMaKH.TabIndex = 41;
            // 
            // txtMaPhieu
            // 
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(108, 145);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PreventEnterBeep = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(233, 26);
            this.txtMaPhieu.TabIndex = 40;
            // 
            // addMaPhieu
            // 
            this.addMaPhieu.Image = global::DemoDoAn.Properties.Resources.add;
            this.addMaPhieu.Location = new System.Drawing.Point(347, 145);
            this.addMaPhieu.Name = "addMaPhieu";
            this.addMaPhieu.Size = new System.Drawing.Size(35, 26);
            this.addMaPhieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addMaPhieu.TabIndex = 39;
            this.addMaPhieu.TabStop = false;
            // 
            // txtSoKhung
            // 
            // 
            // 
            // 
            this.txtSoKhung.Border.Class = "TextBoxBorder";
            this.txtSoKhung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoKhung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKhung.Location = new System.Drawing.Point(938, 145);
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.PreventEnterBeep = true;
            this.txtSoKhung.Size = new System.Drawing.Size(194, 26);
            this.txtSoKhung.TabIndex = 25;
            // 
            // txtTGBH
            // 
            // 
            // 
            // 
            this.txtTGBH.Border.Class = "TextBoxBorder";
            this.txtTGBH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTGBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGBH.Location = new System.Drawing.Point(520, 215);
            this.txtTGBH.Name = "txtTGBH";
            this.txtTGBH.PreventEnterBeep = true;
            this.txtTGBH.Size = new System.Drawing.Size(178, 26);
            this.txtTGBH.TabIndex = 24;
            // 
            // txtSoMay
            // 
            // 
            // 
            // 
            this.txtSoMay.Border.Class = "TextBoxBorder";
            this.txtSoMay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoMay.Location = new System.Drawing.Point(938, 181);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.PreventEnterBeep = true;
            this.txtSoMay.Size = new System.Drawing.Size(194, 26);
            this.txtSoMay.TabIndex = 23;
            // 
            // txtMaNv
            // 
            // 
            // 
            // 
            this.txtMaNv.Border.Class = "TextBoxBorder";
            this.txtMaNv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNv.Location = new System.Drawing.Point(3, 72);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.PreventEnterBeep = true;
            this.txtMaNv.Size = new System.Drawing.Size(113, 26);
            this.txtMaNv.TabIndex = 21;
            // 
            // txtLoaiXe
            // 
            // 
            // 
            // 
            this.txtLoaiXe.Border.Class = "TextBoxBorder";
            this.txtLoaiXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoaiXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiXe.Location = new System.Drawing.Point(108, 221);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.PreventEnterBeep = true;
            this.txtLoaiXe.Size = new System.Drawing.Size(274, 26);
            this.txtLoaiXe.TabIndex = 20;
            // 
            // txtTenXe
            // 
            // 
            // 
            // 
            this.txtTenXe.Border.Class = "TextBoxBorder";
            this.txtTenXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(219, 183);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.PreventEnterBeep = true;
            this.txtTenXe.Size = new System.Drawing.Size(163, 26);
            this.txtTenXe.TabIndex = 19;
            // 
            // cboxTenLoaiXe
            // 
            this.cboxTenLoaiXe.DisplayMember = "Text";
            this.cboxTenLoaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxTenLoaiXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenLoaiXe.FormattingEnabled = true;
            this.cboxTenLoaiXe.ItemHeight = 21;
            this.cboxTenLoaiXe.Location = new System.Drawing.Point(337, 71);
            this.cboxTenLoaiXe.Name = "cboxTenLoaiXe";
            this.cboxTenLoaiXe.Size = new System.Drawing.Size(129, 27);
            this.cboxTenLoaiXe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxTenLoaiXe.TabIndex = 18;
            // 
            // cboxTGBH
            // 
            this.cboxTGBH.DisplayMember = "Text";
            this.cboxTGBH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxTGBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTGBH.FormattingEnabled = true;
            this.cboxTGBH.ItemHeight = 21;
            this.cboxTGBH.Location = new System.Drawing.Point(122, 72);
            this.cboxTGBH.Name = "cboxTGBH";
            this.cboxTGBH.Size = new System.Drawing.Size(77, 27);
            this.cboxTGBH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxTGBH.TabIndex = 17;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(705, 210);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(87, 32);
            this.labelX12.TabIndex = 15;
            this.labelX12.Text = "(Năm)";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(822, 214);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(110, 32);
            this.labelX11.TabIndex = 14;
            this.labelX11.Text = "Ngày Lập Phiếu";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(822, 176);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(74, 32);
            this.labelX10.TabIndex = 13;
            this.labelX10.Text = "Số Máy";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(417, 177);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(74, 32);
            this.labelX9.TabIndex = 12;
            this.labelX9.Text = "Ngày Mua";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(416, 215);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(98, 32);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "Thời Gian BH";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(822, 139);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(98, 32);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Số Khung";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(417, 140);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(97, 32);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Khách Hàng";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(10, 215);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 32);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Loại xe";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(10, 178);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(74, 32);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Tên Xe";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(10, 145);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 32);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Mã Phiếu BH";
            // 
            // cboxMaXe
            // 
            this.cboxMaXe.DisplayMember = "Text";
            this.cboxMaXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxMaXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMaXe.FormattingEnabled = true;
            this.cboxMaXe.ItemHeight = 21;
            this.cboxMaXe.Location = new System.Drawing.Point(108, 183);
            this.cboxMaXe.Name = "cboxMaXe";
            this.cboxMaXe.Size = new System.Drawing.Size(105, 27);
            this.cboxMaXe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxMaXe.TabIndex = 5;
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.dataPhieuBH);
            this.expandablePanel2.Controls.Add(this.txtTim);
            this.expandablePanel2.Controls.Add(this.btTim);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel2.HideControlsWhenCollapsed = true;
            this.expandablePanel2.Location = new System.Drawing.Point(12, 308);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(1145, 261);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 25;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Tìm Kiếm";
            // 
            // dataPhieuBH
            // 
            this.dataPhieuBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPBH,
            this.MaKH,
            this.MaNV,
            this.Maxe,
            this.Ngaymua,
            this.NgayLapPhieu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhieuBH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataPhieuBH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataPhieuBH.Location = new System.Drawing.Point(0, 76);
            this.dataPhieuBH.Name = "dataPhieuBH";
            this.dataPhieuBH.Size = new System.Drawing.Size(1145, 191);
            this.dataPhieuBH.TabIndex = 12;
            // 
            // MaPBH
            // 
            this.MaPBH.HeaderText = "Mã Phiếu BH";
            this.MaPBH.Name = "MaPBH";
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // Maxe
            // 
            this.Maxe.HeaderText = "Mã Xe";
            this.Maxe.Name = "Maxe";
            // 
            // Ngaymua
            // 
            this.Ngaymua.HeaderText = "Ngày Mua";
            this.Ngaymua.Name = "Ngaymua";
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.HeaderText = "Ngày Lập Phiếu";
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTim.Location = new System.Drawing.Point(24, 38);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(309, 32);
            this.txtTim.TabIndex = 11;
            this.txtTim.Text = "Nhập mã Phiếu bảo hành cần tìm";
            // 
            // btTim
            // 
            this.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTim.Location = new System.Drawing.Point(357, 38);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(104, 32);
            this.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTim.Symbol = "";
            this.btTim.TabIndex = 10;
            this.btTim.Text = "Tìm";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bt_Quydinh);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.btThem);
            this.panelEx1.Controls.Add(this.btSua);
            this.panelEx1.Controls.Add(this.btXoa);
            this.panelEx1.Controls.Add(this.btDong);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(12, 571);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1145, 57);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 29;
            // 
            // bt_Quydinh
            // 
            this.bt_Quydinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Quydinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Quydinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Quydinh.Location = new System.Drawing.Point(670, 5);
            this.bt_Quydinh.Name = "bt_Quydinh";
            this.bt_Quydinh.Size = new System.Drawing.Size(100, 42);
            this.bt_Quydinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_Quydinh.Symbol = "";
            this.bt_Quydinh.TabIndex = 27;
            this.bt_Quydinh.Text = "Quy Định Phiếu BH";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(497, 10);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(94, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 26;
            this.buttonX1.Text = "In";
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(32, 10);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(99, 37);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.Symbol = "";
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm";
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(347, 10);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 36);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.Symbol = "";
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(191, 10);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.Symbol = "";
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa";
            // 
            // btDong
            // 
            this.btDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(977, 8);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 37);
            this.btDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btDong.Symbol = "";
            this.btDong.TabIndex = 24;
            this.btDong.Text = "ĐÓNG";
            // 
            // cboxLoaiXe
            // 
            this.cboxLoaiXe.DisplayMember = "Text";
            this.cboxLoaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxLoaiXe.FormattingEnabled = true;
            this.cboxLoaiXe.ItemHeight = 20;
            this.cboxLoaiXe.Location = new System.Drawing.Point(206, 72);
            this.cboxLoaiXe.Name = "cboxLoaiXe";
            this.cboxLoaiXe.Size = new System.Drawing.Size(121, 26);
            this.cboxLoaiXe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxLoaiXe.TabIndex = 49;
            // 
            // frmPhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 633);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel2);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.labelX1);
            this.Name = "frmPhieuBaoHanh";
            this.Text = "frmPhieuBaoHanh";
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateLapPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMaPhieu)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuBH)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoKhung;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTGBH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoMay;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoaiXe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenXe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxTenLoaiXe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxTGBH;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxMaXe;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataPhieuBH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btTim;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btDong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxMaKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private System.Windows.Forms.PictureBox addMaPhieu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateLapPhieu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateMua;
        private DevComponents.DotNetBar.ButtonX bt_Quydinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxSoMay;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxSoKhung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxTenKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboxLoaiXe;


    }
}