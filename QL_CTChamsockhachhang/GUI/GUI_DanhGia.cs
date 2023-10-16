using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DanhGia : Form
    {
        CollectionKhachHang dal = new CollectionKhachHang();
        string makh;
        public GUI_DanhGia(string makh)
        {
            InitializeComponent();
            this.makh = makh;
            init();          
        }
        void init()
        {
            loadCombobox();
            loadDVG();
            Console.WriteLine("klsdf"+makh);
        }
        void loadCombobox()
        {
            cbLoaiDanhGia.Items.AddRange(new object[] { "All", "Tốt", "Không tốt" });        
        }
        void loadDVG()
        {
            dgvDanhGia.DataSource = dal.GetDanhGias(makh);
        }

        private void cbLoaiDanhGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDanhGia.DataSource = dal.GetDanhGiasbyType(cbLoaiDanhGia.Text,makh);
        }

        private void dgvDanhGia_SelectionChanged(object sender, EventArgs e)
        {
            txtMSP.Text = dgvDanhGia.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvDanhGia.CurrentRow.Cells[1].Value.ToString();
            if (dgvDanhGia.CurrentRow.Cells[2].Value.ToString() == "Tốt")
            {
                rsbTot.Checked = true;
            }
            else
            {
                rdbKhongTot.Checked = true;
            }
            txtNoiDung.Text = dgvDanhGia.CurrentRow.Cells[3].Value.ToString();
            if (dgvDanhGia.CurrentRow.Cells[4].Value.ToString()== "Đã phản hồi")
            {
                rBResponded.Checked = true;
            }
            else
            {
                rBNoresponse.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia();
            dg.masp = txtMSP.Text;
            dg.tensp = txtTenSP.Text;
            dg.danhgiasp = txtNoiDung.Text;
            if (rdbKhongTot.Checked)
            {
                dg.loaidg = "Không tốt";
            }
            else
            {
                dg.loaidg = "Tốt";
            }
            if (rBResponded.Checked)
            {
                dg.tt = "Đã phản hồi";
            }
            else
            {
                dg.tt = "Chưa phản hồi";
            }
            if (dal.AddDanhgia(dg,makh) == true)
            {
                MessageBox.Show("Thêm đánh giá thành công");
                loadDVG();
            }
            else
            {
                MessageBox.Show("Thêm đánh giá thất bại");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia();
            dg.masp = txtMSP.Text;
            dg.tensp = txtTenSP.Text;
            dg.danhgiasp = txtNoiDung.Text;
            if (rdbKhongTot.Checked)
            {
                dg.loaidg = "Không tốt";
            }
            else
            {
                dg.loaidg = "Tốt";
            }
            if (rBResponded.Checked)
            {
                dg.tt = "Đã phản hồi";
            }
            else
            {
                dg.tt = "Chưa phản hồi";
            }
            if (dal.delDanhgia(dg, makh) == true)
            {
                MessageBox.Show("Xoá đánh giá thành công");
                loadDVG();
            }
            else
            {
                MessageBox.Show("Xoá đánh giá thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia();
            dg.masp = txtMSP.Text;
            dg.tensp = txtTenSP.Text;
            dg.danhgiasp = txtNoiDung.Text;
            if (rdbKhongTot.Checked)
            {
                dg.loaidg = "Không tốt";
            }
            else
            {
                dg.loaidg = "Tốt";
            }
            if (rBResponded.Checked)
            {
                dg.tt = "Đã phản hồi";
            }
            else
            {
                dg.tt = "Chưa phản hồi";
            }
            if (dal.editDanhgia(dg, makh) == true)
            {
                MessageBox.Show("Sửa đánh giá thành công");
                loadDVG();
            }
            else
            {
                MessageBox.Show("Sửa đánh giá thất bại");
            }
        }
    }
}
