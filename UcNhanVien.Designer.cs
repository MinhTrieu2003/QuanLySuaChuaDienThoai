namespace QLDVSC
{
    partial class UcNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNhanVien));
            toolStrip1 = new ToolStrip();
            toolStripTxtSearch2 = new ToolStripTextBox();
            toolStripbtnSearch2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddEmployee = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditEmployee = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDeleteEployee = new ToolStripLabel();
            dgvNhanVien = new DataGridView();
            ID_nhan_vien = new DataGridViewTextBoxColumn();
            Ho_ten = new DataGridViewTextBoxColumn();
            Vai_tro = new DataGridViewTextBoxColumn();
            Ten_dang_nhap = new DataGridViewTextBoxColumn();
            Mat_khau = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTxtSearch2, toolStripbtnSearch2, toolStripSeparator1, btnAddEmployee, toolStripSeparator2, btnEditEmployee, toolStripSeparator3, btnDeleteEployee });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(945, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTxtSearch2
            // 
            toolStripTxtSearch2.Name = "toolStripTxtSearch2";
            toolStripTxtSearch2.Size = new Size(300, 27);
            toolStripTxtSearch2.KeyDown += toolStripTxtSearch2_KeyDown;
            // 
            // toolStripbtnSearch2
            // 
            toolStripbtnSearch2.BackgroundImage = (Image)resources.GetObject("toolStripbtnSearch2.BackgroundImage");
            toolStripbtnSearch2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtnSearch2.Image = (Image)resources.GetObject("toolStripbtnSearch2.Image");
            toolStripbtnSearch2.ImageTransparentColor = Color.Magenta;
            toolStripbtnSearch2.Name = "toolStripbtnSearch2";
            toolStripbtnSearch2.Size = new Size(29, 24);
            toolStripbtnSearch2.Text = "toolStripButton1";
            toolStripbtnSearch2.Click += toolStripbtnSearch2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Image = (Image)resources.GetObject("btnAddEmployee.Image");
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(96, 24);
            btnAddEmployee.Text = "Thêm mới";
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Image = (Image)resources.GetObject("btnEditEmployee.Image");
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(54, 24);
            btnEditEmployee.Text = "Sửa";
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnDeleteEployee
            // 
            btnDeleteEployee.Image = (Image)resources.GetObject("btnDeleteEployee.Image");
            btnDeleteEployee.Name = "btnDeleteEployee";
            btnDeleteEployee.Size = new Size(55, 24);
            btnDeleteEployee.Text = "Xóa";
            btnDeleteEployee.Click += btnDeleteEployee_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.Control;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID_nhan_vien, Ho_ten, Vai_tro, Ten_dang_nhap, Mat_khau });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvNhanVien.Location = new Point(0, 27);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(945, 446);
            dgvNhanVien.TabIndex = 2;
            // 
            // ID_nhan_vien
            // 
            ID_nhan_vien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID_nhan_vien.DataPropertyName = "ID_nhan_vien";
            ID_nhan_vien.HeaderText = "Mã nhân viên";
            ID_nhan_vien.MinimumWidth = 6;
            ID_nhan_vien.Name = "ID_nhan_vien";
            ID_nhan_vien.ReadOnly = true;
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
            // Vai_tro
            // 
            Vai_tro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vai_tro.DataPropertyName = "Vai_tro";
            Vai_tro.HeaderText = "Vai trò";
            Vai_tro.MinimumWidth = 6;
            Vai_tro.Name = "Vai_tro";
            Vai_tro.ReadOnly = true;
            Vai_tro.Resizable = DataGridViewTriState.True;
            // 
            // Ten_dang_nhap
            // 
            Ten_dang_nhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten_dang_nhap.DataPropertyName = "Ten_dang_nhap";
            Ten_dang_nhap.HeaderText = "Tên đăng nhập";
            Ten_dang_nhap.MinimumWidth = 6;
            Ten_dang_nhap.Name = "Ten_dang_nhap";
            Ten_dang_nhap.ReadOnly = true;
            // 
            // Mat_khau
            // 
            Mat_khau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mat_khau.DataPropertyName = "Mat_khau";
            Mat_khau.HeaderText = "Mật khẩu";
            Mat_khau.MinimumWidth = 6;
            Mat_khau.Name = "Mat_khau";
            Mat_khau.ReadOnly = true;
            // 
            // UcNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNhanVien);
            Controls.Add(toolStrip1);
            Name = "UcNhanVien";
            Size = new Size(945, 473);
            Load += UcNhanVien_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTxtSearch2;
        private ToolStripButton toolStripbtnSearch2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnAddEmployee;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnEditEmployee;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btnDeleteEployee;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID_nhan_vien;
        private DataGridViewTextBoxColumn Ho_ten;
        private DataGridViewTextBoxColumn Vai_tro;
        private DataGridViewTextBoxColumn Ten_dang_nhap;
        private DataGridViewTextBoxColumn Mat_khau;
    }
}
