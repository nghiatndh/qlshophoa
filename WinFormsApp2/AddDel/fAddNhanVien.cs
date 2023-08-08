using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DAO;

namespace WinFormsApp2.AddDel
{
    public partial class fAddNhanVien : Form
    {
        public fAddNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            string id = txbMaNV.Text;
            string name = txbTenNV.Text;
            string email = txbEmail.Text;
            string sdtnv = txbSDTNV.Text;
            string chucvu = txbChucVu.Text;
            float luong = (float)nmLuongNV.Value;
            string diachinv = txbDiaChiNV.Text;

            if (NhanVienDAO.Instance.InsertNhanVien(id, name, email, sdtnv, chucvu, luong, diachinv))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên mới");
            }
        }
    }
}
