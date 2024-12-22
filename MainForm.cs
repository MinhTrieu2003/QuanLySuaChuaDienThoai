using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDVSC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Nạp User Control Hệ thống vào Panel chính khi Form load
            LoadUserControl(new UcHeThong());
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcHeThong());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcKhachHang());
        }

        // Hàm nạp User Control vào Panel chính
        private void LoadUserControl(UserControl userControl)
        {
            // Xóa nội dung cũ trong panel chính
            mainPanel.Controls.Clear();

            // Đặt Dock của User Control để nó chiếm toàn bộ panel
            userControl.Dock = DockStyle.Fill;

            // Thêm User Control vào panel chính
            mainPanel.Controls.Add(userControl);
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDonhang());
        }

        
    }
}
