namespace QLDVSC
{
    partial class FormCapNhatDonHang
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
            button1 = new Button();
            txtTongTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbTinhTrang = new ComboBox();
            clbDichVu = new CheckedListBox();
            clbLinhKien = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(252, 330);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCapNhat_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(94, 253);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(499, 27);
            txtTongTien.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "Tình trạng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Dịch vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(323, 98);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "Linh kiện";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 253);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "Tổng tiền";
            // 
            // cbTinhTrang
            // 
            cbTinhTrang.FormattingEnabled = true;
            cbTinhTrang.Location = new Point(94, 30);
            cbTinhTrang.Name = "cbTinhTrang";
            cbTinhTrang.Size = new Size(193, 28);
            cbTinhTrang.TabIndex = 10;
            // 
            // clbDichVu
            // 
            clbDichVu.FormattingEnabled = true;
            clbDichVu.Location = new Point(94, 98);
            clbDichVu.Name = "clbDichVu";
            clbDichVu.Size = new Size(193, 114);
            clbDichVu.TabIndex = 11;
            // 
            // clbLinhKien
            // 
            clbLinhKien.FormattingEnabled = true;
            clbLinhKien.Location = new Point(400, 98);
            clbLinhKien.Name = "clbLinhKien";
            clbLinhKien.Size = new Size(193, 114);
            clbLinhKien.TabIndex = 12;
            // 
            // FormCapNhatDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 403);
            Controls.Add(clbLinhKien);
            Controls.Add(clbDichVu);
            Controls.Add(cbTinhTrang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTongTien);
            Controls.Add(button1);
            Name = "FormCapNhatDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật đơn hàng";
            Load += FormCapNhatDonHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTongTien;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox cbTinhTrang;
        private CheckedListBox clbDichVu;
        private CheckedListBox clbLinhKien;
    }
}