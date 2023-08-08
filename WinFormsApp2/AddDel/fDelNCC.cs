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
    public partial class fDelNCC : Form
    {
        public fDelNCC()
        {
            InitializeComponent();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbMaNCC.Text;
            if (NCCDAO.Instance.DeleteNCCByID(id))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công! ");
            }
            else
            {
                MessageBox.Show("Không tồn tại nhà cung cấp  này");
            }
        }
    }
}
