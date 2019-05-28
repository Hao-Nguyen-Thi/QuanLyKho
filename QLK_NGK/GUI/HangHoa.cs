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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        BindingSource HHlist = new BindingSource();


        public HangHoa()
        {
            InitializeComponent();
            LoadHH();
        }
        public void LoadHH()
        {
            dgvHH.DataSource = HHlist;
            LoadListHH();
            AddBinding();

        }
        void LoadListHH()
        {
            HHlist.DataSource = HangHoa_DAO.Instance.GetDSHH();
            dgvHH.Columns["MaHH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // EditDataGridView();

        }

        void AddBinding()
        {
            txtMaHH.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "MaHangHoa", true, DataSourceUpdateMode.Never));
            txtTenHH.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "TenHangHoa", true, DataSourceUpdateMode.Never));
            txtMaLHH.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "MaLoaiHangHoa", true, DataSourceUpdateMode.Never));
            txtQuyCach.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "QuyCach", true, DataSourceUpdateMode.Never));
            txtMaLo.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "MaLo", true, DataSourceUpdateMode.Never));
            txtMaKho.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "MaKho", true, DataSourceUpdateMode.Never));
            txtSoLuongTon.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "SoLuongTon", true, DataSourceUpdateMode.Never));
            txtDungTich.DataBindings.Add(new Binding("Text", dgvHH.DataSource, "DungTich", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm hàng hóa có tên là: " + txtTenHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtMaLHH.Text == "" || txtDungTich.Text == "" || txtQuyCach.Text == "" || txtSoLuongTon.Text == "" || txtMaLo.Text == "" || txtMaKho.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListHH();
                }
                else
                {
                    string mahh = txtMaHH.Text;
                    string tenhh = txtTenHH.Text;
                    string malhh = txtMaLHH.Text;
                    string malo = txtMaLo.Text;
                    string makho = txtMaKho.Text;
                    int soluongton;
                    Int32.TryParse(txtSoLuongTon.Text, out soluongton);
                    int dungtich;
                    Int32.TryParse(txtDungTich.Text, out dungtich);
                    string quycach = txtQuyCach.Text;

                    if (HangHoa_DAO.Instance.InsertHH(mahh, tenhh, malhh, malo, quycach, makho, soluongton, dungtich))
                    {
                        MessageBox.Show("Thêm hàng hóa thành công! ");
                        LoadListHH();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm hàng hóa! ");
                    }

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thể  muốn sửa hàng hóa có tên là: " + txtTenHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtMaLHH.Text == "" || txtDungTich.Text == "" || txtQuyCach.Text == "" || txtSoLuongTon.Text == "" || txtMaLo.Text == "" || txtMaKho.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }

                else
                {
                    string mahh = txtMaHH.Text;
                    string tenhh = txtTenHH.Text;
                    string malhh = txtMaLHH.Text;
                    string malo = txtMaLo.Text;
                    string makho = txtMaKho.Text;
                    int soluongton;
                    Int32.TryParse(txtSoLuongTon.Text, out soluongton);
                    int dungtich;
                    Int32.TryParse(txtDungTich.Text, out dungtich);
                    string quycach = txtQuyCach.Text;

                    if (HangHoa_DAO.Instance.UpdateHH(mahh, tenhh, malhh, malo, quycach, makho, soluongton, dungtich))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListHH();
                    }

                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa hàng hóa có tên là: " + txtTenHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string mahh = txtMaHH.Text;
                if (HangHoa_DAO.Instance.DeleteHH(mahh))
                {
                    MessageBox.Show("Xóa hàng hóa thành công! ");
                    LoadListHH();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa hàng hóa! ");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvHH.DataSource = HHlist;
            HHlist.DataSource = HangHoa_DAO.Instance.SearchHH(str);

        }
        */

    }
}





