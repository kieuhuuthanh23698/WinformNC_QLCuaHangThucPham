namespace QL_CuaHangNongSan
{
    partial class frmManHinh
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
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            this.phanQuyen = new QL_CuaHangNongSan.PhanQuyen();
            this.mAN_HINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAN_HINHTableAdapter = new QL_CuaHangNongSan.PhanQuyenTableAdapters.MAN_HINHTableAdapter();
            this.tableAdapterManager = new QL_CuaHangNongSan.PhanQuyenTableAdapters.TableAdapterManager();
            this.mAN_HINHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.mAN_HINHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mAN_HINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHBindingNavigator)).BeginInit();
            this.mAN_HINHBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phanQuyen
            // 
            this.phanQuyen.DataSetName = "PhanQuyen";
            this.phanQuyen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAN_HINHBindingSource
            // 
            this.mAN_HINHBindingSource.DataMember = "MAN_HINH";
            this.mAN_HINHBindingSource.DataSource = this.phanQuyen;
            // 
            // mAN_HINHTableAdapter
            // 
            this.mAN_HINHTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MAN_HINHTableAdapter = this.mAN_HINHTableAdapter;
            this.tableAdapterManager.NGUOIDUNG_NHOM_NDTableAdapter = null;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOM_NGUOI_DUNGTableAdapter = null;
            this.tableAdapterManager.PHAN_QUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager.THE_THANH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_CuaHangNongSan.PhanQuyenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAN_HINHBindingNavigator
            // 
            this.mAN_HINHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mAN_HINHBindingNavigator.BindingSource = this.mAN_HINHBindingSource;
            this.mAN_HINHBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mAN_HINHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mAN_HINHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mAN_HINHBindingNavigatorSaveItem});
            this.mAN_HINHBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mAN_HINHBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mAN_HINHBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mAN_HINHBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mAN_HINHBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mAN_HINHBindingNavigator.Name = "mAN_HINHBindingNavigator";
            this.mAN_HINHBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mAN_HINHBindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.mAN_HINHBindingNavigator.TabIndex = 0;
            this.mAN_HINHBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(55, 33);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(74, 13);
            maManHinhLabel.TabIndex = 1;
            maManHinhLabel.Text = "Ma Man Hinh:";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAN_HINHBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Location = new System.Drawing.Point(139, 30);
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.maManHinhTextBox.TabIndex = 2;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(55, 59);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(78, 13);
            tenManHinhLabel.TabIndex = 3;
            tenManHinhLabel.Text = "Ten Man Hinh:";
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAN_HINHBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Location = new System.Drawing.Point(139, 56);
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenManHinhTextBox.TabIndex = 4;
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
            // mAN_HINHBindingNavigatorSaveItem
            // 
            this.mAN_HINHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAN_HINHBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mAN_HINHBindingNavigatorSaveItem.Image")));
            this.mAN_HINHBindingNavigatorSaveItem.Name = "mAN_HINHBindingNavigatorSaveItem";
            this.mAN_HINHBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mAN_HINHBindingNavigatorSaveItem.Text = "Save Data";
            this.mAN_HINHBindingNavigatorSaveItem.Click += new System.EventHandler(this.mAN_HINHBindingNavigatorSaveItem_Click);
            // 
            // mAN_HINHDataGridView
            // 
            this.mAN_HINHDataGridView.AutoGenerateColumns = false;
            this.mAN_HINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mAN_HINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mAN_HINHDataGridView.DataSource = this.mAN_HINHBindingSource;
            this.mAN_HINHDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mAN_HINHDataGridView.Location = new System.Drawing.Point(0, 96);
            this.mAN_HINHDataGridView.Name = "mAN_HINHDataGridView";
            this.mAN_HINHDataGridView.Size = new System.Drawing.Size(394, 296);
            this.mAN_HINHDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 392);
            this.Controls.Add(this.mAN_HINHDataGridView);
            this.Controls.Add(maManHinhLabel);
            this.Controls.Add(this.maManHinhTextBox);
            this.Controls.Add(tenManHinhLabel);
            this.Controls.Add(this.tenManHinhTextBox);
            this.Controls.Add(this.mAN_HINHBindingNavigator);
            this.Name = "frmManHinh";
            this.Text = "frmManHinh";
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHBindingNavigator)).EndInit();
            this.mAN_HINHBindingNavigator.ResumeLayout(false);
            this.mAN_HINHBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAN_HINHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhanQuyen phanQuyen;
        private System.Windows.Forms.BindingSource mAN_HINHBindingSource;
        private PhanQuyenTableAdapters.MAN_HINHTableAdapter mAN_HINHTableAdapter;
        private PhanQuyenTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mAN_HINHBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mAN_HINHBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
        private System.Windows.Forms.DataGridView mAN_HINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}