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

namespace WinFormsApp2
{
    public partial class fDelSP : Form
    {
        public fDelSP()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbMaHoa.Text;
            if(SanPhamDAO.Instance.DeleteSanPhamByID(id))
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
