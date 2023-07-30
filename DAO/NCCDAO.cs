using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
    }
}
