using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAO
{
    internal class AdminDAO
    {
        private static AdminDAO instance; // Ctrl + R + E

        public static AdminDAO Instance
        {
            get { if (instance == null) instance = new AdminDAO(); return AdminDAO.instance; }
            private set { AdminDAO.instance = value; }
        }

        private AdminDAO() { }

        public DataTable GetHoaList()
        {

            string query = "Select * From SanPham";


            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable GetLoaiList()
        {

            string query = "Select * From Loai";


            return DataProvider.Instance.ExecuteQuery(query);

        }

        public DataTable GetNCCList()
        {

            string query = "Select * From NhaCungCap";


            return DataProvider.Instance.ExecuteQuery(query);

        }

        public DataTable GetKhoList()
        {

            string query = "Select * From KhoHang";


            return DataProvider.Instance.ExecuteQuery(query);

        }

        public DataTable GetNVList()
        {

            string query = "Select * From NhanVien";


            return DataProvider.Instance.ExecuteQuery(query);

        }
        
    }
}
