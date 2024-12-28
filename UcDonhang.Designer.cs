namespace QLDVSC
{
    partial class UcDonhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDonhang));
            dataGridView1 = new DataGridView();
            IDPhieuSuaChua = new DataGridViewTextBoxColumn();
            NgayTiepNhan = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenThietBi = new DataGridViewTextBoxColumn();
            MoTaLoi = new DataGridViewTextBoxColumn();
            TinhTrangSuaChua = new DataGridViewTextBoxColumn();
            NhanVienSuaChua = new DataGridViewTextBoxColumn();
            TenDichVu = new DataGridViewTextBoxColumn();
            SoLuongLinhKien = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            txtSearch0 = new ToolStripTextBox();
            btnSearch0 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCapNhatTT = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnXuatPhieu = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnXoaPhieu = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDPhieuSuaChua, NgayTiepNhan, TenKhachHang, SoDienThoai, TenThietBi, MoTaLoi, TinhTrangSuaChua, NhanVienSuaChua, TenDichVu, SoLuongLinhKien, GiaTien });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1108, 461);
            dataGridView1.TabIndex = 0;
            // 
            // IDPhieuSuaChua
            // 
            IDPhieuSuaChua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDPhieuSuaChua.DataPropertyName = "IDPhieuSuaChua";
            IDPhieuSuaChua.HeaderText = "ID Phiếu Sửa Chữa";
            IDPhieuSuaChua.MinimumWidth = 6;
            IDPhieuSuaChua.Name = "IDPhieuSuaChua";
            // 
            // NgayTiepNhan
            // 
            NgayTiepNhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            NgayTiepNhan.HeaderText = "Ngày tiếp nhận";
            NgayTiepNhan.MinimumWidth = 6;
            NgayTiepNhan.Name = "NgayTiepNhan";
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenThietBi
            // 
            TenThietBi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThietBi.DataPropertyName = "TenThietBi";
            TenThietBi.HeaderText = "Tên thiết bị";
            TenThietBi.MinimumWidth = 6;
            TenThietBi.Name = "TenThietBi";
            // 
            // MoTaLoi
            // 
            MoTaLoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MoTaLoi.DataPropertyName = "MoTaLoi";
            MoTaLoi.HeaderText = "Mô tả lỗi";
            MoTaLoi.MinimumWidth = 6;
            MoTaLoi.Name = "MoTaLoi";
            // 
            // TinhTrangSuaChua
            // 
            TinhTrangSuaChua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TinhTrangSuaChua.DataPropertyName = "TinhTrangSuaChua";
            TinhTrangSuaChua.HeaderText = "Tình trạng sửa chữa";
            TinhTrangSuaChua.MinimumWidth = 6;
            TinhTrangSuaChua.Name = "TinhTrangSuaChua";
            TinhTrangSuaChua.Resizable = DataGridViewTriState.True;
            TinhTrangSuaChua.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NhanVienSuaChua
            // 
            NhanVienSuaChua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NhanVienSuaChua.DataPropertyName = "NhanVienSuaChua";
            NhanVienSuaChua.HeaderText = "Nhân viên sửa chữa";
            NhanVienSuaChua.MinimumWidth = 6;
            NhanVienSuaChua.Name = "NhanVienSuaChua";
            // 
            // TenDichVu
            // 
            TenDichVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenDichVu.DataPropertyName = "TenDichVu";
            TenDichVu.HeaderText = "Tên dịch vụ";
            TenDichVu.MinimumWidth = 6;
            TenDichVu.Name = "TenDichVu";
            // 
            // SoLuongLinhKien
            // 
            SoLuongLinhKien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuongLinhKien.DataPropertyName = "SoLuongLinhKien";
            SoLuongLinhKien.HeaderText = "Số lượng linh kiện";
            SoLuongLinhKien.MinimumWidth = 6;
            SoLuongLinhKien.Name = "SoLuongLinhKien";
            // 
            // GiaTien
            // 
            GiaTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaTien.DataPropertyName = "GiaTien";
            GiaTien.HeaderText = "Thành Tiền";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtSearch0, btnSearch0, toolStripSeparator1, btnCapNhatTT, toolStripSeparator2, btnXuatPhieu, toolStripSeparator3, btnXoaPhieu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1108, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtSearch0
            // 
            txtSearch0.Name = "txtSearch0";
            txtSearch0.Size = new Size(250, 27);
            // 
            // btnSearch0
            // 
            btnSearch0.Image = (Image)resources.GetObject("btnSearch0.Image");
            btnSearch0.Name = "btnSearch0";
            btnSearch0.Size = new Size(20, 24);
            btnSearch0.Click += btnSearch0_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCapNhatTT
            // 
            btnCapNhatTT.Image = (Image)resources.GetObject("btnCapNhatTT.Image");
            btnCapNhatTT.Name = "btnCapNhatTT";
            btnCapNhatTT.Size = new Size(160, 24);
            btnCapNhatTT.Text = "Cập nhật trạng thái ";
            btnCapNhatTT.Click += btnCapNhatTT_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnXuatPhieu
            // 
            btnXuatPhieu.Image = (Image)resources.GetObject("btnXuatPhieu.Image");
            btnXuatPhieu.Name = "btnXuatPhieu";
            btnXuatPhieu.Size = new Size(100, 24);
            btnXuatPhieu.Text = "Xuất phiếu";
            btnXuatPhieu.Click += btnXuatPhieu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnXoaPhieu
            // 
            btnXoaPhieu.Image = (Image)resources.GetObject("btnXoaPhieu.Image");
            btnXoaPhieu.Name = "btnXoaPhieu";
            btnXoaPhieu.Size = new Size(96, 24);
            btnXoaPhieu.Text = "Xóa phiếu";
            btnXoaPhieu.Click += btnXoaPhieu_Click;
            // 
            // UcDonhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcDonhang";
            Size = new Size(1108, 488);
            Load += UcDonhang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtSearch0;
        private ToolStripLabel btnSearch0;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnCapNhatTT;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnXuatPhieu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btnXoaPhieu;
        private DataGridViewTextBoxColumn IDPhieuSuaChua;
        private DataGridViewTextBoxColumn NgayTiepNhan;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenThietBi;
        private DataGridViewTextBoxColumn MoTaLoi;
        private DataGridViewTextBoxColumn TinhTrangSuaChua;
        private DataGridViewTextBoxColumn NhanVienSuaChua;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn SoLuongLinhKien;
        private DataGridViewTextBoxColumn GiaTien;
    }
}
