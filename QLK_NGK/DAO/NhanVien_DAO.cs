using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class NhanVien_DAO
    {
        private static NhanVien_DAO instance;

        internal static NhanVien_DAO Instance
        {
            get { if (instance == null) instance = new NhanVien_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVien_DTO> GetDSNV()
        {
            List<NhanVien_DTO> list = new List<NhanVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallNV");
            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO NV = new NhanVien_DTO(item);
                list.Add(NV);
            }
            return list;
        }

        public bool InsertNV(string manhanvien, string tennhanvien, int gioitinh, DateTime ngaysinh, string diachi, int sodienthoai, string email, int luong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertNV @manv , @tennv, @gt, @ns, @dc, @sdt, @email, @luong ", new object[] { manhanvien, tennhanvien, gioitinh, ngaysinh, diachi, sodienthoai, email, luong });

            return result > 0;
        }
        public bool UpdateNV(string manhanvien, string tennhanvien, int gioitinh, DateTime ngaysinh, string diachi, int sodienthoai, string email, int luong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateNV @manv , @tennv, @gt, @ns, @dc, @sdt, @email, @luong ", new object[] { manhanvien, tennhanvien, gioitinh, ngaysinh, diachi, sodienthoai, email, luong });

            return result > 0;
        }
        public bool DeleteNV(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteNV @ma ", new object[] { ma });

            return result > 0;
        }
        public List<NhanVien_DTO> SearchNV(string str)
        {
            List<NhanVien_DTO> NVlist = new List<NhanVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNV @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO NV = new NhanVien_DTO(item);
                NVlist.Add(NV);
            }
            return NVlist;
        }
    }
}
