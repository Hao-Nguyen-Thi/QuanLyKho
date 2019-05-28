using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK_NGK.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnNPP_Click(object sender, EventArgs e)
        {
            NhaPhanPhoi f = new NhaPhanPhoi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLHH_Click(object sender, EventArgs e)
        {
            LoaiHangHoa f = new LoaiHangHoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            Lo f = new Lo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPX_Click(object sender, EventArgs e)
        {
            PhanXuong f = new PhanXuong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHĐN_Click(object sender, EventArgs e)
        {
            HoaDonNhapKho f = new HoaDonNhapKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHĐX_Click(object sender, EventArgs e)
        {
            HoaDonXuatKho f = new HoaDonXuatKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
