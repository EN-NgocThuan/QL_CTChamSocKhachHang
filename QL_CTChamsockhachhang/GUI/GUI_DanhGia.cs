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
    }
}
