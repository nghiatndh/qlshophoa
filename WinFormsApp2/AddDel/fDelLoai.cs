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
    public partial class fDelLoai : Form
    {
        public fDelLoai()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbMaLoai.Text;
            if (LoaiDAO.Instance.DeleteLoaiByID(id))
            {
                MessageBox.Show("Xóa sản phẩm thành công! ");
            }
            else
            {
                MessageBox.Show("Không tồn tại sản phẩm này");
            }
        }
    }
}
