using QLKS.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.DAL.Models;


namespace Form_quan_ly_khach_san
{
    public partial class frmDichVu : Form
    {
        private DichVuBUS dichVuBUS = new DichVuBUS();
        private CheckinBUS checkinBUS = new CheckinBUS();
        public frmDichVu()
        {
            InitializeComponent();
            LoadDichVu();
            LoadMaCheckin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTenDichVu.Text) || string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DichVu dv = new DichVu()
            {
                MaDV = "DV" + DateTime.Now.Ticks.ToString().Substring(10), // tự tạo mã
                TenDV = cmbTenDichVu.Text,
                DonGia = decimal.Parse(txtGiaTien.Text)
            };

            bool kq = dichVuBUS.ThemDichVu(dv);
            if (kq)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại!");
            }
        }

        private void LoadDichVu()
        {
            cmbTenDichVu.DataSource = dichVuBUS.LayTatCaDichVu();
            cmbTenDichVu.DisplayMember = "TenDV";
            cmbTenDichVu.ValueMember = "MaDV";

            listView1.Items.Clear();
            foreach (var dv in dichVuBUS.LayTatCaDichVu())
            {
                ListViewItem item = new ListViewItem(dv.MaDV);
                item.SubItems.Add(dv.TenDV);
                item.SubItems.Add(dv.DonGia.ToString());
                listView1.Items.Add(item);
            }
        }


        private void LoadMaCheckin()
        {
            var dsPhieu = checkinBUS.LayTatCaPhieuThue(); // Cần thêm method trong CheckinBUS
            cmbMaCheckin.DataSource = dsPhieu;
            cmbMaCheckin.DisplayMember = "MaPhieu";
            cmbMaCheckin.ValueMember = "MaPhieu";
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaCheckin_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cmbMaCheckin.SelectedValue == null)
                return;

            string maPhieu = cmbMaCheckin.SelectedValue.ToString();
            HienThiDichVuTheoPhieu(maPhieu);
        }

        

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenDichVu.SelectedItem is DichVu dv)
            {
                txtGiaTien.Text = dv.DonGia.ToString();
            }
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {

        }


        private void HienThiDichVuTheoPhieu(string maPhieu)
        {
            var ds = dichVuBUS.LayDichVuTheoPhieu(maPhieu);

            listView1.Items.Clear();
            foreach (var ct in ds)
            {
                ListViewItem item = new ListViewItem(ct.MaDV);
                item.SubItems.Add(ct.DichVu.TenDV);
                item.SubItems.Add(ct.SoLuong.ToString());
                item.SubItems.Add(ct.DichVu.DonGia.ToString("N0"));
                item.SubItems.Add((ct.SoLuong * ct.DichVu.DonGia).ToString("N0"));

                listView1.Items.Add(item);
            }
        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            if (cmbMaCheckin.SelectedValue == null ||
       cmbTenDichVu.SelectedValue == null ||
       string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu, dịch vụ và số lượng!");
                return;
            }

            string maPhieu = cmbMaCheckin.SelectedValue.ToString();
            string maDV = cmbTenDichVu.SelectedValue.ToString();
            int soLuong;

            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            bool kq = dichVuBUS.ThemDichVuVaoPhieu(maPhieu, maDV, soLuong);

            if (kq)
            {
                MessageBox.Show("Đã thêm dịch vụ cho khách!");
                HienThiDichVuTheoPhieu(maPhieu);
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại!");
            }
        }
    }
}
