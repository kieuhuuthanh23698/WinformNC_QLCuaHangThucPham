﻿namespace QL_CuaHangNongSan
{
    partial class frmDanhMucMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnThemLoaiMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoaLoaiMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuaLoaiMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnThemMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoaMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuaMatHang = new DevComponents.DotNetBar.ButtonItem();
            this.btnThemHangVaoKho = new DevComponents.DotNetBar.ButtonItem();
            this.treeViewLoaiMatHang = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dataGridViewHangHoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoluongTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewLoaiMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThemLoaiMatHang,
            this.btnXoaLoaiMatHang,
            this.btnSuaLoaiMatHang});
            this.bar1.Location = new System.Drawing.Point(9, 85);
            this.bar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(230, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 6;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnThemLoaiMatHang
            // 
            this.btnThemLoaiMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThemLoaiMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThemLoaiMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.them_icon;
            this.btnThemLoaiMatHang.Name = "btnThemLoaiMatHang";
            this.btnThemLoaiMatHang.Text = "Thêm";
            this.btnThemLoaiMatHang.Click += new System.EventHandler(this.btnThemLoaiMatHang_Click);
            // 
            // btnXoaLoaiMatHang
            // 
            this.btnXoaLoaiMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoaLoaiMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXoaLoaiMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoaiMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.xoa_icon;
            this.btnXoaLoaiMatHang.Name = "btnXoaLoaiMatHang";
            this.btnXoaLoaiMatHang.Text = "Xóa";
            this.btnXoaLoaiMatHang.Click += new System.EventHandler(this.btnXoaLoaiMatHang_Click);
            // 
            // btnSuaLoaiMatHang
            // 
            this.btnSuaLoaiMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuaLoaiMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSuaLoaiMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLoaiMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.sua_icon;
            this.btnSuaLoaiMatHang.Name = "btnSuaLoaiMatHang";
            this.btnSuaLoaiMatHang.Text = "Sửa";
            this.btnSuaLoaiMatHang.Click += new System.EventHandler(this.btnSuaLoaiMatHang_Click);
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThemMatHang,
            this.btnXoaMatHang,
            this.btnSuaMatHang,
            this.btnThemHangVaoKho});
            this.bar2.Location = new System.Drawing.Point(295, 85);
            this.bar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(432, 41);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 7;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThemMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThemMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.them_icon;
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Text = "Thêm";
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // btnXoaMatHang
            // 
            this.btnXoaMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoaMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXoaMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.xoa_icon;
            this.btnXoaMatHang.Name = "btnXoaMatHang";
            this.btnXoaMatHang.Text = "Xóa";
            this.btnXoaMatHang.Click += new System.EventHandler(this.btnXoaMatHang_Click);
            // 
            // btnSuaMatHang
            // 
            this.btnSuaMatHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuaMatHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSuaMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMatHang.Image = global::QL_CuaHangNongSan.Properties.Resources.sua_icon;
            this.btnSuaMatHang.Name = "btnSuaMatHang";
            this.btnSuaMatHang.Text = "Sửa";
            this.btnSuaMatHang.Click += new System.EventHandler(this.btnSuaMatHang_Click);
            // 
            // btnThemHangVaoKho
            // 
            this.btnThemHangVaoKho.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThemHangVaoKho.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThemHangVaoKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHangVaoKho.Image = global::QL_CuaHangNongSan.Properties.Resources.themHangVaoKho2_icon;
            this.btnThemHangVaoKho.Name = "btnThemHangVaoKho";
            this.btnThemHangVaoKho.Text = "Thêm hàng vào kho";
            this.btnThemHangVaoKho.Click += new System.EventHandler(this.btnThemHangVaoKho_Click);
            // 
            // treeViewLoaiMatHang
            // 
            this.treeViewLoaiMatHang.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeViewLoaiMatHang.AllowDrop = true;
            this.treeViewLoaiMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewLoaiMatHang.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.treeViewLoaiMatHang.BackgroundStyle.Class = "TreeBorderKey";
            this.treeViewLoaiMatHang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeViewLoaiMatHang.Location = new System.Drawing.Point(13, 142);
            this.treeViewLoaiMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeViewLoaiMatHang.Name = "treeViewLoaiMatHang";
            this.treeViewLoaiMatHang.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.treeViewLoaiMatHang.NodesConnector = this.nodeConnector1;
            this.treeViewLoaiMatHang.NodeStyle = this.elementStyle1;
            this.treeViewLoaiMatHang.PathSeparator = ";";
            this.treeViewLoaiMatHang.Size = new System.Drawing.Size(230, 395);
            this.treeViewLoaiMatHang.Styles.Add(this.elementStyle1);
            this.treeViewLoaiMatHang.TabIndex = 8;
            this.treeViewLoaiMatHang.Text = "advTree1";
            this.treeViewLoaiMatHang.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeViewLoaiMatHang_NodeClick);
            // 
            // node1
            // 
            this.node1.Name = "node1";
            this.node1.Text = "Tất cả loại hàng hóa";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridViewHangHoa
            // 
            this.dataGridViewHangHoa.AllowUserToAddRows = false;
            this.dataGridViewHangHoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHangHoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.GiaBan,
            this.DonVi,
            this.SoluongTrongKho});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHangHoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewHangHoa.Location = new System.Drawing.Point(295, 142);
            this.dataGridViewHangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHangHoa.Name = "dataGridViewHangHoa";
            this.dataGridViewHangHoa.ReadOnly = true;
            this.dataGridViewHangHoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHangHoa.RowHeadersVisible = false;
            this.dataGridViewHangHoa.RowTemplate.Height = 24;
            this.dataGridViewHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHangHoa.Size = new System.Drawing.Size(432, 395);
            this.dataGridViewHangHoa.TabIndex = 103;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "Mã hàng hóa";
            this.MaHangHoa.FillWeight = 75F;
            this.MaHangHoa.HeaderText = "Mã hàng hóa";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            this.MaHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "Tên hàng hóa";
            this.TenHangHoa.FillWeight = 225F;
            this.TenHangHoa.HeaderText = "Tên hàng hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            this.TenHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "Giá bán";
            this.GiaBan.FillWeight = 50F;
            this.GiaBan.HeaderText = "GIá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "Đơn vị";
            this.DonVi.FillWeight = 50F;
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // SoluongTrongKho
            // 
            this.SoluongTrongKho.DataPropertyName = "Số lượng";
            this.SoluongTrongKho.FillWeight = 50F;
            this.SoluongTrongKho.HeaderText = "Số lượng";
            this.SoluongTrongKho.Name = "SoluongTrongKho";
            this.SoluongTrongKho.ReadOnly = true;
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Location = new System.Drawing.Point(12, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(715, 71);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 104;
            // 
            // labelX2
            // 
            this.labelX2.BackgroundImage = global::QL_CuaHangNongSan.Properties.Resources.mathang_1;
            this.labelX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 68);
            this.labelX2.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelX1.Location = new System.Drawing.Point(221, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(248, 38);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "DANH MỤC MẶT HÀNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmDanhMucMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QL_CuaHangNongSan.Properties.Resources.bg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.dataGridViewHangHoa);
            this.Controls.Add(this.treeViewLoaiMatHang);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDanhMucMatHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục mặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewLoaiMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnThemLoaiMatHang;
        private DevComponents.DotNetBar.ButtonItem btnXoaLoaiMatHang;
        private DevComponents.DotNetBar.ButtonItem btnSuaLoaiMatHang;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnThemMatHang;
        private DevComponents.DotNetBar.ButtonItem btnXoaMatHang;
        private DevComponents.DotNetBar.ButtonItem btnSuaMatHang;
        private DevComponents.DotNetBar.ButtonItem btnThemHangVaoKho;
        private DevComponents.AdvTree.AdvTree treeViewLoaiMatHang;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewHangHoa;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoluongTrongKho;
    }
}