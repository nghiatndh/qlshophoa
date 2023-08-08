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
    internal class NCCDAO
    {
        private static NCCDAO instance;

        public static NCCDAO Instance
        {
            get { if (instance == null) instance = new NCCDAO(); return NCCDAO.instance; }
            private set { NCCDAO.instance = value; }
        }

        private NCCDAO() { }

        public List<NCC> GetListNCC()
        {
            List<NCC> list = new List<NCC>();

            string query = "select * from NhaCungCap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NCC category = new NCC(item);
                list.Add(category);
            }

            return list;
        }

        public NCC GetNCCByID(string id)
        {
            NCC ncc = null;

            string query = "select * from NhaCungCap where MaNCC = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ncc = new NCC(item);
                return ncc;
            }

            return ncc;
        }

        public NCC GetIDByNCC(string name)
        {
            NCC category = null;

            string query = "select * from NhaCungCap where TenNCC = '" + name + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new NCC(item);
                return category;
            }

            return category;
        }
        public bool InsertNCC(string id, string name, string diachi, string sdt)
        {
            string query = string.Format("INSERT dbo.SanPham ( MaNCC, TenNCC, DiaChi, SDT )VALUES  ( N'{0}', N'{1}', N{2}, N{3})", id, name, diachi, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNCCByID(string id)
        {
            string query = string.Format("DELETE dbo.NhaCungCap where MaNCC = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
