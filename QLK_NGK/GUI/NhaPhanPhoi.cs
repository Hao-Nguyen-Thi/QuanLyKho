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
    public partial class NhaPhanPhoi : Form
    {
        BindingSource NPPlist = new BindingSource();


        public NhaPhanPhoi()
        {
            InitializeComponent();
            LoadNPP();
        }
        public void LoadNPP()
        {
            dgvNPP.DataSource = NPPlist;
            LoadListNPP();
            AddBinding();

        }
        void LoadListNPP()
        {

            NPPlist.DataSource = NhaPhanPhoi_DAO.Instance.GetDSNPP();
            dgvNPP.Columns["MaNPP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // EditDataGridView();

        }

        void AddBinding()
        {
            txtMaNPP.DataBindings.Add(new Binding("Text", dgvNPP.DataSource, "MaNPP", true, DataSourceUpdateMode.Never));
            txtTenNPP.DataBindings.Add(new Binding("Text", dgvNPP.DataSource, "TenNPP", true, DataSourceUpdateMode.Never));
            txtLoaiNPP.DataBindings.Add(new Binding("Text", dgvNPP.DataSource, "LoaiNPP", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvNPP.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNPP.DataSource, "SDT", true, DataSourceUpdateMode.Never));
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm nhà phần phối có tên là: " + txtTenNPP.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaNPP.Text == "" || txtTenNPP.Text == "" || txtLoaiNPP.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListNPP();
                }
                else
                {
                    string manpp = txtMaNPP.Text;
                    string tennpp = txtTenNPP.Text;
                    string loainpp = txtLoaiNPP.Text;
                    string diachi = txtDiachi.Text;
                    string SDT = txtSDT.Text;
                    if (NhaPhanPhoi_DAO.Instance.InsertNPP(manpp, tennpp, SDT, loainpp, diachi))
                    {
                        MessageBox.Show("Thêm nhà phân phối thành công! ");
                        LoadListNPP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhà phân phối ! ");
                    }

                }

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thể  muốn sửa nhà phân phối có tên là: " + txtTenNPP.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtMaNPP.Text == "" || txtTenNPP.Text == "" || txtLoaiNPP.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {

                    string manpp = txtMaNPP.Text;
                    string tennpp = txtTenNPP.Text;
                    string loainpp = txtLoaiNPP.Text;
                    string diachi = txtDiachi.Text;
                    string SDT = txtSDT.Text;
                    if (NhaPhanPhoi_DAO.Instance.UpdateNPP(manpp, tennpp, SDT, loainpp, diachi))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListNPP();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhà phân phối có tên là: " + txtTenNPP.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string ma = txtMaNPP.Text;
                if (NhaPhanPhoi_DAO.Instance.DeleteNPP(ma))
                {
                    MessageBox.Show("Xóa nhà phân phối thành công! ");
                    LoadListNPP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhà phân phối! ");
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chua nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNPP.DataSource = NPPlist;
            NPPlist.DataSource = NhaPhanPhoi_DAO.Instance.SearchNPP(str);
        }

        /*private void button5_Click(object sender, EventArgs e)
        {

            Report f = new Report();
            f.Show();
        }*/
    }
}
