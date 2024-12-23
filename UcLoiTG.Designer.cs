namespace QLDVSC
{
    partial class UcLoiTG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLoiTG));
            toolStrip1 = new ToolStrip();
            toolStriptxtSearch5 = new ToolStripTextBox();
            toolStriptxtSearch6 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddLoi = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditLoi = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnEditLLoi = new ToolStripLabel();
            dgvLoiTG = new DataGridView();
            ID_Loi = new DataGridViewTextBoxColumn();
            Mo_ta_loi = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoiTG).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStriptxtSearch5, toolStriptxtSearch6, toolStripSeparator1, btnAddLoi, toolStripSeparator2, btnEditLoi, toolStripSeparator3, btnEditLLoi });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(942, 27);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStriptxtSearch5
            // 
            toolStriptxtSearch5.Name = "toolStriptxtSearch5";
            toolStriptxtSearch5.Size = new Size(300, 27);
            // 
            // toolStriptxtSearch6
            // 
            toolStriptxtSearch6.BackgroundImage = (Image)resources.GetObject("toolStriptxtSearch6.BackgroundImage");
            toolStriptxtSearch6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStriptxtSearch6.Image = (Image)resources.GetObject("toolStriptxtSearch6.Image");
            toolStriptxtSearch6.ImageTransparentColor = Color.Magenta;
            toolStriptxtSearch6.Name = "toolStriptxtSearch6";
            toolStriptxtSearch6.Size = new Size(29, 24);
            toolStriptxtSearch6.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAddLoi
            // 
            btnAddLoi.Image = (Image)resources.GetObject("btnAddLoi.Image");
            btnAddLoi.Name = "btnAddLoi";
            btnAddLoi.Size = new Size(96, 24);
            btnAddLoi.Text = "Thêm mới";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditLoi
            // 
            btnEditLoi.Image = (Image)resources.GetObject("btnEditLoi.Image");
            btnEditLoi.Name = "btnEditLoi";
            btnEditLoi.Size = new Size(54, 24);
            btnEditLoi.Text = "Sửa";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnEditLLoi
            // 
            btnEditLLoi.Image = (Image)resources.GetObject("btnEditLLoi.Image");
            btnEditLLoi.Name = "btnEditLLoi";
            btnEditLLoi.Size = new Size(55, 24);
            btnEditLLoi.Text = "Xóa";
            // 
            // dgvLoiTG
            // 
            dgvLoiTG.BackgroundColor = SystemColors.Control;
            dgvLoiTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoiTG.Columns.AddRange(new DataGridViewColumn[] { ID_Loi, Mo_ta_loi });
            dgvLoiTG.Dock = DockStyle.Fill;
            dgvLoiTG.Location = new Point(0, 27);
            dgvLoiTG.Name = "dgvLoiTG";
            dgvLoiTG.RowHeadersWidth = 51;
            dgvLoiTG.Size = new Size(942, 477);
            dgvLoiTG.TabIndex = 5;
            // 
            // ID_Loi
            // 
            ID_Loi.DataPropertyName = "ID_Loi";
            ID_Loi.HeaderText = "Mã lỗi";
            ID_Loi.MinimumWidth = 6;
            ID_Loi.Name = "ID_Loi";
            ID_Loi.Width = 125;
            // 
            // Mo_ta_loi
            // 
            Mo_ta_loi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mo_ta_loi.DataPropertyName = "Mo_ta_loi";
            Mo_ta_loi.HeaderText = "Mô tả lỗi";
            Mo_ta_loi.MinimumWidth = 6;
            Mo_ta_loi.Name = "Mo_ta_loi";
            // 
            // UcLoiTG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLoiTG);
            Controls.Add(toolStrip1);
            Name = "UcLoiTG";
            Size = new Size(942, 504);
            Load += UcLoiTG_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoiTG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStriptxtSearch5;
        private ToolStripButton toolStriptxtSearch6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnAddLoi;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnEditLoi;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel btnEditLLoi;
        private DataGridView dgvLoiTG;
        private DataGridViewTextBoxColumn ID_Loi;
        private DataGridViewTextBoxColumn Mo_ta_loi;
    }
}
