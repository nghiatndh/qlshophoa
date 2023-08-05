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
using WinFormsApp2.DTO;

namespace WinFormsApp2
{
    public partial class fAdmin : Form
    {
        BindingSource hoaList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            dtgvHoa.DataSource = hoaList;
            LoadHoaList();
            LoadLoaiList();
            LoadNCCList();
            LoadKhoList();
            LoadNVList();
            LoadLoaiIntoComboBox(cbxMaLoai);
            LoadKhoHangIntoComboBox(cbxMaKho);
            LoadNCCIntoComboBox(cbxMaNCC);
            AddHoaBinding();
            AddLoaiBinding();
            AddKhoHangBinding();
            AddNCCBinding();
            AddNhanVienBinding();
        }

        void LoadHoaList()
        {
            hoaList.DataSource = AdminDAO.Instance.GetHoaList();

        }
        void LoadLoaiList()
        {
            dtgvLoai.DataSource = AdminDAO.Instance.GetLoaiList();
        }

        void LoadNCCList()
        {
            dtgvNCC.DataSource = AdminDAO.Instance.GetNCCList();
        }

        void LoadKhoList()
        {
            dtgvKho.DataSource = AdminDAO.Instance.GetKhoList();

        }

        void LoadNVList()
        {
            dtgvNV.DataSource = AdminDAO.Instance.GetNVList();

        }

        void AddHoaBinding()
        {
            txbMaHoa.DataBindings.Add(new Binding("Text", dtgvHoa.DataSource, "MaSP"));
            txbTenHoa.DataBindings.Add(new Binding("Text", dtgvHoa.DataSource, "TenSP"));
            nmGiaHoa.DataBindings.Add(new Binding("Value", dtgvHoa.DataSource, "Gia"));
            txbSizeHoa.DataBindings.Add(new Binding("Text", dtgvHoa.DataSource, "KichThuoc"));
            txbMoTaHoa.DataBindings.Add(new Binding("Text", dtgvHoa.DataSource, "MoTa"));
        }

        void LoadLoaiIntoComboBox(ComboBox cb)
        {
            cb.DataSource = LoaiDAO.Instance.GetListCategory();
            cb.DisplayMember = "TenLoai";
        }

        void LoadKhoHangIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoHangDAO.Instance.GetListKhoHang();
            cb.DisplayMember = "TenKho";
        }

        void LoadNCCIntoComboBox(ComboBox cb)
        {
            cb.DataSource = NCCDAO.Instance.GetListNCC();
            cb.DisplayMember = "TenNCC";
        }

        private void txbMaHoa_TextChanged(object sender, EventArgs e)
        {
            if (dtgvHoa.SelectedCells.Count > 0)
            {
                //Load Loai
                string idLoai = (string)dtgvHoa.SelectedCells[0].OwningRow.Cells["MaLoai"].Value;
                Loai cateogory = LoaiDAO.Instance.GetCategoryByID(idLoai);
                cbxMaLoai.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Loai item in cbxMaLoai.Items)
                {
                    if (item.MaLoai == cateogory.MaLoai)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbxMaLoai.SelectedIndex = index;


                //Load Kho
                string idKho = (string)dtgvHoa.SelectedCells[0].OwningRow.Cells["MaKho"].Value;
                KhoHang kho = KhoHangDAO.Instance.GetKhoHangByID(idKho);
                cbxMaKho.SelectedItem = kho;

                int indexKho = -1;
                int j = 0;
                foreach (KhoHang item in cbxMaKho.Items)
                {
                    if (item.MaKho == kho.MaKho)
                    {
                        indexKho = j;
                        break;
                    }
                    j++;
                }

                cbxMaKho.SelectedIndex = indexKho;

                //Load NCC
                string idNCC = (string)dtgvHoa.SelectedCells[0].OwningRow.Cells["MaNCC"].Value;
                NCC ncc = NCCDAO.Instance.GetNCCByID(idNCC);
                cbxMaNCC.SelectedItem = ncc;

                int indexNCC = -1;
                int k = 0;
                foreach (NCC item in cbxMaNCC.Items)
                {
                    if (item.MaNCC == ncc.MaNCC)
                    {
                        indexNCC = k;
                        break;
                    }
                    k++;
                }

                cbxMaNCC.SelectedIndex = indexNCC;


            }
        }
        void AddLoaiBinding()
        {
            txbMaLoai.DataBindings.Add(new Binding("Text", dtgvLoai.DataSource, "MaLoai"));
            txbTenLoai.DataBindings.Add(new Binding("Text", dtgvLoai.DataSource, "TenLoai"));
            txbMoTa.DataBindings.Add(new Binding("Text", dtgvLoai.DataSource, "MoTa"));
        }
        void AddKhoHangBinding()
        {
            txbMaKho.DataBindings.Add(new Binding("Text", dtgvKho.DataSource, "MaKho"));
            txbTenKho.DataBindings.Add(new Binding("Text", dtgvKho.DataSource, "TenKho"));
        }
        void AddNCCBinding()
        {
            txbMaNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "MaNCC"));
            txbTenNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "TenNCC"));
            txbDiaChiNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "DiaChi"));
            txbSDTNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "SDT"));
        }
        void AddNhanVienBinding()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "MaNV"));
            txbTenNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "TenNV"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Email"));
            txbSDTNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "SDT"));
            txbChucVu.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "ChucVu"));
            nmLuongNV.DataBindings.Add(new Binding("Value", dtgvNV.DataSource, "Luong"));
            txbDiaChiNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DiaChi"));
        }

        private void btnXemHoa_Click(object sender, EventArgs e)
        {
            LoadHoaList();
        }

        private void btnXemLoai_Click(object sender, EventArgs e)
        {
            LoadLoaiList();
        }

        private void btnXemNCC_Click(object sender, EventArgs e)
        {
            LoadNCCList();
        }

        private void btnXemKho_Click(object sender, EventArgs e)
        {
            LoadKhoList();
        }

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            LoadNVList();
        }

        private void btnThemHoa_Click(object sender, EventArgs e)
        {
            fAddSP f = new fAddSP();
            f.Show();
        }

        private void btnXoaHoa_Click(object sender, EventArgs e)
        {
            fDelSP f = new fDelSP();
            f.Show();
        }
    }
}
