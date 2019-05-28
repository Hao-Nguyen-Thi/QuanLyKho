using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLK_NGK.DAO;
using QLK_NGK.DTO;
using QLK_NGK.GUI;

namespace QLK_NGK.GUI
{
    public partial class PhanXuong : Form
    {
        public PhanXuong()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
