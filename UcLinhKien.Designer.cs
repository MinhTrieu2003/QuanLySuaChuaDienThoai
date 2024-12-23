namespace QLDVSC
{
    partial class UcLinhKien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLinhKien));
            toolStrip1 = new ToolStrip();
            toolStriptxtSearch4 = new ToolStripTextBox();
            toolStripbtnSearch4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddLinhKien = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditLinhKien = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btndeleteLiLinhKien = new ToolStripLabel();
            dgvLinhKien = new DataGridView();
            ID_linh_kien = new DataGridViewTextBoxColumn();
            Ten_linh_kien = new DataGridViewTextBoxColumn();
            Loai_linh_kien = new DataGridViewTextBoxColumn();
            Gia_nhap = new DataGridViewTextBoxColumn();
            Gia_ban = new DataGridViewTextBoxColumn();
            So_luong_ton_kho = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLinhKien).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStriptxtSearch4, toolStripbtnSearch4, toolStripSeparator1, btnAddLinhKien, toolStripSeparator2, btnEditLinhKien, toolStripSeparator3, btndeleteLiLinhKien });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(935, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStriptxtSearch4
            // 
            toolStriptxtSearch4.Name = "toolStriptxtSearch4";
            toolStriptxtSearch4.Size = new Size(300, 27);
            toolStriptxtSearch4.KeyDown += toolStriptxtSearch4_KeyDown;
            // 
            // toolStripbtnSearch4
            // 
            toolStripbtnSearch4.BackgroundImage = (Image)resources.GetObject("toolStripbtnSearch4.BackgroundImage");
            toolStripbtnSearch4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtnSearch4.Image = (Image)resources.GetObject("toolStripbtnSearch4.Image");
            toolStripbtnSearch4.ImageTransparentColor = Color.Magenta;
            toolStripbtnSearch4.Name = "toolStripbtnSearch4";
            toolStripbtnSearch4.Size = new Size(29, 24);
            toolStripbtnSearch4.Text = "toolStripButton1";
            toolStripbtnSearch4.Click += toolStripbtnSearch4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAddLinhKien
            // 
            btnAddLinhKien.Image = (Image)resources.GetObject("btnAddLinhKien.Image");
            btnAddLinhKien.Name = "btnAddLinhKien";
            btnAddLinhKien.Size = new Size(96, 24);
            btnAddLinhKien.Text = "Thêm mới";
            btnAddLinhKien.Click += btnAddLinhKien_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditLinhKien
            // 
            btnEditLinhKien.Image = (Image)resources.GetObject("btnEditLinhKien.Image");
            btnEditLinhKien.Name = "btnEditLinhKien";
            btnEditLinhKien.Size = new Size(54, 24);
            btnEditLinhKien.Text = "Sửa";
            btnEditLinhKien.Click += btnEditLinhKien_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btndeleteLiLinhKien
            // 
            btndeleteLiLinhKien.Image = (Image)resources.GetObject("btndeleteLiLinhKien.Image");
            btndeleteLiLinhKien.Name = "btndeleteLiLinhKien";
            btndeleteLiLinhKien.Size = new Size(55, 24);
            btndeleteLiLinhKien.Text = "Xóa";
            btndeleteLiLinhKien.Click += btndeleteLiLinhKien_Click;
            // 
            // dgvLinhKien
            // 
            dgvLinhKien.BackgroundColor = SystemColors.Control;
            dgvLinhKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinhKien.Columns.AddRange(new DataGridViewColumn[] { ID_linh_kien, Ten_linh_kien, Loai_linh_kien, Gia_nhap, Gia_ban, So_luong_ton_kho });
            dgvLinhKien.Dock = DockStyle.Fill;
            dgvLinhKien.Location = new Point(0, 27);
            dgvLinhKien.Name = "dgvLinhKien";
            dgvLinhKien.RowHeadersWidth = 51;
            dgvLinhKien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinhKien.Size = new Size(935, 485);
            dgvLinhKien.TabIndex = 4;
            // 
            // ID_linh_kien
            // 
            ID_linh_kien.DataPropertyName = "ID_linh_kien";
            ID_linh_kien.HeaderText = "Mã linh kiện";
            ID_linh_kien.MinimumWidth = 6;
            ID_linh_kien.Name = "ID_linh_kien";
            ID_linh_kien.Width = 125;
            // 
            // Ten_linh_kien
            // 
            Ten_linh_kien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten_linh_kien.DataPropertyName = "Ten_linh_kien";
            Ten_linh_kien.HeaderText = "Tên linh kiện";
            Ten_linh_kien.MinimumWidth = 6;
            Ten_linh_kien.Name = "Ten_linh_kien";
            // 
            // Loai_linh_kien
            // 
            Loai_linh_kien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Loai_linh_kien.DataPropertyName = "Loai_linh_kien";
            Loai_linh_kien.HeaderText = "Loại linh kiện";
            Loai_linh_kien.MinimumWidth = 6;
            Loai_linh_kien.Name = "Loai_linh_kien";
            // 
            // Gia_nhap
            // 
            Gia_nhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gia_nhap.DataPropertyName = "Gia_nhap";
            Gia_nhap.HeaderText = "Giá nhập";
            Gia_nhap.MinimumWidth = 6;
            Gia_nhap.Name = "Gia_nhap";
            // 
            // Gia_ban
            // 
            Gia_ban.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gia_ban.DataPropertyName = "Gia_ban";
            Gia_ban.HeaderText = "Giá bán";
            Gia_ban.MinimumWidth = 6;
            Gia_ban.Name = "Gia_ban";
            // 
            // So_luong_ton_kho
            // 
            So_luong_ton_kho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            So_luong_ton_kho.DataPropertyName = "So_luong_ton_kho";
            So_luong_ton_kho.HeaderText = "Số lượng tồn kho";
            So_luong_ton_kho.MinimumWidth = 6;
            So_luong_ton_kho.Name = "So_luong_ton_kho";
            // 
            // UcLinhKien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLinhKien);
            Controls.Add(toolStrip1);
            Name = "UcLinhKien";
            Size = new Size(935, 512);
            Load += UcLinhKien_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLinhKien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStriptxtSearch4;
        private ToolStripButton toolStripbtnSearch4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnAddLinhKien;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnEditLinhKien;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btndeleteLiLinhKien;
        private DataGridView dgvLinhKien;
        private DataGridViewTextBoxColumn ID_linh_kien;
        private DataGridViewTextBoxColumn Ten_linh_kien;
        private DataGridViewTextBoxColumn Loai_linh_kien;
        private DataGridViewTextBoxColumn Gia_nhap;
        private DataGridViewTextBoxColumn Gia_ban;
        private DataGridViewTextBoxColumn So_luong_ton_kho;
    }
}
