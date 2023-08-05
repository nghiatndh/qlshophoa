using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DAO;


namespace WinFormsApp2
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        void LoadCustomerList()
        { 
            dtgvKH.DataSource = CustomerDAO.Instance.GetCustomerList();

        }

    }
}
