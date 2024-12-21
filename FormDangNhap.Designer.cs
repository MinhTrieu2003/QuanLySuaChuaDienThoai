namespace QLDVSC
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            btn_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(448, 158);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(248, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(448, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 27);
            txtPassword.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(448, 279);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Ghi nhớ mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ButtonFace;
            btn_Login.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(446, 331);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(111, 36);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 41);
            label1.Name = "label1";
            label1.Size = new Size(572, 35);
            label1.TabIndex = 5;
            label1.Text = "PHẦN MỀM QUẢN Ý DỊCH VỤ SỬA ĐIỆN THOẠI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 157);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 6;
            label2.Text = "Người dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 221);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(587, 331);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 36);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(755, 439);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            Name = "FormDangNhap";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Button btn_Login;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}
