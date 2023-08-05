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

            LoadSanPhamList();
            dgvIDK.DataSource = LoadIDK();
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

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.Show();
        }

        void LoadSanPhamList()
        {
            string query = "select MaSP, TenSP, Gia, SoLuong from SanPham";

            dgvSP.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        DataTable LoadIDK()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ThanhTien", typeof(float));

            return dt;

        }



        private void dgvSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;



            DataTable dt = (DataTable)dgvIDK.DataSource;
            DataRow drToAdd = dt.NewRow();

            DataGridViewRow dtSP = dgvSP.Rows[index];

            //dtHD.Cells[0].Value = dtSP.Cells["MaSP"].Value;//maSP
            //dtHD.Cells[1].Value = dtSP.Cells["TenSP"].Value;//tenSP

            drToAdd["MaSP"] = dtSP.Cells[0].Value;//maSP
            drToAdd["TenSP"] = dtSP.Cells[1].Value;//tenSP
                                                   //dtHD.Cells[2].Value = dtSP.Cells[0].Value;

            drToAdd["SoLuong"] = 1;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    drToAdd["ThanhTien"] = item["SoLuong"];
                }
            }
            else
            {
                drToAdd["ThanhTien"] = Convert.ToSingle(dtSP.Cells["Gia"].Value);
            }

            dt.Rows.Add(drToAdd);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int index = dgvIDK.CurrentCell.RowIndex;
            dgvIDK.Rows.RemoveAt(index);
        }
    }
}
