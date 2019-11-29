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
    public partial class frmNhomNguoiDung : Form
    {
        public frmNhomNguoiDung()
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
            // TODO: This line of code loads data into the 'phanQuyen.NHOM_NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.nHOM_NGUOI_DUNGTableAdapter.Fill(this.phanQuyen.NHOM_NGUOI_DUNG);

        }
    }
}
