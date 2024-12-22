namespace QLDVSC
{
    partial class UcKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcKhachHang));
            toolStrip1 = new ToolStrip();
            toolStripTxtSearch1 = new ToolStripTextBox();
            toolStripbtnSearch1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddCustomer = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditCustomer = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDeleteCustomer = new ToolStripLabel();
            dgvKhachHang = new DataGridView();
            ID_khach_hang = new DataGridViewTextBoxColumn();
            Ho_ten = new DataGridViewTextBoxColumn();
            So_dien_thoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Dia_chi = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTxtSearch1, toolStripbtnSearch1, toolStripSeparator1, btnAddCustomer, toolStripSeparator2, btnEditCustomer, toolStripSeparator3, btnDeleteCustomer });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1110, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTxtSearch1
            // 
            toolStripTxtSearch1.Name = "toolStripTxtSearch1";
            toolStripTxtSearch1.Size = new Size(300, 27);
            toolStripTxtSearch1.Enter += toolStripbtnSearch1_Click;
            toolStripTxtSearch1.KeyDown += toolStripTxtSearch1_KeyDown;
            // 
            // toolStripbtnSearch1
            // 
            toolStripbtnSearch1.BackgroundImage = (Image)resources.GetObject("toolStripbtnSearch1.BackgroundImage");
            toolStripbtnSearch1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtnSearch1.Image = (Image)resources.GetObject("toolStripbtnSearch1.Image");
            toolStripbtnSearch1.ImageTransparentColor = Color.Magenta;
            toolStripbtnSearch1.Name = "toolStripbtnSearch1";
            toolStripbtnSearch1.Size = new Size(29, 24);
            toolStripbtnSearch1.Text = "toolStripButton1";
            toolStripbtnSearch1.Click += toolStripbtnSearch1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Image = (Image)resources.GetObject("btnAddCustomer.Image");
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(96, 24);
            btnAddCustomer.Text = "Thêm mới";
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Image = (Image)resources.GetObject("btnEditCustomer.Image");
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(54, 24);
            btnEditCustomer.Text = "Sửa";
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Image = (Image)resources.GetObject("btnDeleteCustomer.Image");
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(55, 24);
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { ID_khach_hang, Ho_ten, So_dien_thoai, Email, Dia_chi });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvKhachHang.Location = new Point(0, 27);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1110, 385);
            dgvKhachHang.TabIndex = 1;
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
            // 
            // ID_khach_hang
            // 
            ID_khach_hang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID_khach_hang.DataPropertyName = "ID_khach_hang";
            ID_khach_hang.HeaderText = "Mã khách hàng";
            ID_khach_hang.MinimumWidth = 6;
            ID_khach_hang.Name = "ID_khach_hang";
            ID_khach_hang.ReadOnly = true;
            // 
            // Ho_ten
            // 
            Ho_ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ho_ten.DataPropertyName = "Ho_ten";
            Ho_ten.HeaderText = "Họ và tên";
            Ho_ten.MinimumWidth = 6;
            Ho_ten.Name = "Ho_ten";
            Ho_ten.ReadOnly = true;
            // 
            // So_dien_thoai
            // 
            So_dien_thoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            So_dien_thoai.DataPropertyName = "So_dien_thoai";
            So_dien_thoai.HeaderText = "Số điện thoại";
            So_dien_thoai.MinimumWidth = 6;
            So_dien_thoai.Name = "So_dien_thoai";
            So_dien_thoai.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Dia_chi
            // 
            Dia_chi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia_chi.DataPropertyName = "Dia_chi";
            Dia_chi.HeaderText = "Địa chỉ";
            Dia_chi.MinimumWidth = 6;
            Dia_chi.Name = "Dia_chi";
            Dia_chi.ReadOnly = true;
            // 
            // UcKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(dgvKhachHang);
            Controls.Add(toolStrip1);
            Name = "UcKhachHang";
            Size = new Size(1110, 412);
            Load += UcKhachHang_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTxtSearch1;
        private ToolStripButton toolStripbtnSearch1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnAddCustomer;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnEditCustomer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btnDeleteCustomer;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn ID_khach_hang;
        private DataGridViewTextBoxColumn Ho_ten;
        private DataGridViewTextBoxColumn So_dien_thoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Dia_chi;
    }
}
