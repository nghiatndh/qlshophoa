using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAO
{
    internal class SanPhamDAO
    {
        private static SanPhamDAO instance; // Ctrl + R + E

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            private set { SanPhamDAO.instance = value; }
        }

        private SanPhamDAO() { }

        public bool InsertSanPham(string id, string name, float price,  int sl, string size, string mota, string maloai, string makho, string mancc )
        {
            string query = string.Format("INSERT dbo.SanPham ( MaSP, TenSP, Gia, SoLuong, KichThuoc, MoTa, MaLoai, MaKho, MaNCC )VALUES  ( N'{0}', N'{1}', {2},{3},N'{4}',N'{5}', '{6}', '{7}','{8}')", id,name,price,sl,size,mota,maloai,makho,mancc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSanPhamByID(string id)
        {
            string query = string.Format("DELETE dbo.SanPham where MaSP = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
