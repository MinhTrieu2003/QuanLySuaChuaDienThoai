
namespace QLDVSC
{
    partial class FormLichSuSuaChua
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
            dgvLichSuSuaChua = new DataGridView();
            ID_phieu_sua_chua = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Mo_ta_loi = new DataGridViewTextBoxColumn();
            Ten_dich_vu = new DataGridViewTextBoxColumn();
            Ten_linh_kien = new DataGridViewTextBoxColumn();
            Tong_tien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuSuaChua).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSuSuaChua
            // 
            dgvLichSuSuaChua.BackgroundColor = SystemColors.Menu;
            dgvLichSuSuaChua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuSuaChua.Columns.AddRange(new DataGridViewColumn[] { ID_phieu_sua_chua, Model, Mo_ta_loi, Ten_dich_vu, Ten_linh_kien, Tong_tien });
            dgvLichSuSuaChua.Dock = DockStyle.Fill;
            dgvLichSuSuaChua.Location = new Point(0, 0);
            dgvLichSuSuaChua.Name = "dgvLichSuSuaChua";
            dgvLichSuSuaChua.RowHeadersWidth = 51;
            dgvLichSuSuaChua.Size = new Size(1027, 299);
            dgvLichSuSuaChua.TabIndex = 0;
            // 
            // ID_phieu_sua_chua
            // 
            ID_phieu_sua_chua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID_phieu_sua_chua.DataPropertyName = "ID_phieu_sua_chua";
            ID_phieu_sua_chua.HeaderText = "Mã phiếu sửa chữa";
            ID_phieu_sua_chua.MinimumWidth = 6;
            ID_phieu_sua_chua.Name = "ID_phieu_sua_chua";
            // 
            // Model
            // 
            Model.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Model.DataPropertyName = "Model";
            Model.HeaderText = "Thiết bị";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            // 
            // Mo_ta_loi
            // 
            Mo_ta_loi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mo_ta_loi.DataPropertyName = "Mo_ta_loi";
            Mo_ta_loi.HeaderText = "Mô tả lỗi";
            Mo_ta_loi.MinimumWidth = 6;
            Mo_ta_loi.Name = "Mo_ta_loi";
            // 
            // Ten_dich_vu
            // 
            Ten_dich_vu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten_dich_vu.DataPropertyName = "Ten_dich_vu";
            Ten_dich_vu.HeaderText = "Dịch vụ";
            Ten_dich_vu.MinimumWidth = 6;
            Ten_dich_vu.Name = "Ten_dich_vu";
            // 
            // Ten_linh_kien
            // 
            Ten_linh_kien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten_linh_kien.DataPropertyName = "Ten_linh_kien";
            Ten_linh_kien.HeaderText = "Linh kiện";
            Ten_linh_kien.MinimumWidth = 6;
            Ten_linh_kien.Name = "Ten_linh_kien";
            // 
            // Tong_tien
            // 
            Tong_tien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tong_tien.DataPropertyName = "Tong_tien";
            Tong_tien.HeaderText = "Tổng tiền";
            Tong_tien.MinimumWidth = 6;
            Tong_tien.Name = "Tong_tien";
            // 
            // FormLichSuSuaChua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 299);
            Controls.Add(dgvLichSuSuaChua);
            Name = "FormLichSuSuaChua";
            Text = "Lịch sử sửa chữa";
            Load += FormLichSuSuaChua_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLichSuSuaChua).EndInit();
            ResumeLayout(false);
        }

        private void FormLichSuSuaChua_Load_3(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormLichSuSuaChua_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgvLichSuSuaChua;
        private DataGridViewTextBoxColumn ID_phieu_sua_chua;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Mo_ta_loi;
        private DataGridViewTextBoxColumn Ten_dich_vu;
        private DataGridViewTextBoxColumn Ten_linh_kien;
        private DataGridViewTextBoxColumn Tong_tien;
    }
}