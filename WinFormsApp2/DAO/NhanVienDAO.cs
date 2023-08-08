using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.DTO;

namespace WinFormsApp2.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        public bool InsertNhanVien(string id, string name, string email, string sdtnv, string chucvu, float luong, string diachinv)
        {
            string query = string.Format("INSERT dbo.NhanVien ( MaNV, TenNV, Email, SDT, ChucVu, Luong, DiaChi )VALUES  ( N'{0}', N'{1}', N'{2}' , N'{3}' ,N'{4}',{5}, '{6}')", id, name, email, sdtnv, chucvu, luong, diachinv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNhanVienByID(string id)
        {
            string query = string.Format("DELETE dbo.NhanVien where MaNV = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
