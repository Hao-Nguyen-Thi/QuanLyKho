using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class NhanVien_DTO
    {
        private string maNV;
        private string tenNV;
        private int gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;        
        private int sDT;
        private string eMail;
        private int luong;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Gioitinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime Ngaysinh { get => ngaySinh; set => ngaySinh = value; }
        public string Diachi { get => diaChi; set => diaChi = value; }
        public int Sdt { get => sDT; set => sDT = value; }
        public string Email { get => eMail; set => eMail = value; }
        public int Luong { get => luong; set => luong = value; }

        public NhanVien_DTO(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string diaChi, int sDT, string eMail, int luong)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.eMail = eMail;
            this.luong = luong;
        }
        public NhanVien_DTO(DataRow row)
        {
            this.maNV = row["MaNhanVien"].ToString();
            this.tenNV = row["TenNhanVien"].ToString();
            Int32.TryParse(row["GioiTinh"].ToString(), out this.gioiTinh);
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.diaChi = row["DiaChi"].ToString();
            Int32.TryParse(row["SoDienThoai"].ToString(), out this.sDT);
            this.eMail = row["Email"].ToString();
            Int32.TryParse(row["Luong"].ToString(), out this.luong);
        }
    }
}
