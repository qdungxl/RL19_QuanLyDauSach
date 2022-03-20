using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            radNXB.Checked = true;
        }

        private void radLoaiSach_CheckedChanged(object sender, EventArgs e)
        {
            HienThiTreeView();
            XoaChiTietSach();
            lvSach.Items.Clear();
        }

        private void HienThiTreeView()
        {
            if (radLoaiSach.Checked)
            {
                HienThiTheoLoaiSach();
            }
            else if (radNXB.Checked)
            {
                HienThiTheoNhaXuatBan();
            }
        }

        private void HienThiTheoNhaXuatBan()
        {
            NHAXUATBANBLL NXBBLL = new NHAXUATBANBLL();
            SACHBLL sachBll = new SACHBLL();
            tvXemTheo.Nodes.Clear();
            foreach(NHAXUATBAN nxb in NXBBLL.LayToanBoNhaXuatBan())
            {
                TreeNode nodeNXB = new TreeNode(nxb.Ten);
                nodeNXB.Tag = nxb;
                tvXemTheo.Nodes.Add(nodeNXB);
                foreach (SACH sach in sachBll.LaySachTheoNhaXuatBan(nxb))
                {
                    TreeNode nodeSach = new TreeNode(sach.TenSach);
                    nodeSach.Tag = sach;
                    nodeNXB.Nodes.Add(nodeSach);
                }
            }
            tvXemTheo.ExpandAll();
        }

        private void HienThiTheoLoaiSach()
        {
            LOAISACHBLL loaiSachBll = new LOAISACHBLL();
            SACHBLL sachBll = new SACHBLL();
            tvXemTheo.Nodes.Clear();
            foreach(LOAISACH ls in loaiSachBll.LayToanBoLoaiSach())
            {
                TreeNode nodels = new TreeNode(ls.TenLoai);
                nodels.Tag = ls;
                tvXemTheo.Nodes.Add(nodels);
                foreach(SACH sach in sachBll.LaySachTheoLoaiSach(ls))
                {
                    TreeNode nodesach = new TreeNode(sach.TenSach);
                    nodesach.Tag = sach;
                    nodels.Nodes.Add(nodesach);
                }
            }
            tvXemTheo.ExpandAll();
        }

        private void radNXB_CheckedChanged(object sender, EventArgs e)
        {
            HienThiTreeView();
            XoaChiTietSach();
            lvSach.Items.Clear();
        }

        private void tvXemTheo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (radLoaiSach.Checked)
            {
                LOAISACH ls = new LOAISACH();
                if (e.Node.Level == 0)
                {
                    ls = e.Node.Tag as LOAISACH;
                }
                else
                {
                    SACH sach = e.Node.Tag as SACH;
                    ls = sach.Loai;
                }
                HienThiLVTheoLoaiSach(ls);
            }    
            else
            {
                NHAXUATBAN nxb = new NHAXUATBAN();
                if (e.Node.Level == 0)
                {
                    nxb = e.Node.Tag as NHAXUATBAN;
                }
                else
                {
                    SACH sach = e.Node.Tag as SACH;
                    nxb = sach.NhaXuatBan;
                }
                HienThiLVTheoNhaXuatBan(nxb);
            }
        }

        private void HienThiLVTheoNhaXuatBan(NHAXUATBAN Nxb)
        {
            lvSach.Items.Clear();
            SACHBLL sachBll = new SACHBLL();
            foreach(SACH sach in sachBll.LaySachTheoNhaXuatBan(Nxb))
            {
                ListViewItem lvi = new ListViewItem(sach.MaSach);
                lvi.SubItems.Add(sach.TenSach);
                lvi.SubItems.Add(sach.DonGia+"");
                lvi.Tag = sach;
                lvSach.Items.Add(lvi);
            }
        }

        private void HienThiLVTheoLoaiSach(LOAISACH Ls)
        {
            lvSach.Items.Clear();
            SACHBLL sachBll = new SACHBLL();
            foreach (SACH sach in sachBll.LaySachTheoLoaiSach(Ls))
            {
                ListViewItem lvi = new ListViewItem(sach.MaSach);
                lvi.SubItems.Add(sach.TenSach);
                lvi.SubItems.Add(sach.DonGia + "");
                lvi.Tag = sach;
                lvSach.Items.Add(lvi);
            }
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count == 0)
                return;
            SACH sach = lvSach.SelectedItems[0].Tag as SACH;
            HienThiChiTietSach(sach);
        }

        private void HienThiChiTietSach(SACH sach)
        {
            XoaChiTietSach();
            txtMa.Text = sach.MaSach;
            txtTenSach.Text = sach.TenSach;
            txtDonGia.Text = sach.DonGia + "";
            if(sach.Loai.TenLoai==""|| sach.Loai.TenLoai == null)
            {
                sach.Loai = new LOAISACHBLL().TimLoaiSachTheoMa(sach.Loai.MaLoai);
                txtLoaiSach.Text = sach.Loai.TenLoai;
            }
            else
            {
                txtLoaiSach.Text = sach.Loai.TenLoai;
            }
            if (sach.NhaXuatBan.Ten == "" || sach.NhaXuatBan.Ten == null)
            {
                sach.NhaXuatBan = new NHAXUATBANBLL().TimNXBTheoMa(sach.NhaXuatBan.MaNXB);
                txtNXB.Text = sach.NhaXuatBan.Ten;
            }
            else
            {
                txtNXB.Text = sach.NhaXuatBan.Ten;
            }           
        }

        private void XoaChiTietSach()
        {
            txtMa.Text = "";
            txtTenSach.Text = "";
            txtDonGia.Text = "";
            txtLoaiSach.Text = "";
            txtNXB.Text = "";
        }
    }
}
