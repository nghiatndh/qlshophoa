using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DTO
{
    public class Loai
    {
        public Loai(string maLoai, string tenLoai, string moTa)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
            this.MoTa = moTa;
        }

        public Loai(DataRow row)
        {
            this.MaLoai = row["MaLoai"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
            this.MoTa = row["MoTa"].ToString();
        }


        private string maLoai;
        private string tenLoai;
        private string moTa;

        public string MaLoai 
        {
            get { return maLoai; }
            set { maLoai = value; } 
        }
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
    }
}
