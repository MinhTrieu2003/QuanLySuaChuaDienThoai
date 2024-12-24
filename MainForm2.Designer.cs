namespace QLDVSC
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            panel1 = new Panel();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripLabel1, toolStripSeparator2, toolStripSeparator3, toolStripLabel2, toolStripSeparator4, toolStripSeparator5, toolStripLabel3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(135, 450);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(133, 6);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(133, 20);
            toolStripLabel1.Text = "Đơn hàng";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(133, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(133, 6);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Image = (Image)resources.GetObject("toolStripLabel2.Image");
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(133, 20);
            toolStripLabel2.Text = "Tài khoản";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(133, 6);
            // 
            // panel1
            // 
            panel1.Location = new Point(138, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 385);
            panel1.TabIndex = 1;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(133, 6);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Image = (Image)resources.GetObject("toolStripLabel3.Image");
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(133, 20);
            toolStripLabel3.Text = "Thiết bị";
            // 
            // MainForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "MainForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ quản lý sửa chữa";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator4;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel3;
    }
}