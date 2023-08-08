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
    public partial class fAddKho : Form
    {
        public fAddKho()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbMaKho.Text;
            string name = txbTenKho.Text;

            if (KhoHangDAO.Instance.InsertKhoHang(id, name))
            {
                MessageBox.Show("Thêm kho thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm kho mới");
            }
        }
    }
}
