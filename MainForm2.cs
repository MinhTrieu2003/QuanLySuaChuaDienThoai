using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDVSC
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }



        private void LoadUserControl(UserControl userControl)
        {
            // Xóa nội dung cũ trong panel chính
            panel1.Controls.Clear();

            // Đặt Dock của User Control để nó chiếm toàn bộ panel
            userControl.Dock = DockStyle.Fill;

            // Thêm User Control vào panel chính
            panel1.Controls.Add(userControl);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcTiepNhanTB());
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UcTiepNhanTB());
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcTaiKhoan());
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDonHangNV());
        }
    }
}
