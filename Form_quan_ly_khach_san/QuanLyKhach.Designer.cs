namespace Form_quan_ly_khach_san
{
    partial class QuanLyKhach
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
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaThongTin = new System.Windows.Forms.Button();
            this.dgvQuanLyKhach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(75, 481);
            this.btnThemKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(116, 41);
            this.btnThemKhach.TabIndex = 0;
            this.btnThemKhach.Text = "Thêm khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(248, 481);
            this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(117, 40);
            this.btnSuaThongTin.TabIndex = 1;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(467, 481);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 40);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaThongTin
            // 
            this.btnXoaThongTin.Location = new System.Drawing.Point(633, 481);
            this.btnXoaThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaThongTin.Name = "btnXoaThongTin";
            this.btnXoaThongTin.Size = new System.Drawing.Size(133, 40);
            this.btnXoaThongTin.TabIndex = 3;
            this.btnXoaThongTin.Text = "Xóa thông tin";
            this.btnXoaThongTin.UseVisualStyleBackColor = true;
            this.btnXoaThongTin.Click += new System.EventHandler(this.btnXoaThongTin_Click);
            // 
            // dgvQuanLyKhach
            // 
            this.dgvQuanLyKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhach.Location = new System.Drawing.Point(48, 40);
            this.dgvQuanLyKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQuanLyKhach.Name = "dgvQuanLyKhach";
            this.dgvQuanLyKhach.RowHeadersWidth = 51;
            this.dgvQuanLyKhach.RowTemplate.Height = 24;
            this.dgvQuanLyKhach.Size = new System.Drawing.Size(789, 414);
            this.dgvQuanLyKhach.TabIndex = 4;
            // 
            // QuanLyKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dgvQuanLyKhach);
            this.Controls.Add(this.btnXoaThongTin);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSuaThongTin);
            this.Controls.Add(this.btnThemKhach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyKhach";
            this.Text = "QuanLyKhach";
            this.Load += new System.EventHandler(this.QuanLyKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaThongTin;
        private System.Windows.Forms.DataGridView dgvQuanLyKhach;
    }
}