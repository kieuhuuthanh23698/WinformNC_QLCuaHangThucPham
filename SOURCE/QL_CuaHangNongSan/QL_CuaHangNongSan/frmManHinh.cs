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
    public partial class frmManHinh : Form
    {
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void mAN_HINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAN_HINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phanQuyen);

        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanQuyen.MAN_HINH' table. You can move, or remove it, as needed.
            this.mAN_HINHTableAdapter.Fill(this.phanQuyen.MAN_HINH);

        }
    }
}
