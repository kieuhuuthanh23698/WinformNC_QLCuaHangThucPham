namespace QL_CuaHangNongSan
{
    partial class frmNhomNguoiDung
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
            System.Windows.Forms.Label maNhomLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomNguoiDung));
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
            this.maNhomTextBox = new System.Windows.Forms.TextBox();
            this.tenNhomTextBox = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.nHOM_NGUOI_DUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhomLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingNavigator)).BeginInit();
            this.nHOM_NGUOI_DUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhomLabel
            // 
            maNhomLabel.AutoSize = true;
            maNhomLabel.Location = new System.Drawing.Point(85, 36);
            maNhomLabel.Name = "maNhomLabel";
            maNhomLabel.Size = new System.Drawing.Size(56, 13);
            maNhomLabel.TabIndex = 1;
            maNhomLabel.Text = "Ma Nhom:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Location = new System.Drawing.Point(85, 62);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(60, 13);
            tenNhomLabel.TabIndex = 3;
            tenNhomLabel.Text = "Ten Nhom:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(85, 88);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(48, 13);
            ghiChuLabel.TabIndex = 5;
            ghiChuLabel.Text = "Ghi Chu:";
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
            this.nHOM_NGUOI_DUNGBindingNavigator.Size = new System.Drawing.Size(365, 25);
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
            // maNhomTextBox
            // 
            this.maNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOM_NGUOI_DUNGBindingSource, "MaNhom", true));
            this.maNhomTextBox.Location = new System.Drawing.Point(151, 33);
            this.maNhomTextBox.Name = "maNhomTextBox";
            this.maNhomTextBox.Size = new System.Drawing.Size(100, 20);
            this.maNhomTextBox.TabIndex = 2;
            // 
            // tenNhomTextBox
            // 
            this.tenNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOM_NGUOI_DUNGBindingSource, "TenNhom", true));
            this.tenNhomTextBox.Location = new System.Drawing.Point(151, 59);
            this.tenNhomTextBox.Name = "tenNhomTextBox";
            this.tenNhomTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenNhomTextBox.TabIndex = 4;
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOM_NGUOI_DUNGBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(151, 85);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(100, 20);
            this.ghiChuTextBox.TabIndex = 6;
            // 
            // nHOM_NGUOI_DUNGDataGridView
            // 
            this.nHOM_NGUOI_DUNGDataGridView.AutoGenerateColumns = false;
            this.nHOM_NGUOI_DUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHOM_NGUOI_DUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nHOM_NGUOI_DUNGDataGridView.DataSource = this.nHOM_NGUOI_DUNGBindingSource;
            this.nHOM_NGUOI_DUNGDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nHOM_NGUOI_DUNGDataGridView.Location = new System.Drawing.Point(0, 112);
            this.nHOM_NGUOI_DUNGDataGridView.Name = "nHOM_NGUOI_DUNGDataGridView";
            this.nHOM_NGUOI_DUNGDataGridView.Size = new System.Drawing.Size(365, 270);
            this.nHOM_NGUOI_DUNGDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 382);
            this.Controls.Add(this.nHOM_NGUOI_DUNGDataGridView);
            this.Controls.Add(maNhomLabel);
            this.Controls.Add(this.maNhomTextBox);
            this.Controls.Add(tenNhomLabel);
            this.Controls.Add(this.tenNhomTextBox);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(this.nHOM_NGUOI_DUNGBindingNavigator);
            this.Name = "frmNhomNguoiDung";
            this.Text = "frmNhomNguoiDung";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGBindingNavigator)).EndInit();
            this.nHOM_NGUOI_DUNGBindingNavigator.ResumeLayout(false);
            this.nHOM_NGUOI_DUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOM_NGUOI_DUNGDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox maNhomTextBox;
        private System.Windows.Forms.TextBox tenNhomTextBox;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.DataGridView nHOM_NGUOI_DUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}