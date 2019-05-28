using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLK_NGK.DTO;

namespace QLK_NGK.DAO
{
    class Lo_DAO
    {
        private static Lo_DAO instance;

        internal static Lo_DAO Instance
        {
            get { if (instance == null) instance = new Lo_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<Lo_DTO> GetDSLo()
        {
            List<Lo_DTO> list = new List<Lo_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallLo");
            foreach (DataRow item in data.Rows)
            {
                Lo_DTO Lo = new Lo_DTO(item);
                list.Add(Lo);
            }
            return list;
        }

        public bool InsertLo(string malo, DateTime ngaysanxuat, DateTime hansudung, int soluong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertLo @malo , @ngaysanxuat , @hansudung , @soluong ", new object[] { malo, ngaysanxuat, hansudung, soluong });

            return result > 0;
        }
        public bool UpdateLo(string ma, DateTime ngaysanxuat, int soluong, DateTime hansudung)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateLo @ma ,  @ngaysanxuat , @soluong , @hansudung", new object[] { ma, ngaysanxuat, hansudung, soluong });

            return result > 0;
        }
        public bool DeleteLo(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteLo @ma ", new object[] { ma });

            return result > 0;
        }
        public List<Lo_DTO> SearchLo(string str)
        {
            List<Lo_DTO> Lolist = new List<Lo_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchLo @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                Lo_DTO Lo = new Lo_DTO(item);
                Lolist.Add(Lo);
            }
            return Lolist;
        }
    }
}
