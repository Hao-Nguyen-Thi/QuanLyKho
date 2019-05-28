using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK_NGK.DTO
{
    class LoaiHangHoa_DTO
    {
        private string maLHH;
        private string tenLHH;

        public string MaLHH { get => maLHH; set => maLHH = value; }
        public string TenLHH { get => tenLHH; set => tenLHH = value; }       

        public LoaiHangHoa_DTO(string maLHH, string tenLHH)
        {
            this.maLHH = maLHH;
            this.tenLHH = tenLHH;
        }

        public LoaiHangHoa_DTO(DataRow row)
        {
            this.maLHH = row["MaLoaiHangHoa"].ToString();
            this.tenLHH = row["TenLoaiHangHoa"].ToString();           
        }
    }
}
