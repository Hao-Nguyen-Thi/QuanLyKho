using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class HangHoa_DTO
    {
        private string maHH;
        private string tenHH;
        private string maLHH;
        private string quyCach;
        private string maLo;
        private string maKho;
        private int dungTich;
        private int soLuongTon;


        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public string MaLHH { get => maLHH; set => maLHH = value; }
        public string QuyCach { get => quyCach; set => quyCach = value; }
        public string MaLo { get => maLo; set => maLo = value; }
        public string MaKho { get => maKho; set => maKho = value; }
        public int DungTich { get => dungTich; set => dungTich = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }

        public HangHoa_DTO(string maHH, string tenHH, string maLHH, string quyCach, string maLo, string maKho, int dungTich, int soLuongTon)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.soLuongTon = soLuongTon;
            this.maLHH = maLHH;
            this.dungTich = dungTich;
            this.maLo = maLo;
            this.maKho = maKho;
            this.quyCach = quyCach;
        }

        public HangHoa_DTO(DataRow row)
        {
            this.maHH = row["MaHangHoa"].ToString();
            this.tenHH = row["TenHangHoa"].ToString();
            this.maLHH = row["MaLoaiHangHoa"].ToString();
            this.quyCach = row["QuyCach"].ToString();
            this.maLo = row["MaLo"].ToString();
            this.maKho = row["MaKho"].ToString();
            Int32.TryParse(row["SoLuongTon"].ToString(), out this.soLuongTon);
            Int32.TryParse(row["DungTich"].ToString(), out this.dungTich);
        }
    }
}
