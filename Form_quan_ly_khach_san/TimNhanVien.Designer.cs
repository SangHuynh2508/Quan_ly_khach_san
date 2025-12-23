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
            this.btnTim.Location = new System.Drawing.Point(219, 512);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(461, 512);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoTenNV
            // 
            this.rdbTimTheoTenNV.AutoSize = true;
            this.rdbTimTheoTenNV.Location = new System.Drawing.Point(157, 51);
            this.rdbTimTheoTenNV.Name = "rdbTimTheoTenNV";
            this.rdbTimTheoTenNV.Size = new System.Drawing.Size(123, 20);
            this.rdbTimTheoTenNV.TabIndex = 2;
            this.rdbTimTheoTenNV.TabStop = true;
            this.rdbTimTheoTenNV.Text = "Tìm theo tên NV";
            this.rdbTimTheoTenNV.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoSDT
            // 
            this.rdbTimTheoSDT.AutoSize = true;
            this.rdbTimTheoSDT.Location = new System.Drawing.Point(476, 51);
            this.rdbTimTheoSDT.Name = "rdbTimTheoSDT";
            this.rdbTimTheoSDT.Size = new System.Drawing.Size(110, 20);
            this.rdbTimTheoSDT.TabIndex = 3;
            this.rdbTimTheoSDT.TabStop = true;
            this.rdbTimTheoSDT.Text = "Tìm theo SĐT";
            this.rdbTimTheoSDT.UseVisualStyleBackColor = true;
            // 
            // dgvTimNhanVien
            // 
            this.dgvTimNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimNhanVien.Location = new System.Drawing.Point(60, 227);
            this.dgvTimNhanVien.Name = "dgvTimNhanVien";
            this.dgvTimNhanVien.RowHeadersWidth = 51;
            this.dgvTimNhanVien.RowTemplate.Height = 24;
            this.dgvTimNhanVien.Size = new System.Drawing.Size(704, 257);
            this.dgvTimNhanVien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(272, 119);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(197, 22);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(272, 173);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(197, 22);
            this.txtSDTNV.TabIndex = 8;
            // 
            // TimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimNhanVien);
            this.Controls.Add(this.rdbTimTheoSDT);
            this.Controls.Add(this.rdbTimTheoTenNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
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