using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.DAO;
using WinFormsApp2.DTO;

namespace WinFormsApp2.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "Select * From TaiKhoan Where ID = N'" + userName + "' AND MatKhau = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public Account GetAccountByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from TAIKHOAN where ID = '" + id + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
    }
}