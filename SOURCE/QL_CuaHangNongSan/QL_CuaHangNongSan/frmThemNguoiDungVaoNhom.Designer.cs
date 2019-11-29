namespace QL_CuaHangNongSan
{
    partial class frmThemNguoiDungVaoNhom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNguoiDungVaoNhom));
            this.phanQuyen = new QL_CuaHangNongSan.PhanQuyen();
            this.nHOM_NGUOI_DUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOM_NGUOI_DUNGTableAdapter = new QL_CuaHangNongSan.PhanQuyenTableAdapters.NHOM_NGUOI_DUNGTableAdapter();
            this.tableAdapterManager = new QL_CuaHangNongSan.PhanQuyenTableAdapters.TableAdapterManager();
            this.nHOM_NGUOI_DUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nHOM_NGUOI_DUNGComboBox = new System.Windows.Forms.ComboBox();
            this.tAI_KHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAI_KHOANTableAdapter = new QL_CuaHangNongSan.PhanQuyenTableAdapters.TAI_KHOANTableAdapter();
            this.tAI_KHOANDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIDUNG_NHOM_NDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNG_NHOM_NDTableAdapter = new QL_CuaHangNongSan.PhanQuyenTableAdapters.NGUOIDUNG_NHOM_NDTableAdapter();
            this.nGUOIDUNG_NHOM_NDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.qL_NguoiDungTrongNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTrongNhomTableAdapter = new QL_CuaHangNongSan.PhanQuyenTableAdapters.QL_NguoiDungTrongNhomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingNavigator)).BeginInit();
            this.nHOM_NGUOI_DUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOANDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOM_NDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOM_NDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungTrongNhomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phanQuyen
            // 
            this.phanQuyen.DataSetName = "PhanQuyen";
            this.phanQuyen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOM_NGUOI_DUNGBindingSource
            // 
            this.nHOM_NGUOI_DUNGBindingSource.DataMember = "NHOM_NGUOI_DUNG";
            this.nHOM_NGUOI_DUNGBindingSource.DataSource = this.phanQuyen;
            // 
            // nHOM_NGUOI_DUNGTableAdapter
            // 
            this.nHOM_NGUOI_DUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANG_GIATableAdapter = null;
            this.tableAdapterManager.CHI_TIET_CCTableAdapter = null;
            this.tableAdapterManager.CHI_TIET_DDHTableAdapter = null;
            this.tableAdapterManager.CHITIET_HDTableAdapter = null;
            this.tableAdapterManager.DANH_MUC_SPTableAdapter = null;
            this.tableAdapterManager.DON_DAT_HANG_NCCTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHUYEN_MAITableAdapter = null;
            this.tableAdapterManager.LO_HANGTableAdapter = null;
            this.tableAdapterManager.MAN_HINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOM_NDTableAdapter = null;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOM_NGUOI_DUNGTableAdapter = this.nHOM_NGUOI_DUNGTableAdapter;
            this.tableAdapterManager.PHAN_QUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager.THE_THANH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_CuaHangNongSan.PhanQuyenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHOM_NGUOI_DUNGBindingNavigator
            // 
            this.nHOM_NGUOI_DUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.BindingSource = this.nHOM_NGUOI_DUNGBindingSource;
            this.nHOM_NGUOI_DUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem});
            this.nHOM_NGUOI_DUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHOM_NGUOI_DUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.Name = "nHOM_NGUOI_DUNGBindingNavigator";
            this.nHOM_NGUOI_DUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nHOM_NGUOI_DUNGBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.nHOM_NGUOI_DUNGBindingNavigator.TabIndex = 0;
            this.nHOM_NGUOI_DUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nHOM_NGUOI_DUNGBindingNavigatorSaveItem
            // 
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Image")));
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Name = "nHOM_NGUOI_DUNGBindingNavigatorSaveItem";
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.nHOM_NGUOI_DUNGBindingNavigatorSaveItem_Click);
            // 
            // nHOM_NGUOI_DUNGComboBox
            // 
            this.nHOM_NGUOI_DUNGComboBox.DataSource = this.nHOM_NGUOI_DUNGBindingSource;
            this.nHOM_NGUOI_DUNGComboBox.DisplayMember = "TenNhom";
            this.nHOM_NGUOI_DUNGComboBox.FormattingEnabled = true;
            this.nHOM_NGUOI_DUNGComboBox.Location = new System.Drawing.Point(412, 28);
            this.nHOM_NGUOI_DUNGComboBox.Name = "nHOM_NGUOI_DUNGComboBox";
            this.nHOM_NGUOI_DUNGComboBox.Size = new System.Drawing.Size(300, 21);
            this.nHOM_NGUOI_DUNGComboBox.TabIndex = 1;
            this.nHOM_NGUOI_DUNGComboBox.ValueMember = "MaNhom";
            this.nHOM_NGUOI_DUNGComboBox.SelectedIndexChanged += new System.EventHandler(this.nHOM_NGUOI_DUNGComboBox_SelectedIndexChanged);
            // 
            // tAI_KHOANBindingSource
            // 
            this.tAI_KHOANBindingSource.DataMember = "TAI_KHOAN";
            this.tAI_KHOANBindingSource.DataSource = this.phanQuyen;
            // 
            // tAI_KHOANTableAdapter
            // 
            this.tAI_KHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tAI_KHOANDataGridView
            // 
            this.tAI_KHOANDataGridView.AutoGenerateColumns = false;
            this.tAI_KHOANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAI_KHOANDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tAI_KHOANDataGridView.DataSource = this.tAI_KHOANBindingSource;
            this.tAI_KHOANDataGridView.Location = new System.Drawing.Point(12, 65);
            this.tAI_KHOANDataGridView.Name = "tAI_KHOANDataGridView";
            this.tAI_KHOANDataGridView.Size = new System.Drawing.Size(313, 349);
            this.tAI_KHOANDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "TENDN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn3.HeaderText = "MATKHAU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HOATDONG";
            this.dataGridViewTextBoxColumn4.HeaderText = "HOATDONG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nGUOIDUNG_NHOM_NDBindingSource
            // 
            this.nGUOIDUNG_NHOM_NDBindingSource.DataMember = "NGUOIDUNG_NHOM_ND";
            this.nGUOIDUNG_NHOM_NDBindingSource.DataSource = this.phanQuyen;
            // 
            // nGUOIDUNG_NHOM_NDTableAdapter
            // 
            this.nGUOIDUNG_NHOM_NDTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNG_NHOM_NDDataGridView
            // 
            this.nGUOIDUNG_NHOM_NDDataGridView.AutoGenerateColumns = false;
            this.nGUOIDUNG_NHOM_NDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nGUOIDUNG_NHOM_NDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.nGUOIDUNG_NHOM_NDDataGridView.DataSource = this.nGUOIDUNG_NHOM_NDBindingSource;
            this.nGUOIDUNG_NHOM_NDDataGridView.Location = new System.Drawing.Point(412, 65);
            this.nGUOIDUNG_NHOM_NDDataGridView.Name = "nGUOIDUNG_NHOM_NDDataGridView";
            this.nGUOIDUNG_NHOM_NDDataGridView.Size = new System.Drawing.Size(300, 349);
            this.nGUOIDUNG_NHOM_NDDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn6.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn7.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(331, 179);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = ">>";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(331, 208);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "<<";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // qL_NguoiDungTrongNhomBindingSource
            // 
            this.qL_NguoiDungTrongNhomBindingSource.DataMember = "QL_NguoiDungTrongNhom";
            this.qL_NguoiDungTrongNhomBindingSource.DataSource = this.phanQuyen;
            // 
            // qL_NguoiDungTrongNhomTableAdapter
            // 
            this.qL_NguoiDungTrongNhomTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 434);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.nGUOIDUNG_NHOM_NDDataGridView);
            this.Controls.Add(this.tAI_KHOANDataGridView);
            this.Controls.Add(this.nHOM_NGUOI_DUNGComboBox);
            this.Controls.Add(this.nHOM_NGUOI_DUNGBindingNavigator);
            this.Name = "frmThemNguoiDungVaoNhom";
            this.Text = "frmThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.frmThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingNavigator)).EndInit();
            this.nHOM_NGUOI_DUNGBindingNavigator.ResumeLayout(false);
            this.nHOM_NGUOI_DUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOANDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOM_NDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOM_NDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungTrongNhomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhanQuyen phanQuyen;
        private System.Windows.Forms.BindingSource nHOM_NGUOI_DUNGBindingSource;
        private PhanQuyenTableAdapters.NHOM_NGUOI_DUNGTableAdapter nHOM_NGUOI_DUNGTableAdapter;
        private PhanQuyenTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nHOM_NGUOI_DUNGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nHOM_NGUOI_DUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox nHOM_NGUOI_DUNGComboBox;
        private System.Windows.Forms.BindingSource tAI_KHOANBindingSource;
        private PhanQuyenTableAdapters.TAI_KHOANTableAdapter tAI_KHOANTableAdapter;
        private System.Windows.Forms.DataGridView tAI_KHOANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource nGUOIDUNG_NHOM_NDBindingSource;
        private PhanQuyenTableAdapters.NGUOIDUNG_NHOM_NDTableAdapter nGUOIDUNG_NHOM_NDTableAdapter;
        private System.Windows.Forms.DataGridView nGUOIDUNG_NHOM_NDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.BindingSource qL_NguoiDungTrongNhomBindingSource;
        private PhanQuyenTableAdapters.QL_NguoiDungTrongNhomTableAdapter qL_NguoiDungTrongNhomTableAdapter;
    }
}