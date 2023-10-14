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
    public partial class GUI_KhachHang : Form
    {
        CollectionKhachHang dal;
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dal = new CollectionKhachHang();
            dgv_Khachhang.DataSource = dal.GetData();
        }

        private void dgv_Khachhang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMakh.Text = dgv_Khachhang.CurrentRow.Cells[0].Value.ToString();
                txtTenkh.Text = dgv_Khachhang.CurrentRow.Cells[1].Value.ToString();
                txtDiachi.Text = dgv_Khachhang.CurrentRow.Cells[2].Value.ToString();
                txtSodienthoai.Text = dgv_Khachhang.CurrentRow.Cells[3].Value.ToString();
            }
            catch {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh= txtTenkh.Text;
            kh.diachi= txtDiachi.Text;
            kh.sdt= txtSodienthoai.Text;
            if (dal.addMember(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                dgv_Khachhang.DataSource = dal.GetData();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh = txtTenkh.Text;
            kh.diachi = txtDiachi.Text;
            kh.sdt = txtSodienthoai.Text;
            if (dal.delMember(kh))
            {
                MessageBox.Show("Xoá khách hàng thành công");
                dgv_Khachhang.DataSource = dal.GetData();
            }
            else
            {
                MessageBox.Show("Xoá khách hàng thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh = txtTenkh.Text;
            kh.diachi = txtDiachi.Text;
            kh.sdt = txtSodienthoai.Text;
            if (dal.editMember(kh))
            {
                MessageBox.Show("Xoá khách hàng thành công");
                dgv_Khachhang.DataSource = dal.GetData();
            }
            else
            {
                MessageBox.Show("Xoá khách hàng thất bại");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text.Length > 0)
            {
                if(dal.Findmember(txtFind.Text)!=null)
                {
                    KhachHang kh = dal.Findmember(txtFind.Text);
                    txtMakh.Text = kh.makh;
                    txtTenkh.Text = kh.tenkh;   
                    txtDiachi.Text = kh.diachi;
                    txtSodienthoai.Text = kh.sdt;
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu");
            }
        }
    }
}
