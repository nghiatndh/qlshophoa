using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DAO;

namespace WinFormsApp2.AddDel
{
    public partial class fAddLoai : Form
    {
        public fAddLoai()
        {
            InitializeComponent();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string id = txbMaLoai.Text;
            string name = txbTenLoai.Text;
            string mota = txbMoTa.Text;

            if (LoaiDAO.Instance.InsertLoai(id, name, mota))
            {
                MessageBox.Show("Thêm loại mới thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm loại mới");
            }
        }
    }
}
