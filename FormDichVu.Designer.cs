namespace QLDVSC
{
    partial class FormDichVu
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
            btbSave3 = new Button();
            label1 = new Label();
            txtTenDichVu = new TextBox();
            txtGiaDV = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btbSave3
            // 
            btbSave3.BackColor = Color.Silver;
            btbSave3.FlatStyle = FlatStyle.Popup;
            btbSave3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbSave3.Location = new Point(128, 266);
            btbSave3.Name = "btbSave3";
            btbSave3.Size = new Size(75, 34);
            btbSave3.TabIndex = 0;
            btbSave3.Text = "Lưu";
            btbSave3.UseVisualStyleBackColor = false;
            btbSave3.Click += btbSave3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên dịch vụ";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(42, 89);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(270, 27);
            txtTenDichVu.TabIndex = 2;
            // 
            // txtGiaDV
            // 
            txtGiaDV.Location = new Point(42, 192);
            txtGiaDV.Name = "txtGiaDV";
            txtGiaDV.Size = new Size(270, 27);
            txtGiaDV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 152);
            label2.Name = "label2";
            label2.Size = new Size(35, 23);
            label2.TabIndex = 4;
            label2.Text = "Giá";
            // 
            // FormDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 368);
            Controls.Add(label2);
            Controls.Add(txtGiaDV);
            Controls.Add(txtTenDichVu);
            Controls.Add(label1);
            Controls.Add(btbSave3);
            Name = "FormDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin dịch vụ";
            Load += FormDichVu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbSave3;
        private Label label1;
        private TextBox txtTenDichVu;
        private TextBox txtGiaDV;
        private Label label2;
    }
}