namespace Form_quan_ly_khach_san
{
    partial class frmDichVu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaCheckin = new System.Windows.Forms.ComboBox();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colummacheckin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colummadicvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthemchitiet = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Check-in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá tiền";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 655);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(267, 654);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaCheckin
            // 
            this.cmbMaCheckin.FormattingEnabled = true;
            this.cmbMaCheckin.Location = new System.Drawing.Point(246, 302);
            this.cmbMaCheckin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMaCheckin.Name = "cmbMaCheckin";
            this.cmbMaCheckin.Size = new System.Drawing.Size(260, 28);
            this.cmbMaCheckin.TabIndex = 6;
            this.cmbMaCheckin.SelectedIndexChanged += new System.EventHandler(this.cmbMaCheckin_SelectedIndexChanged);
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(246, 434);
            this.cmbTenDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(260, 28);
            this.cmbTenDichVu.TabIndex = 7;
            this.cmbTenDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbTenDichVu_SelectedIndexChanged);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(246, 555);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(260, 26);
            this.txtGiaTien.TabIndex = 9;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummacheckin,
            this.colummadicvu,
            this.columngay});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(136, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 192);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colummacheckin
            // 
            this.colummacheckin.Text = "Mã Check-in";
            this.colummacheckin.Width = 120;
            // 
            // colummadicvu
            // 
            this.colummadicvu.Text = "Mã dịch vụ";
            this.colummadicvu.Width = 120;
            // 
            // columngay
            // 
            this.columngay.Text = "Thành Tiền";
            this.columngay.Width = 120;
            // 
            // btnthemchitiet
            // 
            this.btnthemchitiet.Location = new System.Drawing.Point(622, 654);
            this.btnthemchitiet.Name = "btnthemchitiet";
            this.btnthemchitiet.Size = new System.Drawing.Size(151, 34);
            this.btnthemchitiet.TabIndex = 11;
            this.btnthemchitiet.Text = "thêm cho khách ";
            this.btnthemchitiet.UseVisualStyleBackColor = true;
            this.btnthemchitiet.Click += new System.EventHandler(this.btnthemchitiet_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(768, 198);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 26);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "số lượng";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnthemchitiet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.cmbTenDichVu);
            this.Controls.Add(this.cmbMaCheckin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDichVu";
            this.Text = "DichVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaCheckin;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colummacheckin;
        private System.Windows.Forms.ColumnHeader colummadicvu;
        private System.Windows.Forms.ColumnHeader columngay;
        private System.Windows.Forms.Button btnthemchitiet;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
    }
}