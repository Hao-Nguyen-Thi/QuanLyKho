/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class KiemTraHangHoa_DAO
    {
        private static KiemTraHangHoa_DAO instance;

        internal static KiemTraHangHoa_DAO Instance


        {
            get { if (instance == null) instance = new KiemTraHangHoa_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<KiemTraHangHoa_DTO> GetKTHH(string maHH)
        {
            List<KiemTraHangHoa_DTO> list = new List<BangDiem_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_DIEMTB_LOP @malop ", new object[] { maLop });
            foreach (DataRow item in data.Rows)
            {
                BangDiem_DTO Lop = new BangDiem_DTO(item);
                list.Add(Lop);
            }
            return list;
        }

        public bool InsertBangDiem(string masv, string hoten, string ngaysinh, int DiemTB, int TongTC, int TongTCNo, string TenChuyenNganh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertBangDiem @masv ,  @ngaysinh , @diemtb , @tongtc ,@tongtcno,@tenchuyennganh", new object[] { masv, hoten, ngaysinh, DiemTB, TongTC, TongTCNo, TenChuyenNganh });

            return result > 0;
        }
        public bool UpdateBangDiem(string masv, string hoten, string ngaysinh, int DiemTB, int TongTC, int TongTCNo, string TenChuyenNganh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateBangDiem @masv ,  @ngaysinh , @diemtb , @tongtc ,@tongtcno,@tenchuyennganh ", new object[] { masv, hoten, ngaysinh, DiemTB, TongTC, TongTCNo, TenChuyenNganh });

            return result > 0;
        }
        public bool DeleteLop(string masv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteLop @masv", new object[] { masv });

            return result > 0;
        }
        public List<BangDiem_DTO> SearchLop(string str)
        {
            List<BangDiem_DTO> Loplist = new List<BangDiem_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchBangDiem @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                BangDiem_DTO BangDiem = new BangDiem_DTO(item);
                Loplist.Add(BangDiem);
            }
            return Loplist;
        }

    }
}
*/