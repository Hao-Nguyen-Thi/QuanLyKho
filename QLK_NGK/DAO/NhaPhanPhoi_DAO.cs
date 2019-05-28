using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class NhaPhanPhoi_DAO
    {
        private static NhaPhanPhoi_DAO instance;

        internal static NhaPhanPhoi_DAO Instance
        {
            get { if (instance == null) instance = new NhaPhanPhoi_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhaPhanPhoi_DTO> GetDSNPP()
        {
            List<NhaPhanPhoi_DTO> list = new List<NhaPhanPhoi_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallNhaPhanPhoi");
            foreach (DataRow item in data.Rows)
            {
                NhaPhanPhoi_DTO NPP = new NhaPhanPhoi_DTO(item);
                list.Add(NPP);
            }
            return list;
        }

        public bool InsertNPP(string ma, string ten, string sdt, string loai, string diachi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertNPP @ma ,  @ten , @sdt , @loai , @diachi ", new object[] { ma, ten, sdt, loai, diachi });

            return result > 0;
        }
        public bool UpdateNPP(string ma, string ten, string sdt, string loai, string diachi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateNhaPhanPhoi @ma , @ten , @sdt , @loai , @diachi ", new object[] { ma, ten, sdt, loai, diachi });

            return result > 0;
        }
        public bool DeleteNPP(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteNhaPhanPhoi @ma ", new object[] { ma });

            return result > 0;
        }
        public List<NhaPhanPhoi_DTO> SearchNPP(string str)
        {
            List<NhaPhanPhoi_DTO> NPPlist = new List<NhaPhanPhoi_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNhaPhanPhoi @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhaPhanPhoi_DTO NPP = new NhaPhanPhoi_DTO(item);
                NPPlist.Add(NPP);
            }
            return NPPlist;
        }
    }
}
