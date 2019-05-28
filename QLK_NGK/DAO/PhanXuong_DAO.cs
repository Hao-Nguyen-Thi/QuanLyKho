using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class PhanXuong_DAO
    {
        private static PhanXuong_DAO instance;

        internal static PhanXuong_DAO Instance
        {
            get { if (instance == null) instance = new PhanXuong_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<PhanXuong_DTO> GetDSPX()
        {
            List<PhanXuong_DTO> list = new List<PhanXuong_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallPX");
            foreach (DataRow item in data.Rows)
            {
                PhanXuong_DTO PX = new PhanXuong_DTO(item);
                list.Add(PX);
            }
            return list;
        }

        public bool InsertPX(string ma, string ten, string sdt, string email)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertPX @ma ,  @ten , @sdt , @email ", new object[] { ma, ten, sdt, email });

            return result > 0;
        }
        public bool UpdatePX(string ma, string ten, string sdt, string email)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdatePX @ma , @ten , @sdt , @email ", new object[] { ma, ten, sdt, email });

            return result > 0;
        }
        public bool DeletePX(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeletePX @ma ", new object[] { ma });

            return result > 0;
        }
        public List<PhanXuong_DTO> SearchPX(string str)
        {
            List<PhanXuong_DTO> PXlist = new List<PhanXuong_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchPX @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                PhanXuong_DTO PX = new PhanXuong_DTO(item);
                PXlist.Add(PX);
            }
            return PXlist;
        }
    }
}
