namespace QLDVSC
{
    partial class FormNhanVien
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
            cbVaiTro = new ComboBox();
            btnSave7 = new Button();
            txtHoTen = new TextBox();
            txtPass = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cbVaiTro
            // 
            cbVaiTro.FormattingEnabled = true;
            cbVaiTro.Items.AddRange(new object[] { "Quản trị", "Nhân viên" });
            cbVaiTro.Location = new Point(45, 131);
            cbVaiTro.Name = "cbVaiTro";
            cbVaiTro.Size = new Size(244, 28);
            cbVaiTro.TabIndex = 0;
            // 
            // btnSave7
            // 
            btnSave7.BackColor = Color.Silver;
            btnSave7.FlatStyle = FlatStyle.Popup;
            btnSave7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave7.Location = new Point(117, 362);
            btnSave7.Name = "btnSave7";
            btnSave7.Size = new Size(94, 29);
            btnSave7.TabIndex = 2;
            btnSave7.Text = "Lưu";
            btnSave7.UseVisualStyleBackColor = false;
            btnSave7.Click += btnSave7_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(45, 61);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(244, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ButtonHighlight;
            txtPass.Location = new Point(45, 286);
            txtPass.Name = "txtPass";
            txtPass.ReadOnly = true;
            txtPass.Size = new Size(244, 27);
            txtPass.TabIndex = 4;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(45, 206);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(244, 27);
            txtTenDangNhap.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 108);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Vai trò";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 183);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 263);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 38);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "Họ và tên";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtPass);
            Controls.Add(txtHoTen);
            Controls.Add(btnSave7);
            Controls.Add(cbVaiTro);
            Name = "FormNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin nhân viên";
            Load += FormNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVaiTro;
        private Label label1;
        private Button btnSave7;
        private TextBox txtHoTen;
        private TextBox txtPass;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}