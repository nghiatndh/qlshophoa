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
    public partial class fAddSP : Form
    {
        public fAddSP()
        {
            InitializeComponent();
            LoadLoaiIntoComboBox(cbxMaLoai);
            LoadKhoHangIntoComboBox(cbxMaKho);
            LoadNCCIntoComboBox(cbxMaNCC);
        }
        void LoadLoaiIntoComboBox(ComboBox cb)
        {
            cb.DataSource = LoaiDAO.Instance.GetListCategory();
            cb.DisplayMember = "MaLoai";
        }

        void LoadKhoHangIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoHangDAO.Instance.GetListKhoHang();
            cb.DisplayMember = "MaKho";
        }

        void LoadNCCIntoComboBox(ComboBox cb)
        {
            cb.DataSource = NCCDAO.Instance.GetListNCC();
            cb.DisplayMember = "MaNCC";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbMaHoa.Text;
            string name = txbTenHoa.Text;
            float gia = (float)nmGiaHoa.Value;
            int sl = (int)nmSLHoa.Value;
            string size = txbSizeHoa.Text;
            string mota = txbMoTaHoa.Text;
            string maloai = cbxMaLoai.Text;
            string makho = cbxMaKho.Text;
            string mancc = cbxMaNCC.Text;
            if(SanPhamDAO.Instance.InsertSanPham(id,name, gia, sl, size, mota, maloai, makho, mancc))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm");
            }
        }
    }
}
