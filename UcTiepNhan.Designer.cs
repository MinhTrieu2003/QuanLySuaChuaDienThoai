namespace QLDVSC
{
    partial class UcTiepNhan
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
            dgvPhieuTiepNhan = new DataGridView();
            btnLoadData = new Button();
            btnSearchPhieuTiepNhan = new Button();
            txtSearchPhieuTiepNhan = new TextBox();
            btnXuatPhieuTiepNhan = new Button();
            label1 = new Label();
            btnXoaPhieuTiepNhan = new Button();
            btnTaoPhieuTiepNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTiepNhan).BeginInit();
            SuspendLayout();
            // 
            // dgvPhieuTiepNhan
            // 
            dgvPhieuTiepNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuTiepNhan.Location = new Point(14, 113);
            dgvPhieuTiepNhan.Name = "dgvPhieuTiepNhan";
            dgvPhieuTiepNhan.Size = new Size(902, 398);
            dgvPhieuTiepNhan.TabIndex = 0;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(814, 67);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(102, 23);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Tải Dữ liệu";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSearchPhieuTiepNhan
            // 
            btnSearchPhieuTiepNhan.Location = new Point(14, 67);
            btnSearchPhieuTiepNhan.Name = "btnSearchPhieuTiepNhan";
            btnSearchPhieuTiepNhan.Size = new Size(110, 23);
            btnSearchPhieuTiepNhan.TabIndex = 2;
            btnSearchPhieuTiepNhan.Text = "Search by ID";
            btnSearchPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnSearchPhieuTiepNhan.Click += btnSearchPhieuTiepNhan_Click;
            // 
            // txtSearchPhieuTiepNhan
            // 
            txtSearchPhieuTiepNhan.Location = new Point(130, 68);
            txtSearchPhieuTiepNhan.Name = "txtSearchPhieuTiepNhan";
            txtSearchPhieuTiepNhan.Size = new Size(69, 23);
            txtSearchPhieuTiepNhan.TabIndex = 3;
            txtSearchPhieuTiepNhan.TextChanged += txtSearchPhieuTiepNhan_TextChanged;
            // 
            // btnXuatPhieuTiepNhan
            // 
            btnXuatPhieuTiepNhan.Location = new Point(615, 67);
            btnXuatPhieuTiepNhan.Name = "btnXuatPhieuTiepNhan";
            btnXuatPhieuTiepNhan.Size = new Size(143, 23);
            btnXuatPhieuTiepNhan.TabIndex = 4;
            btnXuatPhieuTiepNhan.Text = "Xuất phiếu tiếp nhận";
            btnXuatPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnXuatPhieuTiepNhan.Click += btnXuatPhieuTiepNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 10);
            label1.Name = "label1";
            label1.Size = new Size(214, 24);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ TIẾP NHẬN";
            // 
            // btnXoaPhieuTiepNhan
            // 
            btnXoaPhieuTiepNhan.Location = new Point(413, 67);
            btnXoaPhieuTiepNhan.Name = "btnXoaPhieuTiepNhan";
            btnXoaPhieuTiepNhan.Size = new Size(152, 23);
            btnXoaPhieuTiepNhan.TabIndex = 8;
            btnXoaPhieuTiepNhan.Text = "Xóa phiếu tiếp nhận";
            btnXoaPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnXoaPhieuTiepNhan.Click += btnXoaPhieuTiepNhan_Click;
            // 
            // btnTaoPhieuTiepNhan
            // 
            btnTaoPhieuTiepNhan.Location = new Point(230, 67);
            btnTaoPhieuTiepNhan.Name = "btnTaoPhieuTiepNhan";
            btnTaoPhieuTiepNhan.Size = new Size(149, 23);
            btnTaoPhieuTiepNhan.TabIndex = 9;
            btnTaoPhieuTiepNhan.Text = "Tạo phiếu tiếp nhận";
            btnTaoPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnTaoPhieuTiepNhan.Click += btnTaoPhieuTiepNhan_Click_1;
            // 
            // UcTiepNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTaoPhieuTiepNhan);
            Controls.Add(btnXoaPhieuTiepNhan);
            Controls.Add(label1);
            Controls.Add(btnXuatPhieuTiepNhan);
            Controls.Add(txtSearchPhieuTiepNhan);
            Controls.Add(btnSearchPhieuTiepNhan);
            Controls.Add(btnLoadData);
            Controls.Add(dgvPhieuTiepNhan);
            Name = "UcTiepNhan";
            Size = new Size(986, 430);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTiepNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhieuTiepNhan;
        private Button btnLoadData;
        private Button btnSearchPhieuTiepNhan;
        private TextBox txtSearchPhieuTiepNhan;
        private Button btnXuatPhieuTiepNhan;
        private Label label1;
        private Button btnXoaPhieuTiepNhan;
        private Button btnTaoPhieuTiepNhan;
    }
}
