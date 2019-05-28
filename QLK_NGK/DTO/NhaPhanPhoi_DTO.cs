using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class NhaPhanPhoi_DTO
    {
        private string maNPP;
        private string tenNPP;
        private string sDT;
        private string loaiNPP;
        private string diaChi;

        public string MaNPP { get => maNPP; set => maNPP = value; }
        public string TenNPP { get => tenNPP; set => tenNPP = value; }
        public string LoaiNPP { get => loaiNPP; set => loaiNPP = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }

        public NhaPhanPhoi_DTO(string maNPP, string tenNPP, string sDT, string loaiNPP, string diaChi)
        {
            this.maNPP = maNPP;
            this.tenNPP = tenNPP;
            this.sDT = sDT;
            this.loaiNPP = loaiNPP;
            this.diaChi = diaChi;

        }
        public NhaPhanPhoi_DTO(DataRow row)
        {
            this.maNPP = row["MaNhaPhanPhoi"].ToString();
            this.tenNPP = row["TenNhaPhanPhoi"].ToString();
            this.loaiNPP = row["LoaiNhaPhanPhoi"].ToString();
            this.SDT = row["SoDienThoai"].ToString();
            this.diaChi = row["DiaChi"].ToString();
        }
    }
}
