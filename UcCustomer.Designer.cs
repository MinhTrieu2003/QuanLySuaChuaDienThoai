namespace QLDVSC
{
    partial class UcCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCustomer));
            dgvCustomers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToOrderColumns = true;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, PhoneNumber, Column4, Address });
            dgvCustomers.Location = new Point(20, 113);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1153, 399);
            dgvCustomers.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Mã khách hàng";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // FullName
            // 
            FullName.HeaderText = "Tên khách hàng";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 300;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Số điện thoại";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 250;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(790, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(221, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(363, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonFace;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(603, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(928, 36);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 39);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1066, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // UcCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(pictureBox1);
            Name = "UcCustomer";
            Size = new Size(1194, 532);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Address;
        private PictureBox pictureBox1;
        private Button btnEdit;
        private Button btnDelete;
    }
}
