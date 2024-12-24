namespace QLDVSC
{
    partial class FormLinhKien
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
            ttnSave4 = new Button();
            txtTenLinhKien = new TextBox();
            label1 = new Label();
            txtLoaiLK = new TextBox();
            txtGiaBan = new TextBox();
            txtGiaNhap = new TextBox();
            txtSltk = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lable4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ttnSave4
            // 
            ttnSave4.BackColor = Color.Silver;
            ttnSave4.FlatStyle = FlatStyle.Popup;
            ttnSave4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttnSave4.Location = new Point(128, 386);
            ttnSave4.Name = "ttnSave4";
            ttnSave4.Size = new Size(82, 37);
            ttnSave4.TabIndex = 0;
            ttnSave4.Text = "Lưu";
            ttnSave4.UseVisualStyleBackColor = false;
            ttnSave4.Click += ttnSave4_Click;
            // 
            // txtTenLinhKien
            // 
            txtTenLinhKien.Location = new Point(44, 51);
            txtTenLinhKien.Name = "txtTenLinhKien";
            txtTenLinhKien.Size = new Size(283, 27);
            txtTenLinhKien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên linh kiện";
            // 
            // txtLoaiLK
            // 
            txtLoaiLK.Location = new Point(44, 123);
            txtLoaiLK.Name = "txtLoaiLK";
            txtLoaiLK.Size = new Size(283, 27);
            txtLoaiLK.TabIndex = 3;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(44, 191);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(283, 27);
            txtGiaBan.TabIndex = 4;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(44, 265);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(283, 27);
            txtGiaNhap.TabIndex = 5;
            // 
            // txtSltk
            // 
            txtSltk.Location = new Point(44, 337);
            txtSltk.Name = "txtSltk";
            txtSltk.Size = new Size(283, 27);
            txtSltk.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 7;
            label2.Text = "Loại linh kiện";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 168);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Giá bán";
            // 
            // lable4
            // 
            lable4.AutoSize = true;
            lable4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable4.Location = new Point(44, 242);
            lable4.Name = "lable4";
            lable4.Size = new Size(70, 20);
            lable4.TabIndex = 9;
            lable4.Text = "Giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 314);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 10;
            label5.Text = "Số lượng tồn kho";
            // 
            // FormLinhKien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(label5);
            Controls.Add(lable4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSltk);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtGiaBan);
            Controls.Add(txtLoaiLK);
            Controls.Add(label1);
            Controls.Add(txtTenLinhKien);
            Controls.Add(ttnSave4);
            Name = "FormLinhKien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin linh kiện";
            Load += FormLinhKien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ttnSave4;
        private TextBox txtTenLinhKien;
        private Label label1;
        private TextBox txtLoaiLK;
        private TextBox txtGiaBan;
        private TextBox txtGiaNhap;
        private TextBox txtSltk;
        private Label label2;
        private Label label3;
        private Label lable4;
        private Label label5;
    }
}