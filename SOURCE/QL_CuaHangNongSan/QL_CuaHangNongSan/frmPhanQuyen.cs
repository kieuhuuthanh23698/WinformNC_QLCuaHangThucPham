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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void nHOM_NGUOI_DUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOM_NGUOI_DUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phanQuyen);

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanQuyen.PHAN_QUYEN' table. You can move, or remove it, as needed.
            this.pHAN_QUYENTableAdapter.Fill(this.phanQuyen.PHAN_QUYEN);
            // TODO: This line of code loads data into the 'phanQuyen.NHOM_NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.nHOM_NGUOI_DUNGTableAdapter.Fill(this.phanQuyen.NHOM_NGUOI_DUNG);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_GetPhanQuyenTableAdapter.Fill(this.phanQuyen.QL_GetPhanQuyen, maNhomNguoiDungToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void LoadDataCondition()
        {
            this.qL_GetPhanQuyenTableAdapter.Fill(this.phanQuyen.QL_GetPhanQuyen, nHOM_NGUOI_DUNGDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void nHOM_NGUOI_DUNGDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataCondition();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string _NhomNguoiDung = nHOM_NGUOI_DUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (DataGridViewRow item in qL_GetPhanQuyenDataGridView.Rows)
            {
                if (qL_GetPhanQuyenTableAdapter.KiemTraKhoaChinhPhanQuyen(_NhomNguoiDung, item.Cells[0].Value.ToString()) == null)
                {
                    try
                    {
                        pHAN_QUYENTableAdapter.Insert(_NhomNguoiDung, item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        pHAN_QUYENTableAdapter.Insert(_NhomNguoiDung, item.Cells[0].Value.ToString(), false);
                    }
                }
                else
                {
                    pHAN_QUYENTableAdapter.UpdateQuery((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), _NhomNguoiDung, item.Cells[0].Value.ToString());
                }
            }
        }
    }
}
