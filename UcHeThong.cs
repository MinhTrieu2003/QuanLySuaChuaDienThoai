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
    public partial class UcHeThong : UserControl
    {
        public UcHeThong()
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




        private void toolStripbtnNhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcNhanVien());
        }

        private void toolStripbtnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcTaiKhoan());
        }

        private void dịchVụSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDichVu());
        }

        private void linhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcLinhKien());
        }

        private void lỗiThườngGặpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcLoiTG());
        }
    }
}
