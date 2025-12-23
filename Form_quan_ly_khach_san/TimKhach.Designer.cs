namespace Form_quan_ly_khach_san
{
    partial class TimKhach
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
            this.rdbTimTheoTen = new System.Windows.Forms.RadioButton();
            this.rdbTimTheoCMND = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.dgvTimKhach = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbTimTheoTen
            // 
            this.rdbTimTheoTen.AutoSize = true;
            this.rdbTimTheoTen.Location = new System.Drawing.Point(102, 49);
            this.rdbTimTheoTen.Name = "rdbTimTheoTen";
            this.rdbTimTheoTen.Size = new System.Drawing.Size(101, 20);
            this.rdbTimTheoTen.TabIndex = 0;
            this.rdbTimTheoTen.TabStop = true;
            this.rdbTimTheoTen.Text = "Tìm theo tên";
            this.rdbTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoCMND
            // 
            this.rdbTimTheoCMND.AutoSize = true;
            this.rdbTimTheoCMND.Location = new System.Drawing.Point(308, 49);
            this.rdbTimTheoCMND.Name = "rdbTimTheoCMND";
            this.rdbTimTheoCMND.Size = new System.Drawing.Size(123, 20);
            this.rdbTimTheoCMND.TabIndex = 1;
            this.rdbTimTheoCMND.TabStop = true;
            this.rdbTimTheoCMND.Text = "Tìm theo CMND";
            this.rdbTimTheoCMND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số CMND";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(248, 135);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(236, 22);
            this.txtTenKhach.TabIndex = 4;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(248, 200);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(236, 22);
            this.txtSoCMND.TabIndex = 5;
            // 
            // dgvTimKhach
            // 
            this.dgvTimKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKhach.Location = new System.Drawing.Point(67, 262);
            this.dgvTimKhach.Name = "dgvTimKhach";
            this.dgvTimKhach.RowHeadersWidth = 51;
            this.dgvTimKhach.RowTemplate.Height = 24;
            this.dgvTimKhach.Size = new System.Drawing.Size(686, 150);
            this.dgvTimKhach.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(201, 473);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(121, 37);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(481, 473);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // TimKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvTimKhach);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbTimTheoCMND);
            this.Controls.Add(this.rdbTimTheoTen);
            this.Name = "TimKhach";
            this.Text = "TimKhach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTimTheoTen;
        private System.Windows.Forms.RadioButton rdbTimTheoCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.DataGridView dgvTimKhach;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}