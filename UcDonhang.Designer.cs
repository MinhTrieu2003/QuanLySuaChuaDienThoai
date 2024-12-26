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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSuaTinhTrang = new Button();
            btnXuatPhieuSuaChua = new Button();
            label1 = new Label();
            btnXoaPhieuSuaChua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDPhieuSuaChua, NgayTiepNhan, TenKhachHang, SoDienThoai, TenThietBi, MoTaLoi, TinhTrangSuaChua, NhanVienSuaChua, TenDichVu, SoLuongLinhKien, GiaTien });
            dataGridView1.Location = new Point(20, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1184, 345);
            dataGridView1.TabIndex = 0;
            // 
            // IDPhieuSuaChua
            // 
            IDPhieuSuaChua.DataPropertyName = "IDPhieuSuaChua";
            IDPhieuSuaChua.HeaderText = "ID Phiếu Sửa Chữa";
            IDPhieuSuaChua.Name = "IDPhieuSuaChua";
            // 
            // NgayTiepNhan
            // 
            NgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            NgayTiepNhan.HeaderText = "Ngày tiếp nhận";
            NgayTiepNhan.Name = "NgayTiepNhan";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.Name = "TenKhachHang";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenThietBi
            // 
            TenThietBi.DataPropertyName = "TenThietBi";
            TenThietBi.HeaderText = "Tên thiết bị";
            TenThietBi.Name = "TenThietBi";
            // 
            // MoTaLoi
            // 
            MoTaLoi.DataPropertyName = "MoTaLoi";
            MoTaLoi.HeaderText = "Mô tả lỗi";
            MoTaLoi.Name = "MoTaLoi";
            // 
            // TinhTrangSuaChua
            // 
            TinhTrangSuaChua.DataPropertyName = "TinhTrangSuaChua";
            TinhTrangSuaChua.HeaderText = "Tình trạng sửa chữa";
            TinhTrangSuaChua.Name = "TinhTrangSuaChua";
            TinhTrangSuaChua.Resizable = DataGridViewTriState.True;
            TinhTrangSuaChua.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NhanVienSuaChua
            // 
            NhanVienSuaChua.DataPropertyName = "NhanVienSuaChua";
            NhanVienSuaChua.HeaderText = "Nhân viên sửa chữa";
            NhanVienSuaChua.Name = "NhanVienSuaChua";
            // 
            // TenDichVu
            // 
            TenDichVu.DataPropertyName = "TenDichVu";
            TenDichVu.HeaderText = "Tên dịch vụ";
            TenDichVu.Name = "TenDichVu";
            // 
            // SoLuongLinhKien
            // 
            SoLuongLinhKien.DataPropertyName = "SoLuongLinhKien";
            SoLuongLinhKien.HeaderText = "Số lượng linh kiện";
            SoLuongLinhKien.Name = "SoLuongLinhKien";
            // 
            // GiaTien
            // 
            GiaTien.DataPropertyName = "GiaTien";
            GiaTien.HeaderText = "Thành Tiền";
            GiaTien.Name = "GiaTien";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(101, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(20, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // btnSuaTinhTrang
            // 
            btnSuaTinhTrang.Location = new Point(261, 61);
            btnSuaTinhTrang.Name = "btnSuaTinhTrang";
            btnSuaTinhTrang.Size = new Size(124, 23);
            btnSuaTinhTrang.TabIndex = 4;
            btnSuaTinhTrang.Text = "Sửa Tình Trạng ";
            btnSuaTinhTrang.UseVisualStyleBackColor = true;
            btnSuaTinhTrang.Click += btnSuaTinhTrang_Click;
            // 
            // btnXuatPhieuSuaChua
            // 
            btnXuatPhieuSuaChua.Location = new Point(616, 58);
            btnXuatPhieuSuaChua.Name = "btnXuatPhieuSuaChua";
            btnXuatPhieuSuaChua.Size = new Size(143, 25);
            btnXuatPhieuSuaChua.TabIndex = 5;
            btnXuatPhieuSuaChua.Text = "Xuất phiếu sửa chữa";
            btnXuatPhieuSuaChua.UseVisualStyleBackColor = true;
            btnXuatPhieuSuaChua.Click += btnXuatPhieuSuaChua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 6;
            label1.Text = "QUẢN LÝ SỬA CHỮA";
            label1.Click += label1_Click;
            // 
            // btnXoaPhieuSuaChua
            // 
            btnXoaPhieuSuaChua.Location = new Point(451, 61);
            btnXoaPhieuSuaChua.Name = "btnXoaPhieuSuaChua";
            btnXoaPhieuSuaChua.Size = new Size(133, 23);
            btnXoaPhieuSuaChua.TabIndex = 7;
            btnXoaPhieuSuaChua.Text = "Xóa phiếu sửa chữa";
            btnXoaPhieuSuaChua.UseVisualStyleBackColor = true;
            btnXoaPhieuSuaChua.Click += btnXoaPhieuSuaChua_Click;
            // 
            // UcDonhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoaPhieuSuaChua);
            Controls.Add(label1);
            Controls.Add(btnXuatPhieuSuaChua);
            Controls.Add(btnSuaTinhTrang);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "UcDonhang";
            Size = new Size(1093, 383);
            Load += UcDonhang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSuaTinhTrang;
        private Button btnXuatPhieuSuaChua;
        private Label label1;
        private Button btnXoaPhieuSuaChua;
    }
}
