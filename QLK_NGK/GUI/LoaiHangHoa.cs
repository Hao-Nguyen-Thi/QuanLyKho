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
    public partial class LoaiHangHoa : Form
    {
        BindingSource LHHlist = new BindingSource();


        public LoaiHangHoa()
        {
            InitializeComponent();
            LoadLHH();
        }

        public void LoadLHH()
        {
            dgvLHH.DataSource = LHHlist;
            LoadListLHH();
            AddBinding();

        }

        void LoadListLHH()
        {

            LHHlist.DataSource = LoaiHangHoa_DAO.Instance.GetDSLHH();
            dgvLHH.Columns["MaLHH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // EditDataGridView();

        }

        void AddBinding()
        {
            txtMaLHH.DataBindings.Add(new Binding("Text", dgvLHH.DataSource, "MaLHH", true, DataSourceUpdateMode.Never));
            txtTenLHH.DataBindings.Add(new Binding("Text", dgvLHH.DataSource, "TenLHH", true, DataSourceUpdateMode.Never));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm loại hàng hóa có tên là: " + txtTenLHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaLHH.Text == "" || txtTenLHH.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListLHH();
                }
                else
                {
                    string malhh = txtMaLHH.Text;
                    string tenlhh = txtTenLHH.Text;                   
                    if (LoaiHangHoa_DAO.Instance.InsertLHH(malhh, tenlhh))
                    {
                        MessageBox.Show("Thêm loại hàng hóa thành công! ");
                        LoadListLHH();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm loại hàng hóa ! ");
                    }

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thể  muốn sửa loại hàng hóa có tên là: " + txtTenLHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaLHH.Text == "" || txtTenLHH.Text == "" )
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {

                    string malhh = txtMaLHH.Text;
                    string tenlhh = txtTenLHH.Text;                  
                    if (LoaiHangHoa_DAO.Instance.UpdateLHH(malhh, tenlhh))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListLHH();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại hàng hóa có tên là: " + txtTenLHH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string ma = txtMaLHH.Text;
                if (LoaiHangHoa_DAO.Instance.DeleteLHH(ma))
                {
                    MessageBox.Show("Xóa loại hàng hóa thành công! ");
                    LoadListLHH();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa loại hàng hóa! ");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chua nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvLHH.DataSource = LHHlist;
            LHHlist.DataSource = LoaiHangHoa_DAO.Instance.SearchLHH(str);
        }
    }
}
