namespace Form_quan_ly_khach_san
{
    partial class Checkin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.txtNgayDi = new System.Windows.Forms.TextBox();
            this.txtSoPhongDon = new System.Windows.Forms.TextBox();
            this.txtSoPhongDoi = new System.Windows.Forms.TextBox();
            this.txtMaCheckin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày đi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số phòng đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số phòng đôi";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(94, 503);
            this.btnThemKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(136, 42);
            this.btnThemKhach.TabIndex = 9;
            this.btnThemKhach.Text = "Thêm khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 503);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 42);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(606, 503);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 42);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(127, 182);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 182);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(127, 55);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(238, 26);
            this.txtMaKhach.TabIndex = 14;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 118);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(238, 26);
            this.txtHoTen.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 249);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(238, 26);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(127, 326);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(238, 26);
            this.txtCMND.TabIndex = 17;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Location = new System.Drawing.Point(565, 118);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(217, 26);
            this.txtNgayDen.TabIndex = 18;
            // 
            // txtNgayDi
            // 
            this.txtNgayDi.Location = new System.Drawing.Point(565, 180);
            this.txtNgayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayDi.Name = "txtNgayDi";
            this.txtNgayDi.Size = new System.Drawing.Size(217, 26);
            this.txtNgayDi.TabIndex = 19;
            // 
            // txtSoPhongDon
            // 
            this.txtSoPhongDon.Location = new System.Drawing.Point(565, 249);
            this.txtSoPhongDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoPhongDon.Name = "txtSoPhongDon";
            this.txtSoPhongDon.Size = new System.Drawing.Size(217, 26);
            this.txtSoPhongDon.TabIndex = 20;
            // 
            // txtSoPhongDoi
            // 
            this.txtSoPhongDoi.Location = new System.Drawing.Point(565, 326);
            this.txtSoPhongDoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoPhongDoi.Name = "txtSoPhongDoi";
            this.txtSoPhongDoi.Size = new System.Drawing.Size(217, 26);
            this.txtSoPhongDoi.TabIndex = 21;
            // 
            // txtMaCheckin
            // 
            this.txtMaCheckin.Location = new System.Drawing.Point(565, 55);
            this.txtMaCheckin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCheckin.Name = "txtMaCheckin";
            this.txtMaCheckin.Size = new System.Drawing.Size(217, 26);
            this.txtMaCheckin.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã Checkin";
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 672);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaCheckin);
            this.Controls.Add(this.txtSoPhongDoi);
            this.Controls.Add(this.txtSoPhongDon);
            this.Controls.Add(this.txtNgayDi);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemKhach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Checkin";
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.TextBox txtNgayDi;
        private System.Windows.Forms.TextBox txtSoPhongDon;
        private System.Windows.Forms.TextBox txtSoPhongDoi;
        private System.Windows.Forms.TextBox txtMaCheckin;
        private System.Windows.Forms.Label label10;
    }
}