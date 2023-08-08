using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinFormsApp2.DAO;
using WinFormsApp2.DTO;

namespace WinFormsApp2
{
    public partial class fMenu : Form
    {
        private int i = 0;
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.ID); }
        }
        public fMenu(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            dgvSP.DataSource = LoadSanPhamList();
            dgvIDK.DataSource = LoadHoaDon();
        }



        void ChangeAccount(string id)
        {
            adminToolStripMenuItem.Enabled = id == "admin";
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.Show();
        }


        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.Show();
        }

        DataTable LoadSanPhamList()
        {
            string query = "select MaSP, TenSP, Gia, SoLuong from SanPham";

            return DataProvider.Instance.ExecuteQuery(query);
        }



        private void dgvSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string query;

            dgvIDK.DataSource = LoadHoaDon();
            DataGridViewRow row = dgvSP.Rows[index];
            DataGridViewRow rowIDK = dgvIDK.Rows[0];
            bool flag = false;
            foreach (DataGridViewRow data in dgvIDK.Rows)
            {
                if (data.Cells[0].Value == row.Cells[0].Value)
                {
                    flag = true; break;
                }
 
            }
            if (flag)
            {
                query = "EXEC dbo.Update_SLSanPham 'SP04'"/*rowIDK.Cells[0].Value*/;
            }
            else
            {
                query = string.Format("INSERT INTO HOADON(MaSP, SoLuong) VALUES('{0}', 1)", row.Cells[0].Value);
            }
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadHoaDon();

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string index = dgvIDK.CurrentCell.Value.ToString();

            string query = "DELETE HOADON WHERE MaSP ='" + index + "'";

            if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
            {
                MessageBox.Show("Xóa đơn thành công!");
                LoadHoaDon();
            }
            
        }

        DataTable LoadHoaDon()
        {
            string query = "SELECT HD.MaSP, SP.TenSP, Sp.Gia, HD.SoLuong , HD.ThanhTien FROM HOADON HD, SANPHAM SP WHERE HD.MASP = SP.MASP";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dgvSP.DataSource = LoadSanPhamList();
            dgvIDK.DataSource = LoadHoaDon();

        }
    }
}
