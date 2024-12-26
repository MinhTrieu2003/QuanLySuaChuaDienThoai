namespace QLDVSC
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thiếtBịToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            hoaDonToolStripMenuItem = new ToolStripMenuItem();
            baoCaoToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            tIẾPNHẬNToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, kháchHàngToolStripMenuItem, thiếtBịToolStripMenuItem, đơnHàngToolStripMenuItem, hoaDonToolStripMenuItem, baoCaoToolStripMenuItem, tIẾPNHẬNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1238, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(78, 20);
            hệThốngToolStripMenuItem.Text = "HỆ THỐNG";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(97, 20);
            kháchHàngToolStripMenuItem.Text = "KHÁCH HÀNG";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // thiếtBịToolStripMenuItem
            // 
            thiếtBịToolStripMenuItem.Name = "thiếtBịToolStripMenuItem";
            thiếtBịToolStripMenuItem.Size = new Size(62, 20);
            thiếtBịToolStripMenuItem.Text = "THIẾT BỊ";
            thiếtBịToolStripMenuItem.Click += thiếtBịToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(82, 20);
            đơnHàngToolStripMenuItem.Text = "ĐƠN HÀNG";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // hoaDonToolStripMenuItem
            // 
            hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            hoaDonToolStripMenuItem.Size = new Size(74, 20);
            hoaDonToolStripMenuItem.Text = "HÓA ĐƠN";
            hoaDonToolStripMenuItem.Click += hoaDonToolStripMenuItem_Click;
            // 
            // baoCaoToolStripMenuItem
            // 
            baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            baoCaoToolStripMenuItem.Size = new Size(71, 20);
            baoCaoToolStripMenuItem.Text = "BÁO CÁO";
            baoCaoToolStripMenuItem.Click += baoCaoToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1238, 488);
            mainPanel.TabIndex = 4;
            // 
            // tIẾPNHẬNToolStripMenuItem
            // 
            tIẾPNHẬNToolStripMenuItem.Name = "tIẾPNHẬNToolStripMenuItem";
            tIẾPNHẬNToolStripMenuItem.Size = new Size(79, 20);
            tIẾPNHẬNToolStripMenuItem.Text = "TIẾP NHẬN";
            tIẾPNHẬNToolStripMenuItem.Click += tIẾPNHẬNToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 512);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ quản lý sửa chữa";
            Load += MainForm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thiếtBịToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem hoaDonToolStripMenuItem;
        private ToolStripMenuItem baoCaoToolStripMenuItem;
        private Panel mainPanel;
        private ToolStripMenuItem tIẾPNHẬNToolStripMenuItem;
    }
}
