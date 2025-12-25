using Form_quan_ly_khach_san.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_quan_ly_khach_san
{
    public partial class Phanquyen : Form
    {
        private QLKSContext db = new QLKSContext();
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

    
            var danhSachNV = db.NhanViens.ToList();

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
            string tag = treeView1.SelectedNode.Tag.ToString();
            if (tag == "Ro")
            {
                MessageBox.Show("Bạn phải chọn nhân viên!");
                return;
            }

            string maNV = tag.Substring(1);
            var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);

            if (nv != null)
            {
                string quyenMoi = "";
                if (listView1.Items[2].Checked) quyenMoi = "ADMIN";
                else if (listView1.Items[0].Checked) quyenMoi = "NHANVIEN";

                if (string.IsNullOrEmpty(quyenMoi))
                {
                    MessageBox.Show("Hãy chọn ít nhất một quyền hạn!");
                    return;
                }
                nv.Quyen = quyenMoi;
                db.SaveChanges();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items) item.Checked = false;

            string tag = treeView1.SelectedNode.Tag.ToString();
            if (tag != "Ro")
            {
                string maNV = tag.Substring(1); 
                var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);

                if (nv != null)
                {
                    txtHoten.Text = nv.HoTen;
                    txtManv.Text = nv.MaNV;
                    txtTendn.Text = nv.TaiKhoan;
                    string quyen = nv.Quyen.Trim();
                    if (quyen == "ADMIN") listView1.Items[2].Checked = true;
                    else if (quyen == "NHANVIEN") listView1.Items[0].Checked = true;
                }
            }
        }
    }
}
