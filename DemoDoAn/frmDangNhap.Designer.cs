namespace DemoDoAn
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lgl2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnTest = new DevComponents.DotNetBar.ButtonX();
            this.server = new System.Windows.Forms.ComboBox();
            this.database = new System.Windows.Forms.ComboBox();
            this.authen = new System.Windows.Forms.ComboBox();
            this.lgl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menu_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.grDangNhap = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.grKetNoi = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel_main = new System.Windows.Forms.Panel();
            this.grDangNhap.SuspendLayout();
            this.grKetNoi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lgl2
            // 
            this.lgl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl2.AutoSize = true;
            this.lgl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lgl2.Location = new System.Drawing.Point(10, 136);
            this.lgl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lgl2.Name = "lgl2";
            this.lgl2.Size = new System.Drawing.Size(101, 24);
            this.lgl2.TabIndex = 16;
            this.lgl2.Text = "Tài Khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtTaiKhoan.Location = new System.Drawing.Point(167, 130);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(341, 29);
            this.txtTaiKhoan.TabIndex = 13;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(380, 345);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Text = "Exit";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(230, 345);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 31);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.Symbol = "";
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTest
            // 
            this.btnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(230, 259);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(172, 34);
            this.btnTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTest.Symbol = "";
            this.btnTest.TabIndex = 22;
            this.btnTest.Text = "Test Connect";
            this.btnTest.Click += new System.EventHandler(this.buttom_test_Click);
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.FormattingEnabled = true;
            this.server.Location = new System.Drawing.Point(230, 94);
            this.server.Margin = new System.Windows.Forms.Padding(4);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(235, 30);
            this.server.TabIndex = 50;
            // 
            // database
            // 
            this.database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.database.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(230, 301);
            this.database.Margin = new System.Windows.Forms.Padding(4);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(235, 30);
            this.database.TabIndex = 46;
            // 
            // authen
            // 
            this.authen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authen.FormattingEnabled = true;
            this.authen.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.authen.Location = new System.Drawing.Point(230, 135);
            this.authen.Margin = new System.Windows.Forms.Padding(4);
            this.authen.Name = "authen";
            this.authen.Size = new System.Drawing.Size(235, 30);
            this.authen.TabIndex = 45;
            this.authen.SelectedIndexChanged += new System.EventHandler(this.authen_SelectedIndexChanged);
            // 
            // lgl3
            // 
            this.lgl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl3.AutoSize = true;
            this.lgl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lgl3.Location = new System.Drawing.Point(10, 185);
            this.lgl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lgl3.Name = "lgl3";
            this.lgl3.Size = new System.Drawing.Size(94, 24);
            this.lgl3.TabIndex = 17;
            this.lgl3.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 730);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 12);
            this.panel2.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(230, 218);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(235, 28);
            this.pass.TabIndex = 44;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(230, 176);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(235, 28);
            this.username.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(59, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(59, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Username:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtMatKhau.Location = new System.Drawing.Point(167, 179);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(341, 29);
            this.txtMatKhau.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 12);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(59, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Database:";
            // 
            // menu_connect
            // 
            this.menu_connect.BackColor = System.Drawing.Color.White;
            this.menu_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_connect.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_connect.Image = ((System.Drawing.Image)(resources.GetObject("menu_connect.Image")));
            this.menu_connect.Name = "menu_connect";
            this.menu_connect.Size = new System.Drawing.Size(283, 54);
            this.menu_connect.Text = "Kết nối CSDL - Đăng nhập";
            this.menu_connect.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Server:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(167, 231);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 34);
            this.btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangNhap.Symbol = "";
            this.btnDangNhap.TabIndex = 22;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // grDangNhap
            // 
            this.grDangNhap.Controls.Add(this.btnDangNhap);
            this.grDangNhap.Controls.Add(this.labelX1);
            this.grDangNhap.Controls.Add(this.lgl2);
            this.grDangNhap.Controls.Add(this.txtMatKhau);
            this.grDangNhap.Controls.Add(this.txtTaiKhoan);
            this.grDangNhap.Controls.Add(this.lgl3);
            this.grDangNhap.Location = new System.Drawing.Point(664, 144);
            this.grDangNhap.Name = "grDangNhap";
            this.grDangNhap.Size = new System.Drawing.Size(561, 400);
            this.grDangNhap.TabIndex = 20;
            this.grDangNhap.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(0, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(561, 52);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "ĐĂNG NHẬP";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(59, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Authentication:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(0, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(561, 52);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "THIẾT LẬP KẾT NỐI";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // grKetNoi
            // 
            this.grKetNoi.Controls.Add(this.buttonX1);
            this.grKetNoi.Controls.Add(this.btnOk);
            this.grKetNoi.Controls.Add(this.btnTest);
            this.grKetNoi.Controls.Add(this.server);
            this.grKetNoi.Controls.Add(this.database);
            this.grKetNoi.Controls.Add(this.authen);
            this.grKetNoi.Controls.Add(this.pass);
            this.grKetNoi.Controls.Add(this.username);
            this.grKetNoi.Controls.Add(this.label5);
            this.grKetNoi.Controls.Add(this.label4);
            this.grKetNoi.Controls.Add(this.label3);
            this.grKetNoi.Controls.Add(this.label2);
            this.grKetNoi.Controls.Add(this.label1);
            this.grKetNoi.Controls.Add(this.labelX2);
            this.grKetNoi.Location = new System.Drawing.Point(137, 144);
            this.grKetNoi.Name = "grKetNoi";
            this.grKetNoi.Size = new System.Drawing.Size(521, 400);
            this.grKetNoi.TabIndex = 21;
            this.grKetNoi.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_connect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1362, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.grKetNoi);
            this.panel_main.Controls.Add(this.grDangNhap);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.menuStrip1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1362, 742);
            this.panel_main.TabIndex = 13;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.panel_main);
            this.Name = "frmDangNhap";
            this.Text = "frmDangnhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grDangNhap.ResumeLayout(false);
            this.grDangNhap.PerformLayout();
            this.grKetNoi.ResumeLayout(false);
            this.grKetNoi.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lgl2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnTest;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.ComboBox authen;
        private System.Windows.Forms.Label lgl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem menu_connect;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnDangNhap;
        private System.Windows.Forms.GroupBox grDangNhap;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox grKetNoi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_main;

    }
}