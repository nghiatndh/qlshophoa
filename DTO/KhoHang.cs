using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DTO
{
    public class KhoHang
    {
        public KhoHang(string maKho, string tenKho)
        {
            this.MaKho = maKho;
            this.TenKho = tenKho;
        }

        public KhoHang(DataRow row)
        {
            this.MaKho = row["MaKho"].ToString();
            this.TenKho = row["TenKho"].ToString();
        }


        private string maKho;
        private string tenKho;

        public string MaKho
        {
            get { return maKho; }
            set { maKho = value; }
        }
        public string TenKho
        {
            get { return tenKho; }
            set { tenKho = value; }
        }
    }
}
