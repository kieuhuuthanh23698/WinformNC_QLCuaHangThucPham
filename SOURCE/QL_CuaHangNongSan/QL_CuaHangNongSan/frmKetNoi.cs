using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace QL_CuaHangNongSan
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            foreach (DataRow r in table.Rows)
            {
                string SQLServer = r["ServerName"].ToString();
                string Instance = r["InstanceName"].ToString();
                if (Instance != null && !string.IsNullOrEmpty(Instance))
                {
                    cbbDataSource.Items.Add(SQLServer + "\\" + Instance);
                }
                else
                    cbbDataSource.Items.Add(SQLServer);
            }
            cbbDataSource.SelectedIndex = 0;
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (cbbDataSource.Text != "" && txtID.Text != "" && cbbIni.Text != "" && txtPass.Text != "")
            {
                this.errorProvider1.Clear();
                //tạo chuỗi kết nối
                string chuoiKetNoi = @"Data Source=" + cbbDataSource.Text + ";Initial Catalog=" + cbbIni.Text + ";User ID=" + txtID.Text + ";Password=" + txtPass.Text;
                KetNoiDuLieu link = new KetNoiDuLieu(chuoiKetNoi);
                if (link.Connec() == true)
                {
                    //đưa kết nối vào form login
                    frmLogin frmlogin = new frmLogin(link);
                    this.Hide();
                    frmlogin.Show();
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại !", "CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                if (cbbDataSource.Text == "")
                    this.errorProvider1.SetError(cbbDataSource, "Bạn không được để trống tên server của database !");
                if (txtID.Text == "")
                    this.errorProvider1.SetError(txtID,"Không được để trống !");
                if (cbbIni.Text == "")
                    this.errorProvider1.SetError(cbbIni,"Không được để trống username đăng nhập vào server !");
                if (txtPass.Text == "")
                    this.errorProvider1.SetError(txtPass, "Không được để trống mật khẩu đăng nhập vào server !");
            }
        }

        private void txtDataSource_Leave(object sender, EventArgs e)
        {
            if (cbbDataSource.Text == "")
                this.errorProvider1.SetError(cbbDataSource, "Bạn không được để trống tên server của database !");
            else
                this.errorProvider1.Clear();
        }

        private void txtIni_Leave(object sender, EventArgs e)
        {
            if (cbbIni.Text == "")
                this.errorProvider1.SetError(cbbIni, "Không được để trống tên database !");
            else
                this.errorProvider1.Clear();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                this.errorProvider1.SetError(txtID, "Không được để trống username đăng nhập vào server !");
            else
                this.errorProvider1.Clear();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                this.errorProvider1.SetError(txtPass, "Không được để trống mật khẩu đăng nhập vào server !");
            else
                this.errorProvider1.Clear();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Kiểm tra chuỗi kết nối đã lưu !");
            //if (Properties.Settings.Default.QL_SIEUTHIConnectionString == "")
            //{
            //    MessageBox.Show("Chuỗi kết nối không tồn tại !\nHãy thiết lập chuỗi kết nối !");
            //    return; 
            //}
            //try {
            //        KetNoiDuLieu link = new KetNoiDuLieu(Properties.Settings.Default.QL_SIEUTHIConnectionString);
            //        if (link.Connec() == true)
            //        {
            //            MessageBox.Show("Kết nối với Database thành công !");
            //            Program.login = new frmLogin(link);
            //            this.Close();
            //            Program.login.Show();
            //        }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Quá trình kiểm tra chuỗi kết nối gặp lỗi !\n" + ex.ToString());
            //    return;
            //}
        }
    }
}
