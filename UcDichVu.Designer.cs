namespace QLDVSC
{
    partial class UcDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDichVu));
            toolStrip1 = new ToolStrip();
            toolStriptxtSearch3 = new ToolStripTextBox();
            toolStripbtnSearch3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddDichVu = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditDichVu = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDeleteDichVu = new ToolStripLabel();
            dgvDichVu = new DataGridView();
            ID_dich_vu = new DataGridViewTextBoxColumn();
            Ten_dich_vu = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStriptxtSearch3, toolStripbtnSearch3, toolStripSeparator1, btnAddDichVu, toolStripSeparator2, btnEditDichVu, toolStripSeparator3, btnDeleteDichVu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(931, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStriptxtSearch3
            // 
            toolStriptxtSearch3.Name = "toolStriptxtSearch3";
            toolStriptxtSearch3.Size = new Size(300, 27);
            toolStriptxtSearch3.KeyDown += toolStriptxtSearch3_KeyDown;
            // 
            // toolStripbtnSearch3
            // 
            toolStripbtnSearch3.BackgroundImage = (Image)resources.GetObject("toolStripbtnSearch3.BackgroundImage");
            toolStripbtnSearch3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtnSearch3.Image = (Image)resources.GetObject("toolStripbtnSearch3.Image");
            toolStripbtnSearch3.ImageTransparentColor = Color.Magenta;
            toolStripbtnSearch3.Name = "toolStripbtnSearch3";
            toolStripbtnSearch3.Size = new Size(29, 24);
            toolStripbtnSearch3.Text = "toolStripButton1";
            toolStripbtnSearch3.Click += toolStripbtnSearch3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAddDichVu
            // 
            btnAddDichVu.Image = (Image)resources.GetObject("btnAddDichVu.Image");
            btnAddDichVu.Name = "btnAddDichVu";
            btnAddDichVu.Size = new Size(96, 24);
            btnAddDichVu.Text = "Thêm mới";
            btnAddDichVu.Click += btnAddDichVu_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditDichVu
            // 
            btnEditDichVu.Image = (Image)resources.GetObject("btnEditDichVu.Image");
            btnEditDichVu.Name = "btnEditDichVu";
            btnEditDichVu.Size = new Size(54, 24);
            btnEditDichVu.Text = "Sửa";
            btnEditDichVu.Click += btnEditDichVu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnDeleteDichVu
            // 
            btnDeleteDichVu.Image = (Image)resources.GetObject("btnDeleteDichVu.Image");
            btnDeleteDichVu.Name = "btnDeleteDichVu";
            btnDeleteDichVu.Size = new Size(55, 24);
            btnDeleteDichVu.Text = "Xóa";
            btnDeleteDichVu.Click += btnDeleteDichVu_Click;
            // 
            // dgvDichVu
            // 
            dgvDichVu.BackgroundColor = SystemColors.Control;
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Columns.AddRange(new DataGridViewColumn[] { ID_dich_vu, Ten_dich_vu, Gia });
            dgvDichVu.Dock = DockStyle.Fill;
            dgvDichVu.Location = new Point(0, 27);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.Size = new Size(931, 463);
            dgvDichVu.TabIndex = 3;
            // 
            // ID_dich_vu
            // 
            ID_dich_vu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID_dich_vu.DataPropertyName = "ID_dich_vu";
            ID_dich_vu.HeaderText = "Mã dịch vụ";
            ID_dich_vu.MinimumWidth = 6;
            ID_dich_vu.Name = "ID_dich_vu";
            ID_dich_vu.Width = 293;
            // 
            // Ten_dich_vu
            // 
            Ten_dich_vu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ten_dich_vu.DataPropertyName = "Ten_dich_vu";
            Ten_dich_vu.HeaderText = "Tên dịch vụ";
            Ten_dich_vu.MinimumWidth = 6;
            Ten_dich_vu.Name = "Ten_dich_vu";
            Ten_dich_vu.Width = 292;
            // 
            // Gia
            // 
            Gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.Width = 293;
            // 
            // UcDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDichVu);
            Controls.Add(toolStrip1);
            Name = "UcDichVu";
            Size = new Size(931, 490);
            Load += UcDichVu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStriptxtSearch3;
        private ToolStripButton toolStripbtnSearch3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnAddDichVu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnEditDichVu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btnDeleteDichVu;
        private DataGridView dgvDichVu;
        private DataGridViewTextBoxColumn ID_dich_vu;
        private DataGridViewTextBoxColumn Ten_dich_vu;
        private DataGridViewTextBoxColumn Gia;
    }
}
