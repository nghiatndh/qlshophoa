using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinFormsApp2.DTO;

namespace WinFormsApp2.DAO
{
    internal class KhoHangDAO
    {
        private static KhoHangDAO instance;

        public static KhoHangDAO Instance
        {
            get { if (instance == null) instance = new KhoHangDAO(); return KhoHangDAO.instance; }
            private set { KhoHangDAO.instance = value; }
        }

        private KhoHangDAO() { }

        public List<KhoHang> GetListKhoHang()
        {
            List<KhoHang> list = new List<KhoHang>();

            string query = "select * from KhoHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhoHang category = new KhoHang(item);
                list.Add(category);
            }

            return list;
        }

        public KhoHang GetKhoHangByID(string id)
        {
            KhoHang kho = null;

            string query = "select * from KhoHang where MaKho = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                kho = new KhoHang(item);
                return kho;
            }

            return kho;
        }

        public KhoHang GetIDByKhoHang(string name)
        {
            KhoHang category = null;

            string query = "select * from KhoHang where TenKho = '" + name + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new KhoHang(item);
                return category;
            }

            return category;
        }
        public bool InsertKhoHang(string id, string name)
        {
            string query = string.Format("INSERT dbo.KhoHang ( MaKhO, TenKho )VALUES  ( N'{0}', N'{1}')", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteKhoHangByID(string id)
        {
            string query = string.Format("DELETE dbo.KhoHang where MaKhO = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
