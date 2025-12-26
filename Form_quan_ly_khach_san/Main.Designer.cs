namespace Form_quan_ly_khach_san
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThayDoiTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCheckin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnXoaKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.MnQuanLyDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCapNhatNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimKiemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThemXoaNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.MnQLKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.MnAboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnDangNhap,
            this.MnThayDoiTTCaNhan,
            this.MnDangXuat,
            this.MnThoat});
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MnDangNhap
            // 
            this.MnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("MnDangNhap.Image")));
            this.MnDangNhap.Name = "MnDangNhap";
            this.MnDangNhap.Size = new System.Drawing.Size(326, 34);
            this.MnDangNhap.Text = "Đăng nhập";
            this.MnDangNhap.Click += new System.EventHandler(this.MnDangNhap_Click);
            // 
            // MnThayDoiTTCaNhan
            // 
            this.MnThayDoiTTCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("MnThayDoiTTCaNhan.Image")));
            this.MnThayDoiTTCaNhan.Name = "MnThayDoiTTCaNhan";
            this.MnThayDoiTTCaNhan.Size = new System.Drawing.Size(326, 34);
            this.MnThayDoiTTCaNhan.Text = "Thay đổi thông tin cá nhân";
            this.MnThayDoiTTCaNhan.Click += new System.EventHandler(this.MnThayDoiTTCaNhan_Click);
            // 
            // MnDangXuat
            // 
            this.MnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("MnDangXuat.Image")));
            this.MnDangXuat.Name = "MnDangXuat";
            this.MnDangXuat.Size = new System.Drawing.Size(326, 34);
            this.MnDangXuat.Text = "Đăng xuất";
            this.MnDangXuat.Click += new System.EventHandler(this.MnDangXuat_Click);
            // 
            // MnThoat
            // 
            this.MnThoat.Name = "MnThoat";
            this.MnThoat.Size = new System.Drawing.Size(326, 34);
            this.MnThoat.Text = "Thoát";
            this.MnThoat.Click += new System.EventHandler(this.MnThoat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnQuanLyKhachHang,
            this.MnQuanLyDichVu,
            this.MnQuanLyNhanVien});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // MnQuanLyKhachHang
            // 
            this.MnQuanLyKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCheckin,
            this.MnCheckout,
            this.MnTimKiem,
            this.MnCapNhat,
            this.MnXoaKhach,
            this.MnQLKhach});
            this.MnQuanLyKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("MnQuanLyKhachHang.Image")));
            this.MnQuanLyKhachHang.Name = "MnQuanLyKhachHang";
            this.MnQuanLyKhachHang.Size = new System.Drawing.Size(271, 34);
            this.MnQuanLyKhachHang.Text = "Quản lý khách hàng";
            // 
            // MnCheckin
            // 
            this.MnCheckin.Image = ((System.Drawing.Image)(resources.GetObject("MnCheckin.Image")));
            this.MnCheckin.Name = "MnCheckin";
            this.MnCheckin.Size = new System.Drawing.Size(270, 34);
            this.MnCheckin.Text = "Check-in";
            this.MnCheckin.Click += new System.EventHandler(this.MnCheckin_Click);
            // 
            // MnCheckout
            // 
            this.MnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("MnCheckout.Image")));
            this.MnCheckout.Name = "MnCheckout";
            this.MnCheckout.Size = new System.Drawing.Size(270, 34);
            this.MnCheckout.Text = "Check-out";
            this.MnCheckout.Click += new System.EventHandler(this.MnCheckout_Click);
            // 
            // MnTimKiem
            // 
            this.MnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("MnTimKiem.Image")));
            this.MnTimKiem.Name = "MnTimKiem";
            this.MnTimKiem.Size = new System.Drawing.Size(270, 34);
            this.MnTimKiem.Text = "Tìm kiếm";
            this.MnTimKiem.Click += new System.EventHandler(this.MnTimKiem_Click);
            // 
            // MnCapNhat
            // 
            this.MnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("MnCapNhat.Image")));
            this.MnCapNhat.Name = "MnCapNhat";
            this.MnCapNhat.Size = new System.Drawing.Size(270, 34);
            this.MnCapNhat.Text = "Cập nhật";
            this.MnCapNhat.Click += new System.EventHandler(this.MnCapNhat_Click);
            // 
            // MnXoaKhach
            // 
            this.MnXoaKhach.Image = ((System.Drawing.Image)(resources.GetObject("MnXoaKhach.Image")));
            this.MnXoaKhach.Name = "MnXoaKhach";
            this.MnXoaKhach.Size = new System.Drawing.Size(270, 34);
            this.MnXoaKhach.Text = "Xóa khách";
            this.MnXoaKhach.Click += new System.EventHandler(this.MnXoaKhach_Click);
            // 
            // MnQuanLyDichVu
            // 
            this.MnQuanLyDichVu.Image = ((System.Drawing.Image)(resources.GetObject("MnQuanLyDichVu.Image")));
            this.MnQuanLyDichVu.Name = "MnQuanLyDichVu";
            this.MnQuanLyDichVu.Size = new System.Drawing.Size(271, 34);
            this.MnQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.MnQuanLyDichVu.Click += new System.EventHandler(this.MnQuanLyDichVu_Click);
            // 
            // MnQuanLyNhanVien
            // 
            this.MnQuanLyNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCapNhatNV,
            this.MnTimKiemNV,
            this.MnThemXoaNV});
            this.MnQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("MnQuanLyNhanVien.Image")));
            this.MnQuanLyNhanVien.Name = "MnQuanLyNhanVien";
            this.MnQuanLyNhanVien.Size = new System.Drawing.Size(271, 34);
            this.MnQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // MnCapNhatNV
            // 
            this.MnCapNhatNV.Name = "MnCapNhatNV";
            this.MnCapNhatNV.Size = new System.Drawing.Size(277, 34);
            this.MnCapNhatNV.Text = "Cập nhật";
            this.MnCapNhatNV.Click += new System.EventHandler(this.MnCapNhatNV_Click);
            // 
            // MnTimKiemNV
            // 
            this.MnTimKiemNV.Name = "MnTimKiemNV";
            this.MnTimKiemNV.Size = new System.Drawing.Size(277, 34);
            this.MnTimKiemNV.Text = "Tìm kiếm";
            this.MnTimKiemNV.Click += new System.EventHandler(this.MnTimKiemNV_Click);
            // 
            // MnThemXoaNV
            // 
            this.MnThemXoaNV.Name = "MnThemXoaNV";
            this.MnThemXoaNV.Size = new System.Drawing.Size(277, 34);
            this.MnThemXoaNV.Text = "Thêm mới và xóa bỏ";
            this.MnThemXoaNV.Click += new System.EventHandler(this.MnThemXoaNV_Click);
            // 
            // MnAboutUs
            // 
            this.MnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("MnAboutUs.Image")));
            this.MnAboutUs.Name = "MnAboutUs";
            this.MnAboutUs.Size = new System.Drawing.Size(121, 29);
            this.MnAboutUs.Text = "About us";
            this.MnAboutUs.Click += new System.EventHandler(this.MnAboutUs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(155, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZAUNMANIA HOTEL";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // MnQLKhach
            // 
            this.MnQLKhach.Image = ((System.Drawing.Image)(resources.GetObject("MnQLKhach.Image")));
            this.MnQLKhach.Name = "MnQLKhach";
            this.MnQLKhach.Size = new System.Drawing.Size(270, 34);
            this.MnQLKhach.Text = "Danh sách khách";
            this.MnQLKhach.Click += new System.EventHandler(this.MnQLKhach_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem MnThayDoiTTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem MnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem MnThoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MnCheckin;
        private System.Windows.Forms.ToolStripMenuItem MnCheckout;
        private System.Windows.Forms.ToolStripMenuItem MnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem MnCapNhat;
        private System.Windows.Forms.ToolStripMenuItem MnXoaKhach;
        private System.Windows.Forms.ToolStripMenuItem MnQuanLyDichVu;
        private System.Windows.Forms.ToolStripMenuItem MnQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnCapNhatNV;
        private System.Windows.Forms.ToolStripMenuItem MnTimKiemNV;
        private System.Windows.Forms.ToolStripMenuItem MnThemXoaNV;
        private System.Windows.Forms.ToolStripMenuItem MnAboutUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MnQLKhach;
    }
}

