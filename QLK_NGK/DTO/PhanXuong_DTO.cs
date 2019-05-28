using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class PhanXuong_DTO
    {
        private string maPX;
        private string tenPX;
        private string sDT;
        private string eMail;

        public string MaPX { get => maPX; set => maPX = value; }
        public string TenPX { get => tenPX; set => tenPX = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string SDT { get => sDT; set => sDT = value; }

        public PhanXuong_DTO(string maPX, string tenPX, string sDT, string eMail)
        {
            this.maPX = maPX;
            this.tenPX = tenPX;
            this.sDT = sDT;
            this.eMail = eMail;

        }
        public PhanXuong_DTO(DataRow row)
        {
            this.maPX = row["MaPhanXuong"].ToString();
            this.tenPX = row["TenPhanXuong"].ToString();
            this.sDT = row["SoDienThoai"].ToString();
            this.eMail = row["Email"].ToString();
        }
    }
}
