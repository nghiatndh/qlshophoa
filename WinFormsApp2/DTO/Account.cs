using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DTO
{
    public class Account
    {
        public Account()
        {
            this.ID = id;
            this.MatKhau = matKhau;
            this.EMail = eMail;
            this.MaNV = maNV;
        }

        public Account(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.MatKhau = row["matKhau"].ToString();
            this.EMail = row["eMail"].ToString();
            this.MaNV = row["maNV"].ToString();
        }

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    }
}
