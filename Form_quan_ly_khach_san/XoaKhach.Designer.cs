namespace Form_quan_ly_khach_san
{
    partial class XoaKhach
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
            this.dgvXoaKhach = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXoaKhach
            // 
            this.dgvXoaKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaKhach.Location = new System.Drawing.Point(99, 30);
            this.dgvXoaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvXoaKhach.Name = "dgvXoaKhach";
            this.dgvXoaKhach.RowHeadersWidth = 51;
            this.dgvXoaKhach.RowTemplate.Height = 24;
            this.dgvXoaKhach.Size = new System.Drawing.Size(711, 360);
            this.dgvXoaKhach.TabIndex = 0;
            this.dgvXoaKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXoaKhach_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(273, 492);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(516, 492);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 49);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(488, 422);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(112, 26);
            this.txtMaKhach.TabIndex = 3;
            this.txtMaKhach.TextChanged += new System.EventHandler(this.txtMaKhach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã khách muốn xóa";
            // 
            // XoaKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvXoaKhach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XoaKhach";
            this.Text = "XoaKhach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXoaKhach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label1;
    }
}