using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_CuaHangNongSan
{
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void nHOM_NGUOI_DUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOM_NGUOI_DUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phanQuyen);

        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanQuyen.NGUOIDUNG_NHOM_ND' table. You can move, or remove it, as needed.
            this.nGUOIDUNG_NHOM_NDTableAdapter.Fill(this.phanQuyen.NGUOIDUNG_NHOM_ND);
            // TODO: This line of code loads data into the 'phanQuyen.TAI_KHOAN' table. You can move, or remove it, as needed.
            this.tAI_KHOANTableAdapter.Fill(this.phanQuyen.TAI_KHOAN);
            // TODO: This line of code loads data into the 'phanQuyen.NHOM_NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.nHOM_NGUOI_DUNGTableAdapter.Fill(this.phanQuyen.NHOM_NGUOI_DUNG);

        }

        private void nHOM_NGUOI_DUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboByCondition();
        }

        public void LoadComboByCondition()
        {
            if (nHOM_NGUOI_DUNGComboBox.SelectedValue != null)
            {
                try
                {
                    this.qL_NguoiDungTrongNhomTableAdapter.Fill(this.phanQuyen.QL_NguoiDungTrongNhom, nHOM_NGUOI_DUNGComboBox.SelectedValue.ToString());

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in tAI_KHOANDataGridView.SelectedRows)
            {
                if (this.qL_NguoiDungTrongNhomTableAdapter.KiemTraKhoaChinh(item.Cells[0].Value.ToString(), nHOM_NGUOI_DUNGComboBox.SelectedValue.ToString()) == string.Empty)
                {
                    MessageBox.Show("Đã tồn tại");
                }
                else
                {
                    this.nGUOIDUNG_NHOM_NDTableAdapter.Insert(item.Cells[0].Value.ToString(), nHOM_NGUOI_DUNGComboBox.SelectedValue.ToString(), string.Empty);
                }
            }
            LoadComboByCondition();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in nGUOIDUNG_NHOM_NDDataGridView.SelectedRows)
            {
                if (this.nGUOIDUNG_NHOM_NDTableAdapter.Delete(item.Cells[0].Value.ToString(), nHOM_NGUOI_DUNGComboBox.SelectedValue.ToString(), item.Cells[2].Value.ToString()) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
                LoadComboByCondition();
            }
        }       
    }
}
