namespace QLDVSC
{
    partial class FormLoiTG
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
            btnSave6 = new Button();
            txtLoiTG = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave6
            // 
            btnSave6.BackColor = Color.Silver;
            btnSave6.FlatStyle = FlatStyle.Popup;
            btnSave6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave6.Location = new Point(115, 282);
            btnSave6.Name = "btnSave6";
            btnSave6.Size = new Size(86, 36);
            btnSave6.TabIndex = 0;
            btnSave6.Text = "Lưu";
            btnSave6.UseVisualStyleBackColor = false;
            btnSave6.Click += btnSave6_Click;
            // 
            // txtLoiTG
            // 
            txtLoiTG.Location = new Point(40, 66);
            txtLoiTG.Multiline = true;
            txtLoiTG.Name = "txtLoiTG";
            txtLoiTG.Size = new Size(247, 178);
            txtLoiTG.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 2;
            label1.Text = "Mô tả lỗi";
            // 
            // FormLoiTG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 368);
            Controls.Add(label1);
            Controls.Add(txtLoiTG);
            Controls.Add(btnSave6);
            Name = "FormLoiTG";
            Text = "Lỗi thường gặp";
            Load += FormLoiTG_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave6;
        private TextBox txtLoiTG;
        private Label label1;
    }
}