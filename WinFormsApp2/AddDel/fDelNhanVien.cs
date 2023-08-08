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
    public partial class fDelNhanVien : Form
    {
        public fDelNhanVien()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbMaNV.Text;
            if (NhanVienDAO.Instance.DeleteNhanVienByID(id))
            {
                MessageBox.Show("Xóa nhân viên thành công! ");
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên này");
            }
        }
    }
}
