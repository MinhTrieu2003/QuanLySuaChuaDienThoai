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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTiepNhan));
            dgvPhieuTiepNhan = new DataGridView();
            toolStrip1 = new ToolStrip();
            txtSearchPhieuTiepNhan = new ToolStripTextBox();
            btnSearchPhieuSuaChua = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btnXuatPhieuTiepNhan = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnXoaPhieuTiepNhan = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTiepNhan).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuTiepNhan
            // 
            dgvPhieuTiepNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuTiepNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuTiepNhan.Dock = DockStyle.Fill;
            dgvPhieuTiepNhan.Location = new Point(0, 27);
            dgvPhieuTiepNhan.Margin = new Padding(3, 4, 3, 4);
            dgvPhieuTiepNhan.Name = "dgvPhieuTiepNhan";
            dgvPhieuTiepNhan.RowHeadersWidth = 51;
            dgvPhieuTiepNhan.Size = new Size(1127, 464);
            dgvPhieuTiepNhan.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtSearchPhieuTiepNhan, btnSearchPhieuSuaChua, toolStripSeparator1, btnXuatPhieuTiepNhan, toolStripSeparator2, btnXoaPhieuTiepNhan });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1127, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchPhieuTiepNhan
            // 
            txtSearchPhieuTiepNhan.Name = "txtSearchPhieuTiepNhan";
            txtSearchPhieuTiepNhan.Size = new Size(300, 27);
            // 
            // btnSearchPhieuSuaChua
            // 
            btnSearchPhieuSuaChua.Image = (Image)resources.GetObject("btnSearchPhieuSuaChua.Image");
            btnSearchPhieuSuaChua.Name = "btnSearchPhieuSuaChua";
            btnSearchPhieuSuaChua.Size = new Size(20, 24);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnXuatPhieuTiepNhan
            // 
            btnXuatPhieuTiepNhan.Image = (Image)resources.GetObject("btnXuatPhieuTiepNhan.Image");
            btnXuatPhieuTiepNhan.Name = "btnXuatPhieuTiepNhan";
            btnXuatPhieuTiepNhan.Size = new Size(100, 24);
            btnXuatPhieuTiepNhan.Text = "Xuất phiếu";
            btnXuatPhieuTiepNhan.Click += btnXuatPhieuTiepNhan_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnXoaPhieuTiepNhan
            // 
            btnXoaPhieuTiepNhan.Image = (Image)resources.GetObject("btnXoaPhieuTiepNhan.Image");
            btnXoaPhieuTiepNhan.Name = "btnXoaPhieuTiepNhan";
            btnXoaPhieuTiepNhan.Size = new Size(59, 24);
            btnXoaPhieuTiepNhan.Text = "Xóa ";
            btnXoaPhieuTiepNhan.Click += btnXoaPhieuTiepNhan_Click;
            // 
            // UcTiepNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPhieuTiepNhan);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcTiepNhan";
            Size = new Size(1127, 491);
            Load += UcTiepNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTiepNhan).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhieuTiepNhan;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtSearchPhieuTiepNhan;
        private ToolStripLabel btnSearchPhieuSuaChua;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnXuatPhieuTiepNhan;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnXoaPhieuTiepNhan;
    }
}
