using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class Lo_DTO
    {
        private string maLo;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private int soLuong;

        public string MaLo { get => maLo; set => maLo = value; }
        public DateTime Ngaysanxuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime Hansudung { get => hanSuDung; set => hanSuDung = value; }
        public int Soluong { get => soLuong; set => soLuong = value; }

        public Lo_DTO(string maLo, DateTime ngaySanXuat, DateTime hanSuDung, int soLuong)
        {
            this.maLo = maLo;
            this.ngaySanXuat = ngaySanXuat;
            this.hanSuDung = hanSuDung;
            this.soLuong = soLuong;
        }
        public Lo_DTO(DataRow row)
        {
            this.maLo = row["MaLo"].ToString();
            this.ngaySanXuat = (DateTime)row["NgaySanXuat"];
            this.hanSuDung = (DateTime)row["HanSuDung"];
            Int32.TryParse(row["SoLuong"].ToString(), out this.soLuong);

        }
    }
}
