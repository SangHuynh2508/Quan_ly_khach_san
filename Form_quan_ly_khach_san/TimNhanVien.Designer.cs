namespace Form_quan_ly_khach_san
{
    partial class TimNhanVien
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
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdbTimTheoTenNV = new System.Windows.Forms.RadioButton();
            this.rdbTimTheoSDT = new System.Windows.Forms.RadioButton();
            this.dgvTimNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(184, 633);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 41);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(437, 633);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 41);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoTenNV
            // 
            this.rdbTimTheoTenNV.AutoSize = true;
            this.rdbTimTheoTenNV.Location = new System.Drawing.Point(177, 64);
            this.rdbTimTheoTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTimTheoTenNV.Name = "rdbTimTheoTenNV";
            this.rdbTimTheoTenNV.Size = new System.Drawing.Size(148, 24);
            this.rdbTimTheoTenNV.TabIndex = 2;
            this.rdbTimTheoTenNV.TabStop = true;
            this.rdbTimTheoTenNV.Text = "Tìm theo tên NV";
            this.rdbTimTheoTenNV.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoSDT
            // 
            this.rdbTimTheoSDT.AutoSize = true;
            this.rdbTimTheoSDT.Location = new System.Drawing.Point(536, 64);
            this.rdbTimTheoSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTimTheoSDT.Name = "rdbTimTheoSDT";
            this.rdbTimTheoSDT.Size = new System.Drawing.Size(131, 24);
            this.rdbTimTheoSDT.TabIndex = 3;
            this.rdbTimTheoSDT.TabStop = true;
            this.rdbTimTheoSDT.Text = "Tìm theo SĐT";
            this.rdbTimTheoSDT.UseVisualStyleBackColor = true;
            // 
            // dgvTimNhanVien
            // 
            this.dgvTimNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimNhanVien.Location = new System.Drawing.Point(68, 284);
            this.dgvTimNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTimNhanVien.Name = "dgvTimNhanVien";
            this.dgvTimNhanVien.RowHeadersWidth = 51;
            this.dgvTimNhanVien.RowTemplate.Height = 24;
            this.dgvTimNhanVien.Size = new System.Drawing.Size(792, 321);
            this.dgvTimNhanVien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(306, 149);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(221, 26);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(306, 216);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(221, 26);
            this.txtSDTNV.TabIndex = 8;
            // 
            // TimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 701);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimNhanVien);
            this.Controls.Add(this.rdbTimTheoSDT);
            this.Controls.Add(this.rdbTimTheoTenNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimNhanVien";
            this.Text = "TimNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdbTimTheoTenNV;
        private System.Windows.Forms.RadioButton rdbTimTheoSDT;
        private System.Windows.Forms.DataGridView dgvTimNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDTNV;
    }
}