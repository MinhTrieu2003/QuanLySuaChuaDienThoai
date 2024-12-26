namespace QLDVSC
{
    partial class FormSuaTinhTrang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDPhieuSuaChua = new TextBox();
            txtTinhTrangMoi = new TextBox();
            btnLuuThongTin = new Button();
            txtHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(286, 61);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 0;
            label1.Text = "Thay Đổi Tình Trạng Sửa Chữa";
           // label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 103);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 1;
            label2.Text = "ID Phiếu Sửa Chữa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 149);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 2;
            label3.Text = "Tình trạng mới";
            // 
            // txtIDPhieuSuaChua
            // 
            txtIDPhieuSuaChua.Location = new Point(286, 97);
            txtIDPhieuSuaChua.Name = "txtIDPhieuSuaChua";
            txtIDPhieuSuaChua.Size = new Size(218, 23);
            txtIDPhieuSuaChua.TabIndex = 3;
            // 
            // txtTinhTrangMoi
            // 
            txtTinhTrangMoi.Location = new Point(286, 148);
            txtTinhTrangMoi.Name = "txtTinhTrangMoi";
            txtTinhTrangMoi.Size = new Size(218, 23);
            txtTinhTrangMoi.TabIndex = 4;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Location = new Point(286, 211);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(111, 23);
            btnLuuThongTin.TabIndex = 5;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.UseVisualStyleBackColor = true;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // txtHuy
            // 
            txtHuy.Location = new Point(426, 211);
            txtHuy.Name = "txtHuy";
            txtHuy.Size = new Size(97, 23);
            txtHuy.TabIndex = 6;
            txtHuy.Text = "Hủy";
            txtHuy.UseVisualStyleBackColor = true;
            txtHuy.Click += txtHuy_Click;
            // 
            // FormSuaTinhTrang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHuy);
            Controls.Add(btnLuuThongTin);
            Controls.Add(txtTinhTrangMoi);
            Controls.Add(txtIDPhieuSuaChua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSuaTinhTrang";
            Text = "FormSuaTinhTrang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDPhieuSuaChua;
        private TextBox txtTinhTrangMoi;
        private Button btnLuuThongTin;
        private Button txtHuy;
    }
}