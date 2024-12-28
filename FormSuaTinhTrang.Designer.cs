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
            label2 = new Label();
            label3 = new Label();
            txtIDPhieuSuaChua = new TextBox();
            txtTinhTrangMoi = new TextBox();
            btnLuuThongTin = new Button();
            txtHuy = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 45);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 1;
            label2.Text = "ID Phiếu Sửa Chữa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 152);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 2;
            label3.Text = "Tình trạng mới";
            // 
            // txtIDPhieuSuaChua
            // 
            txtIDPhieuSuaChua.Location = new Point(60, 94);
            txtIDPhieuSuaChua.Margin = new Padding(3, 4, 3, 4);
            txtIDPhieuSuaChua.Name = "txtIDPhieuSuaChua";
            txtIDPhieuSuaChua.Size = new Size(249, 27);
            txtIDPhieuSuaChua.TabIndex = 3;
            // 
            // txtTinhTrangMoi
            // 
            txtTinhTrangMoi.Location = new Point(60, 201);
            txtTinhTrangMoi.Margin = new Padding(3, 4, 3, 4);
            txtTinhTrangMoi.Name = "txtTinhTrangMoi";
            txtTinhTrangMoi.Size = new Size(249, 27);
            txtTinhTrangMoi.TabIndex = 4;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Location = new Point(83, 315);
            btnLuuThongTin.Margin = new Padding(3, 4, 3, 4);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(84, 31);
            btnLuuThongTin.TabIndex = 5;
            btnLuuThongTin.Text = "Lưu";
            btnLuuThongTin.UseVisualStyleBackColor = true;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // txtHuy
            // 
            txtHuy.Location = new Point(193, 315);
            txtHuy.Margin = new Padding(3, 4, 3, 4);
            txtHuy.Name = "txtHuy";
            txtHuy.Size = new Size(84, 31);
            txtHuy.TabIndex = 6;
            txtHuy.Text = "Hủy";
            txtHuy.UseVisualStyleBackColor = true;
            txtHuy.Click += txtHuy_Click;
            // 
            // FormSuaTinhTrang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 400);
            Controls.Add(txtHuy);
            Controls.Add(btnLuuThongTin);
            Controls.Add(txtTinhTrangMoi);
            Controls.Add(txtIDPhieuSuaChua);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSuaTinhTrang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật tình trạng sửa chữa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtIDPhieuSuaChua;
        private TextBox txtTinhTrangMoi;
        private Button btnLuuThongTin;
        private Button txtHuy;
    }
}