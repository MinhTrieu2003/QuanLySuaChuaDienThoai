namespace QLDVSC
{
    partial class UcHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHoaDon));
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            txtMaHoaDon = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnInHoaDon = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnXoaHoaDon = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1103, 527);
            dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtMaHoaDon, toolStripSeparator1, btnInHoaDon, toolStripSeparator2, btnXoaHoaDon });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1103, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(300, 27);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(100, 24);
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Image = (Image)resources.GetObject("btnXoaHoaDon.Image");
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(114, 24);
            btnXoaHoaDon.Text = "Xóa hóa đơn";
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // UcHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UcHoaDon";
            Size = new Size(1103, 527);
            Load += UcHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStrip toolStrip1;
        private ToolStripTextBox txtMaHoaDon;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnInHoaDon;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel btnXoaHoaDon;
    }
}
