using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.DAL.Models;

namespace Form_quan_ly_khach_san
{
    public partial class Phanquyen : Form
    {
        private NhanVienBUS nvBus = new NhanVienBUS();
        public Phanquyen()
        {
            InitializeComponent();
        }
        private void Phanquyen_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("Danh sách nhân viên");    
            root.Tag = "Ro";
            treeView1.Nodes.Add(root);
            var danhSachNV = nvBus.LayDanhSachNhanVien();

            foreach (var nv in danhSachNV)
            {
                TreeNode tn = new TreeNode(nv.TaiKhoan);
                tn.Tag = "E" + nv.MaNV;
                root.Nodes.Add(tn);
            }
            treeView1.ExpandAll();
        }
        #region Các nút chức năng
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Tag.ToString() == "Ro")
            {
                MessageBox.Show("Bạn phải chọn nhân viên!");
                return;
            }

            string maNV = treeView1.SelectedNode.Tag.ToString().Substring(1);
            string quyenMoi = "";
            if (listView1.Items[1].Checked) quyenMoi = "ADMIN";
            else if (listView1.Items[0].Checked) quyenMoi = "NHANVIEN";

            if (string.IsNullOrEmpty(quyenMoi))
            {
                MessageBox.Show("Hãy chọn ít nhất một quyền hạn!");
                return;
            }
            if (nvBus.CapNhatQuyen(maNV, quyenMoi))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region treeview và listview
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items) item.Checked = false;

            string tag = treeView1.SelectedNode.Tag.ToString();
            if (tag != "Ro")
            {
                string maNV = tag.Substring(1);
                var nv = nvBus.TimTheoMa(maNV);

                if (nv != null)
                {
                    txtHoten.Text = nv.HoTen;
                    txtManv.Text = nv.MaNV;
                    txtTendn.Text = nv.TaiKhoan;
                    string quyen = nv.Quyen.Trim();
                    if (quyen == "ADMIN") listView1.Items[1].Checked = true;
                    else if (quyen == "NHANVIEN") listView1.Items[0].Checked = true;
                }
            }
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Index != e.Index)
                    {
                        item.Checked = false;
                    }
                }
            }
        }
        #endregion
    }
}
