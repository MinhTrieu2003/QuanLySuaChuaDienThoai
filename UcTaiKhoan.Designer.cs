namespace QLDVSC
{
    partial class UcTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTaiKhoan));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtPasswword = new TextBox();
            txtUssername = new TextBox();
            txtVai_tro = new TextBox();
            txtHo_ten = new TextBox();
            btnChangePass = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnSelectPic = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.DragEnter += pictureBox1_DragEnter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtPasswword);
            groupBox1.Controls.Add(txtUssername);
            groupBox1.Controls.Add(txtVai_tro);
            groupBox1.Controls.Add(txtHo_ten);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(280, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 337);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(40, 264);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 189);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(40, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtPasswword
            // 
            txtPasswword.Location = new Point(91, 264);
            txtPasswword.Multiline = true;
            txtPasswword.Name = "txtPasswword";
            txtPasswword.Size = new Size(376, 34);
            txtPasswword.TabIndex = 3;
            // 
            // txtUssername
            // 
            txtUssername.Location = new Point(91, 189);
            txtUssername.Multiline = true;
            txtUssername.Name = "txtUssername";
            txtUssername.Size = new Size(376, 34);
            txtUssername.TabIndex = 2;
            // 
            // txtVai_tro
            // 
            txtVai_tro.Location = new Point(91, 124);
            txtVai_tro.Multiline = true;
            txtVai_tro.Name = "txtVai_tro";
            txtVai_tro.Size = new Size(376, 34);
            txtVai_tro.TabIndex = 1;
            // 
            // txtHo_ten
            // 
            txtHo_ten.Location = new Point(91, 54);
            txtHo_ten.Multiline = true;
            txtHo_ten.Name = "txtHo_ten";
            txtHo_ten.Size = new Size(376, 34);
            txtHo_ten.TabIndex = 0;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.Silver;
            btnChangePass.FlatStyle = FlatStyle.Popup;
            btnChangePass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePass.Location = new Point(280, 393);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(177, 38);
            btnChangePass.TabIndex = 2;
            btnChangePass.Text = "Cập nhật mật khẩu";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectPic
            // 
            btnSelectPic.BackColor = Color.Silver;
            btnSelectPic.FlatStyle = FlatStyle.Popup;
            btnSelectPic.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectPic.Location = new Point(82, 271);
            btnSelectPic.Name = "btnSelectPic";
            btnSelectPic.Size = new Size(103, 38);
            btnSelectPic.TabIndex = 3;
            btnSelectPic.Text = "Chọn ảnh";
            btnSelectPic.UseVisualStyleBackColor = false;
            btnSelectPic.Click += btnSelectPic_Click;
            // 
            // UcTaiKhoan
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnSelectPic);
            Controls.Add(btnChangePass);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "UcTaiKhoan";
            Size = new Size(892, 508);
            Load += UcTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnChangePass;
        private TextBox txtPasswword;
        private TextBox txtUssername;
        private TextBox txtVai_tro;
        private TextBox txtHo_ten;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private OpenFileDialog openFileDialog1;
        private Button btnSelectPic;
    }
}
