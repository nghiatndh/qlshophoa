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
    public partial class fAddNCC : Form
    {
        public fAddNCC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbMaNCC.Text;
            string name = txbTenNCC.Text;
            string diachi = txbDiaChiNCC.Text;
            string sdt = txbSDTNCC.Text;
            if (NCCDAO.Instance.InsertNCC(id, name,diachi, sdt))
            {
                MessageBox.Show("Thêm nhà cung cấp mới thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhà cugn cấp");
            }
        }
    }

}
