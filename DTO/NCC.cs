using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp2.DTO
{
    internal class NCC
    {
        public NCC(string maNCC, string tenNCC, string diaChi, string sdt)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;           
            this.DiaChi = diaChi;
            this.SDT = sdt;
        }

        public NCC(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString() ;
        }


        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sdt;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
