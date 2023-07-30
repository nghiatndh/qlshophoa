using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
    }
}
