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
            btnTaoPhieuTiepNhan = new Button();
            IDPhieuSuaChua = new DataGridViewTextBoxColumn();
            NgayTiepNhan = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenThietBi = new DataGridViewTextBoxColumn();
            MoTaLoi = new DataGridViewTextBoxColumn();
            TinhTrangSuaChua = new DataGridViewComboBoxColumn();
            NhanVienSuaChua = new DataGridViewTextBoxColumn();
            TenDichVu = new DataGridViewTextBoxColumn();
            SoLuongLinhKien = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDPhieuSuaChua, NgayTiepNhan, TenKhachHang, SoDienThoai, TenThietBi, MoTaLoi, TinhTrangSuaChua, NhanVienSuaChua, TenDichVu, SoLuongLinhKien, GiaTien });
            dataGridView1.Location = new Point(-64, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1184, 345);
            dataGridView1.TabIndex = 0;
            // 
            // btnTaoPhieuTiepNhan
            // 
            btnTaoPhieuTiepNhan.Location = new Point(20, 60);
            btnTaoPhieuTiepNhan.Name = "btnTaoPhieuTiepNhan";
            btnTaoPhieuTiepNhan.Size = new Size(149, 23);
            btnTaoPhieuTiepNhan.TabIndex = 1;
            btnTaoPhieuTiepNhan.Text = "Tạo phiếu tiếp nhận";
            btnTaoPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnTaoPhieuTiepNhan.Click += btnTaoPhieuTiepNhan_Click;
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
            // UcDonhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTaoPhieuTiepNhan);
            Controls.Add(dataGridView1);
            Name = "UcDonhang";
            Size = new Size(1093, 383);
            Load += UcDonhang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTaoPhieuTiepNhan;
        private DataGridViewTextBoxColumn IDPhieuSuaChua;
        private DataGridViewTextBoxColumn NgayTiepNhan;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenThietBi;
        private DataGridViewTextBoxColumn MoTaLoi;
        private DataGridViewComboBoxColumn TinhTrangSuaChua;
        private DataGridViewTextBoxColumn NhanVienSuaChua;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn SoLuongLinhKien;
        private DataGridViewTextBoxColumn GiaTien;
    }
}
