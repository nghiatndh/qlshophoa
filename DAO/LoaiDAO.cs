using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.DTO;

namespace WinFormsApp2.DAO
{
    internal class LoaiDAO
    {
        private static LoaiDAO instance;

        public static LoaiDAO Instance
        {
            get { if (instance == null) instance = new LoaiDAO(); return LoaiDAO.instance; }
            private set { LoaiDAO.instance = value; }
        }

        private LoaiDAO() { }

        public List<Loai> GetListCategory()
        {
            List<Loai> list = new List<Loai>();

            string query = "select * from Loai";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Loai category = new Loai(item);
                list.Add(category);
            }

            return list;
        }

        public Loai GetCategoryByID(string id)
        {
            Loai category = null;

            string query = "select * from Loai where MaLoai = '" + id +"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Loai(item);
                return category;
            }

            return category;
        }

    }
}
