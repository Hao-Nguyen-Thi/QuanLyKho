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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
        BindingSource NVlist = new BindingSource();


        public NhanVien()
        {
            InitializeComponent();
            LoadNV();
        }
        public void LoadNV()
        {
            dgvNV.DataSource = NVlist;
            LoadListNV();
            AddBinding();

        }
        void LoadListNV()
        {

            NVlist.DataSource = NhanVien_DAO.Instance.GetDSNV();
            dgvNV.Columns["MaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // EditDataGridView();

        }

        void AddBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "TenNV", true, DataSourceUpdateMode.Never));     
            txtGT.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtNS.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never));
            txtDC.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtLuong.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
        }
        */
    }
}
