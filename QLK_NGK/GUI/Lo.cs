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

namespace QLK_NGK.GUI
{
    public partial class Lo : Form
    {
        BindingSource lolist = new BindingSource();
        public Lo()
        {
            InitializeComponent();
            LoadLo();
        }
        public void LoadLo()
        {
            dgvLo.DataSource = lolist;
            LoadListLo();
            AddBinding();

        }
        void LoadListLo()
        {

            lolist.DataSource = Lo_DAO.Instance.GetDSLo();
            dgvLo.Columns["MaLo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // EditDataGridView();

        }
        void AddBinding()
        {
            txtMaL.DataBindings.Add(new Binding("Text", dgvLo.DataSource, "MaLo", true, DataSourceUpdateMode.Never));
            dtpHSD.DataBindings.Add(new Binding("Text", dgvLo.DataSource, "HanSuDung", true, DataSourceUpdateMode.Never));
            dtpNSX.DataBindings.Add(new Binding("Text", dgvLo.DataSource, "NgaySanXuat", true, DataSourceUpdateMode.Never));
            txtSL.DataBindings.Add(new Binding("Text", dgvLo.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thêm lô hàng hóa có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dtpNSX.Text == "" || dtpHSD.Text == "" || txtSL.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListLo();
                }
                else
                {
                    string malo = txtMaL.Text;
                    DateTime nsx;
                    DateTime.TryParse(dtpNSX.Text, out nsx);
                    DateTime hsd;
                    DateTime.TryParse(dtpHSD.Text, out hsd);
                    int sl;
                    Int32.TryParse(txtSL.Text, out sl);
                    if (Lo_DAO.Instance.InsertLo(malo, nsx, hsd, sl))
                    {
                        MessageBox.Show("Thêm lô hàng hóa thành công! ");
                        LoadListLo();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm lô hàng hóa ! ");
                    }

                }

            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thể  muốn sửa lô hàng hóa có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dtpNSX.Text == "" || dtpHSD.Text == "" || txtSL.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string mal = txtMaL.Text;
                    DateTime nsx;
                    DateTime.TryParse(dtpNSX.Text, out nsx);
                    DateTime hsd;
                    DateTime.TryParse(dtpHSD.Text, out hsd);
                    int sl;
                    Int32.TryParse(txtSL.Text, out sl);
                    if (Lo_DAO.Instance.UpdateLo(mal, nsx, sl, hsd))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListLo();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa lô hàng có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string mal = txtMaL.Text;
                if (Lo_DAO.Instance.DeleteLo(mal))
                {
                    MessageBox.Show("Xóa lô hàng hóa thành công! ");
                    LoadListLo();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa lô hàng! ");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chua nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvLo.DataSource = lolist;
            lolist.DataSource = Lo_DAO.Instance.SearchLo(str);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm lô hàng hóa có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dtpNSX.Text == "" || dtpHSD.Text == "" || txtSL.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListLo();
                }
                else
                {
                    string malo = txtMaL.Text;
                    DateTime nsx;
                    DateTime.TryParse(dtpNSX.Text, out nsx);
                    DateTime hsd;
                    DateTime.TryParse(dtpHSD.Text, out hsd);
                    int sl;
                    Int32.TryParse(txtSL.Text, out sl);
                    if (Lo_DAO.Instance.InsertLo(malo, nsx, hsd, sl))
                    {
                        MessageBox.Show("Thêm lô hàng hóa thành công! ");
                        LoadListLo();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm lô hàng hóa ! ");
                    }

                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thể  muốn sửa lô hàng hóa có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dtpNSX.Text == "" || dtpHSD.Text == "" || txtSL.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string mal = txtMaL.Text;
                    DateTime nsx;
                    DateTime.TryParse(dtpNSX.Text, out nsx);
                    DateTime hsd;
                    DateTime.TryParse(dtpHSD.Text, out hsd);
                    int sl;
                    Int32.TryParse(txtSL.Text, out sl);
                    if (Lo_DAO.Instance.UpdateLo(mal, nsx, sl, hsd))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListLo();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa lô hàng có mã là: " + txtMaL.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string mal = txtMaL.Text;
                if (Lo_DAO.Instance.DeleteLo(mal))
                {
                    MessageBox.Show("Xóa lô hàng hóa thành công! ");
                    LoadListLo();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa lô hàng! ");
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chua nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvLo.DataSource = lolist;
            lolist.DataSource = Lo_DAO.Instance.SearchLo(str);
        }
    }
}
