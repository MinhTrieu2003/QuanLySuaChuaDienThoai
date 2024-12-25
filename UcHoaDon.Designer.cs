namespace QLDVSC
{
    partial class UcHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;

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
            btnXoaHoaDon = new Button();
            dataGridView1 = new DataGridView();
            txtMaHoaDon = new TextBox();
            btnInHoaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Location = new Point(418, 5);
            btnXoaHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(133, 35);
            btnXoaHoaDon.TabIndex = 3;
            btnXoaHoaDon.Text = "Xoá Hóa Đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 97);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1103, 430);
            dataGridView1.TabIndex = 0;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(4, 5);
            txtMaHoaDon.Margin = new Padding(4, 5, 4, 5);
            txtMaHoaDon.Multiline = true;
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.PlaceholderText = "Nhập mã hóa đơn...";
            txtMaHoaDon.Size = new Size(265, 35);
            txtMaHoaDon.TabIndex = 1;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(277, 5);
            btnInHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(133, 35);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // UcHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoaHoaDon);
            Controls.Add(dataGridView1);
            Controls.Add(txtMaHoaDon);
            Controls.Add(btnInHoaDon);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UcHoaDon";
            Size = new Size(1103, 527);
            Load += UcHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
