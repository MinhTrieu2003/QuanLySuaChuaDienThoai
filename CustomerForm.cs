using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace QLDVSC
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
        }

        public CustomerForm(UcCustomer.Customer? customer)
        {
            InitializeComponent();
        }

        public UcCustomer.Customer CustomerData { get; internal set; }
    }
}
