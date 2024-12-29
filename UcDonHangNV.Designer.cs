namespace QLDVSC
{
    partial class UcDonHangNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDonHangNV));
            dgvDonSuaChua = new DataGridView();
            colCapNhat = new DataGridViewButtonColumn();
            toolStrip1 = new ToolStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDonSuaChua).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDonSuaChua
            // 
            dgvDonSuaChua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonSuaChua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonSuaChua.Columns.AddRange(new DataGridViewColumn[] { colCapNhat });
            dgvDonSuaChua.Dock = DockStyle.Fill;
            dgvDonSuaChua.Location = new Point(0, 27);
            dgvDonSuaChua.Name = "dgvDonSuaChua";
            dgvDonSuaChua.RowHeadersWidth = 51;
            dgvDonSuaChua.Size = new Size(640, 423);
            dgvDonSuaChua.TabIndex = 0;
            dgvDonSuaChua.CellContentClick += dgvDonSuaChua_CellContentClick;
            // 
            // colCapNhat
            // 
            colCapNhat.HeaderText = "Cập nhật";
            colCapNhat.MinimumWidth = 6;
            colCapNhat.Name = "colCapNhat";
            colCapNhat.Text = "Cập nhật";
            colCapNhat.UseColumnTextForButtonValue = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripButton1, toolStripSeparator1, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(640, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(250, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(155, 24);
            toolStripLabel1.Text = "Cập nhật đơn hàng";
            // 
            // UcDonHangNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDonSuaChua);
            Controls.Add(toolStrip1);
            Name = "UcDonHangNV";
            Size = new Size(640, 450);
            Load += UcDonHangNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonSuaChua).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDonSuaChua;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridViewButtonColumn colCapNhat;
    }
}
