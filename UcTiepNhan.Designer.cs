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
            dgvPhieuTiepNhan.Location = new Point(16, 138);
            dgvPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            dgvPhieuTiepNhan.Name = "dgvPhieuTiepNhan";
            dgvPhieuTiepNhan.RowHeadersWidth = 51;
            dgvPhieuTiepNhan.Size = new Size(1094, 349);
            dgvPhieuTiepNhan.TabIndex = 0;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(750, 89);
            btnLoadData.Margin = new Padding(3, 4, 3, 4);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(117, 31);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Tải Dữ liệu";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSearchPhieuTiepNhan
            // 
            btnSearchPhieuTiepNhan.Location = new Point(100, 89);
            btnSearchPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            btnSearchPhieuTiepNhan.Name = "btnSearchPhieuTiepNhan";
            btnSearchPhieuTiepNhan.Size = new Size(112, 31);
            btnSearchPhieuTiepNhan.TabIndex = 2;
            btnSearchPhieuTiepNhan.Text = "Search by ID";
            btnSearchPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnSearchPhieuTiepNhan.Click += btnSearchPhieuTiepNhan_Click;
            // 
            // txtSearchPhieuTiepNhan
            // 
            txtSearchPhieuTiepNhan.Location = new Point(16, 89);
            txtSearchPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            txtSearchPhieuTiepNhan.Multiline = true;
            txtSearchPhieuTiepNhan.Name = "txtSearchPhieuTiepNhan";
            txtSearchPhieuTiepNhan.Size = new Size(78, 31);
            txtSearchPhieuTiepNhan.TabIndex = 3;
            txtSearchPhieuTiepNhan.TextChanged += txtSearchPhieuTiepNhan_TextChanged;
            // 
            // btnXuatPhieuTiepNhan
            // 
            btnXuatPhieuTiepNhan.Location = new Point(581, 89);
            btnXuatPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            btnXuatPhieuTiepNhan.Name = "btnXuatPhieuTiepNhan";
            btnXuatPhieuTiepNhan.Size = new Size(163, 31);
            btnXuatPhieuTiepNhan.TabIndex = 4;
            btnXuatPhieuTiepNhan.Text = "Xuất phiếu tiếp nhận";
            btnXuatPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnXuatPhieuTiepNhan.Click += btnXuatPhieuTiepNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 31);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ TIẾP NHẬN";
            // 
            // btnXoaPhieuTiepNhan
            // 
            btnXoaPhieuTiepNhan.Location = new Point(401, 89);
            btnXoaPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            btnXoaPhieuTiepNhan.Name = "btnXoaPhieuTiepNhan";
            btnXoaPhieuTiepNhan.Size = new Size(174, 31);
            btnXoaPhieuTiepNhan.TabIndex = 8;
            btnXoaPhieuTiepNhan.Text = "Xóa phiếu tiếp nhận";
            btnXoaPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnXoaPhieuTiepNhan.Click += btnXoaPhieuTiepNhan_Click;
            // 
            // btnTaoPhieuTiepNhan
            // 
            btnTaoPhieuTiepNhan.Location = new Point(218, 89);
            btnTaoPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            btnTaoPhieuTiepNhan.Name = "btnTaoPhieuTiepNhan";
            btnTaoPhieuTiepNhan.Size = new Size(170, 31);
            btnTaoPhieuTiepNhan.TabIndex = 9;
            btnTaoPhieuTiepNhan.Text = "Tạo phiếu tiếp nhận";
            btnTaoPhieuTiepNhan.UseVisualStyleBackColor = true;
            btnTaoPhieuTiepNhan.Click += btnTaoPhieuTiepNhan_Click_1;
            // 
            // UcTiepNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTaoPhieuTiepNhan);
            Controls.Add(btnXoaPhieuTiepNhan);
            Controls.Add(label1);
            Controls.Add(btnXuatPhieuTiepNhan);
            Controls.Add(txtSearchPhieuTiepNhan);
            Controls.Add(btnSearchPhieuTiepNhan);
            Controls.Add(btnLoadData);
            Controls.Add(dgvPhieuTiepNhan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcTiepNhan";
            Size = new Size(1127, 491);
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
