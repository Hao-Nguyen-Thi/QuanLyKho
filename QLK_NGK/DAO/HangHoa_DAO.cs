using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class HangHoa_DAO
    {
        private static HangHoa_DAO instance;

        internal static HangHoa_DAO Instance
        {
            get { if (instance == null) instance = new HangHoa_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<HangHoa_DTO> GetDSHH()
        {
            List<HangHoa_DTO> list = new List<HangHoa_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallHangHoa");
            foreach (DataRow item in data.Rows)
            {
                HangHoa_DTO HH = new HangHoa_DTO(item);
                list.Add(HH);
            }
            return list;
        }

        public bool InsertHH(string mahh, string tenhh, string malhh, string quycach, string malo, string makho, int soluongton, int dungtich)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertHangHoa @mahh ,  @tenhh , @malhh , @quycach , @malo , @makho , @soluongton, @dungtich ", new object[] { mahh, tenhh, malhh, quycach, malo, makho, soluongton, dungtich });

            return result > 0;
        }
        public bool UpdateHH(string mahh, string tenhh, string malhh, string quycach, string malo, string makho, int soluongton, int dungtich)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateHangHoa @mahh ,  @tenhh , @malhh , @quycach , @malo , @makho , @soluongton, @dungtich ", new object[] { mahh, tenhh, malhh, quycach, malo, makho, soluongton, dungtich });

            return result > 0;
            
        }
        public bool DeleteHH(string mahh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteHangHoa @mahh ", new object[] { mahh });

            return result > 0;
        }
        public List<HangHoa_DTO> SearchHH(string str)
        {
            List<HangHoa_DTO> HHlist = new List<HangHoa_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchHangHoa @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                HangHoa_DTO HH = new HangHoa_DTO(item);
                HHlist.Add(HH);
            }
            return HHlist;
        }
    }
}
