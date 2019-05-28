using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;


namespace QLK_NGK.DAO
{
    class LoaiHangHoa_DAO
    {
        private static LoaiHangHoa_DAO instance;

        internal static LoaiHangHoa_DAO Instance
        {
            get { if (instance == null) instance = new LoaiHangHoa_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<LoaiHangHoa_DTO> GetDSLHH()
        {
            List<LoaiHangHoa_DTO> list = new List<LoaiHangHoa_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallLHH");
            foreach (DataRow item in data.Rows)
            {
                LoaiHangHoa_DTO LHH = new LoaiHangHoa_DTO(item);
                list.Add(LHH);
            }
            return list;
        }

        public bool InsertLHH(string ma, string ten)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertLHH @ma ,  @ten ", new object[] { ma, ten });

            return result > 0;
        }
        public bool UpdateLHH(string ma, string ten)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateLHH @ma , @ten ", new object[] { ma, ten });

            return result > 0;
        }
        public bool DeleteLHH(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteLHH @ma ", new object[] { ma });

            return result > 0;
        }
        public List<LoaiHangHoa_DTO> SearchLHH(string str)
        {
            List<LoaiHangHoa_DTO> LHHlist = new List<LoaiHangHoa_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchLHH @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                LoaiHangHoa_DTO LHH = new LoaiHangHoa_DTO(item);
                LHHlist.Add(LHH);
            }
            return LHHlist;
        }
    }
}
