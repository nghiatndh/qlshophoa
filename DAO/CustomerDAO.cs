using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAO
{
    internal class CustomerDAO
    {
        private static CustomerDAO instance; // Ctrl + R + E

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }


        public DataTable GetCustomerList()
        {
            string query = "Select * From KhachHang";

            return DataProvider.Instance.ExecuteQuery(query);


        }
    }


}
